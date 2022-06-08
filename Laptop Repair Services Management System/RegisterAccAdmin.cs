using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System
{
    public partial class RegisterAccAdmin : Form
    {
        public RegisterAccAdmin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account Registered!");
            txtEmail.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
        }
    }
}
