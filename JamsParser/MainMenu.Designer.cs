namespace JamsParser
{
    partial class MainMenu
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
            this.VolumeIssue = new System.Windows.Forms.Button();
            this.UpdateAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VolumeIssue
            // 
            this.VolumeIssue.Location = new System.Drawing.Point(2, 3);
            this.VolumeIssue.Name = "VolumeIssue";
            this.VolumeIssue.Size = new System.Drawing.Size(292, 59);
            this.VolumeIssue.TabIndex = 0;
            this.VolumeIssue.Text = "Update By Volume / Issue";
            this.VolumeIssue.UseVisualStyleBackColor = true;
            this.VolumeIssue.Click += new System.EventHandler(this.VolumeIssue_Click);
            // 
            // UpdateAll
            // 
            this.UpdateAll.Location = new System.Drawing.Point(2, 68);
            this.UpdateAll.Name = "UpdateAll";
            this.UpdateAll.Size = new System.Drawing.Size(292, 58);
            this.UpdateAll.TabIndex = 1;
            this.UpdateAll.Text = "Update All";
            this.UpdateAll.UseVisualStyleBackColor = true;
            this.UpdateAll.Click += new System.EventHandler(this.UpdateAll_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 128);
            this.Controls.Add(this.UpdateAll);
            this.Controls.Add(this.VolumeIssue);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VolumeIssue;
        private System.Windows.Forms.Button UpdateAll;
    }
}

