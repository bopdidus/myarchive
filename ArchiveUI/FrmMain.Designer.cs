namespace ArchiveUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mLink = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mPanel
            // 
            this.mPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 12;
            this.mPanel.Location = new System.Drawing.Point(6, 79);
            this.mPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(888, 496);
            this.mPanel.TabIndex = 0;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // mLink
            // 
            this.mLink.Image = ((System.Drawing.Image)(resources.GetObject("mLink.Image")));
            this.mLink.ImageSize = 32;
            this.mLink.Location = new System.Drawing.Point(6, 9);
            this.mLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mLink.Name = "mLink";
            this.mLink.Size = new System.Drawing.Size(75, 65);
            this.mLink.TabIndex = 1;
            this.mLink.UseSelectable = true;
            this.mLink.Click += new System.EventHandler(this.mLink_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 588);
            this.Controls.Add(this.mLink);
            this.Controls.Add(this.mPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(20, 75, 20, 25);
            this.Text = "         Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroLink mLink;
    }
}