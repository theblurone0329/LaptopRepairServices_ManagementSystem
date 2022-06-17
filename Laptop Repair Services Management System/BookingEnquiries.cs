using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System
{
    public partial class BookingEnquiries : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public BookingEnquiries()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            con.Open();
            string servName = checkedLstAcceptCustomerRequest.CheckedItems.ToString();
            SqlCommand cmd = new SqlCommand($"Update BookedServices Set servStatus = 'Service Approved' Where servName='{servName} and userID = '{txtFindCustomer.Text}';'", con);
            cmd.ExecuteScalar();
            SqlCommand cmd1 = new SqlCommand($"Insert into Notifications values ('Service Booking Approved', 'Your booked service for {servName} has been approved! Technician will begin service ASAP!', '{txtFindCustomer.Text}'", con);
            cmd1.ExecuteScalar();
            lstConfirmedServices.Text = $"{servName}\n";
            con.Close();
        }

        private void btnGoFindCustomer_Click(object sender, EventArgs e)
        {
            con.Open();
            string userID = txtFindCustomer.Text;
            List<char> charToRemove = new List<char>() { 'U' };
            userID = userID.Filter(charToRemove);

            SqlCommand cmd = new SqlCommand($"Select Count(servStatus) From BookedServices Where servStatus = 'Request Received' and userID = '{userID}';", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (count != 0)
            {
                while (count != 0)
                {
                    SqlCommand cmd1 = new SqlCommand($"Select Top(1) servName From BookedServices Where servStatus = 'Request Received';", con);
                    string servName = cmd1.ExecuteScalar().ToString();
                    checkedLstAcceptCustomerRequest.Items.Add(servName);
                }
            }
            else
            {
                MessageBox.Show("No services booked from this customer...");
                txtFindCustomer.Text = "";
            }
            con.Close();
        }
    }
}
