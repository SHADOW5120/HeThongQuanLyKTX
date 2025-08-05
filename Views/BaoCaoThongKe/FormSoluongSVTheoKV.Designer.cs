using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System;

namespace HeThongQuanLyKTX.Views.BaoCaoThongKe
{
    partial class FormSoluongSVTheoKV
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
        private DataGridView dgvSoLuongSV;
        private Chart chartSoLuongSV;
        private ComboBox cmbYear;
        private Label lblTotalStudents;
        private Label lblHighestRegion;
        private Label lblLowestRegion;
        private Label lblAverageStudents;
        private DataGridViewTextBoxColumn colRegion;
        private DataGridViewTextBoxColumn colMonth;
        private DataGridViewTextBoxColumn colStudentCount;
        private Label lblYear;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvSoLuongSV = new System.Windows.Forms.DataGridView();
            this.colRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartSoLuongSV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.lblHighestRegion = new System.Windows.Forms.Label();
            this.lblLowestRegion = new System.Windows.Forms.Label();
            this.lblAverageStudents = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoLuongSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoLuongSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSoLuongSV
            // 
            this.dgvSoLuongSV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSoLuongSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSoLuongSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoLuongSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRegion,
            this.colMonth,
            this.colStudentCount});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoLuongSV.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSoLuongSV.GridColor = System.Drawing.Color.Gray;
            this.dgvSoLuongSV.Location = new System.Drawing.Point(2, 50);
            this.dgvSoLuongSV.Name = "dgvSoLuongSV";
            this.dgvSoLuongSV.Size = new System.Drawing.Size(601, 270);
            this.dgvSoLuongSV.TabIndex = 1;
            // 
            // colRegion
            // 
            this.colRegion.HeaderText = "Khu vực";
            this.colRegion.Name = "colRegion";
            this.colRegion.Width = 200;
            // 
            // colMonth
            // 
            this.colMonth.HeaderText = "Tháng";
            this.colMonth.Name = "colMonth";
            this.colMonth.Width = 150;
            // 
            // colStudentCount
            // 
            this.colStudentCount.HeaderText = "Số lượng SV";
            this.colStudentCount.Name = "colStudentCount";
            this.colStudentCount.Width = 200;
            // 
            // chartSoLuongSV
            // 
            chartArea1.Name = "MainArea";
            this.chartSoLuongSV.ChartAreas.Add(chartArea1);
            this.chartSoLuongSV.Location = new System.Drawing.Point(2, 326);
            this.chartSoLuongSV.Name = "chartSoLuongSV";
            series1.ChartArea = "MainArea";
            series1.Name = "Số lượng SV";
            this.chartSoLuongSV.Series.Add(series1);
            this.chartSoLuongSV.Size = new System.Drawing.Size(1007, 303);
            this.chartSoLuongSV.TabIndex = 2;
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
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTotalStudents.ForeColor = System.Drawing.Color.Black;
            this.lblTotalStudents.Location = new System.Drawing.Point(609, 50);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(179, 25);
            this.lblTotalStudents.TabIndex = 4;
            this.lblTotalStudents.Text = "Tổng số SV: 0 người";
            // 
            // lblHighestRegion
            // 
            this.lblHighestRegion.AutoSize = true;
            this.lblHighestRegion.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblHighestRegion.ForeColor = System.Drawing.Color.Black;
            this.lblHighestRegion.Location = new System.Drawing.Point(609, 120);
            this.lblHighestRegion.Name = "lblHighestRegion";
            this.lblHighestRegion.Size = new System.Drawing.Size(236, 25);
            this.lblHighestRegion.TabIndex = 5;
            this.lblHighestRegion.Text = "Khu vực có SV nhiều nhất: ";
            // 
            // lblLowestRegion
            // 
            this.lblLowestRegion.AutoSize = true;
            this.lblLowestRegion.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblLowestRegion.ForeColor = System.Drawing.Color.Black;
            this.lblLowestRegion.Location = new System.Drawing.Point(609, 202);
            this.lblLowestRegion.Name = "lblLowestRegion";
            this.lblLowestRegion.Size = new System.Drawing.Size(199, 25);
            this.lblLowestRegion.TabIndex = 6;
            this.lblLowestRegion.Text = "Khu vực có SV ít nhất: ";
            // 
            // lblAverageStudents
            // 
            this.lblAverageStudents.AutoSize = true;
            this.lblAverageStudents.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblAverageStudents.ForeColor = System.Drawing.Color.Black;
            this.lblAverageStudents.Location = new System.Drawing.Point(609, 275);
            this.lblAverageStudents.Name = "lblAverageStudents";
            this.lblAverageStudents.Size = new System.Drawing.Size(227, 25);
            this.lblAverageStudents.TabIndex = 7;
            this.lblAverageStudents.Text = "Số SV trung bình: 0 người";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.Color.Black;
            this.lblYear.Location = new System.Drawing.Point(0, 5);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(103, 25);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Chọn năm";
            // 
            // FormSoluongSVTheoKV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 630);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblAverageStudents);
            this.Controls.Add(this.lblLowestRegion);
            this.Controls.Add(this.lblHighestRegion);
            this.Controls.Add(this.lblTotalStudents);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.chartSoLuongSV);
            this.Controls.Add(this.dgvSoLuongSV);
            this.Name = "FormSoluongSVTheoKV";
            this.Text = "Số lượng SV theo Khu vực";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoLuongSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoLuongSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
    }
}
