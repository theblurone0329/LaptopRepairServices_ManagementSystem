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
    public partial class CustomerMainMenu : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public static string n;
        string username;
        string notiNameBack = "";
        public CustomerMainMenu(string n)
        {
            InitializeComponent();
            lblDisplayUsernameA.Text = "Hello, " + n;
            lblDisplayTime.Text = DateTime.Now.ToString();
            username = n;
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
            // Dimensions = 647, 461
            pnlAttachForm.Controls.Add(childForm);
            pnlAttachForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void picViewMyProfile_Click(object sender, EventArgs e)
        {
            ViewDetails view = new ViewDetails(username);
            showForm(view);
        }

        private void btnNotificationAlert_Click(object sender, EventArgs e)
        {
            Notifications noti = new Notifications(username, notiNameBack);
            showForm(noti);
        }

        private void btnViewServiceCust_Click(object sender, EventArgs e)
        {
            BookingPage bookingPage = new BookingPage(username);
            showForm(bookingPage);
        }


        private void btnChangeServiceCust_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"Select userID From AccountDetails Where username = '{username}';", con);
            string userID = cmd.ExecuteScalar().ToString();
            ChangeServiceCustomer1 changeService = new ChangeServiceCustomer1(userID);
            showForm(changeService);
        }

        private void btnToLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage view = new LoginPage(username);
            view.Closed += (s, args) => this.Close();
            view.Show();
        }
    }
}
