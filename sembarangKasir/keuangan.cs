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
    public partial class keuangan : Form
    {
        public keuangan()
        {
            InitializeComponent();
        }

        private void uang_transaksiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uang_transaksiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sembarangkasirDataSet);

        }

        private void keuangan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sembarangkasirDataSet.uang_transaksi' table. You can move, or remove it, as needed.
            this.uang_transaksiTableAdapter.Fill(this.sembarangkasirDataSet.uang_transaksi);
            var db = new sembarangkasirEntities();
            var result = db.uang_transaksi.ToList();
            var total = 0;
            foreach(var lop in result)
            {
                total += Convert.ToInt32(lop.income);

            }
            lb_total.Text = "Rp "+total;
            //MessageBox.Show("sd" + total);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dashboard = new dashboard();
            dashboard.Show();
        }
    }
}
