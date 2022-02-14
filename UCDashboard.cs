using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyArchive
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
    }
}
