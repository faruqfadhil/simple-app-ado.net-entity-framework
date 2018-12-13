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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            var db = new sembarangkasirEntities();
            var uname = tb_username.Text;
            var passwd = tb_password.Text;
            
            var mhs = (from a in db.master_user where a.username==uname && a.password==passwd select a).Count();
            if(mhs > 0)
            {
                this.Hide();
                Form dashboard = new dashboard();
                dashboard.Show();

            }
            else
            {
                MessageBox.Show("Login Gagal");
            }

        }
    }
}
