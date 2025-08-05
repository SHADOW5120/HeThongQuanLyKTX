using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HeThongQuanLyKTX.Views.BaoCaoThongKe
{
    partial class FormSoPhongTrongTheoKV
    {
        private DataGridView dgvEmptyRooms;
        private Chart chartEmptyRooms;
        private ComboBox cmbAreaFilter;
        private Label lblTotalEmptyRooms;
        private DataGridViewTextBoxColumn colArea;
        private DataGridViewTextBoxColumn colEmptyRooms;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Dispose resources.
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
        /// Initialize form components.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvEmptyRooms = new System.Windows.Forms.DataGridView();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmptyRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartEmptyRooms = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbAreaFilter = new System.Windows.Forms.ComboBox();
            this.lblTotalEmptyRooms = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmptyRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmptyRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmptyRooms
            // 
            this.dgvEmptyRooms.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEmptyRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmptyRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmptyRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArea,
            this.colEmptyRooms});
            this.dgvEmptyRooms.Location = new System.Drawing.Point(5, 51);
            this.dgvEmptyRooms.Name = "dgvEmptyRooms";
            this.dgvEmptyRooms.Size = new System.Drawing.Size(465, 278);
            this.dgvEmptyRooms.TabIndex = 1;
            this.dgvEmptyRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmptyRooms_CellContentClick);
            // 
            // colArea
            // 
            this.colArea.HeaderText = "Khu vực";
            this.colArea.Name = "colArea";
            this.colArea.Width = 200;
            // 
            // colEmptyRooms
            // 
            this.colEmptyRooms.HeaderText = "Số phòng trống";
            this.colEmptyRooms.Name = "colEmptyRooms";
            this.colEmptyRooms.Width = 200;
            // 
            // chartEmptyRooms
            // 
            chartArea1.Name = "MainArea";
            this.chartEmptyRooms.ChartAreas.Add(chartArea1);
            this.chartEmptyRooms.Location = new System.Drawing.Point(5, 335);
            this.chartEmptyRooms.Name = "chartEmptyRooms";
            series1.ChartArea = "MainArea";
            series1.Name = "Phòng trống";
            this.chartEmptyRooms.Series.Add(series1);
            this.chartEmptyRooms.Size = new System.Drawing.Size(1008, 294);
            this.chartEmptyRooms.TabIndex = 2;
            // 
            // cmbAreaFilter
            // 
            this.cmbAreaFilter.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbAreaFilter.FormattingEnabled = true;
            this.cmbAreaFilter.Items.AddRange(new object[] {
            "Tất cả",
            "Khu vực A",
            "Khu vực B",
            "Khu vực C"});
            this.cmbAreaFilter.Location = new System.Drawing.Point(130, 0);
            this.cmbAreaFilter.Name = "cmbAreaFilter";
            this.cmbAreaFilter.Size = new System.Drawing.Size(121, 33);
            this.cmbAreaFilter.TabIndex = 3;
            this.cmbAreaFilter.SelectedIndexChanged += new System.EventHandler(this.cmbAreaFilter_SelectedIndexChanged);
            // 
            // lblTotalEmptyRooms
            // 
            this.lblTotalEmptyRooms.AutoSize = true;
            this.lblTotalEmptyRooms.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTotalEmptyRooms.Location = new System.Drawing.Point(476, 164);
            this.lblTotalEmptyRooms.Name = "lblTotalEmptyRooms";
            this.lblTotalEmptyRooms.Size = new System.Drawing.Size(209, 25);
            this.lblTotalEmptyRooms.TabIndex = 4;
            this.lblTotalEmptyRooms.Text = "Tổng số phòng trống: 0";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblYear.Location = new System.Drawing.Point(0, 5);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(103, 25);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "Chọn năm";
            // 
            // FormSoPhongTrongTheoKV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 630);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.dgvEmptyRooms);
            this.Controls.Add(this.chartEmptyRooms);
            this.Controls.Add(this.cmbAreaFilter);
            this.Controls.Add(this.lblTotalEmptyRooms);
            this.Name = "FormSoPhongTrongTheoKV";
            this.Text = "FormSoPhongTrongTheoKV";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmptyRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmptyRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblYear;

        /// <summary>
        /// Load data based on selected area.
        /// </summary>
        /// <param name="area">Selected area</param>

    }
}
