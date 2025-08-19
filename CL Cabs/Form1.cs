using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CL_Cabs
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            btnLogin.Enabled = false;
            btnCancel.Enabled = false;
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username, password;
            username = "admin";
            password = "12345";

            if(txtUsername.Text == username && txtPassword.Text == password)
            {
                MessageBox.Show("Welcome!!!", "Login Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmMainMenu f2 = new frmMainMenu();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password. Try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
                btnCancel.Enabled = false;
                btnLogin.Enabled = false;
            }
        }
    }
}
