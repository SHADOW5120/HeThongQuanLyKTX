namespace HeThongQuanLyKTX.Views
{
    partial class FormThemSuaDichVu
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMaDV;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.Label lblDonViDV;
        private System.Windows.Forms.Label lblGiaDV;

        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtDonViDV;
        private System.Windows.Forms.TextBox txtGiaDV;

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
            this.lblMaDV = new System.Windows.Forms.Label();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.lblDonViDV = new System.Windows.Forms.Label();
            this.lblGiaDV = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtDonViDV = new System.Windows.Forms.TextBox();
            this.txtGiaDV = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaDV
            // 
            this.lblMaDV.AutoSize = true;
            this.lblMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDV.Location = new System.Drawing.Point(30, 30);
            this.lblMaDV.Name = "lblMaDV";
            this.lblMaDV.Size = new System.Drawing.Size(88, 20);
            this.lblMaDV.TabIndex = 0;
            this.lblMaDV.Text = "Mã dịch vụ:";
            // 
            // lblTenDV
            // 
            this.lblTenDV.AutoSize = true;
            this.lblTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDV.Location = new System.Drawing.Point(30, 70);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(93, 20);
            this.lblTenDV.TabIndex = 1;
            this.lblTenDV.Text = "Tên dịch vụ:";
            // 
            // lblDonViDV
            // 
            this.lblDonViDV.AutoSize = true;
            this.lblDonViDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViDV.Location = new System.Drawing.Point(30, 110);
            this.lblDonViDV.Name = "lblDonViDV";
            this.lblDonViDV.Size = new System.Drawing.Size(84, 20);
            this.lblDonViDV.TabIndex = 2;
            this.lblDonViDV.Text = "Đơn vị DV:";
            // 
            // lblGiaDV
            // 
            this.lblGiaDV.AutoSize = true;
            this.lblGiaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaDV.Location = new System.Drawing.Point(30, 150);
            this.lblGiaDV.Name = "lblGiaDV";
            this.lblGiaDV.Size = new System.Drawing.Size(65, 20);
            this.lblGiaDV.TabIndex = 3;
            this.lblGiaDV.Text = "Giá DV:";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.Location = new System.Drawing.Point(150, 30);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(200, 26);
            this.txtMaDV.TabIndex = 4;
            this.txtMaDV.TextChanged += new System.EventHandler(this.txtMaDV_TextChanged);
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Location = new System.Drawing.Point(150, 70);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(200, 26);
            this.txtTenDV.TabIndex = 5;
            // 
            // txtDonViDV
            // 
            this.txtDonViDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViDV.Location = new System.Drawing.Point(150, 110);
            this.txtDonViDV.Name = "txtDonViDV";
            this.txtDonViDV.Size = new System.Drawing.Size(200, 26);
            this.txtDonViDV.TabIndex = 6;
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaDV.Location = new System.Drawing.Point(150, 150);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(200, 26);
            this.txtGiaDV.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(150, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormThemSuaDichVu
            // 
            this.ClientSize = new System.Drawing.Size(401, 287);
            this.Controls.Add(this.lblMaDV);
            this.Controls.Add(this.lblTenDV);
            this.Controls.Add(this.lblDonViDV);
            this.Controls.Add(this.lblGiaDV);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.txtDonViDV);
            this.Controls.Add(this.txtGiaDV);
            this.Controls.Add(this.btnSave);
            this.Name = "FormThemSuaDichVu";
            this.Text = "Chi tiết dịch vụ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}