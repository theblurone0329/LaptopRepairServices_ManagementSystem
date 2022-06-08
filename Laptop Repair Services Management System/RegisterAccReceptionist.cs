﻿using System;
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

        private void btnRegisterCus_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txtUsernameCus.Text == "" || txtPasswordCus.Text == "" || txtEmailCus.Text == "")
            {
                MessageBox.Show("All Details must be filled in to register a new customer!");
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
            con.Close();
        }
    }
}