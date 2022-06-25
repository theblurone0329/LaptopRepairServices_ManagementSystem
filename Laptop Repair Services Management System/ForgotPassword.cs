using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System
{
    public partial class ForgotPassword : Form
    {
        public static string name;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public ForgotPassword(string n)
        {
            InitializeComponent();
            picBoxTickEmail.Hide();
            picBoxNone.Hide();
            btnReset.Enabled = false;
            txtBoxNewPassw.Enabled = false;
            txtBoxConfirmPassw.Enabled = false;
            name = n;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) From AccountDetails Where email='" + txtBoxEmail.Text + "';", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                picBoxTickEmail.Show();
                picBoxTickEmail.BringToFront();
                btnReset.Enabled = true;
                txtBoxConfirmPassw.Enabled = true;
                txtBoxNewPassw.Enabled = true;
            }
            else
            {
                picBoxNone.Show();
                picBoxNone.BringToFront();
                btnReset.Enabled = false;
                txtBoxConfirmPassw.Enabled = false;
                txtBoxNewPassw.Enabled = false;
            }
            con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select password From AccountDetails Where email='" + txtBoxEmail.Text + "';", con);
            string pw = cmd.ExecuteScalar().ToString();

            if (pw == txtBoxNewPassw.Text)
            {
                MessageBox.Show("New Password cannot be same as old password! Choose Another!");
            }
            else if (pw != txtBoxNewPassw.Text)
            {
                if (txtBoxNewPassw.Text != txtBoxConfirmPassw.Text)
                {
                    MessageBox.Show("Please make sure you type the same new password for both!");
                }
                else if (txtBoxNewPassw.Text == txtBoxConfirmPassw.Text)
                {
                    SqlCommand cmd3 = new SqlCommand($"Update AccountDetails Set password='{txtBoxNewPassw.Text}' Where email='{txtBoxEmail.Text}';", con);
                    cmd3.ExecuteScalar();
                    MessageBox.Show("Password Successfully Changed. Returning to login screen now...");
                    SqlCommand cmd4 = new SqlCommand($"Select count(*) From AccountDetails Where email='{txtBoxEmail.Text}';", con);
                    int count = Convert.ToInt32(cmd4.ExecuteScalar().ToString());

                    if (count > 0)
                    {
                        SqlCommand cmd5 = new SqlCommand($"Select username From AccountDetails Where email='{txtBoxEmail.Text}';", con);
                        string username = cmd5.ExecuteScalar().ToString();
                        this.Hide();
                        LoginPage login = new LoginPage(name);
                        login.Closed += (s, args) => this.Close();
                        login.Show();
                    }

                }
            }
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage(name);
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
    }
}
