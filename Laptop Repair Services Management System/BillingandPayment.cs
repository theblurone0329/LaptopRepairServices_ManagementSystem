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
            SqlCommand cmd = new SqlCommand($"Select servName From BookedDetails Where userID = '{txtEnterCustomerID.Text} And servStatus = 'Service Completed';", con);
            string servName = cmd.ExecuteScalar().ToString();
        }
    }
}
