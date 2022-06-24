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
            string temp = txtFindCustomer.Text;
            List<char> charToRemove = new List<char>() { 'U'};
            int userID = Convert.ToInt32(temp.Filter(charToRemove));

            int count = checkedLstAcceptCustomerRequest.CheckedItems.Count;
            int index = 0;

            while (count != index)
            {
                string servName = checkedLstAcceptCustomerRequest.Items[index].ToString();
                SqlCommand cmd = new SqlCommand($"Update BookedServices Set servStatus = 'Service Approved' Where servName = '{servName}' AND userID = {userID};", con);
                cmd.ExecuteScalar();
                SqlCommand cmd1 = new SqlCommand($"Insert into Notifications values ('Service Booking Approved', 'Your booked service for {servName} has been approved! Technician will begin service ASAP!', '{userID}');", con);
                cmd1.ExecuteScalar();
                lstConfirmedServices.Items.Add($"{servName}\n");
                index++;
            }
            con.Close();
        }

        private void btnGoFindCustomer_Click(object sender, EventArgs e)
        {
            con.Open();
            string temp = txtFindCustomer.Text;
            List<char> charToRemove = new List<char>() { 'U'};
            int userID = Convert.ToInt32(temp.Filter(charToRemove));

            SqlCommand cmd = new SqlCommand($"Select Count(*) From BookedServices Where servStatus = 'Request Received' and userID = '{userID}';", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            int curr = 1;
            if (count != 0)
            {
                count++;
                while (curr != count)
                {
                    SqlCommand cmd1 = new SqlCommand($"Select Top({curr}) servName From BookedServices Where servStatus = 'Request Received' Order by servName ASC;", con);
                    string servName = cmd1.ExecuteScalar().ToString();
                    SqlCommand cmd2 = new SqlCommand($"Update BookedServices Set servStatus = 'In List' Where servName = '{servName}' AND userID = '{userID}';", con);
                    cmd2.ExecuteScalar();
                    checkedLstAcceptCustomerRequest.Items.Add(servName);
                    curr++;
                }
            }
            else
            {
                MessageBox.Show("No services booked from this customer...");
                txtFindCustomer.Text = "";
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string temp = txtFindCustomer.Text;
            List<char> charToRemove = new List<char>() { 'U' };
            int userID = Convert.ToInt32(temp.Filter(charToRemove));

            int count = checkedLstAcceptCustomerRequest.Items.Count;
            int index = 0;

            while (count != index)
            {
                string servName = checkedLstAcceptCustomerRequest.Items[0].ToString();
                SqlCommand cmd = new SqlCommand($"Update BookedServices Set servStatus = 'Request Received' Where userID = '{userID}' AND servName = '{servName}' AND servStatus = 'In List';", con);
                cmd.ExecuteScalar();
                checkedLstAcceptCustomerRequest.Items.RemoveAt(0);
                index++;
            }
            txtFindCustomer.Text = "";
            con.Close();
        }
    }
}
