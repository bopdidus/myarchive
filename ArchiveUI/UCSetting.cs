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
    public partial class UCSetting : MetroFramework.Controls.MetroUserControl
    {

        public UCSetting()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(FrmMain.Lang);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(FrmMain.Lang);
            InitializeComponent();
        }
        private void mBtnLang_Click(object sender, EventArgs e)
        {
            switch (mcbLang.SelectedIndex)
            {
                case 0:
                    FrmMain.Lang = "en";
                    break;
                case 1:
                    FrmMain.Lang = "fr";
                    ArchiveUI.Properties.Settings.Default.userLanguage = "fr";
                    //Thread.CurrentThread.CurrentCulture.ClearCachedData();
                    break;
                case 2:
                    FrmMain.Lang = "de";
                    ArchiveUI.Properties.Settings.Default.userLanguage = "de";
                    // Thread.CurrentThread.CurrentCulture.ClearCachedData();
                    break;
            }
           
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
