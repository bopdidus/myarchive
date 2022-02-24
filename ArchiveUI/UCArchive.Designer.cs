namespace ArchiveUI
{
    partial class UCArchive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCArchive));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpRecep = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.linkBrowser = new System.Windows.Forms.LinkLabel();
            this.lbFile = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lkToCat = new System.Windows.Forms.LinkLabel();
            this.cbCats = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // txtSubject
            // 
            resources.ApplyResources(this.txtSubject, "txtSubject");
            this.txtSubject.Name = "txtSubject";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // dtpRecep
            // 
            resources.ApplyResources(this.dtpRecep, "dtpRecep");
            this.dtpRecep.Name = "dtpRecep";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // linkBrowser
            // 
            resources.ApplyResources(this.linkBrowser, "linkBrowser");
            this.linkBrowser.BackColor = System.Drawing.Color.White;
            this.linkBrowser.Name = "linkBrowser";
            this.linkBrowser.TabStop = true;
            this.linkBrowser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBrowser_LinkClicked);
            // 
            // lbFile
            // 
            resources.ApplyResources(this.lbFile, "lbFile");
            this.lbFile.BackColor = System.Drawing.Color.White;
            this.lbFile.Name = "lbFile";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lkToCat);
            this.groupBox1.Controls.Add(this.cbCats);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lkToCat
            // 
            resources.ApplyResources(this.lkToCat, "lkToCat");
            this.lkToCat.Name = "lkToCat";
            this.lkToCat.TabStop = true;
            this.lkToCat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkToCat_LinkClicked);
            // 
            // cbCats
            // 
            resources.ApplyResources(this.cbCats, "cbCats");
            this.cbCats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCats.FormattingEnabled = true;
            this.cbCats.Name = "cbCats";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.Color.Lime;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UCArchive
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbFile);
            this.Controls.Add(this.linkBrowser);
            this.Controls.Add(this.dtpRecep);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UCArchive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSubject;
        private Label label2;
        private DateTimePicker dtpRecep;
        private Label label3;
        private LinkLabel linkBrowser;
        private Label lbFile;
        private GroupBox groupBox1;
        private LinkLabel lkToCat;
        private ComboBox cbCats;
        private Label label5;
        private Button button1;
        private Button btnSave;
        private OpenFileDialog openFileDialog1;
    }
}
