namespace JamsParser
{
    partial class VolumeIssueSelector
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
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.IssueLabel = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.MaskedTextBox();
            this.Issue = new System.Windows.Forms.MaskedTextBox();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(13, 13);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(42, 13);
            this.VolumeLabel.TabIndex = 0;
            this.VolumeLabel.Text = "Volume";
            // 
            // IssueLabel
            // 
            this.IssueLabel.AutoSize = true;
            this.IssueLabel.Location = new System.Drawing.Point(23, 36);
            this.IssueLabel.Name = "IssueLabel";
            this.IssueLabel.Size = new System.Drawing.Size(32, 13);
            this.IssueLabel.TabIndex = 1;
            this.IssueLabel.Text = "Issue";
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(61, 10);
            this.Volume.Mask = "00";
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(100, 20);
            this.Volume.TabIndex = 2;
            // 
            // Issue
            // 
            this.Issue.Location = new System.Drawing.Point(61, 33);
            this.Issue.Mask = "00";
            this.Issue.Name = "Issue";
            this.Issue.Size = new System.Drawing.Size(100, 20);
            this.Issue.TabIndex = 3;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(61, 59);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(98, 23);
            this.Update.TabIndex = 4;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // VolumeIssueSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 92);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Issue);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.IssueLabel);
            this.Controls.Add(this.VolumeLabel);
            this.Name = "VolumeIssueSelector";
            this.Text = "VolumeIssueSelector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label IssueLabel;
        private System.Windows.Forms.MaskedTextBox Volume;
        private System.Windows.Forms.MaskedTextBox Issue;
        private System.Windows.Forms.Button Update;
    }
}