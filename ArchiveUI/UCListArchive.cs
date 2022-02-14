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
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UCListArchive_Load(object sender, EventArgs e)
        {
            RepoCategory repo = new RepoCategory();
            cbCats.Items.AddRange(repo.GetAll().ToArray());
            RepoArchive repos = new RepoArchive();
            dtGrid.DataSource = repos.GetAll().ToList().Select(a => new {Subject = a.Subject, ReceptionDate = a.ReceptionDate, CategoryName = a.GetCategory.Name} );
        }
    }
}
