namespace HeThongQuanLyKTX.Views
{
    partial class FormThemSuaLoaiPhong
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
            this.txtMaLoaiPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoSVToiDa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDienTich = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.lblMaLoaiPhong = new System.Windows.Forms.Label();
            this.lblSoSVToiDa = new System.Windows.Forms.Label();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.lblTienLP = new System.Windows.Forms.Label();
            this.txtTienLP = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // txtMaLoaiPhong
            // 
            this.txtMaLoaiPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLoaiPhong.DefaultText = "";
            this.txtMaLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaLoaiPhong.Location = new System.Drawing.Point(150, 20);
            this.txtMaLoaiPhong.Name = "txtMaLoaiPhong";
            this.txtMaLoaiPhong.PasswordChar = '\0';
            this.txtMaLoaiPhong.PlaceholderText = "Mã loại phòng";
            this.txtMaLoaiPhong.SelectedText = "";
            this.txtMaLoaiPhong.Size = new System.Drawing.Size(300, 40);
            this.txtMaLoaiPhong.TabIndex = 0;
            this.txtMaLoaiPhong.TextChanged += new System.EventHandler(this.txtMaLoaiPhong_TextChanged);
            // 
            // txtSoSVToiDa
            // 
            this.txtSoSVToiDa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoSVToiDa.DefaultText = "";
            this.txtSoSVToiDa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoSVToiDa.Location = new System.Drawing.Point(150, 70);
            this.txtSoSVToiDa.Name = "txtSoSVToiDa";
            this.txtSoSVToiDa.PasswordChar = '\0';
            this.txtSoSVToiDa.PlaceholderText = "Tên loại phòng";
            this.txtSoSVToiDa.SelectedText = "";
            this.txtSoSVToiDa.Size = new System.Drawing.Size(300, 40);
            this.txtSoSVToiDa.TabIndex = 1;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDienTich.DefaultText = "";
            this.txtDienTich.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDienTich.Location = new System.Drawing.Point(150, 120);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.PasswordChar = '\0';
            this.txtDienTich.PlaceholderText = "Diện tích (m²)";
            this.txtDienTich.SelectedText = "";
            this.txtDienTich.Size = new System.Drawing.Size(300, 40);
            this.txtDienTich.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(80, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FillColor = System.Drawing.Color.Crimson;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(240, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMaLoaiPhong
            // 
            this.lblMaLoaiPhong.AutoSize = true;
            this.lblMaLoaiPhong.Location = new System.Drawing.Point(30, 30);
            this.lblMaLoaiPhong.Name = "lblMaLoaiPhong";
            this.lblMaLoaiPhong.Size = new System.Drawing.Size(77, 13);
            this.lblMaLoaiPhong.TabIndex = 0;
            this.lblMaLoaiPhong.Text = "Mã loại phòng:";
            // 
            // lblSoSVToiDa
            // 
            this.lblSoSVToiDa.AutoSize = true;
            this.lblSoSVToiDa.Location = new System.Drawing.Point(30, 80);
            this.lblSoSVToiDa.Name = "lblSoSVToiDa";
            this.lblSoSVToiDa.Size = new System.Drawing.Size(71, 13);
            this.lblSoSVToiDa.TabIndex = 1;
            this.lblSoSVToiDa.Text = "Số sinh viên: ";
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Location = new System.Drawing.Point(30, 130);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(54, 13);
            this.lblDienTich.TabIndex = 2;
            this.lblDienTich.Text = "Diện tích:";
            // 
            // lblTienLP
            // 
            this.lblTienLP.AutoSize = true;
            this.lblTienLP.Location = new System.Drawing.Point(30, 180);
            this.lblTienLP.Name = "lblTienLP";
            this.lblTienLP.Size = new System.Drawing.Size(64, 13);
            this.lblTienLP.TabIndex = 3;
            this.lblTienLP.Text = "Tiền phòng:";
            // 
            // txtTienLP
            // 
            this.txtTienLP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienLP.DefaultText = "";
            this.txtTienLP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTienLP.Location = new System.Drawing.Point(150, 166);
            this.txtTienLP.Name = "txtTienLP";
            this.txtTienLP.PasswordChar = '\0';
            this.txtTienLP.PlaceholderText = "Tiền phòng (VND)";
            this.txtTienLP.SelectedText = "";
            this.txtTienLP.Size = new System.Drawing.Size(300, 40);
            this.txtTienLP.TabIndex = 6;
            // 
            // FormThemSuaLoaiPhong
            // 
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.txtTienLP);
            this.Controls.Add(this.lblMaLoaiPhong);
            this.Controls.Add(this.txtMaLoaiPhong);
            this.Controls.Add(this.lblSoSVToiDa);
            this.Controls.Add(this.txtSoSVToiDa);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.lblTienLP);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormThemSuaLoaiPhong";
            this.Text = "Thêm/Sửa loại phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna.UI2.WinForms.Guna2TextBox txtMaLoaiPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtSoSVToiDa;
        private Guna.UI2.WinForms.Guna2TextBox txtDienTich;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label lblMaLoaiPhong;
        private System.Windows.Forms.Label lblSoSVToiDa;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.Label lblTienLP;
        private Guna.UI2.WinForms.Guna2TextBox txtTienLP;
    }
}