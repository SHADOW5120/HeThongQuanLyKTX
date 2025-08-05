namespace HeThongQuanLyKTX
{
    partial class FormQuenMatKhau
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.txtOTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVerify = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(330, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Nhập email của bạn";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(400, 50);
            this.txtEmail.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelTitle.Location = new System.Drawing.Point(419, 68);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(219, 30);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Khôi phục mật khẩu";
            // 
            // btnSend
            // 
            this.btnSend.BorderRadius = 15;
            this.btnSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(450, 210);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(150, 45);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Gửi mã OTP";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelInstruction.ForeColor = System.Drawing.Color.Gray;
            this.labelInstruction.Location = new System.Drawing.Point(330, 270);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(269, 19);
            this.labelInstruction.TabIndex = 5;
            this.labelInstruction.Text = "Nhập mã OTP được gửi đến email của bạn.";
            // 
            // txtOTP
            // 
            this.txtOTP.BorderRadius = 15;
            this.txtOTP.BorderThickness = 2;
            this.txtOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOTP.DefaultText = "";
            this.txtOTP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOTP.Location = new System.Drawing.Point(330, 310);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.PasswordChar = '\0';
            this.txtOTP.PlaceholderText = "Nhập mã OTP";
            this.txtOTP.SelectedText = "";
            this.txtOTP.Size = new System.Drawing.Size(400, 50);
            this.txtOTP.TabIndex = 2;
            // 
            // btnVerify
            // 
            this.btnVerify.BorderRadius = 15;
            this.btnVerify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(330, 390);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(180, 45);
            this.btnVerify.TabIndex = 3;
            this.btnVerify.Text = "Xác nhận OTP";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(550, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormQuenMatKhau
            // 
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.txtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormQuenMatKhau";
            this.Text = "Khôi phục mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private System.Windows.Forms.Label labelInstruction;
        private Guna.UI2.WinForms.Guna2TextBox txtOTP;
        private Guna.UI2.WinForms.Guna2Button btnVerify;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}
