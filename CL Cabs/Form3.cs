using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CL_Cabs
{
    public partial class frmCD : Form
    {
        public frmCD()
        {
            InitializeComponent();
        }
        String MyConnection = "server=localhost;userid=root;password=;database=clcabs";
        MySqlConnection con;
        MySqlCommand com;

        private void btnExit3_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }
        private void btnBack2_Click(object sender, EventArgs e)
        {
            frmMainMenu f2 = new frmMainMenu();
            f2.Show();
            this.Hide();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnCancel2.Enabled = true;
        }

        private void txtNic_TextChanged(object sender, EventArgs e)
        {
            btnInsert.Enabled = true;
            btnDone.Enabled = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Succesful", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmMainMenu f2 = new frmMainMenu();
            f2.Show();
            this.Hide();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtCustomerID.Text = "";
            txtNic.Text = "";
            cbVehicle.Text = "----Select Here----";
            btnCancel2.Enabled = false;
            btnInsert.Enabled = false;
            btnDone.Enabled = false;
            txtName.Focus();
        }

        private void cbVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCancel2.Enabled = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                String sql1;
                sql1 = "INSERT INTO `customer_details`(`customerid`,`name`,`address`,`nic`,`vehicle`,`rentingdate`,`returndate`) VALUES ('" + this.txtCustomerID.Text + "','" + this.txtName.Text + "','" + this.txtAddress.Text + "','" + this.txtNic.Text + "','" + this.cbVehicle.Text + "','" + this.dateRent.Text + "','" + this.dateReturn.Text + "')";
                con = new MySqlConnection(MyConnection);
                con.Open();
                com = new MySqlCommand(sql1, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Record Added Succesfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
