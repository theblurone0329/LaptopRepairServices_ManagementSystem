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
    public partial class DisplayNotification : Form
    {
        public static string n;
        string username;
        string notiNameBack;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public DisplayNotification(string n, string notiName)
        {
            InitializeComponent();
            btnView.Hide();
            con.Open();
            SqlCommand cmd = new SqlCommand($"Select userID From AccountDetails Where username='{n}';", con);
            string userID = cmd.ExecuteScalar().ToString();
            SqlCommand cmd1 = new SqlCommand($"Select notiDescrip From Notifications Where userID='{userID}' AND notiName = '{notiName}'", con);
            string notiDescrip = cmd1.ExecuteScalar().ToString();
            lblTitleNotiName.Text = notiName;
            lblNotiDescrip.Text = notiDescrip;
            con.Close();
            username = n;
            notiNameBack = notiName;
            if (notiName == "New Service Request" || notiName == "New Service Booked")
            {
                btnView.Show();
                BookingEnquiries view = new BookingEnquiries();
                showForm(view);
            }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Notifications noti = new Notifications(username, notiNameBack);
            showForm(noti);
        }
    }
}
