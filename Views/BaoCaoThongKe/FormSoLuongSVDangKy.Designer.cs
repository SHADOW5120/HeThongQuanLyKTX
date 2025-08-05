using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HeThongQuanLyKTX.Views.BaoCaoThongKe
{
    partial class FormSoLuongSVDangKy
    {
        private DataGridView dgvStudentRegistration;
        private Chart chartStudentRegistration;
        private ComboBox cmbYear;
        private Label lblTotalStudents;
        private Label lblMonthHighest;
        private Label lblMonthLowest;
        private DataGridViewTextBoxColumn colMonth;
        private DataGridViewTextBoxColumn colRegisteredStudents;

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
        /// Initialize components for the form.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvStudentRegistration = new System.Windows.Forms.DataGridView();
            this.colMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegisteredStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartStudentRegistration = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.lblMonthHighest = new System.Windows.Forms.Label();
            this.lblMonthLowest = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStudentRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentRegistration
            // 
            this.dgvStudentRegistration.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStudentRegistration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudentRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentRegistration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMonth,
            this.colRegisteredStudents});
            this.dgvStudentRegistration.Location = new System.Drawing.Point(5, 50);
            this.dgvStudentRegistration.Name = "dgvStudentRegistration";
            this.dgvStudentRegistration.Size = new System.Drawing.Size(456, 282);
            this.dgvStudentRegistration.TabIndex = 1;
            this.dgvStudentRegistration.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentRegistration_CellContentClick);
            // 
            // colMonth
            // 
            this.colMonth.HeaderText = "Tháng";
            this.colMonth.Name = "colMonth";
            this.colMonth.Width = 200;
            // 
            // colRegisteredStudents
            // 
            this.colRegisteredStudents.HeaderText = "Số lượng sinh viên đăng ký";
            this.colRegisteredStudents.Name = "colRegisteredStudents";
            this.colRegisteredStudents.Width = 200;
            // 
            // chartStudentRegistration
            // 
            chartArea1.Name = "MainArea";
            this.chartStudentRegistration.ChartAreas.Add(chartArea1);
            this.chartStudentRegistration.Location = new System.Drawing.Point(5, 338);
            this.chartStudentRegistration.Name = "chartStudentRegistration";
            series1.ChartArea = "MainArea";
            series1.Name = "Số lượng đăng ký";
            this.chartStudentRegistration.Series.Add(series1);
            this.chartStudentRegistration.Size = new System.Drawing.Size(1007, 294);
            this.chartStudentRegistration.TabIndex = 2;
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
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTotalStudents.Location = new System.Drawing.Point(467, 66);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(249, 25);
            this.lblTotalStudents.TabIndex = 4;
            this.lblTotalStudents.Text = "Tổng số sinh viên đăng ký: 0";
            // 
            // lblMonthHighest
            // 
            this.lblMonthHighest.AutoSize = true;
            this.lblMonthHighest.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblMonthHighest.Location = new System.Drawing.Point(467, 149);
            this.lblMonthHighest.Name = "lblMonthHighest";
            this.lblMonthHighest.Size = new System.Drawing.Size(346, 25);
            this.lblMonthHighest.TabIndex = 5;
            this.lblMonthHighest.Text = "Tháng có nhiều sinh viên đăng ký nhất: ";
            // 
            // lblMonthLowest
            // 
            this.lblMonthLowest.AutoSize = true;
            this.lblMonthLowest.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblMonthLowest.Location = new System.Drawing.Point(467, 227);
            this.lblMonthLowest.Name = "lblMonthLowest";
            this.lblMonthLowest.Size = new System.Drawing.Size(309, 25);
            this.lblMonthLowest.TabIndex = 6;
            this.lblMonthLowest.Text = "Tháng có ít sinh viên đăng ký nhất: ";
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
            // FormSoLuongSVDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 630);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.dgvStudentRegistration);
            this.Controls.Add(this.chartStudentRegistration);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblTotalStudents);
            this.Controls.Add(this.lblMonthHighest);
            this.Controls.Add(this.lblMonthLowest);
            this.Name = "FormSoLuongSVDangKy";
            this.Text = "FormSoLuongSVDangKy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStudentRegistration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblYear;

        /// <summary>
        /// Load data based on selected year.
        /// </summary>
        /// <param name="year">Selected year</param>

    }
}
