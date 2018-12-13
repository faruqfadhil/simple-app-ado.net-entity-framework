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
    public partial class restock : Form
    {
        public restock()
        {
            InitializeComponent();
        }

        private void master_restockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.master_restockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sembarangkasirDataSet);

            // update stock data on table barang
            var db = new sembarangkasirEntities();
            var id_barang = Convert.ToInt32(id_barangComboBox.SelectedValue.ToString());
            var qty = Convert.ToInt32(qtyTextBox.Text);
            var barang = (from a in db.master_barang where a.id == id_barang select a).Single();
            var stock_new = barang.stock + qty;
            barang.stock = stock_new;
            db.SaveChanges();

        }

        private void restock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sembarangkasirDataSet.master_barang' table. You can move, or remove it, as needed.
            this.master_barangTableAdapter.Fill(this.sembarangkasirDataSet.master_barang);
            // TODO: This line of code loads data into the 'sembarangkasirDataSet.master_restock' table. You can move, or remove it, as needed.
            this.master_restockTableAdapter.Fill(this.sembarangkasirDataSet.master_restock);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dashboard = new dashboard();
            dashboard.Show();
        }
    }
}
