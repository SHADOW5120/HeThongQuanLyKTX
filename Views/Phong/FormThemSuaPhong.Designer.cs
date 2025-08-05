using System.Windows.Forms;

namespace HeThongQuanLyKTX.Views
{
    partial class FormThemSuaPhong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblSoSinhVienHienTai;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.Label lblKhuVuc;

        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.ComboBox cmbTinhTrang; // Thay đổi từ TextBox thành ComboBox
        private System.Windows.Forms.TextBox txtSoSinhVienHienTai;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.ComboBox cmbKhuVuc; // Thay đổi từ TextBox thành ComboBox

        private System.Windows.Forms.Button btnSave;

        /// <summary>
        /// Clean up resources being used.
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

        /// <summary>
        /// Designer generated code
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblSoSinhVienHienTai = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.cmbTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtSoSinhVienHienTai = new System.Windows.Forms.TextBox();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.cmbKhuVuc = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.Location = new System.Drawing.Point(30, 30);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(84, 20);
            this.lblMaPhong.TabIndex = 0;
            this.lblMaPhong.Text = "Mã phòng:";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.Location = new System.Drawing.Point(30, 70);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(84, 20);
            this.lblTinhTrang.TabIndex = 1;
            this.lblTinhTrang.Text = "Tình trạng:";
            // 
            // lblSoSinhVienHienTai
            // 
            this.lblSoSinhVienHienTai.AutoSize = true;
            this.lblSoSinhVienHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoSinhVienHienTai.Location = new System.Drawing.Point(30, 110);
            this.lblSoSinhVienHienTai.Name = "lblSoSinhVienHienTai";
            this.lblSoSinhVienHienTai.Size = new System.Drawing.Size(153, 20);
            this.lblSoSinhVienHienTai.TabIndex = 2;
            this.lblSoSinhVienHienTai.Text = "Số sinh viên hiện tại:";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(30, 150);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(92, 20);
            this.lblLoaiPhong.TabIndex = 3;
            this.lblLoaiPhong.Text = "Loại phòng:";
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhuVuc.Location = new System.Drawing.Point(30, 190);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(69, 20);
            this.lblKhuVuc.TabIndex = 4;
            this.lblKhuVuc.Text = "Khu vực:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(196, 30);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(216, 26);
            this.txtMaPhong.TabIndex = 5;
            this.txtMaPhong.TextChanged += new System.EventHandler(this.txtMaPhong_TextChanged);
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTinhTrang.FormattingEnabled = true;
            this.cmbTinhTrang.Location = new System.Drawing.Point(196, 70);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Size = new System.Drawing.Size(216, 28);
            this.cmbTinhTrang.TabIndex = 6;
            // 
            // txtSoSinhVienHienTai
            // 
            this.txtSoSinhVienHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoSinhVienHienTai.Location = new System.Drawing.Point(196, 110);
            this.txtSoSinhVienHienTai.Name = "txtSoSinhVienHienTai";
            this.txtSoSinhVienHienTai.Size = new System.Drawing.Size(216, 26);
            this.txtSoSinhVienHienTai.TabIndex = 7;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiPhong.Location = new System.Drawing.Point(196, 150);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(216, 26);
            this.txtLoaiPhong.TabIndex = 8;
            // 
            // cmbKhuVuc
            // 
            this.cmbKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhuVuc.FormattingEnabled = true;
            this.cmbKhuVuc.Location = new System.Drawing.Point(196, 190);
            this.cmbKhuVuc.Name = "cmbKhuVuc";
            this.cmbKhuVuc.Size = new System.Drawing.Size(216, 28);
            this.cmbKhuVuc.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(196, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormThemSuaPhong
            // 
            this.ClientSize = new System.Drawing.Size(444, 360);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.lblSoSinhVienHienTai);
            this.Controls.Add(this.lblLoaiPhong);
            this.Controls.Add(this.lblKhuVuc);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.cmbTinhTrang);
            this.Controls.Add(this.txtSoSinhVienHienTai);
            this.Controls.Add(this.txtLoaiPhong);
            this.Controls.Add(this.cmbKhuVuc);
            this.Controls.Add(this.btnSave);
            this.Name = "FormThemSuaPhong";
            this.Text = "Chi tiết phòng";
            this.Load += new System.EventHandler(this.FormThemSuaPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
