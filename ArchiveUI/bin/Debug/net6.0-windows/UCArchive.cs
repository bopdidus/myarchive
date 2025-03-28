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
    public partial class UCArchive : MetroFramework.Controls.MetroUserControl
    {
        public UCArchive()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(FrmMain.Lang);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(FrmMain.Lang);
            InitializeComponent();
            LoadCategories();
        }

        void LoadCategories()
        {
            RepoCategory repo = new RepoCategory();
            cbCats.Items.Clear();
            if(repo.GetAll() != null) 
                cbCats.Items.AddRange(repo.GetAll().ToArray());
        }

        private void linkBrowser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.openFileDialog1.Filter = "File (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|*.PDF|*.pdf";
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Select the file";
            if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lbFile.Text = this.openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    throw;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var folder = Environment.SpecialFolder.LocalApplicationData;
                var path = Environment.GetFolderPath(folder);
                Directory.CreateDirectory(path + @"\MyArchive\Fichier");
                string dest = System.IO.Path.Join(path + @"\MyArchive\Fichier", Path.GetFileName(this.openFileDialog1.FileName));;
                File.Copy(this.openFileDialog1.FileName, dest,true);
                ArchiveDTO archiveDTO = new ArchiveDTO()
                {
                    Subject = txtSubject.Text,
                    ReceptionDate = dtpRecep.Value,
                    ArchiveFile = dest,
                    Category = (cbCats.SelectedIndex != -1) ? (cbCats.Items[cbCats.SelectedIndex] as Category).Name : null
                };

                RepoArchive repo = new RepoArchive();
                Archive archive = repo.Create(archiveDTO);

                if (archive != null)
                {
                    txtSubject.Clear();
                    lbFile.Text = "";
                    MessageBox.Show("Archive created with success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }

        private void lkToCat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!FrmMain.Instance.MContainer.Controls.ContainsKey("UCCaategory"))
            {
                UCCaategory uC = new UCCaategory();
                uC.Dock = DockStyle.Fill;
                FrmMain.Instance.MContainer.Controls.Add(uC);
            }
            FrmMain.Instance.Text = "         Add new Category";
            FrmMain.Instance.MContainer.Controls["UCCaategory"].BringToFront();
            FrmMain.Instance.MBack.Visible = true;
        }
        
        public void Refresher()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(FrmMain.Lang);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(FrmMain.Lang);
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
