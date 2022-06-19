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
            string temp = txtEnterCustomerID.Text;
            List<char> charToRemove = new List<char>() { 'U'};
            int userID = Convert.ToInt32(temp.Filter(charToRemove));

            SqlCommand cmd = new SqlCommand($"Select servName From BookedDetails Where userID = '{userID} And servStatus = 'Waiting for Payment';", con);
            string servName = cmd.ExecuteScalar().ToString();
            SqlCommand cmd1 = new SqlCommand($"Select username From BookedDetails Where userID = '{userID} And servStatus = 'Waiting for Payment' AND servName = '{servName}';", con);
            string username = cmd1.ExecuteScalar().ToString();
            SqlCommand cmd2 = new SqlCommand($"Select servType From BookedDetails Where userID = '{userID} And servStatus = 'Waiting for Payment' AND servName = '{servName}';", con);
            string servType = cmd2.ExecuteScalar().ToString();
            double price;

            if (servType == "Urgent")
            {
                SqlCommand cmd3 = new SqlCommand($"Select urgPrice From BookedDetails Where servName = '{servName}';", con);
                price = Convert.ToDouble(cmd3.ExecuteScalar().ToString());
            } else
            {
                SqlCommand cmd3 = new SqlCommand($"Select normPrice From BookedDetails Where servName = '{servName}';", con);
                price = Convert.ToDouble(cmd3.ExecuteScalar().ToString());
            }
            lblDisplayTotalAmountPay.Text = $"RM {price}";
            lblDisplayCustomerName.Text = username;
        }
    }
}
