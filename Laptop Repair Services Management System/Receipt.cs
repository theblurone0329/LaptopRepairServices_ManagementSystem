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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
            MessageBox.Show("Take a screenshot using the Windows + Shift + 'S' keys to activate snippet tool for screenshot...");
            pnlEntry1.Hide();
            pnlEntry2.Hide();
            pnlEntry3.Hide();
            pnlEntry4.Hide();
            pnlEntry5.Hide();
            pnlTotalPrice.Hide();
        }

        private void lblReceiptList_Click(object sender, EventArgs e)
        {

        }
    }
}
