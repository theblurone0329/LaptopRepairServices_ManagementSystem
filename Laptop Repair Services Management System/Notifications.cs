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
    public partial class Notifications : Form
    {
        public static string n;
        string username;
        string notiNameBring1;
        string notiNameBring2;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        public Notifications(string n, string notiNameBack)
        {
            InitializeComponent();
            pnlAttachNoti1.Hide();
            pnlAttachNoti2.Hide();
            lblNoNoti.Hide();
            con.Open();
            //To delete notification when it returns from ViewNotification Page
            if (notiNameBack != "")
            {
                SqlCommand getTempUID = new SqlCommand($"Select userID From AccountDetails Where username='{n}';", con);
                string tempUID = getTempUID.ExecuteScalar().ToString();
                //this line got problem, solving it soon
                SqlCommand delNotiNameBack = new SqlCommand($"Delete Top(1) From Notifications Where userID='{tempUID}' AND notiName='{notiNameBack}';", con);
                delNotiNameBack.ExecuteScalar();
            }
            //To display the notifications
            SqlCommand cmd = new SqlCommand($"Select userID From AccountDetails Where username='{n}';", con);
            int userID = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            SqlCommand cmd1 = new SqlCommand($"Select count(*) From Notifications Where userID='{userID}';", con);
            int count = Convert.ToInt32(cmd1.ExecuteScalar().ToString());

            //To check whether there are 1, 2, or 3 notifications
            if (count > 2)
            {
                SqlCommand cmd2 = new SqlCommand($"Select Top(1) notiName From Notifications Where userID='{userID}';", con);
                string notiName = cmd2.ExecuteScalar().ToString();
                lblNotiName1.Text = notiName;
                notiNameBring1 = notiName;
                pnlAttachNoti1.Show();

                SqlCommand cmd3 = new SqlCommand($"Select Top(2) Max(notiName) From Notifications Where userID = '{userID}';", con);
                string notiName2 = cmd3.ExecuteScalar().ToString();
                lblNotiName2.Text = notiName2;
                notiNameBring2 = notiName2;
                pnlAttachNoti2.Show();

            }
            else if (count == 2)
            {
                SqlCommand cmd2 = new SqlCommand($"Select Top(1) notiName From Notifications Where userID='{userID}';", con);
                string notiName = cmd2.ExecuteScalar().ToString();
                lblNotiName1.Text = notiName;
                notiNameBring1 = notiName;
                pnlAttachNoti1.Show();

                SqlCommand cmd3 = new SqlCommand($"Select Top(2) Max(notiName) From Notifications Where userID = '{userID}';", con);
                string notiName2 = cmd3.ExecuteScalar().ToString();
                lblNotiName2.Text = notiName2;
                notiNameBring2 = notiName2;
                pnlAttachNoti2.Show();

            }
            else if (count == 1)
            {
                SqlCommand cmd2 = new SqlCommand($"Select Top(1) notiName From Notifications Where userID='{userID}';", con);
                string notiName = cmd2.ExecuteScalar().ToString();
                lblNotiName1.Text = notiName;
                notiNameBring1 = notiName;
                pnlAttachNoti1.Show();

                pnlAttachNoti2.Hide();
            }
            else if (count == 0)
            {
                pnlAttachAllNoti.Hide();
                lblNoNoti.Show();
            }
            con.Close();
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
            // Dimensions = 647, 461
            pnlAttachForm.Controls.Add(childForm);
            pnlAttachForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnView1_Click(object sender, EventArgs e)
        {
            DisplayNotification viewNoti = new DisplayNotification(username, notiNameBring1);
            showForm(viewNoti);
        }

        private void btnView2_Click_1(object sender, EventArgs e)
        {
            DisplayNotification viewNoti = new DisplayNotification(username, notiNameBring2);
            showForm(viewNoti);
        }
    }
}
