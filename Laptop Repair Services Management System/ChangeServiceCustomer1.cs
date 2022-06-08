using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System
{
    public partial class ChangeServiceCustomer1 : Form
    {
        public ChangeServiceCustomer1()
        {
            InitializeComponent();
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

        private void btnView1_Click(object sender, EventArgs e)
        {
            ServiceOverview viewService = new ServiceOverview();
            showForm(viewService);
        }

        private void btnView2_Click(object sender, EventArgs e)
        {
            ServiceOverview viewService = new ServiceOverview();
            showForm(viewService);
        }

        private void btnView3_Click(object sender, EventArgs e)
        {
            ServiceOverview viewService = new ServiceOverview();
            showForm(viewService);
        }

        private void btnView4_Click(object sender, EventArgs e)
        {
            ServiceOverview viewService = new ServiceOverview();
            showForm(viewService);
        }

        private void btnChange1_Click(object sender, EventArgs e)
        {
            ChangeServicesCustomer2 changeServ = new ChangeServicesCustomer2();
            showForm(changeServ);
        }

        private void btnChange2_Click(object sender, EventArgs e)
        {
            ChangeServicesCustomer2 changeServ = new ChangeServicesCustomer2();
            showForm(changeServ);
        }

        private void btnChange3_Click(object sender, EventArgs e)
        {
            ChangeServicesCustomer2 changeServ = new ChangeServicesCustomer2();
            showForm(changeServ);
        }

        private void btnChange4_Click(object sender, EventArgs e)
        {
            ChangeServicesCustomer2 changeServ = new ChangeServicesCustomer2();
            showForm(changeServ);
        }
    }
}
