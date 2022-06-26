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
    public partial class ServiceOverviewNew : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public static string UID;
        public ServiceOverviewNew(string userID, string servName)
        {
            //to display service name, progress, and comments on the form
            InitializeComponent();
            UID = userID;
            con.Open();
            lblTitleServName.Text = servName;
            SqlCommand cmd = new SqlCommand($"Select servProgress From BookedServices Where servName = '{servName}' AND userID = '{userID}';", con);
            int servProg = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            int progress = servProg * 20;
            lblservProg.Text = progress.ToString() + "% Complete";
            SqlCommand cmd1 = new SqlCommand($"Select servType From BookedServices Where servName = '{servName}' AND userID = '{userID}';", con);
            string servType = cmd1.ExecuteScalar().ToString();

            //to check if selected service type is urgent or normal
            if (servType == "Urgent")
            {
                SqlCommand cmd2 = new SqlCommand($"Select urgPrice From ServiceDetails Where servName = '{servName}';", con);
                double price = Convert.ToDouble(cmd2.ExecuteScalar().ToString());
                lblPrice.Text = $"RM {price}";
            }
            else if (servType == "Normal")
            {
                SqlCommand cmd2 = new SqlCommand($"Select normPrice From ServiceDetails Where servName = '{servName}';", con);
                double price = Convert.ToDouble(cmd2.ExecuteScalar().ToString());
                lblPrice.Text = $"RM {price}";
            }

            SqlCommand cmd3 = new SqlCommand($"Select comment From BookedServices Where servName = '{servName}' AND userID = '{userID}';", con);
            string comments = cmd3.ExecuteScalar().ToString();
            txtComments.Text = comments;

            con.Close();
        }

        //method to display form on panel
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
            //to redirect user back to view service page
            ChangeServiceCustomer1 viewServ = new ChangeServiceCustomer1(UID);
            showForm(viewServ);
        }
    }
}
