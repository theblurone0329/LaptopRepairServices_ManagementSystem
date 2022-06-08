
namespace Laptop_Repair_Services_Management_System
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.txtEnterPasswordLogin = new System.Windows.Forms.TextBox();
            this.txtEnterUserIDLogin = new System.Windows.Forms.TextBox();
            this.lblTitlePassword = new System.Windows.Forms.Label();
            this.lblTitleUserID = new System.Windows.Forms.Label();
            this.picLoginCompanyLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginCompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(79)))), ((int)(((byte)(243)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(148, 340);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 26);
            this.btnLogin.TabIndex = 24;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPassword.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPassword.Location = new System.Drawing.Point(201, 287);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(108, 23);
            this.btnForgotPassword.TabIndex = 23;
            this.btnForgotPassword.Text = "forgot password ?";
            this.btnForgotPassword.UseVisualStyleBackColor = false;
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // txtEnterPasswordLogin
            // 
            this.txtEnterPasswordLogin.Location = new System.Drawing.Point(124, 261);
            this.txtEnterPasswordLogin.Name = "txtEnterPasswordLogin";
            this.txtEnterPasswordLogin.Size = new System.Drawing.Size(185, 20);
            this.txtEnterPasswordLogin.TabIndex = 22;
            // 
            // txtEnterUserIDLogin
            // 
            this.txtEnterUserIDLogin.Location = new System.Drawing.Point(124, 220);
            this.txtEnterUserIDLogin.Name = "txtEnterUserIDLogin";
            this.txtEnterUserIDLogin.Size = new System.Drawing.Size(185, 20);
            this.txtEnterUserIDLogin.TabIndex = 21;
            // 
            // lblTitlePassword
            // 
            this.lblTitlePassword.AutoSize = true;
            this.lblTitlePassword.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePassword.Location = new System.Drawing.Point(50, 261);
            this.lblTitlePassword.Name = "lblTitlePassword";
            this.lblTitlePassword.Size = new System.Drawing.Size(68, 18);
            this.lblTitlePassword.TabIndex = 20;
            this.lblTitlePassword.Text = "PASSWORD";
            // 
            // lblTitleUserID
            // 
            this.lblTitleUserID.AutoSize = true;
            this.lblTitleUserID.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleUserID.Location = new System.Drawing.Point(50, 220);
            this.lblTitleUserID.Name = "lblTitleUserID";
            this.lblTitleUserID.Size = new System.Drawing.Size(51, 18);
            this.lblTitleUserID.TabIndex = 19;
            this.lblTitleUserID.Text = "USER ID";
            // 
            // picLoginCompanyLogo
            // 
            this.picLoginCompanyLogo.Image = global::Laptop_Repair_Services_Management_System.Properties.Resources.LaptopiaFinallogo1;
            this.picLoginCompanyLogo.Location = new System.Drawing.Point(106, 23);
            this.picLoginCompanyLogo.Name = "picLoginCompanyLogo";
            this.picLoginCompanyLogo.Size = new System.Drawing.Size(170, 158);
            this.picLoginCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoginCompanyLogo.TabIndex = 18;
            this.picLoginCompanyLogo.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 473);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.txtEnterPasswordLogin);
            this.Controls.Add(this.txtEnterUserIDLogin);
            this.Controls.Add(this.lblTitlePassword);
            this.Controls.Add(this.lblTitleUserID);
            this.Controls.Add(this.picLoginCompanyLogo);
            this.Name = "LoginPage";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picLoginCompanyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.TextBox txtEnterPasswordLogin;
        private System.Windows.Forms.TextBox txtEnterUserIDLogin;
        private System.Windows.Forms.Label lblTitlePassword;
        private System.Windows.Forms.Label lblTitleUserID;
        private System.Windows.Forms.PictureBox picLoginCompanyLogo;
    }
}

