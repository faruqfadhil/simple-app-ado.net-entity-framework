using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sembarangKasir
{
    public partial class barang : Form
    {
        public barang()
        {
            InitializeComponent();
        }

        private void master_barangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.master_barangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sembarangkasirDataSet);

        }

        private void barang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sembarangkasirDataSet.master_barang' table. You can move, or remove it, as needed.
            this.master_barangTableAdapter.Fill(this.sembarangkasirDataSet.master_barang);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dashboard = new dashboard();
            dashboard.Show();
        }
    }
}
