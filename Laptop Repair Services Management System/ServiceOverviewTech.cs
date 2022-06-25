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
    public partial class ServiceOverviewTech : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        string userIDHere;
        public ServiceOverviewTech(string servNameArgs, string userID, int servProg)
        {
            InitializeComponent();
            btnComplete.Enabled = false;
            lblTitleServName.Text = servNameArgs;
            userIDHere = userID;
            int temp = servProg * 20;
            string prog = temp.ToString();
            lblStatus.Text = prog + "% Complete";
            progressBar1.Value = temp;

            if (servProg == 1)
            {
                checkedListBox1.SetItemChecked(0, true);
            } else if (servProg == 2)
            {
                checkedListBox1.SetItemChecked(0, true);
                checkedListBox1.SetItemChecked(1, true);
            } else if (servProg == 3)
            {
                checkedListBox1.SetItemChecked(0, true);
                checkedListBox1.SetItemChecked(1, true);
                checkedListBox1.SetItemChecked(2, true);
            } else if (servProg == 4)
            {
                checkedListBox1.SetItemChecked(0, true);
                checkedListBox1.SetItemChecked(1, true);
                checkedListBox1.SetItemChecked(2, true);
                checkedListBox1.SetItemChecked(3, true);
            }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            ViewServiceTechnician view = new ViewServiceTechnician();
            showForm(view);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = checkedListBox1.CheckedItems.Count;

            if (count == 5)
            {
                progressBar1.Value = 100;
                lblStatus.Text = "100% Complete";
                btnComplete.Enabled = true;
            } else if (count == 4) 
            {
                progressBar1.Value = 80;
                lblStatus.Text = "80% Completed";
                btnComplete.Enabled = false;
            } else if (count == 3)
            {
                progressBar1.Value = 60;
                lblStatus.Text = "60% Completed";
                btnComplete.Enabled = false;
            } else if (count == 2)
            {
                progressBar1.Value = 40;
                lblStatus.Text = "40% Completed";
                btnComplete.Enabled = false;
            } else if (count == 1)
            {
                progressBar1.Value = 20;
                lblStatus.Text = "20% Completed";
                btnComplete.Enabled = false;
            } else if (count == 0)
            {
                progressBar1.Value = 0;
                lblStatus.Text = "0% Completed";
                btnComplete.Enabled = false;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand($"Update BookedServices Set servProgress = '{progressBar1.Value / 20}' Where servName = '{lblTitleServName.Text} AND userID = {userIDHere}';", con);
            cmd.ExecuteScalar();
            con.Close();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"Update BookedServices Set servStatus = 'Waiting for Payment' Where servName = '{lblTitleServName.Text}' And userID = '{userIDHere}';", con);
            cmd.ExecuteScalar();
            SqlCommand cmd1 = new SqlCommand($"Update BookedServices Set comment = '{txtComment.Text}' Where servName = '{lblTitleServName.Text}' And userID = '{userIDHere}';", con);
            cmd1.ExecuteScalar();
            SqlCommand cmd2 = new SqlCommand($"Insert into Notifications values('Service Completed', 'Your service for {lblTitleServName.Text} has been completed and is waiting for payment! Please contact our receptionist for payment and retrieval!', '{userIDHere}');", con);
            cmd2.ExecuteScalar();
            MessageBox.Show("Service Update Submitted...");
            con.Close();
        }
    }
}
