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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }
        String MyConnection = "server=localhost;userid=root;password=;database=clcabs";
        MySqlConnection con;
        MySqlCommand com;
        private void btnBack3_Click(object sender, EventArgs e)
        {
            frmMainMenu f2 = new frmMainMenu();
            f2.Show();
            this.Hide();
        }

        private void btnExit4_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtDriver_TextChanged(object sender, EventArgs e)
        {
            btnView.Enabled = true;
            btnCancel3.Enabled = true;
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text ="";
            txtName.Text = "";
            txtAddress.Text = "";
            txtNic.Text = "";
            txtDistance.Text = "";
            txtVehicle.Text = "";
            DateRented.Text = "";
            txtDays.Text = "";
            btnCal.Enabled = false;
            btnDelete.Enabled = false;
            btnView.Enabled = false;
            btnCancel3.Enabled = false;
            txtCustomerID.Focus();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCustomerID.Text != "")
                {
                    String sql2;
                    sql2 = "SELECT * FROM `customer_details` WHERE `customerid`='" + this.txtCustomerID.Text + "';";
                    con = new MySqlConnection(MyConnection);
                    con.Open();
                    com = new MySqlCommand(sql2, con);
                    MySqlDataReader DR;
                    DR = com.ExecuteReader();
                    con.Close();
                    MySqlDataAdapter ADP = new MySqlDataAdapter(com);
                    DataTable DT = new DataTable();
                    ADP.Fill(DT);
                    txtName.Text = DT.Rows[0][1].ToString();
                    txtAddress.Text = DT.Rows[0][2].ToString();
                    txtNic.Text = DT.Rows[0][3].ToString();
                    txtVehicle.Text = DT.Rows[0][4].ToString();
                    DateRented.Text = DT.Rows[0][5].ToString();
                }
                else
                {
                    MessageBox.Show("Enter Valied Driver's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String sql3;
                sql3 = "DELETE FROM `customer_details` WHERE `customerid`='" + this.txtCustomerID.Text + "';";
                con = new MySqlConnection(MyConnection);
                con.Open();
                com = new MySqlCommand(sql3, con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Rocord Deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerID.Text = "";
                txtName.Text = "";
                txtAddress.Text = "";
                txtNic.Text = "";
                txtVehicle.Text = "";
                txtDays.Text = "";
                btnDelete.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtVehicle_TextChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void txtDistance_TextChanged(object sender, EventArgs e)
        {
            btnCal.Enabled = true;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            String strTdis,strDays;
            int intTdis,intExdis,intDays,intExdays;
            float fltPay;
            strTdis = this.txtDistance.Text;
            strDays = this.txtDays.Text;
            bool isParsable = Int32.TryParse(strTdis, out intTdis);
            bool isParable1 = Int32.TryParse(strDays, out intDays);
            intExdays = intDays - 2;

            if (txtVehicle.Text == "Car - Audi" && intTdis > 20 && intDays > 2)
            {
                intExdis = intTdis - 20;
                fltPay = 2500 + (intExdis * 50) + (intExdays * 100);
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txtVehicle.Text == "Car - Audi" && intTdis > 20 && intDays <= 2)
            {
                intExdis = intTdis - 20;
                fltPay = 2500 + (intExdis * 50);
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtVehicle.Text == "Car - Audi" && intTdis <= 20 && intDays > 2)
            {
                fltPay = 2500 + (intExdays * 100);
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtVehicle.Text == "Car - Audi" && intTdis <= 20 && intDays <= 2)
            {
                fltPay = 2500;
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtVehicle.Text == "Car - BMW" && intTdis > 20 && intDays > 2)
            {
                intExdis = intTdis - 20;
                fltPay = 2500 + (intExdis * 50) + (intExdays * 100);
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtVehicle.Text == "Car - BMW" && intTdis > 20 && intDays <= 2)
            {
                intExdis = intTdis - 20;
                fltPay = 2500 + (intExdis * 50);
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtVehicle.Text == "Car - BMW" && intTdis <= 20 && intDays > 2)
            {
                fltPay = 2500 + (intExdays * 100);
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtVehicle.Text == "Car - BMw" && intTdis <= 20 && intDays <= 2)
            {
                fltPay = 2500;
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txtVehicle.Text == "Van - Nissan" && intTdis > 50 && intDays > 2)
            {
                intExdis = intTdis - 50;
                fltPay = 3500 + (intExdis * 50) + (intExdays * 100);
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txtVehicle.Text == "Van - Nissan" && intTdis > 50 && intDays <= 2)
            {
                intExdis = intTdis - 50;
                fltPay = 3500 + (intExdis * 50);
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtVehicle.Text == "Van - Nissan" && intTdis <= 50 && intDays > 2)
            {
                fltPay = 3500 + (intExdays * 100);
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtVehicle.Text == "Van - Nissan" && intTdis <= 50 && intDays <= 2)
            {
                fltPay = 3500;
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtVehicle.Text == "Van - KDH" && intTdis > 50 && intDays > 2)
            {
                intExdis = intTdis - 50;
                fltPay = 3500 + (intExdis * 50) + (intExdays * 100);
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtVehicle.Text == "Van - KDH" && intTdis > 50 && intDays <= 2)
            {
                intExdis = intTdis - 50;
                fltPay = 3500 + (intExdis * 50);
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtVehicle.Text == "Van - KDH" && intTdis <= 50 && intDays > 2)
            {
                fltPay = 3500 + (intExdays * 100);
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtVehicle.Text == "Van - KDH" && intTdis <= 50 && intDays <= 2)
            {
                fltPay = 3500;
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtVehicle.Text == "Jeep - Toyota" && intTdis > 50 && intDays > 2)
            {
                intExdis = intTdis - 50;
                fltPay = 3000 + (intExdis * 50) + (intExdays * 100);
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtVehicle.Text == "Jeep - Toyota" && intTdis > 50 && intDays <= 2)
            {
                intExdis = intTdis - 50;
                fltPay = 3000 + (intExdis * 50);
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtVehicle.Text == "Jeep - Toyota" && intTdis <= 50 && intDays > 2)
            {
                fltPay = 3000 + (intExdays * 100);
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtVehicle.Text == "Jeep - Toyota" && intTdis <= 50 && intDays <= 2)
            {
                fltPay = 3000;
                MessageBox.Show("Rs." + fltPay, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Travelled Distance. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtDistance.Text = "";
                btnCal.Enabled = false;
            }
        }
        private void DateRented_ValueChanged(object sender, EventArgs e)
        {
            DateTime d1 = Convert.ToDateTime(DateRented.Text);
            DateTime d2 = DateTime.Now;
            txtDays.Text = d2.Subtract(d1).Days.ToString();
        }
    }
}
