using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace HeThongQuanLyKTX.Views.BaoCaoThongKe
{
    partial class FormDoanhThuThang
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

        #region Windows Form Designer generated code
        private Label lblAverageRevenue;
        private DataGridView dgvDoanhThu;
        private Chart chartDoanhThu;
        private ComboBox cmbYear;
        private Label lblTotalRevenue;
        private Label lblHighestMonth;
        private Label lblLowestMonth;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblHighestMonth = new System.Windows.Forms.Label();
            this.lblLowestMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblAverageRevenue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoanhThu.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoanhThu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dgvDoanhThu.Location = new System.Drawing.Point(2, 63);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.Size = new System.Drawing.Size(419, 270);
            this.dgvDoanhThu.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tháng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Doanh thu (VNĐ)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "MainArea";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            this.chartDoanhThu.Location = new System.Drawing.Point(2, 339);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "MainArea";
            series1.Name = "Doanh thu";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(1009, 293);
            this.chartDoanhThu.TabIndex = 2;
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
            this.cmbYear.Size = new System.Drawing.Size(150, 33);
            this.cmbYear.TabIndex = 3;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRevenue.Location = new System.Drawing.Point(437, 63);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(210, 25);
            this.lblTotalRevenue.TabIndex = 4;
            this.lblTotalRevenue.Text = "Tổng doanh thu: 0 VNĐ";
            // 
            // lblHighestMonth
            // 
            this.lblHighestMonth.AutoSize = true;
            this.lblHighestMonth.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblHighestMonth.ForeColor = System.Drawing.Color.Black;
            this.lblHighestMonth.Location = new System.Drawing.Point(437, 142);
            this.lblHighestMonth.Name = "lblHighestMonth";
            this.lblHighestMonth.Size = new System.Drawing.Size(244, 25);
            this.lblHighestMonth.TabIndex = 5;
            this.lblHighestMonth.Text = "Tháng doanh thu cao nhất: ";
            // 
            // lblLowestMonth
            // 
            this.lblLowestMonth.AutoSize = true;
            this.lblLowestMonth.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblLowestMonth.ForeColor = System.Drawing.Color.Black;
            this.lblLowestMonth.Location = new System.Drawing.Point(437, 224);
            this.lblLowestMonth.Name = "lblLowestMonth";
            this.lblLowestMonth.Size = new System.Drawing.Size(252, 25);
            this.lblLowestMonth.TabIndex = 6;
            this.lblLowestMonth.Text = "Tháng doanh thu thấp nhất: ";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.Color.Black;
            this.lblYear.Location = new System.Drawing.Point(0, 5);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(103, 25);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Chọn năm";
            // 
            // lblAverageRevenue
            // 
            this.lblAverageRevenue.AutoSize = true;
            this.lblAverageRevenue.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblAverageRevenue.ForeColor = System.Drawing.Color.Black;
            this.lblAverageRevenue.Location = new System.Drawing.Point(437, 308);
            this.lblAverageRevenue.Name = "lblAverageRevenue";
            this.lblAverageRevenue.Size = new System.Drawing.Size(258, 25);
            this.lblAverageRevenue.TabIndex = 7;
            this.lblAverageRevenue.Text = "Doanh thu trung bình: 0 VNĐ";
            // 
            // FormDoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 630);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblLowestMonth);
            this.Controls.Add(this.lblHighestMonth);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.lblAverageRevenue);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.chartDoanhThu);
            this.Name = "FormDoanhThuThang";
            this.Text = "Thống kê Doanh thu Tháng";
            this.Load += new System.EventHandler(this.FormDoanhThuThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblYear;
    }
}
