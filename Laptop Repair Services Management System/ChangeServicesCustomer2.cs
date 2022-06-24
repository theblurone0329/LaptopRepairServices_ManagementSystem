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
            con.Open();
            SqlCommand cmd = new SqlCommand($"Delete From BookedServices Where userID = '{UID}' AND servName = '{lblCurrServName.Text}' AND servType = '{lblCurrServType.Text}';", con);
            cmd.ExecuteScalar();

            DateTime date = DateTime.Today.Date;
            string today = date.ToString("dd/MMMM/yyyy");
            today.Replace("/", " ");

            
            if (radBtnNormal.Checked == true)
            {
                SqlCommand cmd1 = new SqlCommand($"Insert into ChangeServices values('{lblCurrServName.Text}', '{UID}', '0', '{ComboBoxServiceType.Text}', '{radBtnNormal.Text}');", con);
                cmd1.ExecuteScalar();
            } else if (radBtnUrgent.Checked == true)
            {
                SqlCommand cmd1 = new SqlCommand($"Insert into ChangeServices values('{lblCurrServName.Text}', '{UID}', '0', '{ComboBoxServiceType.Text}', '{radBtnUrgent.Text}');", con);
                cmd1.ExecuteScalar();
            }
            else if (radBtnNormal.Checked == false || radBtnUrgent.Checked == false)
            {
                MessageBox.Show("Please choose a service type");
            }
            con.Close();
            MessageBox.Show("Service Change Successfully");
            ChangeServiceCustomer1 viewServ = new ChangeServiceCustomer1(UID);
            showForm(viewServ);
        }

        private void ComboBoxServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand($"Select urgPrice From ServiceDetails Where servName = '{ComboBoxServiceType.Text}';", con);
            string urgPrice = cmd2.ExecuteScalar().ToString();
            SqlCommand cmd3 = new SqlCommand($"Select normPrice From ServiceDetails Where servName = '{ComboBoxServiceType.Text}';", con);
            string normPrice = cmd3.ExecuteScalar().ToString();

            lblUrgPrice.Text = "RM " + urgPrice;
            lblNormPrice.Text = "RM " + normPrice;
            con.Close();
        }
    }
}
