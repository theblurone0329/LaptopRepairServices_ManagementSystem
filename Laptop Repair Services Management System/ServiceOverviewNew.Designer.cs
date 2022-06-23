
namespace Laptop_Repair_Services_Management_System
{
    partial class ServiceOverviewNew
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Label();
            this.lblProgressPercent = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtComments = new System.Windows.Forms.RichTextBox();
            this.lblservProg = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTitleServName = new System.Windows.Forms.Label();
            this.pnlAttachForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAttachForm
            // 
            this.pnlAttachForm.BackColor = System.Drawing.Color.White;
            this.pnlAttachForm.Controls.Add(this.lblPrice);
            this.pnlAttachForm.Controls.Add(this.label1);
            this.pnlAttachForm.Controls.Add(this.btnBack);
            this.pnlAttachForm.Controls.Add(this.lblProgressPercent);
            this.pnlAttachForm.Controls.Add(this.groupBox1);
            this.pnlAttachForm.Controls.Add(this.lblservProg);
            this.pnlAttachForm.Controls.Add(this.progressBar1);
            this.pnlAttachForm.Controls.Add(this.lblTitleServName);
            this.pnlAttachForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAttachForm.Location = new System.Drawing.Point(0, 0);
            this.pnlAttachForm.Name = "pnlAttachForm";
            this.pnlAttachForm.Size = new System.Drawing.Size(631, 432);
            this.pnlAttachForm.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(443, 114);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 24);
            this.lblPrice.TabIndex = 27;
            this.lblPrice.Text = "RM ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Price: ";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(14, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 24);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "< Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblProgressPercent
            // 
            this.lblProgressPercent.AutoSize = true;
            this.lblProgressPercent.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressPercent.Location = new System.Drawing.Point(118, 114);
            this.lblProgressPercent.Name = "lblProgressPercent";
            this.lblProgressPercent.Size = new System.Drawing.Size(139, 24);
            this.lblProgressPercent.TabIndex = 24;
            this.lblProgressPercent.Text = "75% Complete";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtComments);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 207);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report from Technician: ";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(22, 29);
            this.txtComments.Name = "txtComments";
            this.txtComments.ReadOnly = true;
            this.txtComments.Size = new System.Drawing.Size(487, 172);
            this.txtComments.TabIndex = 0;
            this.txtComments.Text = "";
            // 
            // lblservProg
            // 
            this.lblservProg.AutoSize = true;
            this.lblservProg.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservProg.Location = new System.Drawing.Point(49, 114);
            this.lblservProg.Name = "lblservProg";
            this.lblservProg.Size = new System.Drawing.Size(72, 24);
            this.lblservProg.TabIndex = 22;
            this.lblservProg.Text = "Status: ";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar1.Location = new System.Drawing.Point(52, 153);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(321, 30);
            this.progressBar1.TabIndex = 21;
            this.progressBar1.Value = 75;
            // 
            // lblTitleServName
            // 
            this.lblTitleServName.AutoSize = true;
            this.lblTitleServName.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleServName.Location = new System.Drawing.Point(46, 61);
            this.lblTitleServName.Name = "lblTitleServName";
            this.lblTitleServName.Size = new System.Drawing.Size(202, 34);
            this.lblTitleServName.TabIndex = 20;
            this.lblTitleServName.Text = "SERVICE NAME";
            // 
            // ServiceOverviewNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 432);
            this.Controls.Add(this.pnlAttachForm);
            this.Name = "ServiceOverviewNew";
            this.Text = "ServiceOverviewNew";
            this.pnlAttachForm.ResumeLayout(false);
            this.pnlAttachForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAttachForm;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnBack;
        private System.Windows.Forms.Label lblProgressPercent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtComments;
        private System.Windows.Forms.Label lblservProg;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTitleServName;
    }
}