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
        public ServiceOverviewTech(string servNameArgs, string userID)
        {
            InitializeComponent();
            lblTitleServName.Text = servNameArgs;
            userIDHere = userID;
            progressBar1.Value = 0;
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
                lblStatus.Text = "100%";
            } else if (count == 4) 
            {
                progressBar1.Value = 80;
                lblStatus.Text = "80%";
            } else if (count == 3)
            {
                progressBar1.Value = 60;
                lblStatus.Text = "60%";
            } else if (count == 2)
            {
                progressBar1.Value = 40;
                lblStatus.Text = "40%";
            } else if (count == 1)
            {
                progressBar1.Value = 20;
                lblStatus.Text = "20%";
            } else if (count == 0)
            {
                progressBar1.Value = 0;
                lblStatus.Text = "0%";
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"Update BookedServices Set servStatus = 'Service Complete' Where servName = '{lblTitleServName.Text} And userID = '{userIDHere}';", con);
            cmd.ExecuteScalar();
            SqlCommand cmd1 = new SqlCommand($"Update BookedServices Set comment = '{txtComment.Text}' Where servName = '{lblTitleServName.Text} And userID = '{userIDHere}';", con);
            cmd1.ExecuteScalar();
            MessageBox.Show("Service Update Submitted...");
            con.Close();
        }
    }
}
