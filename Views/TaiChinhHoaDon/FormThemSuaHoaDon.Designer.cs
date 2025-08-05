namespace HeThongQuanLyKTX.Views.TaiChinhHoaDon
{
    partial class FormThemSuaHoaDon
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

        private void InitializeComponent()
        {
            this.colMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.dtpThoiGianHD = new System.Windows.Forms.DateTimePicker();
            this.cmbTrangThaiHD = new System.Windows.Forms.ComboBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblThoiGianHD = new System.Windows.Forms.Label();
            this.lblTrangThaiHD = new System.Windows.Forms.Label();
            this.lblMANV = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboBoxDV = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.btnAddDV = new System.Windows.Forms.Button();
            this.groupBoxDV = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxDV.SuspendLayout();
            this.SuspendLayout();
            // 
            // colMaDV
            // 
            this.colMaDV.HeaderText = "Mã Dịch Vụ";
            this.colMaDV.Name = "colMaDV";
            this.colMaDV.ReadOnly = true;
            // 
            // colTenDV
            // 
            this.colTenDV.HeaderText = "Tên Dịch Vụ";
            this.colTenDV.Name = "colTenDV";
            this.colTenDV.ReadOnly = true;
            // 
            // colGiaDV
            // 
            this.colGiaDV.HeaderText = "Giá Dịch Vụ";
            this.colGiaDV.Name = "colGiaDV";
            this.colGiaDV.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaHD.Location = new System.Drawing.Point(275, 74);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(305, 26);
            this.txtMaHD.TabIndex = 19;
            // 
            // dtpThoiGianHD
            // 
            this.dtpThoiGianHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpThoiGianHD.Location = new System.Drawing.Point(275, 114);
            this.dtpThoiGianHD.Name = "dtpThoiGianHD";
            this.dtpThoiGianHD.Size = new System.Drawing.Size(305, 26);
            this.dtpThoiGianHD.TabIndex = 18;
            // 
            // cmbTrangThaiHD
            // 
            this.cmbTrangThaiHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThaiHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTrangThaiHD.FormattingEnabled = true;
            this.cmbTrangThaiHD.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cmbTrangThaiHD.Location = new System.Drawing.Point(275, 154);
            this.cmbTrangThaiHD.Name = "cmbTrangThaiHD";
            this.cmbTrangThaiHD.Size = new System.Drawing.Size(305, 28);
            this.cmbTrangThaiHD.TabIndex = 17;
            // 
            // txtMANV
            // 
            this.txtMANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMANV.Location = new System.Drawing.Point(275, 194);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(305, 26);
            this.txtMANV.TabIndex = 16;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaPhong.Location = new System.Drawing.Point(275, 234);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(305, 26);
            this.txtMaPhong.TabIndex = 15;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDV,
            this.colTenDV,
            this.colGiaDV,
            this.colSoLuong,
            this.colThanhTien});
            this.dgvDichVu.Location = new System.Drawing.Point(37, 123);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.Size = new System.Drawing.Size(629, 228);
            this.dgvDichVu.TabIndex = 5;
            this.dgvDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellContentClick);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Teal;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(206, 632);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 35);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(501, 632);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 35);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblMaHD
            // 
            this.lblMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMaHD.Location = new System.Drawing.Point(71, 77);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(150, 23);
            this.lblMaHD.TabIndex = 13;
            this.lblMaHD.Text = "Mã Hóa Đơn";
            // 
            // lblThoiGianHD
            // 
            this.lblThoiGianHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblThoiGianHD.Location = new System.Drawing.Point(71, 117);
            this.lblThoiGianHD.Name = "lblThoiGianHD";
            this.lblThoiGianHD.Size = new System.Drawing.Size(150, 23);
            this.lblThoiGianHD.TabIndex = 12;
            this.lblThoiGianHD.Text = "Thời Gian";
            // 
            // lblTrangThaiHD
            // 
            this.lblTrangThaiHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTrangThaiHD.Location = new System.Drawing.Point(71, 157);
            this.lblTrangThaiHD.Name = "lblTrangThaiHD";
            this.lblTrangThaiHD.Size = new System.Drawing.Size(150, 23);
            this.lblTrangThaiHD.TabIndex = 11;
            this.lblTrangThaiHD.Text = "Trạng Thái";
            // 
            // lblMANV
            // 
            this.lblMANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMANV.Location = new System.Drawing.Point(71, 197);
            this.lblMANV.Name = "lblMANV";
            this.lblMANV.Size = new System.Drawing.Size(150, 23);
            this.lblMANV.TabIndex = 10;
            this.lblMANV.Text = "Mã Nhân Viên";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMaPhong.Location = new System.Drawing.Point(71, 237);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(150, 23);
            this.lblMaPhong.TabIndex = 9;
            this.lblMaPhong.Text = "Mã Phòng";
            // 
            // lblDichVu
            // 
            this.lblDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDichVu.Location = new System.Drawing.Point(17, 35);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(100, 23);
            this.lblDichVu.TabIndex = 8;
            this.lblDichVu.Text = "Dịch Vụ";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(816, 60);
            this.panelHeader.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm Hóa Đơn";
            // 
            // comboBoxDV
            // 
            this.comboBoxDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxDV.FormattingEnabled = true;
            this.comboBoxDV.Location = new System.Drawing.Point(155, 32);
            this.comboBoxDV.Name = "comboBoxDV";
            this.comboBoxDV.Size = new System.Drawing.Size(305, 28);
            this.comboBoxDV.TabIndex = 20;
            this.comboBoxDV.SelectedIndexChanged += new System.EventHandler(this.comboBoxDV_SelectedIndexChanged);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSoLuong.Location = new System.Drawing.Point(17, 80);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(100, 23);
            this.lblSoLuong.TabIndex = 21;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(155, 80);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(216, 26);
            this.numericUpDown1.TabIndex = 22;
            // 
            // lblDonVi
            // 
            this.lblDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDonVi.Location = new System.Drawing.Point(387, 83);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(100, 23);
            this.lblDonVi.TabIndex = 23;
            this.lblDonVi.Text = "Đơn vị";
            // 
            // btnAddDV
            // 
            this.btnAddDV.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddDV.ForeColor = System.Drawing.Color.White;
            this.btnAddDV.Location = new System.Drawing.Point(502, 47);
            this.btnAddDV.Name = "btnAddDV";
            this.btnAddDV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddDV.Size = new System.Drawing.Size(136, 35);
            this.btnAddDV.TabIndex = 24;
            this.btnAddDV.Text = "Thêm dịch vụ";
            this.btnAddDV.UseVisualStyleBackColor = false;
            this.btnAddDV.Click += new System.EventHandler(this.btnAddDV_Click);
            // 
            // groupBoxDV
            // 
            this.groupBoxDV.Controls.Add(this.lblDichVu);
            this.groupBoxDV.Controls.Add(this.btnAddDV);
            this.groupBoxDV.Controls.Add(this.lblSoLuong);
            this.groupBoxDV.Controls.Add(this.lblDonVi);
            this.groupBoxDV.Controls.Add(this.comboBoxDV);
            this.groupBoxDV.Controls.Add(this.numericUpDown1);
            this.groupBoxDV.Controls.Add(this.dgvDichVu);
            this.groupBoxDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDV.Location = new System.Drawing.Point(51, 275);
            this.groupBoxDV.Name = "groupBoxDV";
            this.groupBoxDV.Size = new System.Drawing.Size(682, 351);
            this.groupBoxDV.TabIndex = 25;
            this.groupBoxDV.TabStop = false;
            this.groupBoxDV.Text = "Thông tin dịch vụ";
            // 
            // FormThemSuaHoaDon
            // 
            this.ClientSize = new System.Drawing.Size(816, 679);
            this.Controls.Add(this.groupBoxDV);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.lblMANV);
            this.Controls.Add(this.lblTrangThaiHD);
            this.Controls.Add(this.lblThoiGianHD);
            this.Controls.Add(this.lblMaHD);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtMANV);
            this.Controls.Add(this.cmbTrangThaiHD);
            this.Controls.Add(this.dtpThoiGianHD);
            this.Controls.Add(this.txtMaHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormThemSuaHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxDV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DateTimePicker dtpThoiGianHD;
        private System.Windows.Forms.ComboBox cmbTrangThaiHD;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblThoiGianHD;
        private System.Windows.Forms.Label lblTrangThaiHD;
        private System.Windows.Forms.Label lblMANV;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private System.Windows.Forms.ComboBox comboBoxDV;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.Button btnAddDV;
        private System.Windows.Forms.GroupBox groupBoxDV;
    }
}
