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
    public partial class RegisterAccReceptionist : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public RegisterAccReceptionist()
        {
            InitializeComponent();
        }

        // Method to get a new customer's detail and validate if the customer is existed in the system or not
        private void btnRegisterCus_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txtUsernameCus.Text == "" || txtPasswordCus.Text == "" || txtEmailCus.Text == "")
            {
                MessageBox.Show("All Details must be filled in to register a new customer!"); // if it's blank, show this error message
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand($"Select Count(*) From AccountDetails Where username = '{txtUsernameCus.Text}';", con);
                int count = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                SqlCommand cmd2 = new SqlCommand($"Select Count(*) From AccountDetails Where email = '{txtEmailCus.Text}';", con);
                int emailCount = Convert.ToInt32(cmd2.ExecuteScalar().ToString());

                if (emailCount != 0)
                {
                    MessageBox.Show("This email already has a account. Please try another!");
                } else
                {
                    if (count != 0)
                    {
                        MessageBox.Show("This username has already been taken. Please try another!");
                        txtUsernameCus.Text = "";
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand($"Insert into AccountDetails values('{txtUsernameCus.Text}', '{txtPasswordCus.Text}', '{txtEmailCus.Text}', 'customer')", con);
                        cmd.ExecuteScalar();
                        MessageBox.Show("User Registered!");
                        txtEmailCus.Clear();
                        txtPasswordCus.Clear();
                        txtUsernameCus.Clear();
                    }
                }
            }
            con.Close();
        }
    }
}
