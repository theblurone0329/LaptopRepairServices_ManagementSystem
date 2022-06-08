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
    public partial class UpdateProfile : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public static string n;
        string username;
        public UpdateProfile(string n)
        {
            InitializeComponent();
            username = n;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            ViewDetails view = new ViewDetails(username);
            showForm(view);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txtBoxUsername.Text == "" && txtBoxEmail.Text == "" && txtBoxNewPassw.Text == "" && txtBoxNewPassw.Text == "")
            {
                MessageBox.Show("No Changes made! Returning...");
                con.Close();
                ViewDetails view5 = new ViewDetails(username);
                showForm(view5);
            }
            else if (txtBoxUsername.Text == "" && txtBoxEmail.Text != "" && txtBoxNewPassw.Text != "" && txtBoxNewPassw.Text != "" && txtBoxConfirmPassw.Text != "")
            {
                if (txtBoxConfirmPassw.Text != txtBoxNewPassw.Text)
                {
                    MessageBox.Show("Both new and confirmation password must be the same! Try Again!");
                    con.Close();
                }
                else
                {
                    SqlCommand cmd6 = new SqlCommand($"Update AccountDetails Set username='{txtBoxEmail.Text}', password='{txtBoxConfirmPassw.Text}' Where username='{username}';", con);
                    cmd6.ExecuteScalar();
                    MessageBox.Show("Email and Password changed successfully!");
                    con.Close();
                    ViewDetails view6 = new ViewDetails(username);
                    showForm(view6);
                }
            }
            else if (txtBoxUsername.Text != "" && txtBoxEmail.Text == "" && txtBoxNewPassw.Text != "" && txtBoxNewPassw.Text != "" && txtBoxConfirmPassw.Text != "")
            {
                if (txtBoxConfirmPassw.Text != txtBoxNewPassw.Text)
                {
                    MessageBox.Show("Both new and confirmation password must be the same! Try Again!");
                    con.Close();
                }
                else
                {
                    SqlCommand cmd5 = new SqlCommand($"Update AccountDetails Set username='{txtBoxUsername.Text}', password='{txtBoxConfirmPassw.Text}' Where username='{username}';", con);
                    cmd5.ExecuteScalar();
                    MessageBox.Show("Username and Password changed successfully!");
                    con.Close();
                    username = txtBoxUsername.Text;
                    ViewDetails view6 = new ViewDetails(username);
                    showForm(view6);
                }
            }
            else if (txtBoxUsername.Text != "" && txtBoxEmail.Text != "" && txtBoxNewPassw.Text != "" && txtBoxNewPassw.Text != "" && txtBoxConfirmPassw.Text != "")
            {
                if (txtBoxConfirmPassw.Text != txtBoxNewPassw.Text)
                {
                    MessageBox.Show("Both new and confirmation password must be the same! Try Again!");
                    con.Close();
                }
                else
                {
                    SqlCommand cmd4 = new SqlCommand($"Update AccountDetails Set username='{txtBoxUsername.Text}', email='{txtBoxEmail.Text}', password='{txtBoxConfirmPassw.Text}' Where username='{username}';", con);
                    cmd4.ExecuteScalar();
                    MessageBox.Show("Username, Email, and Password changed successfully!");
                    con.Close();
                    username = txtBoxUsername.Text;
                    ViewDetails view6 = new ViewDetails(username);
                    showForm(view6);
                }
            }
            else if (txtBoxCurrentPassw.Text != "" && txtBoxNewPassw.Text != "" && txtBoxConfirmPassw.Text == "")
            {
                MessageBox.Show("Please fill in your new password another time to confirm!");
                con.Close();
            }
            else if (txtBoxCurrentPassw.Text != "" && txtBoxNewPassw.Text != "" && txtBoxConfirmPassw.Text != "")
            {
                if (txtBoxConfirmPassw.Text != txtBoxNewPassw.Text)
                {
                    MessageBox.Show("Both new and confirmation password must be the same! Try Again!");
                    con.Close();
                }
                else
                {
                    SqlCommand cmd3 = new SqlCommand($"Update AccountDetails Set password = '{txtBoxConfirmPassw.Text}' Where username = '{username}';", con);
                    cmd3.ExecuteScalar();
                    MessageBox.Show("Password changed successfully!");
                    con.Close();
                    ViewDetails view1 = new ViewDetails(username);
                    showForm(view1);
                }
            }
            else if (txtBoxUsername.Text != "" && txtBoxEmail.Text != "" && txtBoxCurrentPassw.Text == "" && txtBoxNewPassw.Text == "" && txtBoxConfirmPassw.Text == "")
            {
                SqlCommand cmd = new SqlCommand($"Update AccountDetails Set username='{txtBoxUsername.Text}', email='{txtBoxEmail.Text}' Where username='{username}';", con);
                cmd.ExecuteScalar();
                con.Close();
                MessageBox.Show("Username and Email change successfully!");
                username = txtBoxUsername.Text;
                ViewDetails view2 = new ViewDetails(username);
                showForm(view2);
            }
            else if (txtBoxUsername.Text != "")
            {
                SqlCommand cmd1 = new SqlCommand($"Update AccountDetails Set username='{txtBoxUsername.Text}' Where username='{username}';", con);
                cmd1.ExecuteScalar();
                MessageBox.Show("Username changed successfully!");
                con.Close();
                username = txtBoxUsername.Text;
                ViewDetails view4 = new ViewDetails(username);
                showForm(view4);
            }
            else if (txtBoxEmail.Text != "")
            {
                SqlCommand cmd2 = new SqlCommand($"Update AccountDetails Set email='{txtBoxEmail.Text}' Where username='{username}';", con);
                cmd2.ExecuteScalar();
                MessageBox.Show("Email changed successfully!");
                con.Close();
                ViewDetails view3 = new ViewDetails(username);
                showForm(view3);
            }
        }
    }
}
