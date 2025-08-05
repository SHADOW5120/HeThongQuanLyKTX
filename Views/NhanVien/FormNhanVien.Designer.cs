using System.Drawing;
using System.Windows.Forms;
using System;

namespace HeThongQuanLyKTX.Views
{
    partial class FormNhanVien
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
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.dtpBirthDate);
            this.panelInfo.Controls.Add(this.lblEmployeeName);
            this.panelInfo.Controls.Add(this.txtEmployeeName);
            this.panelInfo.Controls.Add(this.lblEmail);
            this.panelInfo.Controls.Add(this.txtEmail);
            this.panelInfo.Controls.Add(this.lblPhone);
            this.panelInfo.Controls.Add(this.txtPhone);
            this.panelInfo.Controls.Add(this.lblAddress);
            this.panelInfo.Controls.Add(this.txtAddress);
            this.panelInfo.Controls.Add(this.lblDOB);
            this.panelInfo.Controls.Add(this.lblGender);
            this.panelInfo.Controls.Add(this.cboGender);
            this.panelInfo.Controls.Add(this.btnEdit);
            this.panelInfo.Controls.Add(this.btnChangePassword);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(30);
            this.panelInfo.Size = new System.Drawing.Size(1064, 720);
            this.panelInfo.TabIndex = 1;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeName.Location = new System.Drawing.Point(83, 110);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(100, 23);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Họ và tên:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtEmployeeName.Font = new System.Drawing.Font("Arial", 14F);
            this.txtEmployeeName.Location = new System.Drawing.Point(233, 110);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(350, 29);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Arial", 14F);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(83, 180);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtEmail.Font = new System.Drawing.Font("Arial", 14F);
            this.txtEmail.Location = new System.Drawing.Point(233, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(350, 29);
            this.txtEmail.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Arial", 14F);
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(83, 250);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 23);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtPhone.Font = new System.Drawing.Font("Arial", 14F);
            this.txtPhone.Location = new System.Drawing.Point(233, 250);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(350, 29);
            this.txtPhone.TabIndex = 5;
            // 
            // lblDOB
            // 
            this.lblDOB.Font = new System.Drawing.Font("Arial", 14F);
            this.lblDOB.ForeColor = System.Drawing.Color.Black;
            this.lblDOB.Location = new System.Drawing.Point(83, 390);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(100, 23);
            this.lblDOB.TabIndex = 8;
            this.lblDOB.Text = "Ngày sinh:";
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Arial", 14F);
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(83, 460);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(100, 23);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Giới tính:";
            // 
            // cboGender
            // 
            this.cboGender.Enabled = false;
            this.cboGender.Font = new System.Drawing.Font("Arial", 14F);
            this.cboGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboGender.Location = new System.Drawing.Point(233, 460);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(350, 30);
            this.cboGender.TabIndex = 11;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(7)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 14F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(233, 530);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 45);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Chỉnh sửa thông tin";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Arial", 14F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(453, 530);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(200, 45);
            this.btnChangePassword.TabIndex = 13;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(7)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(1064, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thông tin nhân viên";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Arial", 14F);
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(83, 320);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtAddress.Font = new System.Drawing.Font("Arial", 14F);
            this.txtAddress.Location = new System.Drawing.Point(233, 320);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(350, 29);
            this.txtAddress.TabIndex = 7;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Checked = true;
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBirthDate.Location = new System.Drawing.Point(233, 390);
            this.dtpBirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(350, 36);
            this.dtpBirthDate.TabIndex = 14;
            this.dtpBirthDate.Value = new System.DateTime(2024, 12, 24, 0, 0, 0, 0);
            // 
            // FormNhanVien
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1064, 720);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelInfo);
            this.Name = "FormNhanVien";
            this.Text = "Thông tin nhân viên";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelInfo;
        private Label lblEmployeeName;
        private TextBox txtEmployeeName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblDOB;
        private Label lblGender;
        private ComboBox cboGender;
        private Button btnEdit;
        private Button btnChangePassword;
        private Label lblTitle;
        private Label lblAddress;
        private TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthDate;
    }
}
