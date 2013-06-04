﻿namespace FunBoardTracker.Demo
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageRecognition = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSizeMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFrame = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRecognizer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFiles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageJira = new System.Windows.Forms.TabPage();
            this.chkFlip = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.trackContrast = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBrightness = new System.Windows.Forms.TrackBar();
            this.tabControl.SuspendLayout();
            this.tabPageRecognition.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageRecognition);
            this.tabControl.Controls.Add(this.tabPageJira);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(875, 646);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageRecognition
            // 
            this.tabPageRecognition.Controls.Add(this.tableLayoutPanel1);
            this.tabPageRecognition.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecognition.Name = "tabPageRecognition";
            this.tabPageRecognition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecognition.Size = new System.Drawing.Size(867, 620);
            this.tabPageRecognition.TabIndex = 0;
            this.tabPageRecognition.Text = "Recognition";
            this.tabPageRecognition.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(861, 614);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 83);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(855, 528);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkFlip);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbSizeMode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnFrame);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnFile);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbRecognizer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbFiles);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 34);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(705, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "SizeMode:";
            // 
            // cmbSizeMode
            // 
            this.cmbSizeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSizeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeMode.FormattingEnabled = true;
            this.cmbSizeMode.Location = new System.Drawing.Point(768, 7);
            this.cmbSizeMode.Name = "cmbSizeMode";
            this.cmbSizeMode.Size = new System.Drawing.Size(84, 21);
            this.cmbSizeMode.TabIndex = 9;
            this.cmbSizeMode.SelectedIndexChanged += new System.EventHandler(this.cmbSizeMode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(9, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "|";
            // 
            // btnFrame
            // 
            this.btnFrame.Location = new System.Drawing.Point(588, 5);
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
            this.label4.Location = new System.Drawing.Point(571, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "or";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(525, 5);
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
            this.label3.Location = new System.Drawing.Point(482, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Go with";
            // 
            // cmbRecognizer
            // 
            this.cmbRecognizer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecognizer.FormattingEnabled = true;
            this.cmbRecognizer.Location = new System.Drawing.Point(380, 7);
            this.cmbRecognizer.Name = "cmbRecognizer";
            this.cmbRecognizer.Size = new System.Drawing.Size(81, 21);
            this.cmbRecognizer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recognizer:";
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
            // tabPageJira
            // 
            this.tabPageJira.Location = new System.Drawing.Point(4, 22);
            this.tabPageJira.Name = "tabPageJira";
            this.tabPageJira.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJira.Size = new System.Drawing.Size(867, 620);
            this.tabPageJira.TabIndex = 1;
            this.tabPageJira.Text = "Jira";
            this.tabPageJira.UseVisualStyleBackColor = true;
            // 
            // chkFlip
            // 
            this.chkFlip.AutoSize = true;
            this.chkFlip.Location = new System.Drawing.Point(639, 9);
            this.chkFlip.Name = "chkFlip";
            this.chkFlip.Size = new System.Drawing.Size(42, 17);
            this.chkFlip.TabIndex = 11;
            this.chkFlip.Text = "Flip";
            this.chkFlip.UseVisualStyleBackColor = true;
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
            this.panel2.Size = new System.Drawing.Size(855, 34);
            this.panel2.TabIndex = 2;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Brightness";
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
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 646);
            this.Controls.Add(this.tabControl);
            this.Name = "Demo";
            this.Text = "Demo";
            this.tabControl.ResumeLayout(false);
            this.tabPageRecognition.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageRecognition;
        private System.Windows.Forms.TabPage tabPageJira;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFrame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRecognizer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSizeMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkFlip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar trackContrast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBrightness;
        private System.Windows.Forms.Label label8;
    }
}

