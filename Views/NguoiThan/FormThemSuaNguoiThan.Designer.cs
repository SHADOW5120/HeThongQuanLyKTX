namespace HeThongQuanLyKTX.Views
{
    partial class FormThemSuaNguoiThan
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

        private void InitializeComponent()
        {
            this.txtMaNT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSdtNT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChiNT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.lblMaNT = new System.Windows.Forms.Label();
            this.lblTenNT = new System.Windows.Forms.Label();
            this.lblSdtNT = new System.Windows.Forms.Label();
            this.lblDiaChiNT = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaNT
            // 
            this.txtMaNT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNT.DefaultText = "";
            this.txtMaNT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNT.Location = new System.Drawing.Point(150, 20);
            this.txtMaNT.Name = "txtMaNT";
            this.txtMaNT.PasswordChar = '\0';
            this.txtMaNT.PlaceholderText = "Mã người thân";
            this.txtMaNT.SelectedText = "";
            this.txtMaNT.Size = new System.Drawing.Size(300, 40);
            this.txtMaNT.TabIndex = 0;
            // 
            // txtTenNT
            // 
            this.txtTenNT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNT.DefaultText = "";
            this.txtTenNT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNT.Location = new System.Drawing.Point(150, 70);
            this.txtTenNT.Name = "txtTenNT";
            this.txtTenNT.PasswordChar = '\0';
            this.txtTenNT.PlaceholderText = "Tên người thân";
            this.txtTenNT.SelectedText = "";
            this.txtTenNT.Size = new System.Drawing.Size(300, 40);
            this.txtTenNT.TabIndex = 1;
            // 
            // txtSdtNT
            // 
            this.txtSdtNT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSdtNT.DefaultText = "";
            this.txtSdtNT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSdtNT.Location = new System.Drawing.Point(150, 120);
            this.txtSdtNT.Name = "txtSdtNT";
            this.txtSdtNT.PasswordChar = '\0';
            this.txtSdtNT.PlaceholderText = "Số điện thoại người thân";
            this.txtSdtNT.SelectedText = "";
            this.txtSdtNT.Size = new System.Drawing.Size(300, 40);
            this.txtSdtNT.TabIndex = 2;
            // 
            // txtDiaChiNT
            // 
            this.txtDiaChiNT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChiNT.DefaultText = "";
            this.txtDiaChiNT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChiNT.Location = new System.Drawing.Point(150, 170);
            this.txtDiaChiNT.Name = "txtDiaChiNT";
            this.txtDiaChiNT.PasswordChar = '\0';
            this.txtDiaChiNT.PlaceholderText = "Địa chỉ người thân";
            this.txtDiaChiNT.SelectedText = "";
            this.txtDiaChiNT.Size = new System.Drawing.Size(300, 40);
            this.txtDiaChiNT.TabIndex = 3;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSV.DefaultText = "";
            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaSV.Location = new System.Drawing.Point(150, 220);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.PasswordChar = '\0';
            this.txtMaSV.PlaceholderText = "Mã sinh viên";
            this.txtMaSV.SelectedText = "";
            this.txtMaSV.Size = new System.Drawing.Size(300, 40);
            this.txtMaSV.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(80, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FillColor = System.Drawing.Color.Crimson;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(240, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMaNT
            // 
            this.lblMaNT.AutoSize = true;
            this.lblMaNT.Location = new System.Drawing.Point(30, 30);
            this.lblMaNT.Name = "lblMaNT";
            this.lblMaNT.Size = new System.Drawing.Size(78, 13);
            this.lblMaNT.TabIndex = 0;
            this.lblMaNT.Text = "Mã người thân:";
            // 
            // lblTenNT
            // 
            this.lblTenNT.AutoSize = true;
            this.lblTenNT.Location = new System.Drawing.Point(30, 80);
            this.lblTenNT.Name = "lblTenNT";
            this.lblTenNT.Size = new System.Drawing.Size(82, 13);
            this.lblTenNT.TabIndex = 1;
            this.lblTenNT.Text = "Tên người thân:";
            // 
            // lblSdtNT
            // 
            this.lblSdtNT.AutoSize = true;
            this.lblSdtNT.Location = new System.Drawing.Point(30, 130);
            this.lblSdtNT.Name = "lblSdtNT";
            this.lblSdtNT.Size = new System.Drawing.Size(126, 13);
            this.lblSdtNT.TabIndex = 2;
            this.lblSdtNT.Text = "Số điện thoại người thân:";
            // 
            // lblDiaChiNT
            // 
            this.lblDiaChiNT.AutoSize = true;
            this.lblDiaChiNT.Location = new System.Drawing.Point(30, 180);
            this.lblDiaChiNT.Name = "lblDiaChiNT";
            this.lblDiaChiNT.Size = new System.Drawing.Size(96, 13);
            this.lblDiaChiNT.TabIndex = 3;
            this.lblDiaChiNT.Text = "Địa chỉ người thân:";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(30, 230);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(70, 13);
            this.lblMaSV.TabIndex = 4;
            this.lblMaSV.Text = "Mã sinh viên:";
            // 
            // FormThemSuaNguoiThan
            // 
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblDiaChiNT);
            this.Controls.Add(this.txtDiaChiNT);
            this.Controls.Add(this.lblSdtNT);
            this.Controls.Add(this.txtSdtNT);
            this.Controls.Add(this.lblTenNT);
            this.Controls.Add(this.txtTenNT);
            this.Controls.Add(this.lblMaNT);
            this.Controls.Add(this.txtMaNT);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormThemSuaNguoiThan";
            this.Text = "Thêm/Sửa người thân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna.UI2.WinForms.Guna2TextBox txtMaNT;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNT;
        private Guna.UI2.WinForms.Guna2TextBox txtSdtNT;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChiNT;
        private Guna.UI2.WinForms.Guna2TextBox txtMaSV;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label lblMaNT;
        private System.Windows.Forms.Label lblTenNT;
        private System.Windows.Forms.Label lblSdtNT;
        private System.Windows.Forms.Label lblDiaChiNT;
        private System.Windows.Forms.Label lblMaSV;
    }
}