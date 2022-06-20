
namespace Laptop_Repair_Services_Management_System
{
    partial class DisplayNotification
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
            this.pnlAttachForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.lblTitleNotiName = new System.Windows.Forms.Label();
            this.lblNotiDescrip = new System.Windows.Forms.RichTextBox();
            this.pnlAttachForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAttachForm
            // 
            this.pnlAttachForm.BackColor = System.Drawing.Color.White;
            this.pnlAttachForm.Controls.Add(this.pictureBox1);
            this.pnlAttachForm.Controls.Add(this.btnBack);
            this.pnlAttachForm.Controls.Add(this.groupBox1);
            this.pnlAttachForm.Controls.Add(this.btnView);
            this.pnlAttachForm.Controls.Add(this.lblTitleNotiName);
            this.pnlAttachForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAttachForm.Location = new System.Drawing.Point(0, 0);
            this.pnlAttachForm.Name = "pnlAttachForm";
            this.pnlAttachForm.Size = new System.Drawing.Size(660, 450);
            this.pnlAttachForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laptop_Repair_Services_Management_System.Properties.Resources.bell;
            this.pictureBox1.Location = new System.Drawing.Point(311, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 24);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "< Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblNotiDescrip);
            this.groupBox1.Location = new System.Drawing.Point(41, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 241);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Image = global::Laptop_Repair_Services_Management_System.Properties.Resources.right_arrow;
            this.btnView.Location = new System.Drawing.Point(551, 388);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(67, 38);
            this.btnView.TabIndex = 12;
            this.btnView.Text = " ";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // lblTitleNotiName
            // 
            this.lblTitleNotiName.AutoSize = true;
            this.lblTitleNotiName.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleNotiName.Location = new System.Drawing.Point(237, 66);
            this.lblTitleNotiName.Name = "lblTitleNotiName";
            this.lblTitleNotiName.Size = new System.Drawing.Size(198, 35);
            this.lblTitleNotiName.TabIndex = 11;
            this.lblTitleNotiName.Text = "Service Booked";
            this.lblTitleNotiName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNotiDescrip
            // 
            this.lblNotiDescrip.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotiDescrip.Location = new System.Drawing.Point(6, 11);
            this.lblNotiDescrip.Name = "lblNotiDescrip";
            this.lblNotiDescrip.Size = new System.Drawing.Size(565, 224);
            this.lblNotiDescrip.TabIndex = 9;
            this.lblNotiDescrip.Text = "";
            // 
            // DisplayNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.pnlAttachForm);
            this.Name = "DisplayNotification";
            this.Text = "DisplayNotification";
            this.pnlAttachForm.ResumeLayout(false);
            this.pnlAttachForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAttachForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblTitleNotiName;
        private System.Windows.Forms.RichTextBox lblNotiDescrip;
    }
}