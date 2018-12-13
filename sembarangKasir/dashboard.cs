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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        

        private void bt_barang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form barang = new barang();
            barang.Show();
        }

        private void bt_transaksi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form riwayat_transaksi = new riwayatTransaksi();
            riwayat_transaksi.Show();
        }

        private void bt_stock_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form restock = new restock();
            restock.Show();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Form1();
            login.Show();
        }

        private void bt_keuangan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form keuangan = new keuangan();
            keuangan.Show();
        }
    }
}
