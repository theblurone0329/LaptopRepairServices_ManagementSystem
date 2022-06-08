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
    public partial class LoginPage : Form
    {
        public static string name;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        StoreAccDetails currUser;
        public LoginPage(string n)
        {
            InitializeComponent();
            StoreAccDetails currUser = new StoreAccDetails(txtEnterUserIDLogin.Text);
            n = currUser.Name;
            name = n;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from AccountDetails Where username='" + txtEnterUserIDLogin.Text + "' AND password='" + txtEnterPasswordLogin.Text + "';", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("Select password From AccountDetails Where username='" + txtEnterUserIDLogin.Text + "';", con);
                string userpw = cmd2.ExecuteScalar().ToString();
                if (userpw == txtEnterPasswordLogin.Text)
                {
                    SqlCommand cmd3 = new SqlCommand("Select accountType From AccountDetails Where username='" + txtEnterUserIDLogin.Text + "';", con);
                    string userAccType = cmd3.ExecuteScalar().ToString();
                    SqlCommand cmd4 = new SqlCommand($"Select username From AccountDetails Where username='{txtEnterUserIDLogin.Text}';", con);
                    string name = cmd4.ExecuteScalar().ToString();
                    if (userAccType == "admin")
                    {
                        this.Hide();
                        AdminMainMenu view = new AdminMainMenu(name);
                        view.Closed += (s, args) => this.Close();
                        view.Show();
                    }
                    else if (userAccType == "technician")
                    {
                        this.Hide();
                        TechnicianMainMenu view = new TechnicianMainMenu(name);
                        view.Closed += (s, args) => this.Close();
                        view.Show();
                    }
                    else if (userAccType == "receptionist")
                    {
                        this.Hide();
                        ReceptionistMainMenu view = new ReceptionistMainMenu(name);
                        view.Closed += (s, args) => this.Close();
                        view.Show();
                    }
                    else if (userAccType == "customer")
                    {
                        this.Hide();
                        CustomerMainMenu view = new CustomerMainMenu(name);
                        view.Closed += (s, args) => this.Close();
                        view.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Username or Password is Incorrect! Please try again!");
                txtEnterUserIDLogin.Clear();
                txtEnterPasswordLogin.Clear();
            }
            con.Close();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPw = new ForgotPassword();
            forgotPw.Closed += (s, args) => this.Close();
            forgotPw.Show();
        }
    }
}
