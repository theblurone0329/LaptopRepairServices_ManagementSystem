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
    public partial class ChangeServicesCustomer2 : Form
    {
        public static string UID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public ChangeServicesCustomer2(string userID, string servName)
        {
            InitializeComponent();
            con.Open();
            UID = userID;
            lblCurrServName.Text = servName;
            SqlCommand cmd = new SqlCommand($"Select servType From BookedServices Where userID = '{userID}' AND servName = '{servName}'", con);
            string servType = cmd.ExecuteScalar().ToString();
            lblCurrServType.Text = servType;
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
            pnlAttachForm.Controls.Add(childForm);
            pnlAttachForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            ChangeServiceCustomer1 viewServ = new ChangeServiceCustomer1(UID);
            showForm(viewServ);
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            ChangeServiceCustomer1 viewServ = new ChangeServiceCustomer1(UID);
            showForm(viewServ);
        }
    }
}
