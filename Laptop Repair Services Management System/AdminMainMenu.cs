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
    public partial class AdminMainMenu : Form
    {
        public static string n;
        string username;
        string notiNameBack = "";
        public AdminMainMenu(string n)
        {
            InitializeComponent();
            lblDisplayUsernameA.Text = "Hello, " + n;
            username = n;
            lblDisplayTime.Text = DateTime.Now.ToString();
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

        private void btnRegisterNewAcc_Click(object sender, EventArgs e)
        {
            RegisterAccAdmin regAcc = new RegisterAccAdmin();
            showForm(regAcc);
        }

        private void btnViewServiceReport_Click(object sender, EventArgs e)
        {
            ViewServicesReportAdmin viewRprt = new ViewServicesReportAdmin();
            showForm(viewRprt);
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
