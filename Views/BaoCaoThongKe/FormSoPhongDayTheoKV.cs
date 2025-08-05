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

namespace HeThongQuanLyKTX.Views.BaoCaoThongKe
{
    public partial class FormSoPhongDayTheoKV : Form
    {
        private readonly SoPhongDayTheoKVViewModel _viewModel;

        public FormSoPhongDayTheoKV()
        {
            InitializeComponent();
            _viewModel = new SoPhongDayTheoKVViewModel();
            LoadAreas();
            LoadData("Tất cả");
        }

        private void LoadAreas()
        {
            var areas = _viewModel.GetAllKhuVuc().Select(kv => kv.TenKV).ToList();
            areas.Insert(0, "Tất cả"); // Thêm "Tất cả" vào danh sách khu vực
            cmbArea.DataSource = areas;
        }

        private void LoadData(string area)
        {
            var data = _viewModel.GetFullRoomsByArea(area);

            dgvRoomStatistics.Rows.Clear();
            chartRoomStatistics.Series[0].Points.Clear();

            int totalFullRooms = 0;

            foreach (var entry in data)
            {
                dgvRoomStatistics.Rows.Add(entry.Key, entry.Value);
                chartRoomStatistics.Series[0].Points.AddXY(entry.Key, entry.Value);
                totalFullRooms += entry.Value;
            }

            lblTotalRooms.Text = $"Tổng số phòng đầy: {totalFullRooms}";
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedArea = cmbArea.SelectedItem?.ToString() ?? "Tất cả";
            LoadData(selectedArea);
        }

        private void dgvRoomStatistics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý logic khi click vào bảng nếu cần
        }

        
    }
}
