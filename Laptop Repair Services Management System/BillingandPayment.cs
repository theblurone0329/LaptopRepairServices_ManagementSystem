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
    public partial class BillingandPayment : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public BillingandPayment()
        {
            InitializeComponent();
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            con.Open();
            string temp = txtEnterCustomerID.Text;
            List<char> charToRemove = new List<char>() { 'U'};
            int userID = Convert.ToInt32(temp.Filter(charToRemove));

            SqlCommand cmd = new SqlCommand($"Select Count(*) From BookedServices Where servStatus = 'Waiting for Payment' and userID = '{userID}';", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            int curr = 1;
            string servName;
            string servType;
            double Totalprice = 0;
            double price;

            if (count != 0)
            {
                count++;
                while (curr != count)
                {
                    SqlCommand cmd1 = new SqlCommand($"Select Top({curr}) servName From BookedServices Where servStatus = 'Waiting for Payment' Order by servName ASC;", con);
                    servName = cmd1.ExecuteScalar().ToString();
                    SqlCommand cmd2 = new SqlCommand($"Update BookedServices Set servStatus = 'In List' Where servName = '{servName}' AND userID = '{userID}';", con);
                    cmd2.ExecuteScalar();
                    SqlCommand cmd3 = new SqlCommand($"Select servType From BookedServices Where userID = {userID} AND servStatus = 'In List' AND servName = '{servName}';", con);
                    servType = cmd3.ExecuteScalar().ToString();
                    lstCustomerBill.Items.Add(servName);
                    if (servType == "Urgent")
                    {
                        SqlCommand cmd4 = new SqlCommand($"Select urgPrice From ServiceDetails Where servName = '{servName}';", con);
                        price = Convert.ToDouble(cmd4.ExecuteScalar().ToString());
                        Totalprice = price + Totalprice;

                    }
                    else
                    {
                        SqlCommand cmd4 = new SqlCommand($"Select normPrice From ServiceDetails Where servName = '{servName}';", con);
                        price = Convert.ToDouble(cmd4.ExecuteScalar().ToString());
                        Totalprice = price + Totalprice;
                    }
                    SqlCommand cmd5 = new SqlCommand($"Select username From AccountDetails Where userID = {userID};", con);
                    string username = cmd5.ExecuteScalar().ToString();
                    lblDisplayCustomerName.Text = username;
                    curr++;
                }
            }
            else
            {
                MessageBox.Show("No services booked from this customer...");
                txtEnterCustomerID.Text = "";
            }

            lblDisplayTotalAmountPay.Text = $"RM {Totalprice}";
            con.Close();
        }
    }
}
