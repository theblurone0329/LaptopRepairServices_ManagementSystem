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
    public partial class ViewServicesReportAdmin : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public ViewServicesReportAdmin()
        {
            InitializeComponent();
        }

        private DataTable GetServiceList()
        {
            con.Close();
            DataTable ServiceData = new DataTable();
            {
                int month = cmbBoxMonth.SelectedIndex + 1;

                if (radButtonCompleted.Checked)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"Select * from CompletedServices where Month(completionDate) = {month};", con);
                    cmd.ExecuteScalar();
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        ServiceData.Load(reader);
                    }
                    con.Close();
                }
                else if (radBtnUncompleted.Checked)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"Select * from BookedServices where Month(date) = {month};", con);
                    cmd.ExecuteScalar();
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        ServiceData.Load(reader);
                    }
                    con.Close();
                } else
                {
                    MessageBox.Show("Please select an option to view data");
                }
            }
            con.Close();
            return ServiceData;         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serviceReportGridView.DataSource = GetServiceList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbBoxMonth.SelectedIndex = -1;
            radButtonCompleted.Checked = false;
            radButtonUncompleted.Checked = false;
        }
    }
}
