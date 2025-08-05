using System;
using System.Windows.Forms;

namespace HeThongQuanLyKTX.Views.BieuMau
{
    public partial class FormTaoPDK : Form
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.lblNgayDangKy = new System.Windows.Forms.Label();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.lblTrangThaiPDK = new System.Windows.Forms.Label();
            this.cboTrangThaiPDK = new System.Windows.Forms.ComboBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Red;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(672, 70);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Tạo Phiếu Đăng Ký";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieu.Location = new System.Drawing.Point(115, 98);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(79, 20);
            this.lblMaPhieu.TabIndex = 1;
            this.lblMaPhieu.Text = "Mã Phiếu:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Location = new System.Drawing.Point(265, 98);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(267, 26);
            this.txtMaPhieu.TabIndex = 2;
            // 
            // lblNgayDangKy
            // 
            this.lblNgayDangKy.AutoSize = true;
            this.lblNgayDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDangKy.Location = new System.Drawing.Point(115, 148);
            this.lblNgayDangKy.Name = "lblNgayDangKy";
            this.lblNgayDangKy.Size = new System.Drawing.Size(113, 20);
            this.lblNgayDangKy.TabIndex = 3;
            this.lblNgayDangKy.Text = "Ngày Đăng Ký:";
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDangKy.Location = new System.Drawing.Point(265, 148);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(267, 26);
            this.dtpNgayDangKy.TabIndex = 4;
            // 
            // lblTrangThaiPDK
            // 
            this.lblTrangThaiPDK.AutoSize = true;
            this.lblTrangThaiPDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThaiPDK.Location = new System.Drawing.Point(115, 198);
            this.lblTrangThaiPDK.Name = "lblTrangThaiPDK";
            this.lblTrangThaiPDK.Size = new System.Drawing.Size(124, 20);
            this.lblTrangThaiPDK.TabIndex = 5;
            this.lblTrangThaiPDK.Text = "Trạng Thái PDK:";
            // 
            // cboTrangThaiPDK
            // 
            this.cboTrangThaiPDK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThaiPDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThaiPDK.Items.AddRange(new object[] {
            "Chờ duyệt",
            "Đã duyệt",
            "Từ chối"});
            this.cboTrangThaiPDK.Location = new System.Drawing.Point(265, 198);
            this.cboTrangThaiPDK.Name = "cboTrangThaiPDK";
            this.cboTrangThaiPDK.Size = new System.Drawing.Size(267, 28);
            this.cboTrangThaiPDK.TabIndex = 6;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(115, 248);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(113, 20);
            this.lblMaNV.TabIndex = 7;
            this.lblMaNV.Text = "Mã Nhân Viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(265, 248);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(267, 26);
            this.txtMaNV.TabIndex = 8;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.Location = new System.Drawing.Point(115, 298);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(85, 20);
            this.lblMaPhong.TabIndex = 9;
            this.lblMaPhong.Text = "Mã Phòng:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(265, 298);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(267, 26);
            this.txtMaPhong.TabIndex = 10;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(115, 348);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(107, 20);
            this.lblMaSV.TabIndex = 11;
            this.lblMaSV.Text = "Mã Sinh Viên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(265, 348);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(267, 26);
            this.txtMaSV.TabIndex = 12;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Green;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(200, 400);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 50);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(320, 400);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 50);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormTaoPDK
            // 
            this.ClientSize = new System.Drawing.Size(672, 500);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.lblMaPhieu);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.lblNgayDangKy);
            this.Controls.Add(this.dtpNgayDangKy);
            this.Controls.Add(this.lblTrangThaiPDK);
            this.Controls.Add(this.cboTrangThaiPDK);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Name = "FormTaoPDK";
            this.Text = "Tạo Phiếu Đăng Ký";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private Label labelTitle;
        private Label lblMaPhieu;
        private TextBox txtMaPhieu;
        private Label lblNgayDangKy;
        private DateTimePicker dtpNgayDangKy;
        private Label lblTrangThaiPDK;
        private ComboBox cboTrangThaiPDK;
        private Label lblMaNV;
        private TextBox txtMaNV;
        private Label lblMaPhong;
        private TextBox txtMaPhong;
        private Label lblMaSV;
        private TextBox txtMaSV;
        private Button btnLuu;
        private Button btnHuy;
    }
}
