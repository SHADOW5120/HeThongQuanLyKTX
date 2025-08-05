using System.Windows.Forms;
using System;

namespace HeThongQuanLyKTX
{
    partial class TestOtp : Form
    {
       

        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtOtp = new System.Windows.Forms.TextBox();
            this.btnSendOtp = new System.Windows.Forms.Button();
            this.btnVerifyOtp = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblOtp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 24);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // txtOtp
            // 
            this.txtOtp.Location = new System.Drawing.Point(112, 65);
            this.txtOtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOtp.Name = "txtOtp";
            this.txtOtp.Size = new System.Drawing.Size(151, 20);
            this.txtOtp.TabIndex = 1;
            // 
            // btnSendOtp
            // 
            this.btnSendOtp.Location = new System.Drawing.Point(112, 98);
            this.btnSendOtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendOtp.Name = "btnSendOtp";
            this.btnSendOtp.Size = new System.Drawing.Size(75, 24);
            this.btnSendOtp.TabIndex = 2;
            this.btnSendOtp.Text = "Send OTP";
            this.btnSendOtp.UseVisualStyleBackColor = true;
            this.btnSendOtp.Click += new System.EventHandler(this.btnSendOtp_Click);
            // 
            // btnVerifyOtp
            // 
            this.btnVerifyOtp.Location = new System.Drawing.Point(195, 98);
            this.btnVerifyOtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerifyOtp.Name = "btnVerifyOtp";
            this.btnVerifyOtp.Size = new System.Drawing.Size(75, 24);
            this.btnVerifyOtp.TabIndex = 3;
            this.btnVerifyOtp.Text = "Verify OTP";
            this.btnVerifyOtp.UseVisualStyleBackColor = true;
            this.btnVerifyOtp.Click += new System.EventHandler(this.btnVerifyOtp_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(38, 24);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblOtp
            // 
            this.lblOtp.AutoSize = true;
            this.lblOtp.Location = new System.Drawing.Point(38, 65);
            this.lblOtp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOtp.Name = "lblOtp";
            this.lblOtp.Size = new System.Drawing.Size(32, 13);
            this.lblOtp.TabIndex = 5;
            this.lblOtp.Text = "OTP:";
            // 
            // TestOtp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 162);
            this.Controls.Add(this.lblOtp);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnVerifyOtp);
            this.Controls.Add(this.btnSendOtp);
            this.Controls.Add(this.txtOtp);
            this.Controls.Add(this.txtEmail);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TestOtp";
            this.Text = "Reset Password via OTP";
            this.Load += new System.EventHandler(this.TestOtp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private TextBox txtEmail;
        private TextBox txtOtp;
        private Button btnSendOtp;
        private Button btnVerifyOtp;
        private Label lblEmail;
        private Label lblOtp;

    }
}