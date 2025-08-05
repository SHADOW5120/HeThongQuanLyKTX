namespace HeThongQuanLyKTX.Views.TaiChinhHoaDon
{
    partial class FormHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFilterByRoom = new System.Windows.Forms.ComboBox();
            this.dgvInvoiceList = new System.Windows.Forms.DataGridView();
            this.btnAddHD = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFilterByDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(7)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1063, 71);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Chọn phòng :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbFilterByRoom
            // 
            this.cmbFilterByRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterByRoom.FormattingEnabled = true;
            this.cmbFilterByRoom.Location = new System.Drawing.Point(10, 112);
            this.cmbFilterByRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilterByRoom.Name = "cmbFilterByRoom";
            this.cmbFilterByRoom.Size = new System.Drawing.Size(204, 28);
            this.cmbFilterByRoom.TabIndex = 16;
            this.cmbFilterByRoom.SelectedIndexChanged += new System.EventHandler(this.cmbFilterByRoom_SelectedIndexChanged);
            // 
            // dgvInvoiceList
            // 
            this.dgvInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceList.Location = new System.Drawing.Point(2, 220);
            this.dgvInvoiceList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInvoiceList.Name = "dgvInvoiceList";
            this.dgvInvoiceList.RowHeadersWidth = 51;
            this.dgvInvoiceList.RowTemplate.Height = 24;
            this.dgvInvoiceList.Size = new System.Drawing.Size(1063, 379);
            this.dgvInvoiceList.TabIndex = 17;
            this.dgvInvoiceList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceList_CellContentClick);
            // 
            // btnAddHD
            // 
            this.btnAddHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHD.ForeColor = System.Drawing.Color.White;
            this.btnAddHD.Location = new System.Drawing.Point(41, 619);
            this.btnAddHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddHD.Name = "btnAddHD";
            this.btnAddHD.Size = new System.Drawing.Size(150, 40);
            this.btnAddHD.TabIndex = 21;
            this.btnAddHD.Text = "Thêm mới";
            this.btnAddHD.UseVisualStyleBackColor = false;
            this.btnAddHD.Click += new System.EventHandler(this.btnAddHD_Click);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteInvoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInvoice.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(247, 619);
            this.btnDeleteInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteInvoice.TabIndex = 23;
            this.btnDeleteInvoice.Text = "Xóa";
            this.btnDeleteInvoice.UseVisualStyleBackColor = false;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(539, 170);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 40);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(10, 178);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(491, 26);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nhập thông tin :";
            // 
            // dtpFilterByDate
            // 
            this.dtpFilterByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFilterByDate.Location = new System.Drawing.Point(265, 114);
            this.dtpFilterByDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFilterByDate.Name = "dtpFilterByDate";
            this.dtpFilterByDate.Size = new System.Drawing.Size(311, 26);
            this.dtpFilterByDate.TabIndex = 28;
            this.dtpFilterByDate.ValueChanged += new System.EventHandler(this.dtpFilterByDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "Chọn ngày :";
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFilterByDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDeleteInvoice);
            this.Controls.Add(this.btnAddHD);
            this.Controls.Add(this.dgvInvoiceList);
            this.Controls.Add(this.cmbFilterByRoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHoaDon";
            this.Text = "QuanLyHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFilterByRoom;
        private System.Windows.Forms.DataGridView dgvInvoiceList;
        private System.Windows.Forms.Button btnAddHD;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFilterByDate;
        private System.Windows.Forms.Label label6;
    }
}