namespace ArchiveUI
{
    partial class UCArchiveView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCArchiveView));
            this.pcbox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.blockBtn = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbLink = new System.Windows.Forms.LinkLabel();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).BeginInit();
            this.blockBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbox
            // 
            resources.ApplyResources(this.pcbox, "pcbox");
            this.pcbox.Name = "pcbox";
            this.pcbox.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // blockBtn
            // 
            this.blockBtn.BackColor = System.Drawing.Color.White;
            this.blockBtn.Controls.Add(this.button2);
            this.blockBtn.Controls.Add(this.button1);
            resources.ApplyResources(this.blockBtn, "blockBtn");
            this.blockBtn.Name = "blockBtn";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbLink
            // 
            resources.ApplyResources(this.lbLink, "lbLink");
            this.lbLink.Name = "lbLink";
            this.lbLink.TabStop = true;
            // 
            // txtSubject
            // 
            resources.ApplyResources(this.txtSubject, "txtSubject");
            this.txtSubject.Name = "txtSubject";
            // 
            // txtCat
            // 
            resources.ApplyResources(this.txtCat, "txtCat");
            this.txtCat.Name = "txtCat";
            // 
            // cbCat
            // 
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbCat, "cbCat");
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Name = "cbCat";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // UCArchiveView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lbLink);
            this.Controls.Add(this.blockBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbox);
            this.Name = "UCArchiveView";
            this.Load += new System.EventHandler(this.UCArchiveView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).EndInit();
            this.blockBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pcbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel blockBtn;
        private Button button2;
        private Button button1;
        private LinkLabel lbLink;
        private TextBox txtSubject;
        private TextBox txtCat;
        private ComboBox cbCat;
        private DateTimePicker dateTimePicker1;
    }
}
