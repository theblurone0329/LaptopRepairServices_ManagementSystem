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
    public partial class ViewDetails : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public static string n;
        string username;
        public ViewDetails(string n)
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select email From AccountDetails Where username='" + n + "';", con);
            string email = cmd.ExecuteScalar().ToString();
            SqlCommand cmd2 = new SqlCommand("Select accountType From AccountDetails Where username='" + n + "';", con);
            string accType = cmd2.ExecuteScalar().ToString();
            SqlCommand cmd3 = new SqlCommand("Select userID From AccountDetails Where username='" + n + "';", con);
            string userID = cmd3.ExecuteScalar().ToString();
            lblUsername.Text = n;
            lblEmailAddr.Text = email;
            lblAccType.Text = accType;
            lblUserID.Text = userID;
            con.Close();
            username = n;
        }

        private void btnUpdateProf_Click(object sender, EventArgs e)
        {
            UpdateProfile view = new UpdateProfile(username);
            showForm(view);
        }

        private Form activeForm = null;
        private void showForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlAttachForm.Controls.Add(childForm);
            pnlAttachForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
