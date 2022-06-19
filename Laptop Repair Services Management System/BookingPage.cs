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
    public partial class BookingPage : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public static string n;
        string username;
        public BookingPage(string n)
        {
            InitializeComponent();
            username = n;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            string servName = "";
            string servType = "";
            if (radNormalFeeRemoveVirus.Checked == true)
            {
                servName = "Remove Virus, Malware, or Spyware";
                servType = "Normal";
            }
            else if (radUrgentFeeRemoveVirus.Checked == true)
            {
                servName = "Remove Virus, Malware, or Spyware";
                servType = "Urgent";
            }
            else if (radNormalFeeTroubleshootComp.Checked == true)
            {
                servName = "Troubleshoot and fix computer running slow";
                servType = "Normal";
            }
            else if (radUrgentFeeTroubleshootComp.Checked == true)
            {
                servName = "Troubleshoot and fix computer running slow";
                servType = "Urgent";
            }
            else if (radUrgentFeeBattRplcmnt.Checked == true)
            {
                servName = "Laptop Battery Replacement";
                servType = "Urgent";
            }
            else if (radNormalFeeBattRplcmnt.Checked == true)
            {
                servName = "Laptop Battery Replacement";
                servType = "Normal";
            }
            else if (radNormalFeeOSFormatInstall.Checked == true)
            {
                servName = "Operating System Format and Installation";
                servType = "Normal";
            }
            else if (radUrgentFeeOSFormatInstall.Checked == true)
            {
                servName = "Operating System Format and Installation";
                servType = "Urgent";
            }
            else if (radNormalFeeLaptopScreen.Checked == true)
            {
                servName = "Laptop Screen Replacement";
                servType = "Normal";
            }
            else if (radUrgentFeeLaptopScreen.Checked == true)
            {
                servName = "Laptop Screen Replacement";
                servType = "Urgent";
            }
            else if (radNormalFeeDataBackup.Checked == true)
            {
                servName = "Data Backup and Recovery";
                servType = "Normal";
            }
            else if (radUrgentFeeDataBackup.Checked == true)
            {
                servName = "Data Backup and Recovery";
                servType = "Urgent";
            }
            else if (radNormalFeeKeyboardRplcmnt.Checked == true)
            {
                servName = "Laptop Keyboard Replacement";
                servType = "Normal";
            }
            else if (radUrgentFeeKeyboardRplcmnt.Checked == true)
            {
                servName = "Laptop Keyboard Replacement";
                servType = "Urgent";
            }
            else if (radNormalFeeInternet.Checked == true)
            {
                servName = "Internet Connectivity Issues";
                servType = "Normal";
            }
            else if (radUrgentFeeInternet.Checked == true)
            {
                servName = "Internet Connectivity Issues";
                servType = "Urgent";
            }

            DateTime date = DateTime.Today.Date;
            string today = date.ToString("dd/MMMM/yyyy");
            today.Replace("/", " ");
            con.Open();
            SqlCommand cmd = new SqlCommand($"Select userID From AccountDetails Where username='{username}';", con);
            string userID = cmd.ExecuteScalar().ToString();
            SqlCommand cmd1 = new SqlCommand($"Insert into BookedServices values('{servName}', '{userID}', 'NULL', '{today}', 'Request Received', '{servType}');", con);
            cmd1.ExecuteScalar();
            SqlCommand cmd2 = new SqlCommand($"Insert into Notifications values('Service Booked', 'You booked {servName}, confirmation will arrive within 3 days', '{userID}');", con);
            cmd2.ExecuteScalar();
            MessageBox.Show("Service Booked Successfully");
            con.Close();
            
        }
    }
}
