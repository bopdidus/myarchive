﻿using ArchiveModel;
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
            InitializeComponent();
            LoadCategories();
        }

        void LoadCategories()
        {
            RepoCategory repo = new RepoCategory();
            cbCats.Items.Clear();
            cbCats.Items.AddRange(repo.GetAll().ToArray());
        }

        private void linkBrowser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|*.PDF|*.pdf";
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
                File.Copy(this.openFileDialog1.FileName, dest);
                Archive archive = new Archive()
                {
                    Subject = txtSubject.Text,
                    ReceptionDate = dtpRecep.Value,
                    ArchiveFile = dest,
                    GetCategory = (cbCats.SelectedIndex != -1) ? (cbCats.Items[cbCats.SelectedIndex] as Category) : null
                };

                RepoArchive repo = new RepoArchive();
                archive = repo.Create(archive);
                if (archive != null)
                {
                    MessageBox.Show("Archive created with success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }
    }
}