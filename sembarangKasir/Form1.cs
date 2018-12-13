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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new login();
            login.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sembarangkasirDataSet.master_barang' table. You can move, or remove it, as needed.
            this.master_barangTableAdapter.Fill(this.sembarangkasirDataSet.master_barang);

        }

        private void btn_beli_Click(object sender, EventArgs e)
        {
            var db = new sembarangkasirEntities();
            var transaksi = new transaksi();
            var qty_pembelian = Convert.ToInt32(cb_qty.SelectedItem.ToString());
            var id_brg_pembelian = Convert.ToInt32(idTextBox.Text);
            DateTime today = DateTime.Today;
            transaksi.tanggal = today;
            transaksi.id_barang = id_brg_pembelian;
            transaksi.qty = qty_pembelian;
            db.transaksi.Add(transaksi);
            db.SaveChanges();

            var barang = (from a in db.master_barang where a.id == id_brg_pembelian select a).Single();
            var stock_new = barang.stock - qty_pembelian;
            var harga = barang.harga;
            barang.stock = stock_new;
            db.SaveChanges();
            int transaksi_id = db.transaksi.Max(p => p.id);
            //MessageBox.Show("sdsd"+max);

            var money = new uang_transaksi();
            money.id_transaksi = transaksi_id;
            money.income = harga * qty_pembelian;
            db.uang_transaksi.Add(money);
            db.SaveChanges();
            MessageBox.Show("pembelian berhasil !");
            this.master_barangTableAdapter.Fill(this.sembarangkasirDataSet.master_barang);

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void nama_barangLabel1_Click(object sender, EventArgs e)
        {

        }

        private void nama_barangTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void jenis_barangLabel1_Click(object sender, EventArgs e)
        {

        }

        private void jenis_barangTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void stockLabel1_Click(object sender, EventArgs e)
        {

        }

        private void stockTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hargaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void hargaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
