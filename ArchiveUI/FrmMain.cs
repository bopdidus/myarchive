using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveUI
{
    public partial class FrmMain : MetroFramework.Forms.MetroForm
    {
        private static FrmMain _instance;
        public static string Lang = ArchiveUI.Properties.Settings.Default.userLanguage ?? "en";
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
            
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Lang);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Lang);
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
            (mPanel.Controls["UCDashboard"] as UCDashboard).Refresher();
            mPanel.Controls["UCDashboard"].BringToFront();
            mLink.Visible=false;
        }

        public void ChangeLanguage(CultureInfo ci)
        {
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
          
        }

       
    }
}
