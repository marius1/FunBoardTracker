namespace FunBoardTracker.Demo
{
    partial class JiraIssue
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.glyphImage = new System.Windows.Forms.PictureBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblStorypoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.glyphImage)).BeginInit();
            this.SuspendLayout();
            // 
            // glyphImage
            // 
            this.glyphImage.Location = new System.Drawing.Point(3, 3);
            this.glyphImage.Name = "glyphImage";
            this.glyphImage.Size = new System.Drawing.Size(64, 64);
            this.glyphImage.TabIndex = 0;
            this.glyphImage.TabStop = false;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(73, 3);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(49, 25);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "Key";
            // 
            // lblSummary
            // 
            this.lblSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSummary.AutoEllipsis = true;
            this.lblSummary.Location = new System.Drawing.Point(78, 32);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(169, 26);
            this.lblSummary.TabIndex = 2;
            this.lblSummary.Text = "Summary";
            // 
            // lblStorypoints
            // 
            this.lblStorypoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStorypoints.AutoSize = true;
            this.lblStorypoints.Location = new System.Drawing.Point(234, 3);
            this.lblStorypoints.Name = "lblStorypoints";
            this.lblStorypoints.Size = new System.Drawing.Size(13, 13);
            this.lblStorypoints.TabIndex = 3;
            this.lblStorypoints.Text = "0";
            // 
            // JiraIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStorypoints);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.glyphImage);
            this.Name = "JiraIssue";
            this.Size = new System.Drawing.Size(250, 70);
            ((System.ComponentModel.ISupportInitialize)(this.glyphImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox glyphImage;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblStorypoints;
    }
}
