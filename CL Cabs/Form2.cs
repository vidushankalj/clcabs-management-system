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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            frmCD f3 = new frmCD();
            f3.Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment f4 = new frmPayment();
            f4.Show();
            this.Hide();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            frmVehicleDetails f5 = new frmVehicleDetails();
            f5.Show();
            this.Hide();
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            frmAvailable f6 = new frmAvailable();
            f6.Show();
            this.Hide();
        }
    }
}
