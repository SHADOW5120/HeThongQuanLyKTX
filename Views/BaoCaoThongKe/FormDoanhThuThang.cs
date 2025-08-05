using HeThongQuanLyKTX.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HeThongQuanLyKTX.Views.BaoCaoThongKe
{
    public partial class FormDoanhThuThang : Form
    {
        private List<ThongTinHoaDon> thongTinHoaDons = new List<ThongTinHoaDon>();

        public FormDoanhThuThang()
        {
            InitializeComponent();
        }

        private void dgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDoanhThuThang_Load(object sender, EventArgs e)
        {
            // Default year
            int year = 2024;
            cmbYear.SelectedItem = year.ToString();

            // Load data for the default year
            LoadData(year);
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedYear = int.Parse(cmbYear.SelectedItem.ToString());
            LoadData(selectedYear);
        }

        private void LoadData(int year)
        {
            var months = new string[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };
            double[] revenues = new double[12]; // Initialize all months with 0 revenue

            // Fetch data from the database
            ThongTinHoaDon thongTinHoaDon = new ThongTinHoaDon();
            List<ThongTinHoaDon> danhSachHoaDon = thongTinHoaDon.GetDanhSachHoaDon();

            // Process data
            foreach (var hoaDon in danhSachHoaDon)
            {
                if (hoaDon.ThoiGianHD.Year == year)
                {
                    int monthIndex = hoaDon.ThoiGianHD.Month - 1; // Month is 1-based, array is 0-based
                    revenues[monthIndex] += hoaDon.TongTienDV;
                }
            }

            // Populate DataGridView
            dgvDoanhThu.Rows.Clear();
            double totalRevenue = 0;
            double highestRevenue = 0;
            double lowestRevenue = double.MaxValue;
            int highestMonthIndex = 0;
            int lowestMonthIndex = 0;

            for (int i = 0; i < 12; i++)
            {
                dgvDoanhThu.Rows.Add(months[i], revenues[i]);
                totalRevenue += revenues[i];

                if (revenues[i] > highestRevenue)
                {
                    highestRevenue = revenues[i];
                    highestMonthIndex = i;
                }

                if (revenues[i] < lowestRevenue)
                {
                    lowestRevenue = revenues[i];
                    lowestMonthIndex = i;
                }
            }

            // Calculate Average Revenue
            double averageRevenue = totalRevenue / 12;

            // Update statistics
            lblTotalRevenue.Text = $"Tổng doanh thu: {totalRevenue:N0} VNĐ";
            lblHighestMonth.Text = $"Tháng doanh thu cao nhất: {months[highestMonthIndex]} - {highestRevenue:N0} VNĐ";
            lblLowestMonth.Text = $"Tháng doanh thu thấp nhất: {months[lowestMonthIndex]} - {lowestRevenue:N0} VNĐ";
            lblAverageRevenue.Text = $"Doanh thu trung bình: {averageRevenue:N0} VNĐ";

            // Update Chart
            chartDoanhThu.Series[0].Points.Clear();
            for (int i = 0; i < 12; i++)
            {
                chartDoanhThu.Series[0].Points.AddXY(months[i], revenues[i]);
            }
        }

    }
}
