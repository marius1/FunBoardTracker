﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using AForge.Vision.GlyphRecognition;
using FunBoardTracker.Jira;
using FunBoardTracker.Jira.Greenhopper;
using FundaBoardTracker;

namespace FunBoardTracker.Demo
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
            InitializeFiles();
            InitializeRecognizers();
            InitializeSizeModes();
        }

        #region Initialize

        private void InitializeSizeModes()
        {
            cmbSizeMode.Items.AddRange(new object[]
                {
                    PictureBoxSizeMode.AutoSize,
                    PictureBoxSizeMode.CenterImage,
                    PictureBoxSizeMode.Normal,
                    PictureBoxSizeMode.StretchImage,
                    PictureBoxSizeMode.Zoom
                });
            cmbSizeMode.SelectedItem = PictureBoxSizeMode.Zoom;
        }

        private void InitializeRecognizers()
        {
            GlyphDatabase boundryDb = new GlyphDatabase(6);
            #region Boundry
            boundryDb.Add(new Glyph("TODO TL", new byte[6, 6] { 
                { 0, 0, 0, 0, 0, 0 }, 
                { 0, 1, 1, 1, 0, 0 },
                { 0, 0, 0, 1, 1, 0 }, 
                { 0, 0, 1, 0, 0, 0 }, 
                { 0, 1, 0, 0, 0, 0 }, 
                { 0, 0, 0, 0, 0, 0 } 
            }));
            boundryDb.Add(new Glyph("TODO TR", new byte[6, 6] { 
                { 0, 0, 0, 0, 0, 0 }, 
                { 0, 1, 0, 0, 0, 0 },
                { 0, 1, 1, 1, 1, 0 }, 
                { 0, 0, 1, 0, 0, 0 }, 
                { 0, 1, 0, 0, 1, 0 }, 
                { 0, 0, 0, 0, 0, 0 } 
            }));
            boundryDb.Add(new Glyph("TODO BL", new byte[6, 6] { 
                { 0, 0, 0, 0, 0, 0 }, 
                { 0, 0, 1, 0, 0, 0 },
                { 0, 1, 0, 1, 1, 0 }, 
                { 0, 0, 1, 0, 0, 0 }, 
                { 0, 0, 0, 1, 1, 0 }, 
                { 0, 0, 0, 0, 0, 0 } 
            }));
            boundryDb.Add(new Glyph("TODO BR", new byte[6, 6] { 
                { 0, 0, 0, 0, 0, 0 }, 
                { 0, 1, 0, 0, 1, 0 },
                { 0, 1, 1, 1, 0, 0 }, 
                { 0, 1, 0, 0, 0, 0 }, 
                { 0, 0, 0, 0, 1, 0 }, 
                { 0, 0, 0, 0, 0, 0 } 
            }));
            /*boundryDb.Add(new Glyph("copy me", new byte[6, 6] { 
                { 0, 0, 0, 0, 0, 0 }, 
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0 }, 
                { 0, 0, 0, 0, 0, 0 }, 
                { 0, 0, 0, 0, 0, 0 }, 
                { 0, 0, 0, 0, 0, 0 } 
            }));*/

            #endregion

            GlyphDatabase issueDb = new GlyphDatabase(5);
            #region Issues
            foreach (Glyph g in IssueGlyphs.Glyphs.Values)
                issueDb.Add(g);

            #endregion

            cmbRecognizer.Items.Add(new Recognizer { Name = "Issue", GlyphRecognizer = new GlyphRecognizer(issueDb) });
            cmbRecognizer.Items.Add(new Recognizer { Name = "Boundry", GlyphRecognizer = new GlyphRecognizer(boundryDb) });
            cmbRecognizer.Items.Add(new Recognizer { Name = "Six", GlyphRecognizer = new GlyphRecognizer(6) });
            cmbRecognizer.Items.Add(new Recognizer { Name = "Five", GlyphRecognizer = new GlyphRecognizer(5) });
            cmbRecognizer.SelectedIndex = 0;
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
            Recognizer recognizer = (Recognizer)cmbRecognizer.SelectedItem;

            if (chkFlip.Checked)
            {
                BaseRotateFilter rotate = new RotateBilinear(180);
                bmp = rotate.Apply(bmp);
            }

            ContrastCorrection contract = new ContrastCorrection(trackContrast.Value);
            contract.ApplyInPlace(bmp);

            BrightnessCorrection bright = new BrightnessCorrection(trackBrightness.Value);
            bright.ApplyInPlace(bmp);

            // TODO: need MOAR!
            recognizer.GlyphRecognizer.MaxNumberOfGlyphsToSearch = 10;
            List<ExtractedGlyphData> foundGlyphs = recognizer.GlyphRecognizer.FindGlyphs(bmp);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (Pen p = new Pen(Color.Red, 3))
                {
                    foreach (var c in foundGlyphs)
                    {
                        List<Point> points = new List<Point>();
                        foreach (var d in c.Quadrilateral)
                            points.Add(new Point(d.X, d.Y));

                        g.DrawPolygon(p, points.ToArray());
                        if (c.RecognizedGlyph != null)
                            g.DrawString(c.RecognizedGlyph.Name, new Font(FontFamily.GenericMonospace, 20, FontStyle.Bold), Brushes.Red, points[0]);
                    }
                }
            }

            pictureBox.Image = bmp;
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
            Grabber grabber = new Grabber();
            Bitmap bmp = grabber.Grab();
            DoRecognition(bmp);
            grabber.Dispose();
        }

        private void cmbSizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            PictureBoxSizeMode mode = (PictureBoxSizeMode) cmbSizeMode.SelectedItem;
            pictureBox.SizeMode = mode;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string username = ConfigurationManager.AppSettings["JiraUsername"];
            string password = ConfigurationManager.AppSettings["JiraPassword"];
            Client jiraClient = new Client(username, password);
            int sprintId = jiraClient.GetSprintsByRapidViewId(37).First(c => !c.Closed).Id;
            SprintReport sprintReport = jiraClient.GetSprintReport(37, sprintId);
            
            var issuePrinter = new IssuePrinter(sprintReport.Contents.AllIssues);
            issuePrinter.Print();
            MessageBox.Show("Done!");
        }
    }
}
