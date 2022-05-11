using ArchiveModel;
using DTO;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveUI
{
    public partial class UCArchiveView : MetroFramework.Controls.MetroUserControl
    {
        public UCArchiveView()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(FrmMain.Lang);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(FrmMain.Lang);
            InitializeComponent();
        }

        public UCArchiveView(ArchiveDTO dTO)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(FrmMain.Lang);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(FrmMain.Lang);
            InitializeComponent();
            blockBtn.Visible = false;
            cbCat.Visible = false;
            txtSubject.Enabled = false;
            txtCat.Visible = true;
            txtCat.Enabled = false; 

            txtSubject.Text = dTO.Subject;
            dateTimePicker1.Value = dTO.ReceptionDate;
            txtCat.Text = dTO.Category;
            pcbox.ImageLocation = dTO.ArchiveFile;
        }

        public UCArchiveView(Archive archive)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(FrmMain.Lang);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(FrmMain.Lang);
            InitializeComponent();
            FillCategory();
            FillData(archive);
            txtSubject.Enabled = true;

            blockBtn.Visible = true;
            cbCat.Visible = true;
            txtSubject.Enabled = true;
            txtCat.Visible = false;
        }

        void FillData(Archive arch)
        {
            txtSubject.Text=arch.Subject;
            dateTimePicker1.Value=arch.ReceptionDate;
            pcbox.ImageLocation=arch.ArchiveFile;
            cbCat.SelectedText = arch.Category.Name;
        }

        void FillCategory()
        {
            RepoCategory repo = new RepoCategory();
            cbCat.Items.Clear();
            cbCat.Items.AddRange(repo.GetAll().ToArray());
        }

        private void UCArchiveView_Load(object sender, EventArgs e)
        {

        }
    }
}
