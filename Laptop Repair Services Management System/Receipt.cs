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
        public Receipt(List<string> servNames, List<double> prices, string totalPrices)
        {
            InitializeComponent();
            MessageBox.Show("Take a screenshot using the Windows + Shift + 'S' keys to activate snippet tool for screenshot...");
            pnlEntry1.Hide();
            pnlEntry2.Hide();
            pnlEntry3.Hide();
            pnlEntry4.Hide();
            pnlEntry5.Hide();
            //pnlTotalPrice.Hide();

            lblTotalPrice.Text = totalPrices;

            if (servNames.Count > 5)
            {
                lblServ1.Text = servNames[0];
                lblServ2.Text = servNames[1];
                lblServ3.Text = servNames[2];
                lblServ4.Text = servNames[3];
                lblServ5.Text = servNames[4];

                lblPrice1.Text = prices[0].ToString();
                lblPrice2.Text = prices[1].ToString();
                lblPrice3.Text = prices[2].ToString();
                lblPrice4.Text = prices[3].ToString();
                lblPrice5.Text = prices[4].ToString();

                pnlEntry1.Show();
                pnlEntry2.Show();
                pnlEntry3.Show();
                pnlEntry4.Show();
                pnlEntry5.Show();
                pnlTotalPrice.Show();

            } else if (servNames.Count == 5)
            {
                lblServ1.Text = servNames[0];
                lblServ2.Text = servNames[1];
                lblServ3.Text = servNames[2];
                lblServ4.Text = servNames[3];
                lblServ5.Text = servNames[4];

                lblPrice1.Text = prices[0].ToString();
                lblPrice2.Text = prices[1].ToString();
                lblPrice3.Text = prices[2].ToString();
                lblPrice4.Text = prices[3].ToString();
                lblPrice5.Text = prices[4].ToString();

                pnlEntry1.Show();
                pnlEntry2.Show();
                pnlEntry3.Show();
                pnlEntry4.Show();
                pnlEntry5.Show();
                pnlTotalPrice.Show();

            } else if (servNames.Count == 4)
            {
                lblServ1.Text = servNames[0];
                lblServ2.Text = servNames[1];
                lblServ3.Text = servNames[2];
                lblServ4.Text = servNames[3];

                lblPrice1.Text = prices[0].ToString();
                lblPrice2.Text = prices[1].ToString();
                lblPrice3.Text = prices[2].ToString();
                lblPrice4.Text = prices[3].ToString();

                pnlEntry1.Show();
                pnlEntry2.Show();
                pnlEntry3.Show();
                pnlEntry4.Show();
                pnlTotalPrice.Show();

            } else if (servNames.Count == 3)
            {
                lblServ1.Text = servNames[0];
                lblServ2.Text = servNames[1];
                lblServ3.Text = servNames[2];

                lblPrice1.Text = prices[0].ToString();
                lblPrice2.Text = prices[1].ToString();
                lblPrice3.Text = prices[2].ToString();

                pnlEntry1.Show();
                pnlEntry2.Show();
                pnlEntry3.Show();
                pnlTotalPrice.Show();

            } else if (servNames.Count == 2)
            {
                lblServ1.Text = servNames[0];
                lblServ2.Text = servNames[1];

                lblPrice1.Text = prices[0].ToString();
                lblPrice2.Text = prices[1].ToString();

                pnlEntry1.Show();
                pnlEntry2.Show();
                pnlTotalPrice.Show();

            } else if (servNames.Count == 1)
            {
                lblServ1.Text = servNames[0];

                lblPrice1.Text = prices[0].ToString();

                pnlEntry1.Show();
                pnlTotalPrice.Show();
            } else if (servNames.Count == 0)
            {
                MessageBox.Show("Its empty!");
            }
        }
    }
}
