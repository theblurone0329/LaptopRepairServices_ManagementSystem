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
    public partial class ChangeServiceReceptionist : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public ChangeServiceReceptionist()
        {
            con.Open();
            InitializeComponent();
            pnlServ1.Hide();
            pnlServ2.Hide();
            lblNoServ.Hide();
            SqlCommand cmd1 = new SqlCommand($"Select count(*) From ChangeServices;", con);
            int count = Convert.ToInt32(cmd1.ExecuteScalar().ToString());

            // to display the current service and its progression and the new service that had made from the customers.
            if (count > 2)
            {
                SqlCommand cmd2 = new SqlCommand($"Select Top(1) servNameBefore From ChangeServices;", con);
                string servName = cmd2.ExecuteScalar().ToString();
                SqlCommand cmd3 = new SqlCommand($"Select Top(1) servNameAfter From ChangeServices Where servNameBefore = '{servName}';", con);
                string servNameAfter = cmd3.ExecuteScalar().ToString();
                SqlCommand cmd6 = new SqlCommand($"Select Top(1) servProgress From ChangeServices Where servNameBefore = '{servName}' AND servNameAfter = '{servNameAfter}';", con);
                int servProgress = Convert.ToInt32(cmd6.ExecuteScalar().ToString());
                lblCurrentService1.Text = servName;
                lblNewService1.Text = servNameAfter;
                progressBar1.Value = servProgress;
                pnlServ1.Show();

                SqlCommand cmd4 = new SqlCommand($"Select Top(2) Max(servNameBefore) From ChangeServices;", con);
                string servName2 = cmd4.ExecuteScalar().ToString();
                SqlCommand cmd5 = new SqlCommand($"Select Top(2) Max(servNameAfter) From ChangeServices Where servNameBefore = '{servName2}';", con);
                string servNameAfter2 = cmd5.ExecuteScalar().ToString();
                SqlCommand cmd7 = new SqlCommand($"Select Top(2) Max(servProgress) From ChangeServices Where servNameBefore = '{servName2}' AND servNameAfter = '{servNameAfter2}';", con);
                int servProgress2 = Convert.ToInt32(cmd7.ExecuteScalar().ToString());
                lblCurrentService2.Text = servName;
                lblNewService2.Text = servNameAfter2;
                progressBar2.Value = servProgress2;
                pnlServ1.Show();

            }
            else if (count == 2)
            {
                SqlCommand cmd2 = new SqlCommand($"Select Top(1) servNameBefore From ChangeServices;", con);
                string servName = cmd2.ExecuteScalar().ToString();
                SqlCommand cmd3 = new SqlCommand($"Select Top(1) servNameAfter From ChangeServices Where servNameBefore = '{servName}';", con);
                string servNameAfter = cmd3.ExecuteScalar().ToString();
                SqlCommand cmd6 = new SqlCommand($"Select Top(1) servProgress From ChangeServices Where servNameBefore = '{servName}' AND servNameAfter = '{servNameAfter}';", con);
                int servProgress = Convert.ToInt32(cmd6.ExecuteScalar().ToString());
                lblCurrentService1.Text = servName;
                lblNewService1.Text = servNameAfter;
                progressBar1.Value = servProgress;
                pnlServ1.Show();

                SqlCommand cmd4 = new SqlCommand($"Select Top(2) Max(servNameBefore) From ChangeServices;", con);
                string servName2 = cmd4.ExecuteScalar().ToString();
                SqlCommand cmd5 = new SqlCommand($"Select Top(2) Max(servNameAfter) From ChangeServices Where servNameBefore = '{servName2}';", con);
                string servNameAfter2 = cmd5.ExecuteScalar().ToString();
                SqlCommand cmd7 = new SqlCommand($"Select Top(2) Max(servProgress) From ChangeServices Where servNameBefore = '{servName2}' AND servNameAfter = '{servNameAfter2}';", con);
                int servProgress2 = Convert.ToInt32(cmd7.ExecuteScalar().ToString());
                lblCurrentService2.Text = servName;
                lblNewService2.Text = servNameAfter2;
                progressBar2.Value = servProgress2;
                pnlServ1.Show();

            }
            else if (count == 1)
            {
                SqlCommand cmd2 = new SqlCommand($"Select Top(1) servNameBefore From ChangeServices;", con);
                string servName = cmd2.ExecuteScalar().ToString();
                SqlCommand cmd3 = new SqlCommand($"Select Top(1) servNameAfter From ChangeServices Where servNameBefore = '{servName}';", con);
                string servNameAfter = cmd3.ExecuteScalar().ToString();
                SqlCommand cmd6 = new SqlCommand($"Select Top(1) servProgress From ChangeServices Where servNameBefore = '{servName}' AND servNameAfter = '{servNameAfter}';", con);
                int servProgress = Convert.ToInt32(cmd6.ExecuteScalar().ToString());
                lblCurrentService1.Text = servName;
                lblNewService1.Text = servNameAfter;
                progressBar1.Value = servProgress;
                pnlServ1.Show();

                groupBox2.Hide();
            }
            else if (count == 0)
            {
                pnlServ1.Hide();
                pnlServ2.Hide();
                lblNoServ.Show();
            }
            con.Close();
        }

        //method to decline the service change request
        private void btnDecline1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand($"Select Top(1) servNameBefore From ChangeServices;", con);
            string servName = cmd1.ExecuteScalar().ToString();
            SqlCommand cmd2 = new SqlCommand($"Select Top(1) servNameAfter From ChangeServices;", con);
            string servNameAfter = cmd2.ExecuteScalar().ToString();
            SqlCommand cmd3 = new SqlCommand($"Select Top(1) userID From ChangeServices Where servNameBefore = '{servName}' AND servNameAfter = '{servNameAfter}';", con);
            string userID = cmd3.ExecuteScalar().ToString();
            SqlCommand cmd = new SqlCommand($"Delete Top(1) From ChangeServices Where servNameBefore = '{servName}' AND servNameAfter = '{servNameAfter}';", con);
            cmd.ExecuteScalar();
            SqlCommand cmd4 = new SqlCommand($"Insert into Notifications values('Service Change Declined', 'Your service for {servNameAfter} has been declined....Contact us for more details', '{userID}');", con);
            cmd4.ExecuteScalar();
            con.Close();
            pnlServ1.Hide();
            MessageBox.Show("Service Change Declined");
        }

        private void btnDecline2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand($"Select Top(2) Max(servNameBefore) From ChangeServices;", con);
            string servName = cmd1.ExecuteScalar().ToString();
            SqlCommand cmd2 = new SqlCommand($"Select Top(2) Max(servNameAfter) From ChangeServices;", con);
            string servNameAfter = cmd2.ExecuteScalar().ToString();
            SqlCommand cmd3 = new SqlCommand($"Select Top(2) Max(userID) From ChangeServices Where servNameBefore = '{servName}' AND servNameAfter = {servNameAfter};", con);
            string userID = cmd3.ExecuteScalar().ToString();
            SqlCommand cmd = new SqlCommand($"Delete Top(2) From ChangeServices Where servNameBefore = '{servName}' AND servNameAfter = {servNameAfter};", con);
            cmd.ExecuteScalar();
            SqlCommand cmd4 = new SqlCommand($"Insert into Notifications values('Service Change Declined', 'Your service for {servNameAfter} has been declined....Contact us for more details', '{userID}'", con);
            cmd4.ExecuteScalar();
            con.Close();
            pnlServ2.Hide();
            MessageBox.Show("Service Change Declined");
        }

        // method to accept the change requests, and update the changes into bookedservices
        private void btnAccept1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            DateTime date = DateTime.Today.Date;
            string today = date.ToString("dd/MMMM/yyyy");
            today.Replace("/", " ");
            SqlCommand cmd1 = new SqlCommand($"Select Top(1) servNameBefore From ChangeServices;", con);
            string servName = cmd1.ExecuteScalar().ToString();
            SqlCommand cmd2 = new SqlCommand($"Select Top(1) servNameAfter From ChangeServices Where servNameBefore = '{servName}';", con);
            string servNameAfter = cmd2.ExecuteScalar().ToString();
            SqlCommand cmd3 = new SqlCommand($"Select Top(1) userID From ChangeServices Where servNameBefore = '{servName}' AND servNameAfter = '{servNameAfter}';", con);
            string userID = cmd3.ExecuteScalar().ToString();
            SqlCommand cmd5 = new SqlCommand($"Select Top(1) servType From ChangeServices Where servNameBefore = '{servName}' AND servNameAfter = '{servNameAfter}' AND userID = '{userID}';", con);
            string servType = cmd5.ExecuteScalar().ToString();
            SqlCommand cmd = new SqlCommand($"Delete Top(1) From ChangeServices Where servNameBefore = '{servName}' AND servNameAfter = '{servNameAfter}';", con);
            cmd.ExecuteScalar();
            SqlCommand cmd4 = new SqlCommand($"Insert into BookedServices values('{servNameAfter}', '{userID}', NULL, '{today}', 'Service Approved', '{servType}', 0);", con);
            cmd4.ExecuteScalar();
            SqlCommand cmd6 = new SqlCommand($"Insert into Notifications values('Service Change Accepted', 'Your service for {servNameAfter} has been accepted!', '{userID}');", con);
            cmd6.ExecuteScalar();
            con.Close();
            pnlServ1.Hide();
            MessageBox.Show("Service Change Accepted!");
        }

        private void btnAccept2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            DateTime date = DateTime.Today.Date;
            string today = date.ToString("dd/MMMM/yyyy");
            today.Replace("/", " ");
            con.Open();
            SqlCommand cmd1 = new SqlCommand($"Select Top(2) Max(servNameBefore) From ChangeServices;", con);
            string servName = cmd1.ExecuteScalar().ToString();
            SqlCommand cmd2 = new SqlCommand($"Select Top(2) Max(servNameAfter) From ChangeServices;", con);
            string servNameAfter = cmd2.ExecuteScalar().ToString();
            SqlCommand cmd3 = new SqlCommand($"Select Top(2) Max(userID) From ChangeServices Where servNameBefore = '{servName}' AND servNameAfter = {servNameAfter};", con);
            string userID = cmd3.ExecuteScalar().ToString();
            SqlCommand cmd5 = new SqlCommand($"Select Top(2) Max(servType) From ChangeServices Where servNameBefore = '{servName}' AND servNameAfter = {servNameAfter} AND userID = '{userID}';", con);
            string servType = cmd5.ExecuteScalar().ToString();
            SqlCommand cmd = new SqlCommand($"Delete From ChangeServices Where servNameBefore = '{servName}' AND servNameAfter = {servNameAfter} AND userID = '{userID}';", con);
            cmd.ExecuteScalar();
            SqlCommand cmd4 = new SqlCommand($"Insert into BookedServices values('{servNameAfter}', '{userID}', NULL, '{today}', 'Service Approved', '{servType}', 0);", con);
            cmd4.ExecuteScalar();
            SqlCommand cmd6 = new SqlCommand($"Insert into Notifications values('Service Change Accepted', 'Your service for {servNameAfter} has been accepted!', '{userID}'", con);
            cmd6.ExecuteScalar();
            con.Close();
            pnlServ2.Hide();
            MessageBox.Show("Service Change Accepted!");
        }
    }
}
