using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using AForge.Vision.GlyphRecognition;
using FunBoardTracker.GlyphDb;
using FunBoardTracker.Jira;
using FunBoardTracker.Jira.Greenhopper;
using FundaBoardTracker;

namespace FunBoardTracker.Demo
{
    public partial class Demo : Form
    {
        private Client jiraClient;
        private List<TrackerIssue> issues = new List<TrackerIssue>();
        private int issueId = 0;
        private ContextMenu jiraMenu;
        
        public Demo()
        {
            InitializeComponent();
            
            InitializeFiles();
            InitializeRecognizers();
 
            new Thread(InitializeJira).Start();

            ImageList imageList = Issues.GetImageList();
            lstTodo.LargeImageList = imageList;
            lstDoing.LargeImageList = imageList;
            lstTest.LargeImageList = imageList;
            lstDone.LargeImageList = imageList;

            jiraMenu = new ContextMenu(new MenuItem[] { new MenuItem("Print", PrintTickedOnClick) });
        }

        private void PrintTickedOnClick(object sender, EventArgs eventArgs)
        {
            MessageBox.Show(sender.ToString());
            /*var pdfGenerator = new IssuePdfGenerator(issues);
            string filename = pdfGenerator.GeneratePdf();
            Process.Start(filename);*/
        }

        private void InitializeJira()
        {
            jiraClient = new Client();

            List<RapidView> rapidViews = jiraClient.GetRapidViews();
            this.Invoke((MethodInvoker) delegate
                {
                    cmbRapidViews.Items.AddRange(rapidViews.ToArray());
                    // team object hack
                    cmbRapidViews.SelectedIndex = rapidViews.FindIndex(i => i.Id == 37);

                    cmbRapidViews.Enabled = true;
                    btnGetIssues.Enabled = true;
                });
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            new Thread(GeneratePdf).Start();
        }

        private void GeneratePdf()
        {
            var pdfGenerator = new IssuePdfGenerator(issues);
            string filename = pdfGenerator.GeneratePdf();

            this.Invoke((MethodInvoker)delegate
            {
                btnPrint.Enabled = true;
            });

            Process.Start(filename);
        }

        private void btnGetIssues_Click(object sender, EventArgs e)
        {
            btnGetIssues.Enabled = false;
            new Thread(GetIssues).Start();
        }

        private void GetIssues()
        {
            this.Invoke((MethodInvoker) delegate
                {
                    ClearIssues();

                    RapidView rapidView = (RapidView) cmbRapidViews.SelectedItem;

                    var sprints = jiraClient.GetSprintsByRapidViewId(rapidView.Id);

                    if (sprints.Any(c => !c.Closed))
                    {

                        int sprintId = sprints.First(c => !c.Closed).Id;
                        SprintReport sprintReport = jiraClient.GetSprintReport(rapidView.Id, sprintId);
                        Dictionary<string, int> order = jiraClient.GetSprintOrder(sprintId);

                        foreach (Issue issue in sprintReport.Contents.AllIssues)
                        {
                            int id = issueId++;
                            if (id > GlyphDb.Issues.Glyphs.Count || !GlyphDb.Issues.Glyphs.ContainsKey(id))
                            {
                                continue;
                            }

                            TrackerIssue trackerIssue = new TrackerIssue(issue, GlyphDb.Issues.Glyphs[id]);
                            trackerIssue.Order = order[issue.Key];
                            issues.Add(trackerIssue);
                        }

                        issues = issues.OrderBy(i => i.Order).ToList();

                        if (issues.Count > 0)
                        {
                            LoadIssues();
                            btnPrint.Enabled = true;
                        }
                    }
                    btnGetIssues.Enabled = true;
                });
        }

        private void LoadIssues()
        {
            double todo = 0;
            double doing = 0;
            double test = 0;
            double done = 0;

            foreach (TrackerIssue issue in issues)
            {
                switch (issue.Issue.Status)
                {
                    case Status.Open:
                        lstTodo.Items.Add(GetListViewItemFromIssue(issue));
                        //todoFlow.Controls.Add(new JiraIssue(issue) { Width = todoFlow.Width });
                        todo += issue.Issue.EstimateStatistic.StatFieldValue.Value;
                        break;
                    case Status.InProgress:
                        lstDoing.Items.Add(GetListViewItemFromIssue(issue));
                        doing += issue.Issue.EstimateStatistic.StatFieldValue.Value;
                        break;
                    case Status.ReadyForQa:
                    case Status.QaInProgress:
                        lstTest.Items.Add(GetListViewItemFromIssue(issue));
                        test += issue.Issue.EstimateStatistic.StatFieldValue.Value;
                        break;
                    case Status.Resolved:
                    case Status.Closed:
                        lstDone.Items.Add(GetListViewItemFromIssue(issue));
                        done += issue.Issue.EstimateStatistic.StatFieldValue.Value;
                        break;
                }
            }

            lblTodo.Text  = String.Format("Todo: {0} issues - {1} points", lstTodo.Items.Count, todo);
            lblDoing.Text = String.Format("Doing: {0} issues - {1} points", lstDoing.Items.Count, doing);
            lblTest.Text  = String.Format("Test: {0} issues - {1} points", lstTest.Items.Count, test);
            lblDone.Text  = String.Format("Done: {0} issues - {1} points", lstDone.Items.Count, done);
        }

        private ListViewItem GetListViewItemFromIssue(TrackerIssue issue)
        {
            ListViewItem item = new ListViewItem
                {
                    Name = issue.Issue.Key, 
                    Text = issue.Issue.Key,
                    ImageKey = issue.Glyph.Id.ToString(), 
                    Tag = issue
                };

            return item;
        }

        private void JiraLaneMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListView s = sender as ListView;
                if (s != null && s.FocusedItem.Bounds.Contains(e.Location))
                {
                    jiraMenu.Show(s, e.Location);
                }
            }
        }

        private void ClearIssues()
        {
            lstTodo.Items.Clear();
            lstDoing.Items.Clear();
            lstTest.Items.Clear();
            lstDone.Items.Clear();

            lblTodo.Text = "Todo";
            lblDoing.Text = "Doing";
            lblTest.Text = "Test";
            lblDone.Text = "Done";

            issues.Clear();

            btnPrint.Enabled = false;
            issueId = 0;
        }
    }
}
