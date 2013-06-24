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
    public class IssuePdfGenerator
    {
        private List<TrackerIssue> _issues;
        private GlobalConfig gc;
        private SimplePechkin pechkin;
        
        public string OutputPath { get; set; }

        public IssuePdfGenerator(List<TrackerIssue> issues)
        {
            _issues = issues;

            OutputPath = String.Empty;

            // setup Pechkin
            gc = new GlobalConfig();
            gc.SetPaperSize(PaperKind.A4);
            gc.SetOutputDpi(96);
            gc.SetMargins(15, 15, 22, 15);

            pechkin = new SimplePechkin(gc);
        }

        public string GeneratePdf()
        {
            IssuesModel model = new IssuesModel
                {
                    Issues = _issues
                };

            string template = File.ReadAllText(@"Templates\Issues.cshtml");
            string html = Razor.Parse<IssuesModel>(template, model);
            byte[] pdf = pechkin.Convert(html);

            string filename = Path.Combine(OutputPath, DateTime.Now.ToShortDateString() + ".pdf");
            File.WriteAllBytes(filename, pdf);

            return filename;
        }
    }
}
