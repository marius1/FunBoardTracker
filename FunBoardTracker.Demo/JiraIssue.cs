using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunBoardTracker.Demo
{
    public partial class JiraIssue : UserControl
    {
        public JiraIssue(TrackerIssue issue)
        {
            InitializeComponent();

            lblKey.Text = issue.Issue.Key;
            lblSummary.Text = issue.Issue.Summary;
            lblStorypoints.Text = issue.Issue.EstimateStatistic.StatFieldValue.Value.ToString();
            glyphImage.Image = GlyphHelper.CreateGlyphIcon(issue.Glyph);
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawLine(Pens.Black, 0, Height - 1, Width, Height - 1);
        }

        private void JiraIssue_Load(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            
        }
    }
}
