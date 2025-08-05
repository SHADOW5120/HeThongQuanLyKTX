using System;
using System.Linq;
using System.Windows.Forms;
using HeThongQuanLyKTX.ViewModels;

namespace HeThongQuanLyKTX.Views.BaoCaoThongKe
{
    public partial class FormSoPhongTrongTheoKV : Form
    {
        private readonly SoPhongTrongTheoKVViewModel _viewModel;

        public FormSoPhongTrongTheoKV()
        {
            InitializeComponent();
            _viewModel = new SoPhongTrongTheoKVViewModel();
            LoadAreaFilter();
            LoadData("Tất cả");
        }

        // Nạp danh sách khu vực vào ComboBox
        private void LoadAreaFilter()
        {
            var areas = _viewModel.GetAllKhuVuc().Select(kv => kv.TenKV).ToList();
            areas.Insert(0, "Tất cả"); // Thêm mục "Tất cả" vào đầu danh sách
            cmbAreaFilter.DataSource = areas;
        }

        // Nạp dữ liệu phòng trống
        private void LoadData(string selectedArea)
        {
            var data = _viewModel.GetEmptyRoomsByArea(selectedArea);

            dgvEmptyRooms.Rows.Clear();
            chartEmptyRooms.Series[0].Points.Clear();

            int totalEmptyRooms = 0;

            foreach (var entry in data)
            {
                dgvEmptyRooms.Rows.Add(entry.Key, entry.Value); // Thêm dữ liệu vào DataGridView
                chartEmptyRooms.Series[0].Points.AddXY(entry.Key, entry.Value); // Thêm dữ liệu vào biểu đồ
                totalEmptyRooms += entry.Value;
            }

            lblTotalEmptyRooms.Text = $"Tổng số phòng trống: {totalEmptyRooms}"; // Hiển thị tổng số phòng
        }

        // Sự kiện khi thay đổi bộ lọc khu vực
        private void cmbAreaFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedArea = cmbAreaFilter.SelectedItem?.ToString() ?? "Tất cả";
            LoadData(selectedArea);
        }

        private void dgvEmptyRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý sự kiện khi click vào bảng nếu cần thiết
        }
    }
}
