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
    public partial class frmVehicleDetails : Form
    {
        public frmVehicleDetails()
        {
            InitializeComponent();
        }

        private void btnBack4_Click(object sender, EventArgs e)
        {
            frmMainMenu f2 = new frmMainMenu();
            f2.Show();
            this.Hide();
        }

        private void btnExit5_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAudi f1 = new frmAudi();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBMW f2 = new frmBMW();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmNissan f3 = new frmNissan();
            f3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmKDH f4 = new frmKDH();
            f4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmToyota f5 = new frmToyota();
            f5.Show();
            this.Hide();
        }
    }
}
