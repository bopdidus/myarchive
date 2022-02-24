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
    public partial class UCListArchive : MetroFramework.Controls.MetroUserControl
    {
        public UCListArchive()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(FrmMain.Lang);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(FrmMain.Lang);
            InitializeComponent();
        }

        private void UCListArchive_Load(object sender, EventArgs e)
        {
            RepoCategory repo = new RepoCategory();
            cbCats.Items.AddRange(repo.GetAll().ToArray());
            RepoArchive repos = new RepoArchive();
           // dtGrid.AutoGenerateColumns = false;
            dtGrid.DataSource = repos.GetAll().ToList();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(cbCats.SelectedIndex != -1)
            {
                dtGrid.Rows.Clear();
                RepoArchive repos = new RepoArchive();
                dtGrid.DataSource = repos.GetAll().Select(a => a.ReceptionDate >= statdate.Value && a.ReceptionDate <= enddate.Value && a.GetCategory.Name == cbCats.Items[cbCats.SelectedIndex]).ToList();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the rows that you want to delete");
            }
            else
            {
                RepoCategory repo = new RepoCategory();
                RepoArchive repos = new RepoArchive();
                int len = dtGrid.SelectedRows.Count;
                for (int i = 0; i < len; i++)
                {
                    ArchiveModel.Archive archive = new ArchiveModel.Archive()
                    {
                        Subject = dtGrid.SelectedRows[i].Cells[1].Value.ToString(),
                        ReceptionDate = DateTime.Parse(dtGrid.SelectedRows[i].Cells[2].Value.ToString()),
                        GetCategory = repo.GetT(dtGrid.SelectedRows[i].Cells[3].Value.ToString())
                    };
                    repos.Delete(archive);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.MContainer.Controls.ContainsKey("UCArchive"))
            {
                UCArchive uC = new UCArchive();
                uC.Dock = DockStyle.Fill;
                FrmMain.Instance.MContainer.Controls.Add(uC);
            }
            FrmMain.Instance.Text = "         Add new Archive";
            FrmMain.Instance.MContainer.Controls["UCArchive"].BringToFront();
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
