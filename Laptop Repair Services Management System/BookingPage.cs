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
            //to validate which radio button has been selected and assign value to attribute
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

            //to get all required information and insert into booked services and notification tables in database
            DateTime date = DateTime.Today.Date;
            string today = date.ToString("dd/MMMM/yyyy");
            today.Replace("/", " ");
            con.Open();
            SqlCommand cmd = new SqlCommand($"Select userID From AccountDetails Where username='{username}';", con);
            string userID = cmd.ExecuteScalar().ToString();
            SqlCommand cmd7 = new SqlCommand($"Select Count(*) From BookedServices Where servName = '{servName}' and userID = '{userID}';", con);
            int countServ = Convert.ToInt32(cmd7.ExecuteScalar().ToString());

            if (countServ != 0)
            {
                MessageBox.Show("Selected service has already been booked and is still active!");
            } else if (countServ == 0)
            {
                SqlCommand cmd1 = new SqlCommand($"Insert into BookedServices values('{servName}', '{userID}', NULL, '{today}', 'Request Received', '{servType}', 0);", con);
                cmd1.ExecuteScalar();
                SqlCommand cmd2 = new SqlCommand($"Insert into Notifications values('Service Booked', 'You booked {servName}, confirmation will arrive within 3 days', '{userID}');", con);
                cmd2.ExecuteScalar();

                SqlCommand cmd4 = new SqlCommand($"Select Count(*) From AccountDetails Where accountType = 'receptionist';", con);
                int count = Convert.ToInt32(cmd4.ExecuteScalar().ToString());
                List<string> userIDList = new List<string>();
                while (count != 0)
                {
                    SqlCommand cmd5 = new SqlCommand($"Select userID From AccountDetails Where accountType = 'receptionist';", con);
                    string uid = cmd5.ExecuteScalar().ToString();
                    SqlCommand cmd3 = new SqlCommand($"Insert into Notifications values('Accept Services', 'There are services to be accepted...', '{uid}');", con);
                    cmd3.ExecuteScalar();
                    SqlCommand cmd6 = new SqlCommand($"Update AccountDetails Set accountType = 'temp' Where accountType = 'receptionist' and userID = '{uid}';", con);
                    cmd6.ExecuteScalar();
                    userIDList.Add(uid);
                    count--;
                }
                SqlCommand cmd8 = new SqlCommand($"Update AccountDetails Set accountType = 'receptionist' Where accountType = 'temp';", con);
                cmd8.ExecuteScalar();
                MessageBox.Show("Service Booked Successfully");
            }
            con.Close();
            
        }
    }
}
