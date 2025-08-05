using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HeThongQuanLyKTX.Views.BaoCaoThongKe
{
    partial class FormSoPhongDayTheoKV
    {
        private DataGridView dgvRoomStatistics;
        private Chart chartRoomStatistics;
        private ComboBox cmbArea;
        private Label lblTotalRooms;
        private DataGridViewTextBoxColumn colArea;
        private DataGridViewTextBoxColumn colFullRooms;

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
            this.dgvRoomStatistics = new System.Windows.Forms.DataGridView();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartRoomStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoomStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoomStatistics
            // 
            this.dgvRoomStatistics.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRoomStatistics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoomStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArea,
            this.colFullRooms});
            this.dgvRoomStatistics.Location = new System.Drawing.Point(5, 54);
            this.dgvRoomStatistics.Name = "dgvRoomStatistics";
            this.dgvRoomStatistics.Size = new System.Drawing.Size(463, 260);
            this.dgvRoomStatistics.TabIndex = 1;
            this.dgvRoomStatistics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomStatistics_CellContentClick);
            // 
            // colArea
            // 
            this.colArea.HeaderText = "Khu vực";
            this.colArea.Name = "colArea";
            this.colArea.Width = 200;
            // 
            // colFullRooms
            // 
            this.colFullRooms.HeaderText = "Số phòng đầy";
            this.colFullRooms.Name = "colFullRooms";
            this.colFullRooms.Width = 200;
            // 
            // chartRoomStatistics
            // 
            chartArea1.Name = "MainArea";
            this.chartRoomStatistics.ChartAreas.Add(chartArea1);
            this.chartRoomStatistics.Location = new System.Drawing.Point(5, 320);
            this.chartRoomStatistics.Name = "chartRoomStatistics";
            series1.ChartArea = "MainArea";
            series1.Name = "Phòng đầy";
            this.chartRoomStatistics.Series.Add(series1);
            this.chartRoomStatistics.Size = new System.Drawing.Size(1006, 309);
            this.chartRoomStatistics.TabIndex = 2;
            // 
            // cmbArea
            // 
            this.cmbArea.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Items.AddRange(new object[] {
            "Khu vực A",
            "Khu vực B",
            "Khu vực C"});
            this.cmbArea.Location = new System.Drawing.Point(130, 5);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(121, 33);
            this.cmbArea.TabIndex = 3;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.AutoSize = true;
            this.lblTotalRooms.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTotalRooms.Location = new System.Drawing.Point(486, 152);
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.Size = new System.Drawing.Size(193, 25);
            this.lblTotalRooms.TabIndex = 4;
            this.lblTotalRooms.Text = "Tổng số phòng đầy: 0";
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
            // FormSoPhongDayTheoKV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 630);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.dgvRoomStatistics);
            this.Controls.Add(this.chartRoomStatistics);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.lblTotalRooms);
            this.Name = "FormSoPhongDayTheoKV";
            this.Text = "FormSoPhongDayTheoKV";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoomStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblYear;

        /// <summary>
        /// Load data for a selected area.
        /// </summary>
        /// <param name="area">Selected area</param>

    }
}
