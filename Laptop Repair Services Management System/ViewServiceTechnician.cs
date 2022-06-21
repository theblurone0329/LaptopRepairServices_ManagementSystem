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
        string servNameArgs1;
        string servNameArgs2;
        string servNameArgs3;
        string servNameArgs4;
        string userID1;
        string userID2;
        string userID3;
        string userID4;
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
                SqlCommand cmd5 = new SqlCommand($"Select Top(1) userID From BookedServices Where servStatus = 'Service Approved' and servName = '{servName1}';", con);
                string userID1 = cmd5.ExecuteScalar().ToString();
                gbServ1.Text = servName1;
                string servNameArgs1 = servName1;

                SqlCommand cmd2 = new SqlCommand($"Select Top(1) servName From BookedServices Where servStatus = 'Service Approved' and servName != (Select Top(1) servName From BookedServices);", con);
                string servName2 = cmd2.ExecuteScalar().ToString();
                SqlCommand cmd6 = new SqlCommand($"Select Top(1) userID From BookedServices Where servName = '{servName2}' and servName != (Select Top(1) servName From BookedServices);", con);
                string userID2 = cmd6.ExecuteScalar().ToString();
                gbServ2.Text = servName2;
                string servNameArgs2 = servName2;

                SqlCommand cmd3 = new SqlCommand($"Select Top(2) Max(servName) From BookedServices Where servStatus = 'Service Approved' and servName != (Select Top(1) servName From BookedServices);", con);
                string servName3 = cmd3.ExecuteScalar().ToString();
                SqlCommand cmd7 = new SqlCommand($"Select Top(2) Max(userID) From BookedServices Where servName = '{servName3}' and servName != (Select Top(1) servName From BookedServices);", con);
                string userID3 = cmd7.ExecuteScalar().ToString();
                gbServ3.Text = servName3;
                string servNameArgs3 = servName3;

                SqlCommand cmd4 = new SqlCommand($"Select Top(4) Min(servName) From BookedServices Where servStatus = 'Service Approved';", con);
                string servName4 = cmd4.ExecuteScalar().ToString();
                SqlCommand cmd8 = new SqlCommand($"Select Top(4) Min(userID) From BookedServices Where servStatus = 'Service Approved';", con);
                string userID4 = cmd8.ExecuteScalar().ToString();
                gbServ4.Text = servName4;
                string servNameArgs4 = servName4;

                pnlServ1.Show();
                pnlServ2.Show();
                pnlServ3.Show();
                pnlServ4.Show();
            }
            else if (count == 4)
            {
                SqlCommand cmd1 = new SqlCommand($"Select Top(1) servName From BookedServices Where servStatus = 'Service Approved';", con);
                string servName1 = cmd1.ExecuteScalar().ToString();
                SqlCommand cmd5 = new SqlCommand($"Select Top(1) userID From BookedServices Where servStatus = 'Service Approved' and servName = '{servName1}';", con);
                string userID1 = cmd5.ExecuteScalar().ToString();
                gbServ1.Text = servName1;
                string servNameArgs1 = servName1;

                SqlCommand cmd2 = new SqlCommand($"Select Top(2) Max(servName) From BookedServices Where servStatus = 'Service Approved';", con);
                string servName2 = cmd2.ExecuteScalar().ToString();
                SqlCommand cmd6 = new SqlCommand($"Select Top(2) Max(userID) From BookedServices Where servStatus = 'Service Approved' and servName = '{servName2}';", con);
                string userID2 = cmd6.ExecuteScalar().ToString();
                gbServ2.Text = servName2;
                string servNameArgs2 = servName2;

                SqlCommand cmd3 = new SqlCommand($"Select Top(3) Min(servName) From BookedServices Where servStatus = 'Service Approved' and servName Not in (Select Top(2) servName From BookedServices);", con);
                string servName3 = cmd3.ExecuteScalar().ToString();
                SqlCommand cmd7 = new SqlCommand($"Select Top(3) Min(userID) From BookedServices Where servStatus = 'Service Approved' and servName Not in (Select Top(2) servName From BookedServices) and servName = '{servName3}';", con);
                string userID3 = cmd7.ExecuteScalar().ToString();
                gbServ3.Text = servName1;
                string servNameArgs3 = servName3;

                SqlCommand cmd4 = new SqlCommand($"Select Top(4) Min(servName) From BookedServices Where servStatus = 'Service Approved' and servName Not in (Select Top(3) servName From BookedServices);", con);
                string servName4 = cmd4.ExecuteScalar().ToString();
                SqlCommand cmd8 = new SqlCommand($"Select Top(4) Min(userID) From BookedServices Where servStatus = 'Service Approved' and servName Not in (Select Top(3) servName From BookedServices) and servName = '{servName4}';", con);
                string userID4 = cmd8.ExecuteScalar().ToString();
                gbServ4.Text = servName4;
                string servNameArgs4 = servName4;

                pnlServ1.Show();
                pnlServ2.Show();
                pnlServ3.Show();
                pnlServ4.Show();
            } else if (count == 3)
            {
                SqlCommand cmd1 = new SqlCommand($"Select Top(1) servName From BookedServices Where servStatus = 'Service Approved';", con);
                string servName1 = cmd1.ExecuteScalar().ToString();
                SqlCommand cmd5 = new SqlCommand($"Select Top(1) userID From BookedServices Where servStatus = 'Service Approved' and servName = '{servName1}';", con);
                string userID1 = cmd5.ExecuteScalar().ToString();
                gbServ1.Text = servName1;
                string servNameArgs1 = servName1;

                SqlCommand cmd2 = new SqlCommand($"Select Top(2) Max(servName) From BookedServices Where servStatus = 'Service Approved';", con);
                string servName2 = cmd2.ExecuteScalar().ToString();
                SqlCommand cmd6 = new SqlCommand($"Select Top(2) Max(userID) From BookedServices Where servStatus = 'Service Approved' and servName = '{servName2}';", con);
                string userID2 = cmd6.ExecuteScalar().ToString();
                gbServ2.Text = servName2;
                string servNameArgs2 = servName2;

                SqlCommand cmd3 = new SqlCommand($"Select Top(3) Min(servName) From BookedServices Where servStatus = 'Service Approved' and servName Not in (Select Top(2) servName From BookedServices);", con);
                string servName3 = cmd3.ExecuteScalar().ToString();
                SqlCommand cmd7 = new SqlCommand($"Select Top(3) Min(userID) From BookedServices Where servStatus = 'Service Approved' and servName Not in (Select Top(2) servName From BookedServices) and servName = '{servName3}';", con);
                string userID3 = cmd7.ExecuteScalar().ToString();
                gbServ3.Text = servName1;
                string servNameArgs3 = servName3;

                pnlServ1.Show();
                pnlServ2.Show();
                pnlServ3.Show();
            } else if (count == 2) 
            {
                SqlCommand cmd1 = new SqlCommand($"Select Top(1) servName From BookedServices Where servStatus = 'Service Approved';", con);
                string servName1 = cmd1.ExecuteScalar().ToString();
                SqlCommand cmd5 = new SqlCommand($"Select Top(1) userID From BookedServices Where servStatus = 'Service Approved' and servName = '{servName1}';", con);
                string userID1 = cmd5.ExecuteScalar().ToString();
                gbServ1.Text = servName1;
                string servNameArgs1 = servName1;

                SqlCommand cmd2 = new SqlCommand($"Select Top(2) Max(servName) From BookedServices Where servStatus = 'Service Approved';", con);
                string servName2 = cmd2.ExecuteScalar().ToString();
                SqlCommand cmd6 = new SqlCommand($"Select Top(2) Max(userID) From BookedServices Where servStatus = 'Service Approved' and servName = '{servName2}';", con);
                string userID2 = cmd6.ExecuteScalar().ToString();
                gbServ2.Text = servName2;
                string servNameArgs2 = servName2;

                pnlServ1.Show();
                pnlServ2.Show();
            } else if (count == 1)
            {
                SqlCommand cmd1 = new SqlCommand($"Select Top(1) servName From BookedServices Where servStatus = 'Service Approved';", con);
                string servName1 = cmd1.ExecuteScalar().ToString();
                SqlCommand cmd5 = new SqlCommand($"Select Top(1) userID From BookedServices Where servStatus = 'Service Approved' and servName = '{servName1}';", con);
                string userID1 = cmd5.ExecuteScalar().ToString();
                gbServ1.Text = servName1;
                string servNameArgs1 = servName1;

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

        private void btnView5_Click(object sender, EventArgs e)
        {
            ServiceOverviewTech view = new ServiceOverviewTech(servNameArgs1, userID1);
            showForm(view);
        }

        private void btnView6_Click(object sender, EventArgs e)
        {
            ServiceOverviewTech view = new ServiceOverviewTech(servNameArgs2, userID2);
            showForm(view);
        }

        private void btnView7_Click(object sender, EventArgs e)
        {
            ServiceOverviewTech view = new ServiceOverviewTech(servNameArgs3, userID3);
            showForm(view);
        }

        private void btnView8_Click(object sender, EventArgs e)
        {
            ServiceOverviewTech view = new ServiceOverviewTech(servNameArgs4, userID4);
            showForm(view);
        }
    }
}
