using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Vision.GlyphRecognition;
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
            cmbSizeMode.SelectedIndex = 0;
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
            issueDb.Add(new Glyph("test", new byte[5, 5] { 
                { 0, 0, 0, 0, 0 }, 
                { 0, 1, 1, 0, 0 }, 
                { 0, 0, 1, 0, 0 }, 
                { 0, 1, 0, 1, 0 }, 
                { 0, 0, 0, 0, 0 } 
            }));
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

        private void DoRecognition(Bitmap bmp)
        {
            Recognizer recognizer = (Recognizer)cmbRecognizer.SelectedItem;

            /*BaseRotateFilter rotate = new RotateBilinear(180);
            bmp = rotate.Apply(bmp);*/

            /*BrightnessCorrection bright = new BrightnessCorrection(32);
            bright.ApplyInPlace(bmp);*/

            /*ContrastCorrection contract = new ContrastCorrection(48);
            contract.ApplyInPlace(bmp);*/

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
    }
}
