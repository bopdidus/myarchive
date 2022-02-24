namespace ArchiveUI
{
    partial class UCSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSetting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mcbLang = new MetroFramework.Controls.MetroComboBox();
            this.mBtnLang = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // mcbLang
            // 
            resources.ApplyResources(this.mcbLang, "mcbLang");
            this.mcbLang.FormattingEnabled = true;
            this.mcbLang.Items.AddRange(new object[] {
            resources.GetString("mcbLang.Items"),
            resources.GetString("mcbLang.Items1"),
            resources.GetString("mcbLang.Items2")});
            this.mcbLang.Name = "mcbLang";
            this.mcbLang.UseSelectable = true;
            // 
            // mBtnLang
            // 
            resources.ApplyResources(this.mBtnLang, "mBtnLang");
            this.mBtnLang.Name = "mBtnLang";
            this.mBtnLang.UseSelectable = true;
            this.mBtnLang.Click += new System.EventHandler(this.mBtnLang_Click);
            // 
            // UCSetting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mBtnLang);
            this.Controls.Add(this.mcbLang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private MetroFramework.Controls.MetroComboBox mcbLang;
        private MetroFramework.Controls.MetroButton mBtnLang;
    }
}
