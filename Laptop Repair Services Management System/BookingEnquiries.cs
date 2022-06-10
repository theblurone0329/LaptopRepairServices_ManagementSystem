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
    public partial class BookingEnquiries : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public BookingEnquiries()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(servStatus) From BookedServices Where servStatus = 'Request Received';", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            while (count != 0)
            {
                SqlCommand cmd1 = new SqlCommand($"Select Top(1) servName From BookedServices Where servStatus = 'Request Received';", con);
                string servName = cmd1.ExecuteScalar().ToString();
                checkedLstAcceptCustomerRequest.Items.Add(servName);
            }
            con.Close();
        }
    }
}
