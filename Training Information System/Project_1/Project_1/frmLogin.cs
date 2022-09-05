using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Ira" && txtPassword.Text == "Ira")
            {
                lblWorng.Visible = false;
                Form1 f = new Form1();
                this.Hide();
                f.Show();
            }
            else
            {
                lblWorng.Visible = true;
                txtPassword.Clear();

            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
