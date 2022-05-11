using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;

namespace  ArchiveUI
{
    public partial class UCCaategory : MetroFramework.Controls.MetroUserControl
    {
        public UCCaategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RepoCategory repoCategory = new RepoCategory();
                var cat = repoCategory.Create(new ArchiveModel.Category(txtName.Text));
                if (cat != null)
                {
                    txtName.Clear();
                    MessageBox.Show("Category created with success", "Information", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
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
