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
    public partial class FrmMain : MetroFramework.Forms.MetroForm
    {
        private static FrmMain _instance;
        public static FrmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmMain();
                return _instance;
            }
        }

        public MetroFramework.Controls.MetroPanel MContainer
        {
            get
            {
                return mPanel;
            }
            set
            {
                mPanel = value;
            }
        }
        public MetroFramework.Controls.MetroLink MBack
        {
            get
            {
                return mLink;
            }
            set
            {
                mLink = value;
            }
        }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            mLink.Visible=false;
            _instance = this;
            UCDashboard uc = new UCDashboard();
            uc.Dock = DockStyle.Fill;
            mPanel.Controls.Add(uc);   
        }

        private void mLink_Click(object sender, EventArgs e)
        {
            mPanel.Controls["UCDashboard"].BringToFront();
            mLink.Visible=false;
        }
    }
}
