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
    public partial class BookingPageReceptionist : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public static string n;
        string username;
        public BookingPageReceptionist(string n)
        {
            InitializeComponent();
            username = n;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            string servName = "";
            if (radNormalFeeRemoveVirus.Checked == true)
            {
                servName = "Normal Remove Virus, Malware, or Spyware";
            }
            else if (radUrgentFeeRemoveVirus.Checked == true)
            {
                servName = "Urgent Remove Virus, Malware, or Spyware";
            }
            else if (radNormalFeeTroubleshootComp.Checked == true)
            {
                servName = "Troubleshoot and fix computer running slow";
            }
            else if (radUrgentFeeTroubleshootComp.Checked == true)
            {
                servName = "Troubleshoot and fix computer running slow";
            }
            else if (radUrgentFeeBattRplcmnt.Checked == true)
            {
                servName = "Laptop Battery Replacement";
            }
            else if (radNormalFeeBattRplcmnt.Checked == true)
            {
                servName = "Laptop Battery Replacement";
            }
            else if (radNormalFeeOSFormatInstall.Checked == true)
            {
                servName = "Operating System Format and Installation";
            }
            else if (radUrgentFeeOSFormatInstall.Checked == true)
            {
                servName = "Operating System Format and Installation";
            }
            else if (radNormalFeeLaptopScreen.Checked == true)
            {
                servName = "Laptop Screen Replacement";
            }
            else if (radUrgentFeeLaptopScreen.Checked == true)
            {
                servName = "Laptop Screen Replacement";
            }
            else if (radNormalFeeDataBackup.Checked == true)
            {
                servName = "Data Backup and Recovery";
            }
            else if (radUrgentFeeDataBackup.Checked == true)
            {
                servName = "Data Backup and Recovery";
            }
            else if (radNormalFeeKeyboardRplcmnt.Checked == true)
            {
                servName = "Laptop Keyboard Replacement";
            }
            else if (radUrgentFeeKeyboardRplcmnt.Checked == true)
            {
                servName = "Laptop Keyboard Replacement";
            }
            else if (radNormalFeeInternet.Checked == true)
            {
                servName = "Internet Connectivity Issues";
            }
            else if (radUrgentFeeInternet.Checked == true)
            {
                servName = "Internet Connectivity Issues";
            }

            DateTime today = DateTime.Today;
            con.Open();
            string userID = txtUserID.Text;
            SqlCommand cmd1 = new SqlCommand($"Insert into BookedServices values('{servName}', '{userID}', 'NULL', '{today}', 'Request Received');", con);
            cmd1.ExecuteScalar();
            SqlCommand cmd2 = new SqlCommand($"Insert into Notifications values('Service Booked', 'You booked {servName}, confirmation will arrive within 3 days', '{userID}');", con);
            cmd2.ExecuteScalar();
            MessageBox.Show("Service Booked Successfully");
            con.Close();
        }
    }
}
