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
    public partial class RegisterAccAdmin : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public RegisterAccAdmin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            con.Open();

            //to check if all textboxes are filled in
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("All Details must be filled in!");
            }
            else
            {
                //to get count of username and email of the entries from database 
                SqlCommand cmd1 = new SqlCommand($"Select Count(*) From AccountDetails Where username = '{txtUsername.Text}';", con);
                int count = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                SqlCommand cmd2 = new SqlCommand($"Select Count(*) From AccountDetails Where email = '{txtEmail.Text}';", con);
                int emailCount = Convert.ToInt32(cmd2.ExecuteScalar().ToString());

                //check email count and if more than 0 then return error message
                if(emailCount != 0)
                {
                    MessageBox.Show("This email already has a account. Please try another!");
                } else
                {
                    //check username count and if more than 0 then return error message
                    if (count != 0)
                    {
                        MessageBox.Show("This username has already been taken. Please try another!");
                        txtUsername.Text = "";
                    }
                    else
                    {
                        //insert details into account database and display account registered message
                        string role = cbAccType.Text.ToLower();
                        SqlCommand cmd = new SqlCommand($"Insert into AccountDetails values('{txtUsername.Text}', '{txtPassword.Text}', '{txtEmail.Text}', '{role}')", con);
                        cmd.ExecuteScalar();
                        MessageBox.Show("Account Registered!");
                        txtEmail.Clear();
                        txtPassword.Clear();
                        txtUsername.Clear();
                        cbAccType.SelectedIndex = -1;
                    }
                }
            }
            con.Close();
        }
    }
}
