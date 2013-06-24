using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunBoardTracker.Jira;
using FunBoardTracker.Jira.Greenhopper;

namespace FunBoardTracker
{
    public class TrackerIssue
    {
        public TrackerIssue(Issue issue, IssueGlyph glyph)
        {
            Issue = issue;
            Glyph = glyph;
        }

        public Issue Issue { get; set; }
        public IssueGlyph Glyph { get; set; }
        public BoardStatus BoardStatus { get; set; }

        public int Order { get; set; }

        public string GlyphBase64Png
        {
            get
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    Glyph.PrintImage.Save(stream, ImageFormat.Png);
                    return Convert.ToBase64String(stream.ToArray());
                }
            }
        }
    }
}
