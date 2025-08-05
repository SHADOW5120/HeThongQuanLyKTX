using HeThongQuanLyKTX.ViewModels;
using HeThongQuanLyKTX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HeThongQuanLyKTX.Views.BaoCaoThongKe
{
    public partial class FormSoluongSVTheoKV : Form
    {
        private readonly KhuVucViewModel _khuVucViewModel;
        private readonly PhieuDangKyViewModel _phieuDangKyViewModel;

        public FormSoluongSVTheoKV()
        {
            InitializeComponent();
            _khuVucViewModel = new KhuVucViewModel();
            _phieuDangKyViewModel = new PhieuDangKyViewModel();
        }

        private void LoadData(int year)
        {
            // Lấy danh sách khu vực từ ViewModel
            var khuVucList = _khuVucViewModel.GetAllKhuVuc();
            var phieuDangKyList = _phieuDangKyViewModel.GetAllPhieuDangKy()
                .Where(pdk => pdk.NgayDangKy.Year == year)
                .ToList();

            dgvSoLuongSV.Rows.Clear();
            chartSoLuongSV.Series.Clear();

            int totalStudents = 0;
            string highestRegion = "";
            string lowestRegion = "";
            int highestCount = 0;
            int lowestCount = int.MaxValue;

            foreach (var khuVuc in khuVucList)
            {
                var sinhVienCountPerMonth = new int[12];

                foreach (var pdk in phieuDangKyList)
                {
                    if (pdk.MaPhong == khuVuc.MaKV) // Giả định mã phòng liên kết với mã khu vực
                    {
                        sinhVienCountPerMonth[pdk.NgayDangKy.Month - 1]++;
                    }
                }

                int regionTotal = sinhVienCountPerMonth.Sum();
                totalStudents += regionTotal;

                if (regionTotal > highestCount)
                {
                    highestCount = regionTotal;
                    highestRegion = khuVuc.TenKV;
                }

                if (regionTotal < lowestCount)
                {
                    lowestCount = regionTotal;
                    lowestRegion = khuVuc.TenKV;
                }

                // Cập nhật bảng
                for (int i = 0; i < 12; i++)
                {
                    dgvSoLuongSV.Rows.Add(khuVuc.TenKV, $"Tháng {i + 1}", sinhVienCountPerMonth[i]);
                }

                // Cập nhật biểu đồ
                var series = new Series(khuVuc.TenKV)
                {
                    ChartType = SeriesChartType.Line
                };

                for (int i = 0; i < 12; i++)
                {
                    series.Points.AddXY($"Tháng {i + 1}", sinhVienCountPerMonth[i]);
                }

                chartSoLuongSV.Series.Add(series);
            }

            int averageStudents = totalStudents / (khuVucList.Count * 12);

            lblTotalStudents.Text = $"Tổng số SV: {totalStudents} người";
            lblHighestRegion.Text = $"Khu vực có SV nhiều nhất: {highestRegion}";
            lblLowestRegion.Text = $"Khu vực có SV ít nhất: {lowestRegion}";
            lblAverageStudents.Text = $"Số SV trung bình: {averageStudents} người";
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cmbYear.SelectedItem.ToString(), out int selectedYear))
            {
                LoadData(selectedYear);
            }
        }
    }
}
