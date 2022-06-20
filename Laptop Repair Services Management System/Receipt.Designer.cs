namespace Laptop_Repair_Services_Management_System
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.panelAttachReceipt = new System.Windows.Forms.Panel();
            this.lblReceiptList = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAttachReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAttachReceipt
            // 
            this.panelAttachReceipt.Controls.Add(this.lblReceiptList);
            this.panelAttachReceipt.Controls.Add(this.pictureBox1);
            this.panelAttachReceipt.Controls.Add(this.label1);
            this.panelAttachReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAttachReceipt.Location = new System.Drawing.Point(0, 0);
            this.panelAttachReceipt.Name = "panelAttachReceipt";
            this.panelAttachReceipt.Size = new System.Drawing.Size(374, 576);
            this.panelAttachReceipt.TabIndex = 0;
            // 
            // lblReceiptList
            // 
            this.lblReceiptList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceiptList.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptList.Location = new System.Drawing.Point(52, 153);
            this.lblReceiptList.Name = "lblReceiptList";
            this.lblReceiptList.Size = new System.Drawing.Size(271, 338);
            this.lblReceiptList.TabIndex = 5;
            this.lblReceiptList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laptop_Repair_Services_Management_System.Properties.Resources.laptopia_white_bg;
            this.pictureBox1.Location = new System.Drawing.Point(127, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thank you \r\nsee you again next time!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 576);
            this.Controls.Add(this.panelAttachReceipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.panelAttachReceipt.ResumeLayout(false);
            this.panelAttachReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAttachReceipt;
        private System.Windows.Forms.Label lblReceiptList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}