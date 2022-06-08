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
    public partial class ChangeServiceReceptionist : Form
    {
        public ChangeServiceReceptionist()
        {
            InitializeComponent();
        }

        private void btnDecline1_Click(object sender, EventArgs e)
        {
            pnlServ1.Hide();
        }

        private void btnAccept1_Click(object sender, EventArgs e)
        {
            pnlServ1.Hide();
        }

        private void btnDecline2_Click(object sender, EventArgs e)
        {
            pnlServ2.Hide();
        }

        private void btnAccept2_Click(object sender, EventArgs e)
        {
            pnlServ2.Hide();
        }
    }
}
