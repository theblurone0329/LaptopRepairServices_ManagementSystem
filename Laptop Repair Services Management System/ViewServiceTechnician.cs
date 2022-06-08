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
    public partial class ViewServiceTechnician : Form
    {
        public ViewServiceTechnician()
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
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnView5_Click(object sender, EventArgs e)
        {
            ServiceOverviewTech view = new ServiceOverviewTech();
            showForm(view);
        }

        private void btnView6_Click(object sender, EventArgs e)
        {
            ServiceOverviewTech view = new ServiceOverviewTech();
            showForm(view);
        }

        private void btnView7_Click(object sender, EventArgs e)
        {
            ServiceOverviewTech view = new ServiceOverviewTech();
            showForm(view);
        }

        private void btnView8_Click(object sender, EventArgs e)
        {
            ServiceOverviewTech view = new ServiceOverviewTech();
            showForm(view);
        }
    }
}
