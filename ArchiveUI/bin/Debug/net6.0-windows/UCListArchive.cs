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
            cbCats.Items.Clear();
            cbCats.Items.AddRange(repo.GetAll().ToArray());
            RepoArchive repos = new RepoArchive();
            dtGrid.AutoGenerateColumns = false;
            dtGrid.DataSource = repos.GetAll().ToList();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(cbCats.SelectedIndex != -1)
            {
                btnClear.Enabled = true;
                dtGrid.DataSource = null;
                RepoArchive repos = new RepoArchive();
                dtGrid.DataSource = repos.GetAll().Select(a => a.ReceptionDate >= statdate.Value && a.ReceptionDate <= enddate.Value && a.Category == (cbCats.SelectedItem as Category).Name).ToList();
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
                        Category = repo.GetT(cbCats.SelectedItem as Category )
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

       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dtGrid.SelectedRows.Count != 0)
            {
                if (FrmMain.Instance.MContainer.Controls.ContainsKey("UCArchiveView"))
                {
                    FrmMain.Instance.MContainer.Controls.RemoveByKey("UCArchiveView");
                }
                Archive arch = (dtGrid.Rows[0].DataBoundItem as ArchiveDTO).DtoToModel();
                UCArchiveView uC = new UCArchiveView(arch);
                uC.Dock = DockStyle.Fill;
                FrmMain.Instance.MContainer.Controls.Add(uC);
                FrmMain.Instance.MContainer.Controls["UCArchiveView"].BringToFront();
                FrmMain.Instance.MBack.Visible = true;
            }
            else
            {
                MessageBox.Show("You must at least a row selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(dtGrid.SelectedRows.Count != 0)
            {
                if (FrmMain.Instance.MContainer.Controls.ContainsKey("UCArchiveView"))
                {
                    FrmMain.Instance.MContainer.Controls.RemoveByKey("UCArchiveView");
                }
                UCArchiveView uC = new UCArchiveView((dtGrid.Rows[0].DataBoundItem as ArchiveDTO));
                uC.Dock = DockStyle.Fill;
                FrmMain.Instance.MContainer.Controls.Add(uC);
                FrmMain.Instance.MContainer.Controls["UCArchiveView"].BringToFront();
                FrmMain.Instance.MBack.Visible = true;
                
            }
            else
            {
                MessageBox.Show("You must at least a row selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
        }
    }
}
