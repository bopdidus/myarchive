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
                var cat = repoCategory.Create(new ArchiveModel.Category() { Name = txtName.Text });
                if (cat != null)
                {
                    MessageBox.Show("Category created with success", "Information", MessageBoxButtons.OK);
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
