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
    public partial class ChangeServicesCustomer2 : Form
    {
        public static string name;
        public ChangeServicesCustomer2(string username)
        {
            InitializeComponent();
            name = username;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeServiceCustomer1 viewServ = new ChangeServiceCustomer1(name);
            showForm(viewServ);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ChangeServiceCustomer1 viewServ = new ChangeServiceCustomer1(name);
            showForm(viewServ);
        }
    }
}
