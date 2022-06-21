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
    public partial class BillingandPayment : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public BillingandPayment()
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
            pnlAttach2.Controls.Add(childForm);
            pnlAttach2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            con.Open();
            string temp = txtEnterCustomerID.Text;
            List<char> charToRemove = new List<char>() { 'U'};
            int userID = Convert.ToInt32(temp.Filter(charToRemove));

            SqlCommand cmd = new SqlCommand($"Select Count(*) From BookedServices Where servStatus = 'Waiting for Payment' and userID = '{userID}';", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            int curr = 1;
            string servName;
            string servType;
            double Totalprice = 0;
            double price;

            if (count != 0)
            {
                count++;
                while (curr != count)
                {
                    SqlCommand cmd1 = new SqlCommand($"Select Top({curr}) servName From BookedServices Where servStatus = 'Waiting for Payment' Order by servName ASC;", con);
                    servName = cmd1.ExecuteScalar().ToString();
                    SqlCommand cmd2 = new SqlCommand($"Update BookedServices Set servStatus = 'In List' Where servName = '{servName}' AND userID = '{userID}';", con);
                    cmd2.ExecuteScalar();
                    SqlCommand cmd3 = new SqlCommand($"Select servType From BookedServices Where userID = {userID} AND servStatus = 'In List' AND servName = '{servName}';", con);
                    servType = cmd3.ExecuteScalar().ToString();
                    lstCustomerBill.Items.Add(servName);
                    if (servType == "Urgent")
                    {
                        SqlCommand cmd4 = new SqlCommand($"Select urgPrice From ServiceDetails Where servName = '{servName}';", con);
                        price = Convert.ToDouble(cmd4.ExecuteScalar().ToString());
                        Totalprice = price + Totalprice;

                    }
                    else
                    {
                        SqlCommand cmd4 = new SqlCommand($"Select normPrice From ServiceDetails Where servName = '{servName}';", con);
                        price = Convert.ToDouble(cmd4.ExecuteScalar().ToString());
                        Totalprice = price + Totalprice;
                    }
                    SqlCommand cmd5 = new SqlCommand($"Select username From AccountDetails Where userID = {userID};", con);
                    string username = cmd5.ExecuteScalar().ToString();
                    lblDisplayCustomerName.Text = username;
                    curr++;
                }
            }
            else
            {
                MessageBox.Show("No services waiting for payment for this customer...");
                txtEnterCustomerID.Text = "";
            }

            lblDisplayTotalAmountPay.Text = $"RM {Totalprice}";
            con.Close();
        }

        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            con.Open();
            string temp = txtEnterCustomerID.Text;
            List<char> charToRemove = new List<char>() { 'U' };
            int userID = Convert.ToInt32(temp.Filter(charToRemove));

            int count = lstCustomerBill.Items.Count;
            int index = 0;

            while (count != index)
            {
                string servName = lstCustomerBill.Items[0].ToString();
                SqlCommand cmd = new SqlCommand($"Update BookedServices Set servStatus = 'Waiting for Payment' Where userID = '{userID}' AND servName = '{servName}' AND servStatus = 'In List';", con);
                cmd.ExecuteScalar();
                lstCustomerBill.Items.RemoveAt(0);
                index++;
            }
            lstCustomerBill.Text = "";
            lblDisplayCustomerName.Text = "";
            lblDisplayTotalAmountPay.Text = "RM ";
            txtEnterCustomerID.Text = "";
            con.Close();
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            con.Open();
            int count = lstCustomerBill.Items.Count;
            int stop = 0;
            int index = 0;
            double price;
            string temp = txtEnterCustomerID.Text;
            List<char> charToRemove = new List<char>() { 'U' };
            int userID = Convert.ToInt32(temp.Filter(charToRemove));

            while (count != stop)
            {
                string servName = lstCustomerBill.Items[index].ToString();
                index++;
                SqlCommand cmd1 = new SqlCommand($"Select servType From BookedServices Where servName = '{servName}' AND userID = '{userID}'; ", con);
                string servType = cmd1.ExecuteScalar().ToString();
      
                if (radCash.Checked == true)
                {
                    if (servType == "Urgent")
                    {
                        SqlCommand cmd2 = new SqlCommand($"Select urgPrice From ServiceDetails Where servName = '{servName}'", con);
                        price = Convert.ToDouble(cmd2.ExecuteScalar().ToString());
                    }
                    else
                    {
                        SqlCommand cmd2 = new SqlCommand($"Select urgPrice From ServiceDetails Where servName = '{servName}'", con);
                        price = Convert.ToDouble(cmd2.ExecuteScalar().ToString());
                    }

                        SqlCommand cmd = new SqlCommand($"Insert into CompletedServices values ('{servName}', '{servType}', '{price}', 'Completed', '{radCash.Text}');", con);
                        cmd.ExecuteScalar();
                        SqlCommand cmd3 = new SqlCommand($"Delete From BookedServices Where servStatus = 'In List' AND servName = '{servName}' AND userID = '{userID}';", con);
                        cmd3.ExecuteScalar();
                        stop++;
                }
                else if (radOnlineBanking.Checked == true)
                {
                    if (servType == "Urgent")
                    {
                        SqlCommand cmd2 = new SqlCommand($"Select urgPrice From ServiceDetails Where servName = '{servName}'", con);
                        price = Convert.ToDouble(cmd2.ExecuteScalar().ToString());
                    }
                    else
                    {
                        SqlCommand cmd2 = new SqlCommand($"Select urgPrice From ServiceDetails Where servName = '{servName}'", con);
                        price = Convert.ToDouble(cmd2.ExecuteScalar().ToString());
                    }

                    SqlCommand cmd = new SqlCommand($"Insert into CompletedServices values ('{servName}', '{servType}', '{price}', 'Completed', '{radOnlineBanking.Text}');", con);
                    cmd.ExecuteScalar();
                    SqlCommand cmd3 = new SqlCommand($"Delete From BookedServices Where servStatus = 'In List' AND servName = '{servName}' AND userID = '{userID}';", con);
                    cmd3.ExecuteScalar();
                    stop++;
                }
                else if (radCash.Checked == false && radOnlineBanking.Checked == false)
                {
                    MessageBox.Show("Please choose a payment method");
                    stop = count;
                }
            }
            radCash.Checked = false;
            radOnlineBanking.Checked = false;
            MessageBox.Show("All Services Paid!");
            con.Close();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            List<string> servNames = new List<string>();
            List<string> prices = new List<string>();
            string totalPrices;
            string tempName;

            for (int i = 0; i < lstCustomerBill.Items.Count; i++)
            {
                tempName = lstCustomerBill.Items[i].ToString();
                servNames.Add(tempName);
            }

            con.Open();
            totalPrices = lblDisplayTotalAmountPay.Text;

            string temp = txtEnterCustomerID.Text;
            List<char> charToRemove = new List<char>() { 'U' };
            int userID = Convert.ToInt32(temp.Filter(charToRemove));

            SqlCommand cmd = new SqlCommand($"Select Count(*) From BookedServices Where servStatus = 'In List' and userID = '{userID}';", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            int index = 0;
            int curr = 1;
            int ohYeah = 1;
            string servName;
            string servType;
            double price;

            if (count != 0)
            {
                while (index != count)
                {
                    if (curr == 1)
                    {
                        servName = lstCustomerBill.Items[index].ToString();
                        MessageBox.Show(servName);

                        SqlCommand cmd3 = new SqlCommand($"Select servType From BookedServices Where userID = {userID} AND servStatus = 'In List' AND servName = '{servName}';", con);
                        servType = cmd3.ExecuteScalar().ToString();

                        if (servType == "Urgent")
                        {
                            SqlCommand cmd4 = new SqlCommand($"Select urgPrice From ServiceDetails Where servName = '{servName}';", con);
                            price = Convert.ToDouble(cmd4.ExecuteScalar().ToString());
                            prices.Add(price.ToString());
                            MessageBox.Show(price.ToString());
                        }
                        else
                        {
                            SqlCommand cmd4 = new SqlCommand($"Select normPrice From ServiceDetails Where servName = '{servName}';", con);
                            price = Convert.ToDouble(cmd4.ExecuteScalar().ToString());
                            prices.Add(price.ToString());
                            MessageBox.Show(price.ToString());
                        }
                    } else if (curr != 1)
                    {
                        servName = lstCustomerBill.Items[index].ToString();
                        MessageBox.Show(servName);

                        SqlCommand cmd3 = new SqlCommand($"Select servType From BookedServices Where userID = {userID} AND servStatus = 'In List' AND servName = '{servName}';", con);
                        servType = cmd3.ExecuteScalar().ToString();

                        if (servType == "Urgent")
                        {
                            SqlCommand cmd4 = new SqlCommand($"Select urgPrice From ServiceDetails Where servName = '{servName}';", con);
                            price = Convert.ToDouble(cmd4.ExecuteScalar().ToString());
                            prices.Add(price.ToString());
                            MessageBox.Show(price.ToString());
                        }
                        else
                        {
                            SqlCommand cmd4 = new SqlCommand($"Select normPrice From ServiceDetails Where servName = '{servName}';", con);
                            price = Convert.ToDouble(cmd4.ExecuteScalar().ToString());
                            prices.Add(price.ToString());
                            MessageBox.Show(price.ToString());
                        }
                    }
                    index++;
                    ohYeah++;
                    curr++;
                }
            }
            con.Close();
            Receipt receipt = new Receipt(servNames, prices, totalPrices);
            receipt.Show();
        }
    }
}
