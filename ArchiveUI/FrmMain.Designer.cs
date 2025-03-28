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
            mPanel = new MetroFramework.Controls.MetroPanel();
            mLink = new MetroFramework.Controls.MetroLink();
            SuspendLayout();
            // 
            // mPanel
            // 
            resources.ApplyResources(mPanel, "mPanel");
            mPanel.HorizontalScrollbarBarColor = true;
            mPanel.HorizontalScrollbarHighlightOnWheel = false;
            mPanel.HorizontalScrollbarSize = 12;
            mPanel.Name = "mPanel";
            mPanel.VerticalScrollbarBarColor = true;
            mPanel.VerticalScrollbarHighlightOnWheel = false;
            mPanel.VerticalScrollbarSize = 10;
            // 
            // mLink
            // 
            resources.ApplyResources(mLink, "mLink");
            mLink.ImageSize = 32;
            mLink.Name = "mLink";
            mLink.UseSelectable = true;
            mLink.Click += mLink_Click;
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mLink);
            Controls.Add(mPanel);
            MaximizeBox = false;
            Name = "FrmMain";
            Load += FrmMain_Load;
            ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroLink mLink;
    }
}