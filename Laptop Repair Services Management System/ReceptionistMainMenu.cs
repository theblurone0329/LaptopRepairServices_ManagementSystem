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
    public partial class ReceptionistMainMenu : Form
    {
        public static string n;
        string username;
        string notiNameBack = "";
        public ReceptionistMainMenu(string n)
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

        private void btnRegisterNewCust_Click(object sender, EventArgs e)
        {
            RegisterAccReceptionist regAcc = new RegisterAccReceptionist();
            showForm(regAcc);
        }

        private void btnChangeServiceCust_Click(object sender, EventArgs e)
        {
            ChangeServiceReceptionist viewServ = new ChangeServiceReceptionist();
            showForm(viewServ); 
        }

        private void btnBookServicesForCust_Click(object sender, EventArgs e)
        {
            BookingPageReceptionist view = new BookingPageReceptionist(n);
            showForm(view);
        }

        private void btnBookingEnquiries_Click(object sender, EventArgs e)
        {
            BookingEnquiries validateBooking = new BookingEnquiries();
            showForm(validateBooking);
        }

        private void btnBillandPay_Click(object sender, EventArgs e)
        {
            BillingandPayment billAndPay = new BillingandPayment();
            showForm(billAndPay);
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
