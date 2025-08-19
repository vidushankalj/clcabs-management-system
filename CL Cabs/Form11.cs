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
    public partial class frmAvailable : Form
    {
        public frmAvailable()
        {
            InitializeComponent();
        }
        String MyConnection = "server=localhost;userid=root;password=;database=clcabs";
        MySqlConnection con;
        MySqlCommand com;
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

        private void Vehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCheck.Enabled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if(Vehicle.Text != "")
                {
                    String sql1;
                    sql1 = "SELECT * FROM `customer_details` WHERE `vehicle`='" + this.Vehicle.Text + "';";
                    con = new MySqlConnection(MyConnection);
                    con.Open();
                    com = new MySqlCommand(sql1, con);
                    MySqlDataReader DR;
                    DR = com.ExecuteReader();
                    con.Close();
                    MySqlDataAdapter ADP = new MySqlDataAdapter(com);
                    DataTable DT = new DataTable();
                    ADP.Fill(DT);
                    txtName.Text = DT.Rows[0][1].ToString();
                    txtAddress.Text = DT.Rows[0][2].ToString();
                    txtNic.Text = DT.Rows[0][3].ToString();
                    cbVehicle.Text = DT.Rows[0][4].ToString();
                    dateRent.Text = DT.Rows[0][5].ToString();
                    dateReturn.Text = DT.Rows[0][6].ToString();
                }
                else
                {
                    MessageBox.Show("Vehicle is Available For Renting", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                if(Vehicle.Text != "")
                {
                    MessageBox.Show("Vehicle is Available For Renting", "Vehicle Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
