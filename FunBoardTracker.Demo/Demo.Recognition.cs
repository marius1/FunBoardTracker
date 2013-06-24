using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Vision.GlyphRecognition;
using FunBoardTracker.GlyphDb;
using FunBoardTracker.Jira;
using FunBoardTracker.Jira.Greenhopper;
using FundaBoardTracker;
using AForge.Math.Geometry;
using IntPoint = AForge.IntPoint;

namespace FunBoardTracker.Demo
{
    public partial class Demo
    {
        #region Initialize

        private Recognizer issueRecognizer;
        private Recognizer boundryRecognizer;

        private Dictionary<string, Rectangle> recognizedIssueBoundries = new Dictionary<string, Rectangle>(); 

        private void InitializeRecognizers()
        {
            GlyphDatabase boundryDb = new GlyphDatabase(6);
            foreach (Glyph g in Boundries.Glyphs.Values)
                boundryDb.Add(g);

            GlyphDatabase issueDb = new GlyphDatabase(5);
            foreach (Glyph g in Issues.Glyphs.Values)
                issueDb.Add(g);

            issueRecognizer = new Recognizer {Name = "Issue", GlyphRecognizer = new GlyphRecognizer(issueDb) {MaxNumberOfGlyphsToSearch = 50}};
            boundryRecognizer = new Recognizer {Name = "Boundry", GlyphRecognizer = new GlyphRecognizer(boundryDb) {MaxNumberOfGlyphsToSearch = 10}};
        }

        private void InitializeFiles()
        {
            string[] files = Directory.GetFiles(@"TestImages");
            cmbFiles.Items.AddRange(files);
            cmbFiles.SelectedIndex = 0;
        }

        #endregion

        private void DoRecognition(Bitmap bmp)
        {
            recognizedIssueBoundries.Clear();

            if (chkFlip.Checked)
            {
                BaseRotateFilter rotate = new RotateBilinear(180);
                bmp = rotate.Apply(bmp);
            }

            ContrastCorrection contract = new ContrastCorrection(trackContrast.Value);
            contract.ApplyInPlace(bmp);

            BrightnessCorrection bright = new BrightnessCorrection(trackBrightness.Value);
            bright.ApplyInPlace(bmp);

            List<ExtractedGlyphData> foundIssues = issueRecognizer.GlyphRecognizer.FindGlyphs(bmp);
            List<ExtractedGlyphData> foundBoundries = boundryRecognizer.GlyphRecognizer.FindGlyphs(bmp);

            Dictionary<BoundryId, Point> boundryPoints = new Dictionary<BoundryId, Point>()
                {
                    {BoundryId.LeftTop, new Point(1, 1)},
                    {BoundryId.LeftBottom, new Point(1, bmp.Height - 2)},
                    {BoundryId.RightTop, new Point(bmp.Width - 2, 1)},
                    {BoundryId.RightBottom, new Point(bmp.Width - 2, bmp.Height - 2)}
                };

            List<SwimLanePolygon> swinLanes = new List<SwimLanePolygon>();

            using (Graphics g = Graphics.FromImage(bmp))
            using (Pen red = new Pen(Color.Red, 2))
            using (Pen darkblue = new Pen(Color.DarkBlue, 2))
            using (Pen blue = new Pen(Color.Blue, 3))
            using (Pen green = new Pen(Color.LimeGreen, 2))
            using (Pen black = new Pen(Color.Black, 2))
            {
                // determine boundries
                foreach (ExtractedGlyphData glyphData in foundBoundries)
                {
                    Point[] points = glyphData.Quadrilateral.Select(d => new Point(d.X, d.Y)).ToArray();
                    g.DrawPolygon(darkblue, points);
                    
                    if (glyphData.RecognizedGlyph == null)
                        continue;

                    Point p = PointFromAForgePoint(PointsCloud.GetCenterOfGravity(glyphData.Quadrilateral));
                    DrawRectangleAtPoint(p, g);

                    BoundryId id = (BoundryId)Enum.Parse(typeof (BoundryId), glyphData.RecognizedGlyph.Name);
                    boundryPoints[id] = p;
                }

                if (boundryPoints.Count == 10)
                {
                    swinLanes.Add(SwimLanePolygon.GetSwimLaneAreaByPoints(
                        new List<Status>() { Status.Open },
                        BoardStatus.Todo, 
                        boundryPoints[BoundryId.LeftTop],
                        boundryPoints[BoundryId.LeftBottom],
                        boundryPoints[BoundryId.TodoTop],
                        boundryPoints[BoundryId.TodoBottom],
                        bmp.Height - 2
                    ));
                    
                    swinLanes.Add(SwimLanePolygon.GetSwimLaneAreaByPoints(
                        new List<Status>() { Status.InProgress }, 
                        BoardStatus.Doing, 
                        boundryPoints[BoundryId.TodoTop], 
                        boundryPoints[BoundryId.TodoBottom], 
                        boundryPoints[BoundryId.DoingTop], 
                        boundryPoints[BoundryId.DoingBottom], 
                        bmp.Height - 2
                    ));

                    swinLanes.Add(SwimLanePolygon.GetSwimLaneAreaByPoints(
                        new List<Status>() { Status.ReadyForQa, Status.QaInProgress },
                        BoardStatus.Test, 
                        boundryPoints[BoundryId.DoingTop], 
                        boundryPoints[BoundryId.DoingBottom], 
                        boundryPoints[BoundryId.TestTop], 
                        boundryPoints[BoundryId.TestBottom], 
                        bmp.Height - 2
                    ));

                    swinLanes.Add(SwimLanePolygon.GetSwimLaneAreaByPoints(
                        new List<Status>() { Status.Resolved, Status.Closed }, 
                        BoardStatus.Done, 
                        boundryPoints[BoundryId.TestTop], 
                        boundryPoints[BoundryId.TestBottom], 
                        boundryPoints[BoundryId.RightTop], 
                        boundryPoints[BoundryId.RightBottom], 
                        bmp.Height - 2
                    ));

                    foreach (SwimLanePolygon swinLane in swinLanes)
                    {
                        g.DrawPolygon(blue, swinLane.Area);    
                    }
                }

                // get issues
                foreach (ExtractedGlyphData glyphData in foundIssues)
                {
                    Point[] points = glyphData.Quadrilateral.Select(d => new Point(d.X, d.Y)).ToArray();
                    Pen p = black;

                    if (glyphData.RecognizedGlyph == null)
                        continue;

                    string key = glyphData.RecognizedGlyph.Name;
                    Point center = PointFromAForgePoint(PointsCloud.GetCenterOfGravity(glyphData.Quadrilateral));

                    if (glyphData.RecognizedGlyph.UserData != null)
                    {
                        int id = (int) glyphData.RecognizedGlyph.UserData;
                        TrackerIssue issue = issues.Find(m => m.Glyph.Id == id);
                        if (issue != null)
                        {
                            key = issue.Issue.Key;
                            SwimLanePolygon swinlane = swinLanes.Find(s => s.PointInArea(center));
                            if (swinlane != null)
                            {
                                issue.BoardStatus = swinlane.BoardStatus;
                                p = (swinlane.JiraStatuses.Contains(issue.Issue.Status)) ? green : red;
                            }
                        }
                    }

                    g.DrawPolygon(p, points);
                    
                    recognizedIssueBoundries[key] = GetRectangleFromQuadrilateral(glyphData.Quadrilateral);
                    DrawRectangleAtPoint(center, g);
                }
            }

            pictureBox.Image = bmp;
        }

        private Point PointFromAForgePoint(AForge.Point point)
        {
            return new Point((int)point.X, (int)point.Y);
        }

        private void DrawRectangleAtPoint(Point point, Graphics g)
        {
            g.FillRectangle(Brushes.Yellow, new Rectangle(point.X - 5, point.Y - 5, 10, 10));
        }

        private Rectangle GetRectangleFromQuadrilateral(IEnumerable<IntPoint> points)
        {
            IntPoint minXy;
            IntPoint maxXy;

            PointsCloud.GetBoundingRectangle(points, out minXy, out maxXy);

            return new Rectangle(minXy.X, minXy.Y, maxXy.X - minXy.X, maxXy.Y - minXy.Y);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (cmbFiles.SelectedIndex < 0)
                return;

            Bitmap img = new Bitmap(cmbFiles.SelectedItem.ToString());
            DoRecognition(img);
        }

        private void btnFrame_Click(object sender, EventArgs e)
        {
            btnFrame.Enabled = false;
            new Thread(GrabFrameAndProcess).Start();
        }

        private void GrabFrameAndProcess()
        {
            this.Invoke((MethodInvoker) delegate
                {
                    Grabber grabber = new Grabber();
                    Bitmap bmp = grabber.Grab();
                    DoRecognition(bmp);
                    grabber.Dispose();
                    btnFrame.Enabled = true;
                });
        }
        
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoordinates.Text = String.Format("X: {0} Y: {1}", e.Location.X, e.Location.Y);

            if (recognizedIssueBoundries.Count > 0)
            {
                lblIssueKey.Text = "";

                foreach (KeyValuePair<string, Rectangle> rectangle in recognizedIssueBoundries)
                {
                    if (rectangle.Value.Contains(CursorToUnscaledPoint(e.Location)))
                    {
                        string text = rectangle.Key;

                        TrackerIssue issue = issues.FirstOrDefault(i => i.Issue.Key == rectangle.Key);
                        if (issue != null)
                        {
                            text = String.Format("{0} - {1} - {2}", issue.Issue.Key, StatusHelper.JiraStatusToBoardStatus(issue.Issue.Status), issue.BoardStatus);
                        }

                        lblIssueKey.Text = text;
                    }
                }
            }
        }

        private Point CursorToUnscaledPoint(Point p)
        {
            Point unscaled_p = new Point();

            // image and container dimensions
            int w_i = pictureBox.Image.Width;
            int h_i = pictureBox.Image.Height;
            int w_c = pictureBox.Width;
            int h_c = pictureBox.Height;
            
            float imageRatio = w_i / (float)h_i; // image W:H ratio
            float containerRatio = w_c / (float)h_c; // container W:H ratio

            if (imageRatio >= containerRatio)
            {
                // horizontal image
                float scaleFactor = w_c / (float)w_i;
                float scaledHeight = h_i * scaleFactor;
                // calculate gap between top of container and top of image
                float filler = Math.Abs(h_c - scaledHeight) / 2;
                unscaled_p.X = (int)(p.X / scaleFactor);
                unscaled_p.Y = (int)((p.Y - filler) / scaleFactor);
            }
            else
            {
                // vertical image
                float scaleFactor = h_c / (float)h_i;
                float scaledWidth = w_i * scaleFactor;
                float filler = Math.Abs(w_c - scaledWidth) / 2;
                unscaled_p.X = (int)((p.X - filler) / scaleFactor);
                unscaled_p.Y = (int)(p.Y / scaleFactor);
            }

            return unscaled_p;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            lblCoordinates.Text = "";
        }
    }
}
