using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HeThongQuanLyKTX.Views.BaoCaoThongKe
{
    partial class FormSoLuongDVSuDung
    {
        private DataGridView dgvServiceUsage;
        private Chart chartServiceUsage;
        private ComboBox cmbYear;
        private Label lblTotalServices;
        private Label lblMostUsedService;
        private Label lblLeastUsedService;
        private Label lblAverageUsage;
        private Label lblYear;
        private DataGridViewTextBoxColumn colService;
        private DataGridViewTextBoxColumn colMonth;
        private DataGridViewTextBoxColumn colUsage;

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

        /// <summary>
        /// Method to initialize components for the form.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvServiceUsage = new System.Windows.Forms.DataGridView();
            this.colService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartServiceUsage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblTotalServices = new System.Windows.Forms.Label();
            this.lblMostUsedService = new System.Windows.Forms.Label();
            this.lblLeastUsedService = new System.Windows.Forms.Label();
            this.lblAverageUsage = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartServiceUsage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServiceUsage
            // 
            this.dgvServiceUsage.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvServiceUsage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServiceUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceUsage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colService,
            this.colMonth,
            this.colUsage});
            this.dgvServiceUsage.Location = new System.Drawing.Point(0, 48);
            this.dgvServiceUsage.Name = "dgvServiceUsage";
            this.dgvServiceUsage.Size = new System.Drawing.Size(608, 235);
            this.dgvServiceUsage.TabIndex = 1;
            this.dgvServiceUsage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceUsage_CellContentClick);
            // 
            // colService
            // 
            this.colService.HeaderText = "Dịch vụ";
            this.colService.Name = "colService";
            this.colService.Width = 200;
            // 
            // colMonth
            // 
            this.colMonth.HeaderText = "Tháng";
            this.colMonth.Name = "colMonth";
            this.colMonth.Width = 150;
            // 
            // colUsage
            // 
            this.colUsage.HeaderText = "Số lần sử dụng";
            this.colUsage.Name = "colUsage";
            this.colUsage.Width = 200;
            // 
            // chartServiceUsage
            // 
            chartArea1.Name = "MainArea";
            this.chartServiceUsage.ChartAreas.Add(chartArea1);
            this.chartServiceUsage.Location = new System.Drawing.Point(0, 289);
            this.chartServiceUsage.Name = "chartServiceUsage";
            series1.ChartArea = "MainArea";
            series1.Name = "Số lần sử dụng";
            this.chartServiceUsage.Series.Add(series1);
            this.chartServiceUsage.Size = new System.Drawing.Size(1008, 338);
            this.chartServiceUsage.TabIndex = 2;
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025"});
            this.cmbYear.Location = new System.Drawing.Point(130, 0);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 33);
            this.cmbYear.TabIndex = 3;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // lblTotalServices
            // 
            this.lblTotalServices.AutoSize = true;
            this.lblTotalServices.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTotalServices.Location = new System.Drawing.Point(614, 48);
            this.lblTotalServices.Name = "lblTotalServices";
            this.lblTotalServices.Size = new System.Drawing.Size(202, 25);
            this.lblTotalServices.TabIndex = 4;
            this.lblTotalServices.Text = "Tổng số lần sử dụng: 0";
            // 
            // lblMostUsedService
            // 
            this.lblMostUsedService.AutoSize = true;
            this.lblMostUsedService.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblMostUsedService.Location = new System.Drawing.Point(614, 109);
            this.lblMostUsedService.Name = "lblMostUsedService";
            this.lblMostUsedService.Size = new System.Drawing.Size(276, 25);
            this.lblMostUsedService.TabIndex = 5;
            this.lblMostUsedService.Text = "Dịch vụ được dùng nhiều nhất: ";
            // 
            // lblLeastUsedService
            // 
            this.lblLeastUsedService.AutoSize = true;
            this.lblLeastUsedService.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblLeastUsedService.Location = new System.Drawing.Point(614, 179);
            this.lblLeastUsedService.Name = "lblLeastUsedService";
            this.lblLeastUsedService.Size = new System.Drawing.Size(239, 25);
            this.lblLeastUsedService.TabIndex = 6;
            this.lblLeastUsedService.Text = "Dịch vụ được dùng ít nhất: ";
            // 
            // lblAverageUsage
            // 
            this.lblAverageUsage.AutoSize = true;
            this.lblAverageUsage.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblAverageUsage.Location = new System.Drawing.Point(614, 247);
            this.lblAverageUsage.Name = "lblAverageUsage";
            this.lblAverageUsage.Size = new System.Drawing.Size(240, 25);
            this.lblAverageUsage.TabIndex = 7;
            this.lblAverageUsage.Text = "Số lần sử dụng trung bình: ";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblYear.Location = new System.Drawing.Point(0, 5);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(103, 25);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Chọn năm";
            // 
            // FormSoLuongDVSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 630);
            this.Controls.Add(this.dgvServiceUsage);
            this.Controls.Add(this.chartServiceUsage);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblTotalServices);
            this.Controls.Add(this.lblMostUsedService);
            this.Controls.Add(this.lblLeastUsedService);
            this.Controls.Add(this.lblAverageUsage);
            this.Controls.Add(this.lblYear);
            this.Name = "FormSoLuongDVSuDung";
            this.Text = "FormSoLuongDVSuDung";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartServiceUsage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Load data based on selected year.
        /// </summary>
        /// <param name="year">Selected year</param>
        
    }
}
