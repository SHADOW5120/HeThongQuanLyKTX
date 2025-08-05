using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using HeThongQuanLyKTX.Models;
using HeThongQuanLyKTX.ViewModels;

namespace HeThongQuanLyKTX.Views.BaoCaoThongKe
{
    public partial class FormSoLuongDVSuDung : Form
    {
        private readonly SoLuongDVViewModel _viewModel;

        public FormSoLuongDVSuDung()
        {
            InitializeComponent();
            _viewModel = new SoLuongDVViewModel();
        }

        private void LoadData(int year)
        {
            var servicesData = new Dictionary<string, List<int>>();
            var months = new[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6",
                                 "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };

            dgvServiceUsage.Rows.Clear();
            chartServiceUsage.Series.Clear();

            int totalUsage = 0, maxUsage = 0, minUsage = int.MaxValue;
            string mostUsedService = "", leastUsedService = "";

            for (int month = 1; month <= 12; month++)
            {
                List<SoLuongDVViewModel> serviceUsage = _viewModel.GetSoLuongDVByMonthYear(month, year);
                foreach (var usage in serviceUsage)
                {
                    if (!servicesData.ContainsKey(usage.TenDV))
                    {
                        servicesData[usage.TenDV] = new List<int>(new int[12]);
                    }

                    servicesData[usage.TenDV][month - 1] = usage.TongSoLuong;
                }
            }

            foreach (var service in servicesData)
            {
                var serviceName = service.Key;
                var serviceTotal = 0;
                var series = new Series(serviceName) { ChartType = SeriesChartType.Line };

                for (int month = 0; month < 12; month++)
                {
                    dgvServiceUsage.Rows.Add(serviceName, months[month], service.Value[month]);
                    serviceTotal += service.Value[month];
                    series.Points.AddXY(months[month], service.Value[month]);
                }

                chartServiceUsage.Series.Add(series);

                if (serviceTotal > maxUsage)
                {
                    maxUsage = serviceTotal;
                    mostUsedService = serviceName;
                }

                if (serviceTotal < minUsage)
                {
                    minUsage = serviceTotal;
                    leastUsedService = serviceName;
                }

                totalUsage += serviceTotal;
            }

            lblTotalServices.Text = $"Tổng số lần sử dụng: {totalUsage}";
            lblMostUsedService.Text = $"Dịch vụ được dùng nhiều nhất: {mostUsedService}";
            lblLeastUsedService.Text = $"Dịch vụ được dùng ít nhất: {leastUsedService}";
            if(servicesData.Count != 0)
            {
                lblAverageUsage.Text = $"Số lần sử dụng trung bình: {totalUsage / (servicesData.Count * 12)}";
            }
            else
            {
                lblAverageUsage.Text = "Số lần sử dụng trung bình: 0";
            }
            
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cmbYear.SelectedItem?.ToString(), out int year))
            {
                LoadData(year);
            }
        }

        private void dgvServiceUsage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý sự kiện click vào ô trong DataGridView nếu cần.
        }
    }
}
