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
    public partial class ViewServiceTechnician : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public static string servNameArgs1;
        public static string servNameArgs2;
        public static string servNameArgs3;
        public static string servNameArgs4;
        public static string userID1;
        public static string userID2;
        public static string userID3;
        public static string userID4;
        public ViewServiceTechnician()
        {
            InitializeComponent();
            pnlServ1.Hide();
            pnlServ2.Hide();
            pnlServ3.Hide();
            pnlServ4.Hide();
            lblNone.Hide();
            con.Open();

            SqlCommand cmd = new SqlCommand($"Select count(*) From BookedServices Where servStatus = 'Service Approved';", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 4)
            {
                SqlCommand cmd1 = new SqlCommand($"Select Top(1) servName From BookedServices Where servStatus = 'Service Approved';", con);
                string servName1 = cmd1.ExecuteScalar().ToString();
                SqlCommand cmd5 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where servStatus = 'Service Approved' AND servName = '{servName1}';", con);
                int servProg = Convert.ToInt32(cmd5.ExecuteScalar().ToString());
                progressBar5.Value = servProg;
                gbServ1.Text = servName1;

                SqlCommand cmd2 = new SqlCommand($"Select Top(1) servName From BookedServices Where servStatus = 'Service Approved' and servName != (Select Top(1) servName From BookedServices);", con);
                string servName2 = cmd2.ExecuteScalar().ToString();
                SqlCommand cmd6 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where servStatus = 'Service Approved' AND servName = '{servName2}' and servName != (Select Top(1) servName From BookedServices);", con);
                int servProg2 = Convert.ToInt32(cmd6.ExecuteScalar().ToString());
                progressBar6.Value = servProg2;
                gbServ2.Text = servName2;

                SqlCommand cmd3 = new SqlCommand($"Select Top(2) Max(servName) From BookedServices Where servStatus = 'Service Approved' and servName != (Select Top(1) servName From BookedServices);", con);
                string servName3 = cmd3.ExecuteScalar().ToString();
                SqlCommand cmd7 = new SqlCommand($"Select Top(2) Max(servProgress) From BookedServices Where servStatus = 'Service Approved' AND servName = '{servName3}' and servName != (Select Top(1) servName From BookedServices);", con);
                int servProg3 = Convert.ToInt32(cmd7.ExecuteScalar().ToString());
                progressBar7.Value = servProg3;
                gbServ3.Text = servName3;

                SqlCommand cmd4 = new SqlCommand($"Select Top(4) Min(servName) From BookedServices Where servStatus = 'Service Approved';", con);
                string servName4 = cmd4.ExecuteScalar().ToString();
                SqlCommand cmd8 = new SqlCommand($"Select Top(4) Min(servProgress) From BookedServices Where servStatus = 'Service Approved' AND servName = '{servName4}';", con);
                int servProg4 = Convert.ToInt32(cmd8.ExecuteScalar().ToString());
                progressBar8.Value = servProg4;
                gbServ4.Text = servName4;

                pnlServ1.Show();
                pnlServ2.Show();
                pnlServ3.Show();
                pnlServ4.Show();

            }
            else if (count == 4)
            {
                SqlCommand cmd1 = new SqlCommand($"Select Top(1) servName From BookedServices Where servStatus = 'Service Approved';", con);
                string servName1 = cmd1.ExecuteScalar().ToString();
                SqlCommand cmd5 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where servStatus = 'Service Approved' AND servName = '{servName1}';", con);
                int servProg = Convert.ToInt32(cmd5.ExecuteScalar().ToString());
                progressBar5.Value = servProg;
                gbServ1.Text = servName1;

                SqlCommand cmd2 = new SqlCommand($"Select Top(1) servName From BookedServices Where servStatus = 'Service Approved' and servName != (Select Top(1) servName From BookedServices);", con);
                string servName2 = cmd2.ExecuteScalar().ToString();
                SqlCommand cmd6 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where servStatus = 'Service Approved' AND servName = '{servName2}' and servName != (Select Top(1) servName From BookedServices);", con);
                int servProg2 = Convert.ToInt32(cmd6.ExecuteScalar().ToString());
                progressBar6.Value = servProg2;
                gbServ2.Text = servName2;

                SqlCommand cmd3 = new SqlCommand($"Select Top(2) Max(servName) From BookedServices Where servStatus = 'Service Approved' and servName != (Select Top(1) servName From BookedServices);", con);
                string servName3 = cmd3.ExecuteScalar().ToString();
                SqlCommand cmd7 = new SqlCommand($"Select Top(2) Max(servProgress) From BookedServices Where servStatus = 'Service Approved' AND servName = '{servName3}' and servName != (Select Top(1) servName From BookedServices);", con);
                int servProg3 = Convert.ToInt32(cmd7.ExecuteScalar().ToString());
                progressBar7.Value = servProg3;
                gbServ3.Text = servName3;

                SqlCommand cmd4 = new SqlCommand($"Select Top(4) Min(servName) From BookedServices Where servStatus = 'Service Approved';", con);
                string servName4 = cmd4.ExecuteScalar().ToString();
                SqlCommand cmd8 = new SqlCommand($"Select Top(4) Min(servProgress) From BookedServices Where servStatus = 'Service Approved' AND servName = '{servName4}';", con);
                int servProg4 = Convert.ToInt32(cmd8.ExecuteScalar().ToString());
                progressBar8.Value = servProg4;
                gbServ4.Text = servName4;

                pnlServ1.Show();
                pnlServ2.Show();
                pnlServ3.Show();
                pnlServ4.Show();

            } else if (count == 3)
            {
                SqlCommand cmd1 = new SqlCommand($"Select Top(1) servName From BookedServices Where servStatus = 'Service Approved';", con);
                string servName1 = cmd1.ExecuteScalar().ToString();
                SqlCommand cmd5 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where servStatus = 'Service Approved' AND servName = '{servName1}';", con);
                int servProg = Convert.ToInt32(cmd5.ExecuteScalar().ToString());
                progressBar5.Value = servProg;
                gbServ1.Text = servName1;

                SqlCommand cmd2 = new SqlCommand($"Select Top(1) servName From BookedServices Where servStatus = 'Service Approved' and servName != (Select Top(1) servName From BookedServices);", con);
                string servName2 = cmd2.ExecuteScalar().ToString();
                SqlCommand cmd6 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where servStatus = 'Service Approved' AND servName = '{servName2}' and servName != (Select Top(1) servName From BookedServices);", con);
                int servProg2 = Convert.ToInt32(cmd6.ExecuteScalar().ToString());
                progressBar6.Value = servProg2;
                gbServ2.Text = servName2;

                SqlCommand cmd3 = new SqlCommand($"Select Top(2) Max(servName) From BookedServices Where servStatus = 'Service Approved' and servName != (Select Top(1) servName From BookedServices);", con);
                string servName3 = cmd3.ExecuteScalar().ToString();
                SqlCommand cmd7 = new SqlCommand($"Select Top(2) Max(servProgress) From BookedServices Where servStatus = 'Service Approved' AND servName = '{servName3}' and servName != (Select Top(1) servName From BookedServices);", con);
                int servProg3 = Convert.ToInt32(cmd7.ExecuteScalar().ToString());
                progressBar7.Value = servProg3;
                gbServ3.Text = servName3;

                pnlServ1.Show();
                pnlServ2.Show();
                pnlServ3.Show();

            } else if (count == 2) 
            {
                SqlCommand cmd1 = new SqlCommand($"Select Top(1) servName From BookedServices Where servStatus = 'Service Approved';", con);
                string servName1 = cmd1.ExecuteScalar().ToString();
                SqlCommand cmd5 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where servStatus = 'Service Approved' AND servName = '{servName1}';", con);
                int servProg = Convert.ToInt32(cmd5.ExecuteScalar().ToString());
                progressBar5.Value = servProg;
                gbServ1.Text = servName1;

                SqlCommand cmd2 = new SqlCommand($"Select Top(1) servName From BookedServices Where servStatus = 'Service Approved' and servName != (Select Top(1) servName From BookedServices);", con);
                string servName2 = cmd2.ExecuteScalar().ToString();
                SqlCommand cmd6 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where servStatus = 'Service Approved' AND servName = '{servName2}' and servName != (Select Top(1) servName From BookedServices);", con);
                int servProg2 = Convert.ToInt32(cmd6.ExecuteScalar().ToString());
                progressBar6.Value = servProg2;
                gbServ2.Text = servName2;

                pnlServ1.Show();
                pnlServ2.Show();

            } else if (count == 1)
            {
                SqlCommand cmd1 = new SqlCommand($"Select Top(1) servName From BookedServices Where servStatus = 'Service Approved';", con);
                string servName1 = cmd1.ExecuteScalar().ToString();
                SqlCommand cmd5 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where servStatus = 'Service Approved' AND servName = '{servName1}';", con);
                int servProg = Convert.ToInt32(cmd5.ExecuteScalar().ToString());
                progressBar5.Value = servProg;
                gbServ1.Text = servName1;

                pnlServ1.Show();

            } else if (count == 0)
            {
                lblNone.Show();
            }
            con.Close();
        }

        private Form activeForm = null;
        private void showForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnView5_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd5 = new SqlCommand($"Select Top(1) userID From BookedServices Where servStatus = 'Service Approved' and servName = '{gbServ1.Text}';", con);
            string userID1 = cmd5.ExecuteScalar().ToString();
            SqlCommand cmd6 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where servStatus = 'Service Approved' AND servName = '{gbServ1.Text}';", con);
            int servProg = Convert.ToInt32(cmd6.ExecuteScalar().ToString());
            servNameArgs1 = gbServ1.Text;
            ServiceOverviewTech view = new ServiceOverviewTech(servNameArgs1, userID1, servProg);
            showForm(view);
        }

        private void btnView6_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd6 = new SqlCommand($"Select Top(1) userID From BookedServices Where servName = '{gbServ2.Text}' and servName != (Select Top(1) servName From BookedServices);", con);
            string userID2 = cmd6.ExecuteScalar().ToString();
            SqlCommand cmd7 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where servStatus = 'Service Approved' AND servName = '{gbServ2.Text}' and servName != (Select Top(1) servName From BookedServices);", con);
            int servProg2 = Convert.ToInt32(cmd7.ExecuteScalar().ToString());
            servNameArgs2 = gbServ2.Text;
            ServiceOverviewTech view = new ServiceOverviewTech(servNameArgs2, userID2, servProg2);
            showForm(view);
        }

        private void btnView7_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd7 = new SqlCommand($"Select Top(2) Max(userID) From BookedServices Where servName = '{gbServ3.Text}' and servName != (Select Top(1) servName From BookedServices);", con);
            string userID3 = cmd7.ExecuteScalar().ToString();
            SqlCommand cmd8 = new SqlCommand($"Select Top(2) Max(servProgress) From BookedServices Where servStatus = 'Service Approved' AND servName = '{gbServ3.Text}' and servName != (Select Top(1) servName From BookedServices);", con);
            int servProg3 = Convert.ToInt32(cmd8.ExecuteScalar().ToString());
            servNameArgs3 = gbServ3.Text;
            ServiceOverviewTech view = new ServiceOverviewTech(servNameArgs3, userID3, servProg3);
            showForm(view);
        }

        private void btnView8_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd8 = new SqlCommand($"Select Top(4) Min(userID) From BookedServices Where servStatus = 'Service Approved';", con);
            string userID4 = cmd8.ExecuteScalar().ToString();
            SqlCommand cmd9 = new SqlCommand($"Select Top(4) Min(servProgress) From BookedServices Where servStatus = 'Service Approved' AND servName = '{gbServ4.Text}';", con);
            int servProg4 = Convert.ToInt32(cmd9.ExecuteScalar().ToString());
            servNameArgs4 = gbServ4.Text;
            ServiceOverviewTech view = new ServiceOverviewTech(servNameArgs4, userID4, servProg4);
            showForm(view);
        }
    }
}
