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
    public partial class UCListCategory : MetroFramework.Controls.MetroUserControl
    {
        public UCListCategory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UCListCategory_Load(object sender, EventArgs e)
        {
            RepoCategory repo = new RepoCategory();
            dtGrid.DataSource = repo.GetAll().ToList();
        }
    }
}
