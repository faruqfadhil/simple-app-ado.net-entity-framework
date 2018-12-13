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
    public partial class riwayatTransaksi : Form
    {
        public riwayatTransaksi()
        {
            InitializeComponent();
        }

        private void transaksiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transaksiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sembarangkasirDataSet);

        }

        private void riwayatTransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sembarangkasirDataSet.transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.sembarangkasirDataSet.transaksi);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dashboard = new dashboard();
            dashboard.Show();
        }
    }
}
