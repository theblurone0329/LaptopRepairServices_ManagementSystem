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
    public partial class ChangeServiceCustomer1 : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public static string UID;
        public ChangeServiceCustomer1(string userID)
        {
            InitializeComponent();
            con.Open();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            lblNone.Hide();

            SqlCommand cmd = new SqlCommand($"Select Count(*) From BookedServices Where userID = '{userID}';", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            
            if (count > 4)
            {
                SqlCommand cmd1 = new SqlCommand($"Select Top(1) servName From BookedServices Where userID = '{userID}';", con);
                string servName = cmd1.ExecuteScalar().ToString();
                SqlCommand cmd2 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where userID = '{userID}' and servName = '{servName}';", con);
                int servProg = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                progressBar1.Value = servProg * 20;
                groupBox1.Text = servName;

                SqlCommand cmd3 = new SqlCommand($"Select Top(1) servName From BookedServices Where userID = '{userID}' and servName != '{servName}';", con);
                string servName2 = cmd3.ExecuteScalar().ToString();
                SqlCommand cmd4 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where userID = '{userID}' and servName != '{servName}';", con);
                int servProg2 = Convert.ToInt32(cmd4.ExecuteScalar().ToString());
                progressBar2.Value = servProg2 * 20;
                groupBox2.Text = servName2;

                SqlCommand cmd5 = new SqlCommand($"Select Top(1) servName From BookedServices Where userID = '{userID}' and servName != '{servName}'and servName != '{servName2}';", con);
                string servName3 = cmd5.ExecuteScalar().ToString();
                SqlCommand cmd6 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where userID = '{userID}' AND servName = '{servName3}' and servName != '{servName}'and servName != '{servName2}';", con);
                int servProg3 = Convert.ToInt32(cmd6.ExecuteScalar().ToString());
                progressBar3.Value = servProg3 * 20;
                groupBox3.Text = servName3;

                SqlCommand cmd7 = new SqlCommand($"Select Top(4) Min(servName) From BookedServices Where userID = '{userID}';", con);
                string servName4 = cmd7.ExecuteScalar().ToString();
                SqlCommand cmd8 = new SqlCommand($"Select Top(4) Min(servProgress) From BookedServices Where userID = '{userID}' AND servName = '{servName4}';", con);
                int servProg4 = Convert.ToInt32(cmd8.ExecuteScalar().ToString());
                progressBar4.Value = servProg4 * 20;
                groupBox4.Text = servName4;

                groupBox1.Show();
                groupBox2.Show();
                groupBox3.Show();
                groupBox4.Show();

            } else if (count == 4)
            {
                SqlCommand cmd1 = new SqlCommand($"Select Top(1) servName From BookedServices Where userID = '{userID}';", con);
                string servName = cmd1.ExecuteScalar().ToString();
                SqlCommand cmd2 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where userID = '{userID}' and servName = '{servName}';", con);
                int servProg = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                progressBar1.Value = servProg * 20;
                groupBox1.Text = servName;

                SqlCommand cmd3 = new SqlCommand($"Select Top(1) servName From BookedServices Where userID = '{userID}' and servName != '{servName}';", con);
                string servName2 = cmd3.ExecuteScalar().ToString();
                SqlCommand cmd4 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where userID = '{userID}' and servName != '{servName}';", con);
                int servProg2 = Convert.ToInt32(cmd4.ExecuteScalar().ToString());
                progressBar2.Value = servProg2 * 20;
                groupBox2.Text = servName2;

                SqlCommand cmd5 = new SqlCommand($"Select Top(1) servName From BookedServices Where userID = '{userID}' and servName != '{servName}'and servName != '{servName2}';", con);
                string servName3 = cmd5.ExecuteScalar().ToString();
                SqlCommand cmd6 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where userID = '{userID}' AND servName = '{servName3}' and servName != '{servName}'and servName != '{servName2}';", con);
                int servProg3 = Convert.ToInt32(cmd6.ExecuteScalar().ToString());
                progressBar3.Value = servProg3 * 20;
                groupBox3.Text = servName3;

                SqlCommand cmd7 = new SqlCommand($"Select Top(4) Min(servName) From BookedServices Where userID = '{userID}';", con);
                string servName4 = cmd7.ExecuteScalar().ToString();
                SqlCommand cmd8 = new SqlCommand($"Select Top(4) Min(servProgress) From BookedServices Where userID = '{userID}' AND servName = '{servName4}';", con);
                int servProg4 = Convert.ToInt32(cmd8.ExecuteScalar().ToString());
                progressBar4.Value = servProg4 * 20;
                groupBox4.Text = servName4;

                groupBox1.Show();
                groupBox2.Show();
                groupBox3.Show();
                groupBox4.Show();
            }
            else if (count == 3)
            {
                SqlCommand cmd1 = new SqlCommand($"Select Top(1) servName From BookedServices Where userID = '{userID}';", con);
                string servName = cmd1.ExecuteScalar().ToString();
                SqlCommand cmd2 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where userID = '{userID}' and servName = '{servName}';", con);
                int servProg = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                progressBar1.Value = servProg * 20;
                groupBox1.Text = servName;

                SqlCommand cmd3 = new SqlCommand($"Select Top(1) servName From BookedServices Where userID = '{userID}' and servName != '{servName}';", con);
                string servName2 = cmd3.ExecuteScalar().ToString();
                SqlCommand cmd4 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where userID = '{userID}' and servName != '{servName}';", con);
                int servProg2 = Convert.ToInt32(cmd4.ExecuteScalar().ToString());
                progressBar2.Value = servProg2 * 20;
                groupBox2.Text = servName2;

                SqlCommand cmd5 = new SqlCommand($"Select Top(1) servName From BookedServices Where userID = '{userID}' and servName != '{servName}'and servName != '{servName2}';", con);
                string servName3 = cmd5.ExecuteScalar().ToString();
                SqlCommand cmd6 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where userID = '{userID}' AND servName = '{servName3}' and servName != '{servName}'and servName != '{servName2}';", con);
                int servProg3 = Convert.ToInt32(cmd6.ExecuteScalar().ToString());
                progressBar3.Value = servProg3 * 20;
                groupBox3.Text = servName3;

                groupBox1.Show();
                groupBox2.Show();
                groupBox3.Show();

            }
            else if (count == 2)
            {
                SqlCommand cmd1 = new SqlCommand($"Select Top(1) servName From BookedServices Where userID = '{userID}';", con);
                string servName = cmd1.ExecuteScalar().ToString();
                SqlCommand cmd2 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where userID = '{userID}' and servName = '{servName}';", con);
                int servProg = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                progressBar1.Value = servProg * 20;
                groupBox1.Text = servName;

                SqlCommand cmd3 = new SqlCommand($"Select Top(1) servName From BookedServices Where userID = '{userID}' and servName != '{servName}';", con);
                string servName2 = cmd3.ExecuteScalar().ToString();
                SqlCommand cmd4 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where userID = '{userID}' and servName != '{servName}';", con);
                int servProg2 = Convert.ToInt32(cmd4.ExecuteScalar().ToString());
                progressBar2.Value = servProg2 * 20;
                groupBox2.Text = servName2;

                groupBox1.Show();
                groupBox2.Show();
            }
            else if (count == 1)
            {
                SqlCommand cmd1 = new SqlCommand($"Select Top(1) servName From BookedServices Where userID = '{userID}';", con);
                string servName = cmd1.ExecuteScalar().ToString();
                SqlCommand cmd2 = new SqlCommand($"Select Top(1) servProgress From BookedServices Where userID = '{userID}' and servName = '{servName}';", con);
                int servProg = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                progressBar1.Value = servProg * 20;
                groupBox1.Text = servName;

                groupBox1.Show();
            }
            else if (count == 0)
            {
                lblNone.Show();
            }
            con.Close();
            UID = userID;
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
            pnlAttachForm.Controls.Add(childForm);
            pnlAttachForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnView1_Click_1(object sender, EventArgs e)
        {
            string servName = groupBox1.Text;
            ServiceOverviewNew viewService = new ServiceOverviewNew(UID, servName);
            showForm(viewService);
        }

        private void btnView2_Click_1(object sender, EventArgs e)
        {
            string servName = groupBox2.Text;
            ServiceOverviewNew viewService = new ServiceOverviewNew(UID, servName);
            showForm(viewService);
        }

        private void btnView3_Click_1(object sender, EventArgs e)
        {
            string servName = groupBox3.Text;
            ServiceOverviewNew viewService = new ServiceOverviewNew(UID, servName);
            showForm(viewService);
        }

        private void btnView4_Click_1(object sender, EventArgs e)
        {
            string servName = groupBox4.Text;
            ServiceOverviewNew viewService = new ServiceOverviewNew(UID, servName);
            showForm(viewService);
        }

        private void btnChange1_Click_1(object sender, EventArgs e)
        {
            string servName = groupBox1.Text;
            ChangeServicesCustomer2 changeServ = new ChangeServicesCustomer2(UID, servName);
            showForm(changeServ);
        }

        private void btnChange2_Click_1(object sender, EventArgs e)
        {
            string servName = groupBox2.Text;
            ChangeServicesCustomer2 changeServ = new ChangeServicesCustomer2(UID, servName);
            showForm(changeServ);
        }

        private void btnChange3_Click_1(object sender, EventArgs e)
        {
            string servName = groupBox3.Text;
            ChangeServicesCustomer2 changeServ = new ChangeServicesCustomer2(UID, servName);
            showForm(changeServ);
        }

        private void btnChange4_Click_1(object sender, EventArgs e)
        {
            string servName = groupBox4.Text;
            ChangeServicesCustomer2 changeServ = new ChangeServicesCustomer2(UID, servName);
            showForm(changeServ);
        }
    }
}
