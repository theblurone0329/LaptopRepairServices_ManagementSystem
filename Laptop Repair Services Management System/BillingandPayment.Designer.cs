
namespace Laptop_Repair_Services_Management_System
{
    partial class BillingandPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingandPayment));
            this.lblTitleBookingEnquiries = new System.Windows.Forms.Label();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radOnlineBanking = new System.Windows.Forms.RadioButton();
            this.lblDisplayTotalAmountPay = new System.Windows.Forms.Label();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.lblTitleTotalPay = new System.Windows.Forms.Label();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.btnCancelPayment = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.grpBillandReceipt = new System.Windows.Forms.GroupBox();
            this.lblReceiptID = new System.Windows.Forms.Label();
            this.lstCustomerBill = new System.Windows.Forms.ListBox();
            this.lblDisplayCustomerName = new System.Windows.Forms.Label();
            this.txtEnterCustomerID = new System.Windows.Forms.TextBox();
            this.lblTitleCustomerID = new System.Windows.Forms.Label();
            this.pnlAttach2 = new System.Windows.Forms.Panel();
            this.grpBillandReceipt.SuspendLayout();
            this.pnlAttach2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleBookingEnquiries
            // 
            this.lblTitleBookingEnquiries.AutoSize = true;
            this.lblTitleBookingEnquiries.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleBookingEnquiries.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitleBookingEnquiries.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBookingEnquiries.ForeColor = System.Drawing.Color.Black;
            this.lblTitleBookingEnquiries.Location = new System.Drawing.Point(12, 9);
            this.lblTitleBookingEnquiries.Name = "lblTitleBookingEnquiries";
            this.lblTitleBookingEnquiries.Size = new System.Drawing.Size(218, 24);
            this.lblTitleBookingEnquiries.TabIndex = 1;
            this.lblTitleBookingEnquiries.Text = "BILLING AND PAYMENT";
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCash.Location = new System.Drawing.Point(310, 234);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(51, 22);
            this.radCash.TabIndex = 34;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // radOnlineBanking
            // 
            this.radOnlineBanking.AutoSize = true;
            this.radOnlineBanking.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOnlineBanking.Location = new System.Drawing.Point(310, 206);
            this.radOnlineBanking.Name = "radOnlineBanking";
            this.radOnlineBanking.Size = new System.Drawing.Size(111, 22);
            this.radOnlineBanking.TabIndex = 33;
            this.radOnlineBanking.TabStop = true;
            this.radOnlineBanking.Text = "Online Banking";
            this.radOnlineBanking.UseVisualStyleBackColor = true;
            // 
            // lblDisplayTotalAmountPay
            // 
            this.lblDisplayTotalAmountPay.AutoSize = true;
            this.lblDisplayTotalAmountPay.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTotalAmountPay.Location = new System.Drawing.Point(442, 154);
            this.lblDisplayTotalAmountPay.Name = "lblDisplayTotalAmountPay";
            this.lblDisplayTotalAmountPay.Size = new System.Drawing.Size(32, 22);
            this.lblDisplayTotalAmountPay.TabIndex = 21;
            this.lblDisplayTotalAmountPay.Text = "RM";
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(56)))));
            this.btnFindCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindCustomer.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCustomer.Location = new System.Drawing.Point(506, 64);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(31, 21);
            this.btnFindCustomer.TabIndex = 31;
            this.btnFindCustomer.Text = "OK";
            this.btnFindCustomer.UseVisualStyleBackColor = false;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // lblTitleTotalPay
            // 
            this.lblTitleTotalPay.AutoSize = true;
            this.lblTitleTotalPay.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTotalPay.Location = new System.Drawing.Point(304, 154);
            this.lblTitleTotalPay.Name = "lblTitleTotalPay";
            this.lblTitleTotalPay.Size = new System.Drawing.Size(132, 22);
            this.lblTitleTotalPay.TabIndex = 20;
            this.lblTitleTotalPay.Text = "TOTAL PAYMENT";
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btnConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPayment.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Location = new System.Drawing.Point(391, 386);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(126, 34);
            this.btnConfirmPayment.TabIndex = 30;
            this.btnConfirmPayment.Text = "CONFIRM PAYMENT";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            // 
            // btnCancelPayment
            // 
            this.btnCancelPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(80)))), ((int)(((byte)(66)))));
            this.btnCancelPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPayment.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPayment.ForeColor = System.Drawing.Color.White;
            this.btnCancelPayment.Location = new System.Drawing.Point(302, 386);
            this.btnCancelPayment.Name = "btnCancelPayment";
            this.btnCancelPayment.Size = new System.Drawing.Size(74, 34);
            this.btnCancelPayment.TabIndex = 29;
            this.btnCancelPayment.Text = "CANCEL";
            this.btnCancelPayment.UseVisualStyleBackColor = false;
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(79)))), ((int)(((byte)(243)))));
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.Color.White;
            this.btnReceipt.Location = new System.Drawing.Point(535, 386);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(67, 34);
            this.btnReceipt.TabIndex = 27;
            this.btnReceipt.Text = "RECEIPT";
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // grpBillandReceipt
            // 
            this.grpBillandReceipt.BackColor = System.Drawing.SystemColors.Control;
            this.grpBillandReceipt.Controls.Add(this.lblReceiptID);
            this.grpBillandReceipt.Controls.Add(this.lstCustomerBill);
            this.grpBillandReceipt.Location = new System.Drawing.Point(17, 62);
            this.grpBillandReceipt.Name = "grpBillandReceipt";
            this.grpBillandReceipt.Size = new System.Drawing.Size(268, 358);
            this.grpBillandReceipt.TabIndex = 26;
            this.grpBillandReceipt.TabStop = false;
            // 
            // lblReceiptID
            // 
            this.lblReceiptID.AutoSize = true;
            this.lblReceiptID.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptID.Location = new System.Drawing.Point(6, 16);
            this.lblReceiptID.Name = "lblReceiptID";
            this.lblReceiptID.Size = new System.Drawing.Size(112, 18);
            this.lblReceiptID.TabIndex = 1;
            this.lblReceiptID.Text = "display RECEIPT ID";
            // 
            // lstCustomerBill
            // 
            this.lstCustomerBill.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomerBill.FormattingEnabled = true;
            this.lstCustomerBill.ItemHeight = 16;
            this.lstCustomerBill.Location = new System.Drawing.Point(19, 37);
            this.lstCustomerBill.Name = "lstCustomerBill";
            this.lstCustomerBill.Size = new System.Drawing.Size(229, 308);
            this.lstCustomerBill.TabIndex = 0;
            // 
            // lblDisplayCustomerName
            // 
            this.lblDisplayCustomerName.AutoSize = true;
            this.lblDisplayCustomerName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayCustomerName.Location = new System.Drawing.Point(307, 86);
            this.lblDisplayCustomerName.Name = "lblDisplayCustomerName";
            this.lblDisplayCustomerName.Size = new System.Drawing.Size(117, 18);
            this.lblDisplayCustomerName.TabIndex = 25;
            this.lblDisplayCustomerName.Text = "Display Username";
            // 
            // txtEnterCustomerID
            // 
            this.txtEnterCustomerID.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterCustomerID.Location = new System.Drawing.Point(400, 62);
            this.txtEnterCustomerID.Name = "txtEnterCustomerID";
            this.txtEnterCustomerID.Size = new System.Drawing.Size(100, 21);
            this.txtEnterCustomerID.TabIndex = 24;
            // 
            // lblTitleCustomerID
            // 
            this.lblTitleCustomerID.AutoSize = true;
            this.lblTitleCustomerID.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCustomerID.Location = new System.Drawing.Point(304, 62);
            this.lblTitleCustomerID.Name = "lblTitleCustomerID";
            this.lblTitleCustomerID.Size = new System.Drawing.Size(100, 18);
            this.lblTitleCustomerID.TabIndex = 23;
            this.lblTitleCustomerID.Text = "Customer\'s ID: ";
            // 
            // pnlAttach2
            // 
            this.pnlAttach2.AutoScroll = true;
            this.pnlAttach2.BackColor = System.Drawing.Color.White;
            this.pnlAttach2.Controls.Add(this.lblTitleBookingEnquiries);
            this.pnlAttach2.Controls.Add(this.radCash);
            this.pnlAttach2.Controls.Add(this.radOnlineBanking);
            this.pnlAttach2.Controls.Add(this.lblDisplayTotalAmountPay);
            this.pnlAttach2.Controls.Add(this.btnFindCustomer);
            this.pnlAttach2.Controls.Add(this.lblTitleTotalPay);
            this.pnlAttach2.Controls.Add(this.btnConfirmPayment);
            this.pnlAttach2.Controls.Add(this.btnCancelPayment);
            this.pnlAttach2.Controls.Add(this.btnReceipt);
            this.pnlAttach2.Controls.Add(this.grpBillandReceipt);
            this.pnlAttach2.Controls.Add(this.lblDisplayCustomerName);
            this.pnlAttach2.Controls.Add(this.txtEnterCustomerID);
            this.pnlAttach2.Controls.Add(this.lblTitleCustomerID);
            this.pnlAttach2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAttach2.Location = new System.Drawing.Point(0, 0);
            this.pnlAttach2.Name = "pnlAttach2";
            this.pnlAttach2.Size = new System.Drawing.Size(631, 432);
            this.pnlAttach2.TabIndex = 1;
            // 
            // BillingandPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 432);
            this.Controls.Add(this.pnlAttach2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillingandPayment";
            this.Text = "Billing and Payment";
            this.grpBillandReceipt.ResumeLayout(false);
            this.grpBillandReceipt.PerformLayout();
            this.pnlAttach2.ResumeLayout(false);
            this.pnlAttach2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleBookingEnquiries;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.RadioButton radOnlineBanking;
        private System.Windows.Forms.Label lblDisplayTotalAmountPay;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.Label lblTitleTotalPay;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Button btnCancelPayment;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.GroupBox grpBillandReceipt;
        private System.Windows.Forms.Label lblReceiptID;
        private System.Windows.Forms.ListBox lstCustomerBill;
        private System.Windows.Forms.Label lblDisplayCustomerName;
        private System.Windows.Forms.TextBox txtEnterCustomerID;
        private System.Windows.Forms.Label lblTitleCustomerID;
        private System.Windows.Forms.Panel pnlAttach2;
    }
}