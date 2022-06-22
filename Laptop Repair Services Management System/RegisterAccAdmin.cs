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

            if (txtUsername.Text == "" || txtPassword.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("All Details must be filled in!");
            }
            else
            {
                string role = cbAccType.Text.ToLower();
                SqlCommand cmd = new SqlCommand($"Insert into AccountDetails values('{txtUsername.Text}', '{txtPassword.Text}', '{txtEmail.Text}', '{role}')", con);
                cmd.ExecuteScalar();
                MessageBox.Show("Account Registered!");
                txtEmail.Clear();
                txtPassword.Clear();
                txtUsername.Clear();
            }
            con.Close();
        }
    }
}
