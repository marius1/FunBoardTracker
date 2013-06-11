using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Vision.GlyphRecognition;
using FunBoardTracker.Jira.Greenhopper;
using FunBoardTracker.Templates;
using Pechkin;
using RazorEngine;

namespace FunBoardTracker
{
    public class IssuePrinter
    {
        private List<Issue> _issues;
        private GlobalConfig gc;

        public IssuePrinter(List<Issue> issues)
        {
            _issues = issues;

            // setup Pechkin
            gc = new GlobalConfig();
            gc.SetPaperSize(PaperKind.A4);
            gc.SetOutputDpi(96);
            gc.SetMargins(15, 15, 15, 15);

        }

        public void Print()
        {
            var glyph = new Glyph("test", new byte[5,5]
                {
                    {0, 0, 0, 0, 0},
                    {0, 1, 1, 0, 0},
                    {0, 0, 1, 0, 0},
                    {0, 1, 0, 1, 0},
                    {0, 0, 0, 0, 0}
                });

            using (Bitmap image = GlyphHelper.CreateGlyphImage(glyph, 250))
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, ImageFormat.Png);
                string img = Convert.ToBase64String(stream.ToArray());
            }

            IssuesModel model = new IssuesModel
                {
                    Issues = _issues
                };

            string template = File.ReadAllText(@"Templates\Issues.cshtml");
            string html = Razor.Parse<IssuesModel>(template, model);

            var pechkin = new SimplePechkin(gc);
            byte[] pdf = pechkin.Convert(html);
            File.WriteAllBytes(@"out.pdf", pdf);
        }
    }
}
