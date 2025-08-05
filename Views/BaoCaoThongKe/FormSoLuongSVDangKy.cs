using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using HeThongQuanLyKTX.ViewModels;

namespace HeThongQuanLyKTX.Views.BaoCaoThongKe
{
    public partial class FormSoLuongSVDangKy : Form
    {
        private readonly PhieuDangKyViewModel _viewModel;

        public FormSoLuongSVDangKy()
        {
            InitializeComponent();
            _viewModel = new PhieuDangKyViewModel();
        }

        private void LoadData(int year)
        {
            var months = new[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6",
                                 "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };

            dgvStudentRegistration.Rows.Clear();
            chartStudentRegistration.Series[0].Points.Clear();

            var registrationData = new int[12];
            var phieuDangKys = _viewModel.GetAllPhieuDangKy()
                .Where(pdk => pdk.NgayDangKy.Year == year)
                .ToList();

            // Tính số lượng sinh viên đăng ký theo từng tháng
            foreach (var pdk in phieuDangKys)
            {
                registrationData[pdk.NgayDangKy.Month - 1]++;
            }

            int totalRegistration = registrationData.Sum();
            int maxRegistration = registrationData.Max();
            int minRegistration = registrationData.Min();
            string monthHighest = months[Array.IndexOf(registrationData, maxRegistration)];
            string monthLowest = months[Array.IndexOf(registrationData, minRegistration)];

            for (int i = 0; i < months.Length; i++)
            {
                dgvStudentRegistration.Rows.Add(months[i], registrationData[i]);
                chartStudentRegistration.Series[0].Points.AddXY(months[i], registrationData[i]);
            }

            lblTotalStudents.Text = $"Tổng số sinh viên đăng ký: {totalRegistration}";
            lblMonthHighest.Text = $"Tháng có nhiều sinh viên đăng ký nhất: {monthHighest}";
            lblMonthLowest.Text = $"Tháng có ít sinh viên đăng ký nhất: {monthLowest}";
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cmbYear.SelectedItem?.ToString(), out int year))
            {
                LoadData(year);
            }
        }

        private void dgvStudentRegistration_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý sự kiện click vào ô trong DataGridView nếu cần.
        }
    }
}
