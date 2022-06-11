
namespace Laptop_Repair_Services_Management_System
{
    partial class ServiceOverviewTech
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
            this.btnSubmitChanges = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.servProg = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTitleServName = new System.Windows.Forms.Label();
            this.pnlAttachForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAttachForm
            // 
            this.pnlAttachForm.BackColor = System.Drawing.Color.White;
            this.pnlAttachForm.Controls.Add(this.btnSubmitChanges);
            this.pnlAttachForm.Controls.Add(this.btnBack);
            this.pnlAttachForm.Controls.Add(this.btnComplete);
            this.pnlAttachForm.Controls.Add(this.checkedListBox1);
            this.pnlAttachForm.Controls.Add(this.lblStatus);
            this.pnlAttachForm.Controls.Add(this.groupBox1);
            this.pnlAttachForm.Controls.Add(this.servProg);
            this.pnlAttachForm.Controls.Add(this.progressBar1);
            this.pnlAttachForm.Controls.Add(this.lblTitleServName);
            this.pnlAttachForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAttachForm.Location = new System.Drawing.Point(0, 0);
            this.pnlAttachForm.Name = "pnlAttachForm";
            this.pnlAttachForm.Size = new System.Drawing.Size(631, 438);
            this.pnlAttachForm.TabIndex = 1;
            // 
            // btnSubmitChanges
            // 
            this.btnSubmitChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(56)))));
            this.btnSubmitChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitChanges.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitChanges.Location = new System.Drawing.Point(518, 134);
            this.btnSubmitChanges.Name = "btnSubmitChanges";
            this.btnSubmitChanges.Size = new System.Drawing.Size(72, 32);
            this.btnSubmitChanges.TabIndex = 25;
            this.btnSubmitChanges.Text = "Submit";
            this.btnSubmitChanges.UseVisualStyleBackColor = false;
            this.btnSubmitChanges.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 24);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "< Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(56)))));
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(221, 396);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(187, 32);
            this.btnComplete.TabIndex = 23;
            this.btnComplete.Text = "Submit Changes";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Silver;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Identified Problem",
            "Found Solution",
            "Begun Work",
            "Finished Work",
            "Testing"});
            this.checkedListBox1.Location = new System.Drawing.Point(357, 102);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(243, 89);
            this.checkedListBox1.TabIndex = 22;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(118, 102);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(139, 24);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "75% Complete";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 193);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report from Technician: ";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(24, 36);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(470, 142);
            this.txtComment.TabIndex = 0;
            // 
            // servProg
            // 
            this.servProg.AutoSize = true;
            this.servProg.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servProg.Location = new System.Drawing.Point(50, 102);
            this.servProg.Name = "servProg";
            this.servProg.Size = new System.Drawing.Size(72, 24);
            this.servProg.TabIndex = 19;
            this.servProg.Text = "Status: ";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar1.Location = new System.Drawing.Point(53, 136);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 30);
            this.progressBar1.TabIndex = 18;
            this.progressBar1.Value = 75;
            // 
            // lblTitleServName
            // 
            this.lblTitleServName.AutoSize = true;
            this.lblTitleServName.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleServName.Location = new System.Drawing.Point(46, 51);
            this.lblTitleServName.Name = "lblTitleServName";
            this.lblTitleServName.Size = new System.Drawing.Size(221, 37);
            this.lblTitleServName.TabIndex = 17;
            this.lblTitleServName.Text = "SERVICE NAME";
            // 
            // ServiceOverviewTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 438);
            this.Controls.Add(this.pnlAttachForm);
            this.Name = "ServiceOverviewTech";
            this.Text = "ServiceOverviewTech";
            this.pnlAttachForm.ResumeLayout(false);
            this.pnlAttachForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAttachForm;
        private System.Windows.Forms.Label btnBack;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label servProg;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTitleServName;
        private System.Windows.Forms.Button btnSubmitChanges;
    }
}