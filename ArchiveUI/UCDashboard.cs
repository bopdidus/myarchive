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
    public partial class UCDashboard : MetroFramework.Controls.MetroUserControl
    {
        public UCDashboard()
        {
            InitializeComponent();
        }
     
        private void metroTile5_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.MContainer.Controls.ContainsKey("UCCaategory"))
            {
                UCCaategory uC= new UCCaategory();
                uC.Dock = DockStyle.Fill;
                FrmMain.Instance.MContainer.Controls.Add(uC);
            }
            FrmMain.Instance.Text = "         Add new Category";
            FrmMain.Instance.MContainer.Controls["UCCaategory"].BringToFront();
            FrmMain.Instance.MBack.Visible = true;
        }

        private void metroTile2_Click(object sender, EventArgs e)
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

        private void metroTile3_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.MContainer.Controls.ContainsKey("UCListCategory"))
            {
                UCListCategory uC = new UCListCategory();
                uC.Dock = DockStyle.Fill;
                FrmMain.Instance.MContainer.Controls.Add(uC);
            }
            FrmMain.Instance.Text = "         List of categories";
            FrmMain.Instance.MContainer.Controls["UCListCategory"].BringToFront();
            FrmMain.Instance.MBack.Visible = true;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.MContainer.Controls.ContainsKey("UCListArchive"))
            {
                UCListArchive uC = new UCListArchive();
                uC.Dock = DockStyle.Fill;
                FrmMain.Instance.MContainer.Controls.Add(uC);
            }
            FrmMain.Instance.Text = "         List of archives";
            FrmMain.Instance.MContainer.Controls["UCListArchive"].BringToFront();
            FrmMain.Instance.MBack.Visible = true;
        }
    }
}
