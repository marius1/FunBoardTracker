using System.Windows.Forms;

namespace FunBoardTracker.Demo
{
    partial class Demo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPageJira = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblDoing = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbRapidViews = new System.Windows.Forms.ComboBox();
            this.btnGetIssues = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lstDoing = new System.Windows.Forms.ListView();
            this.lstTest = new System.Windows.Forms.ListView();
            this.lstDone = new System.Windows.Forms.ListView();
            this.lblTodo = new System.Windows.Forms.Label();
            this.lstTodo = new System.Windows.Forms.ListView();
            this.tabPageRecognition = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkFlip = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFrame = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFiles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBrightness = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.trackContrast = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblHover = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblIssueKey = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPageJira.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPageRecognition.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackContrast)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageJira
            // 
            this.tabPageJira.Controls.Add(this.tableLayoutPanel2);
            this.tabPageJira.Location = new System.Drawing.Point(4, 22);
            this.tabPageJira.Name = "tabPageJira";
            this.tabPageJira.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJira.Size = new System.Drawing.Size(867, 598);
            this.tabPageJira.TabIndex = 1;
            this.tabPageJira.Text = "Jira";
            this.tabPageJira.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.lblDone, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTest, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDoing, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lstDoing, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lstTest, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lstDone, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblTodo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lstTodo, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(861, 592);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDone.Location = new System.Drawing.Point(648, 40);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(210, 20);
            this.lblDone.TabIndex = 8;
            this.lblDone.Text = "Done";
            this.lblDone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTest.Location = new System.Drawing.Point(433, 40);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(209, 20);
            this.lblTest.TabIndex = 7;
            this.lblTest.Text = "Test";
            this.lblTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoing
            // 
            this.lblDoing.AutoSize = true;
            this.lblDoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoing.Location = new System.Drawing.Point(218, 40);
            this.lblDoing.Name = "lblDoing";
            this.lblDoing.Size = new System.Drawing.Size(209, 20);
            this.lblDoing.TabIndex = 6;
            this.lblDoing.Text = "Doing";
            this.lblDoing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel3, 4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cmbRapidViews);
            this.panel3.Controls.Add(this.btnGetIssues);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 34);
            this.panel3.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Rapid views:";
            // 
            // cmbRapidViews
            // 
            this.cmbRapidViews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRapidViews.Enabled = false;
            this.cmbRapidViews.FormattingEnabled = true;
            this.cmbRapidViews.Location = new System.Drawing.Point(77, 7);
            this.cmbRapidViews.Name = "cmbRapidViews";
            this.cmbRapidViews.Size = new System.Drawing.Size(163, 21);
            this.cmbRapidViews.TabIndex = 2;
            // 
            // btnGetIssues
            // 
            this.btnGetIssues.Enabled = false;
            this.btnGetIssues.Location = new System.Drawing.Point(246, 5);
            this.btnGetIssues.Name = "btnGetIssues";
            this.btnGetIssues.Size = new System.Drawing.Size(163, 23);
            this.btnGetIssues.TabIndex = 1;
            this.btnGetIssues.Text = "Get issues for active sprint";
            this.btnGetIssues.UseVisualStyleBackColor = true;
            this.btnGetIssues.Click += new System.EventHandler(this.btnGetIssues_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(777, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lstDoing
            // 
            this.lstDoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDoing.Location = new System.Drawing.Point(218, 63);
            this.lstDoing.Name = "lstDoing";
            this.lstDoing.Size = new System.Drawing.Size(209, 526);
            this.lstDoing.TabIndex = 2;
            this.lstDoing.UseCompatibleStateImageBehavior = false;
            this.lstDoing.View = System.Windows.Forms.View.Tile;
            this.lstDoing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.JiraLaneMouseClick);
            // 
            // lstTest
            // 
            this.lstTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTest.Location = new System.Drawing.Point(433, 63);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(209, 526);
            this.lstTest.TabIndex = 3;
            this.lstTest.UseCompatibleStateImageBehavior = false;
            this.lstTest.View = System.Windows.Forms.View.Tile;
            this.lstTest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.JiraLaneMouseClick);
            // 
            // lstDone
            // 
            this.lstDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDone.Location = new System.Drawing.Point(648, 63);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(210, 526);
            this.lstDone.TabIndex = 4;
            this.lstDone.UseCompatibleStateImageBehavior = false;
            this.lstDone.View = System.Windows.Forms.View.Tile;
            this.lstDone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.JiraLaneMouseClick);
            // 
            // lblTodo
            // 
            this.lblTodo.AutoSize = true;
            this.lblTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTodo.Location = new System.Drawing.Point(3, 40);
            this.lblTodo.Name = "lblTodo";
            this.lblTodo.Size = new System.Drawing.Size(209, 20);
            this.lblTodo.TabIndex = 5;
            this.lblTodo.Text = "Todo";
            this.lblTodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstTodo
            // 
            this.lstTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTodo.Location = new System.Drawing.Point(3, 63);
            this.lstTodo.Name = "lstTodo";
            this.lstTodo.Size = new System.Drawing.Size(209, 526);
            this.lstTodo.TabIndex = 9;
            this.lstTodo.UseCompatibleStateImageBehavior = false;
            this.lstTodo.View = System.Windows.Forms.View.Tile;
            // 
            // tabPageRecognition
            // 
            this.tabPageRecognition.Controls.Add(this.tableLayoutPanel1);
            this.tabPageRecognition.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecognition.Name = "tabPageRecognition";
            this.tabPageRecognition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecognition.Size = new System.Drawing.Size(867, 598);
            this.tabPageRecognition.TabIndex = 0;
            this.tabPageRecognition.Text = "Recognition";
            this.tabPageRecognition.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(861, 592);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox, 2);
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 83);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(855, 506);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkFlip);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnFrame);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnFile);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbFiles);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 34);
            this.panel1.TabIndex = 1;
            // 
            // chkFlip
            // 
            this.chkFlip.AutoSize = true;
            this.chkFlip.Checked = true;
            this.chkFlip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFlip.Location = new System.Drawing.Point(476, 9);
            this.chkFlip.Name = "chkFlip";
            this.chkFlip.Size = new System.Drawing.Size(42, 17);
            this.chkFlip.TabIndex = 11;
            this.chkFlip.Text = "Flip";
            this.chkFlip.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(9, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "|";
            // 
            // btnFrame
            // 
            this.btnFrame.Location = new System.Drawing.Point(425, 5);
            this.btnFrame.Name = "btnFrame";
            this.btnFrame.Size = new System.Drawing.Size(45, 23);
            this.btnFrame.TabIndex = 7;
            this.btnFrame.Text = "Frame";
            this.btnFrame.UseVisualStyleBackColor = true;
            this.btnFrame.Click += new System.EventHandler(this.btnFrame_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "or";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(362, 5);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(45, 23);
            this.btnFile.TabIndex = 5;
            this.btnFile.Text = "File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Go with";
            // 
            // cmbFiles
            // 
            this.cmbFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiles.FormattingEnabled = true;
            this.cmbFiles.Location = new System.Drawing.Point(41, 7);
            this.cmbFiles.Name = "cmbFiles";
            this.cmbFiles.Size = new System.Drawing.Size(263, 21);
            this.cmbFiles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Files:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.trackBrightness);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.trackContrast);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 34);
            this.panel2.TabIndex = 2;
            // 
            // trackBrightness
            // 
            this.trackBrightness.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackBrightness.LargeChange = 10;
            this.trackBrightness.Location = new System.Drawing.Point(374, 4);
            this.trackBrightness.Maximum = 255;
            this.trackBrightness.Name = "trackBrightness";
            this.trackBrightness.Size = new System.Drawing.Size(260, 45);
            this.trackBrightness.SmallChange = 5;
            this.trackBrightness.TabIndex = 3;
            this.trackBrightness.TickFrequency = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Brightness";
            // 
            // trackContrast
            // 
            this.trackContrast.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackContrast.LargeChange = 10;
            this.trackContrast.Location = new System.Drawing.Point(49, 4);
            this.trackContrast.Maximum = 255;
            this.trackContrast.Name = "trackContrast";
            this.trackContrast.Size = new System.Drawing.Size(260, 45);
            this.trackContrast.SmallChange = 5;
            this.trackContrast.TabIndex = 1;
            this.trackContrast.TickFrequency = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Contrast";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblHover);
            this.panel4.Controls.Add(this.lblStats);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(714, 3);
            this.panel4.Name = "panel4";
            this.tableLayoutPanel1.SetRowSpan(this.panel4, 2);
            this.panel4.Size = new System.Drawing.Size(144, 74);
            this.panel4.TabIndex = 3;
            // 
            // lblHover
            // 
            this.lblHover.Location = new System.Drawing.Point(4, 22);
            this.lblHover.Name = "lblHover";
            this.lblHover.Size = new System.Drawing.Size(137, 52);
            this.lblHover.TabIndex = 2;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(35, 5);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(10, 13);
            this.lblStats.TabIndex = 1;
            this.lblStats.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Stats:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageRecognition);
            this.tabControl.Controls.Add(this.tabPageJira);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(875, 624);
            this.tabControl.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCoordinates,
            this.lblIssueKey});
            this.statusStrip.Location = new System.Drawing.Point(0, 624);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(875, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(860, 17);
            this.lblCoordinates.Spring = true;
            this.lblCoordinates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIssueKey
            // 
            this.lblIssueKey.Name = "lblIssueKey";
            this.lblIssueKey.Size = new System.Drawing.Size(0, 17);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 646);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Name = "Demo";
            this.Text = "Demo";
            this.tabPageJira.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPageRecognition.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackContrast)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageJira;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblDoing;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbRapidViews;
        private System.Windows.Forms.Button btnGetIssues;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ListView lstDoing;
        private System.Windows.Forms.ListView lstTest;
        private System.Windows.Forms.ListView lstDone;
        private System.Windows.Forms.Label lblTodo;
        private System.Windows.Forms.TabPage tabPageRecognition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkFlip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFrame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar trackBrightness;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackContrast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblCoordinates;
        private System.Windows.Forms.ToolStripStatusLabel lblIssueKey;
        private ListView lstTodo;
        private Panel panel4;
        private Label lblStats;
        private Label label10;
        private Label lblHover;

    }
}

