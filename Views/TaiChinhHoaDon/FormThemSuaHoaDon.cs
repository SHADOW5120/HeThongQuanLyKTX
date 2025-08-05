using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HeThongQuanLyKTX.Models;
using HeThongQuanLyKTX.ViewModels;

namespace HeThongQuanLyKTX.Views.TaiChinhHoaDon
{
    public partial class FormThemSuaHoaDon : Form
    {
        private readonly HoaDonViewModel _hoaDonViewModel;
        private readonly DichVuViewModel _dichVuViewModel;
        private readonly HoaDonDichVuViewModel _hoaDonDichVuViewModel;

        public FormThemSuaHoaDon()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _hoaDonViewModel = new HoaDonViewModel();
            _dichVuViewModel = new DichVuViewModel();
            _hoaDonDichVuViewModel = new HoaDonDichVuViewModel();
            LoadDichVuData();
        }

        private void LoadDichVuData()
        {
            var danhSachDichVu = _dichVuViewModel.GetAllDichVu();
            dgvDichVu.Rows.Clear();
            comboBoxDV.Items.Clear();

            // Thêm dịch vụ vào ComboBox
            foreach (var dichVu in danhSachDichVu)
            {
                comboBoxDV.Items.Add(new { Name = dichVu.TenDV, Value = dichVu.MaDV });
            }

            comboBoxDV.DisplayMember = "Name";
            comboBoxDV.ValueMember = "Value";
            comboBoxDV.SelectedIndex = -1; // Đặt mặc định là không chọn gì
        }

        private void comboBoxDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dịch vụ hay chưa
            if (comboBoxDV.SelectedIndex == -1) return; // Nếu chưa chọn dịch vụ thì không làm gì cả

            // Lấy dịch vụ được chọn
            var selectedService = (dynamic)comboBoxDV.SelectedItem;
            int maDichVu = selectedService.Value;
            string tenDichVu = selectedService.Name;
            decimal giaDichVu = _dichVuViewModel.GetGiaDichVuById(maDichVu);

            //// Cập nhật giá trị vào DataGridView cho dòng mới
            //dgvDichVu.Rows.Add(maDichVu, tenDichVu, giaDichVu, 1, giaDichVu);  // Lưu ý: số lượng mặc định là 1 và tính thành tiền tương ứng.
        }

        private void dgvDichVu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Chỉ cập nhật Thành Tiền khi thay đổi số lượng
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDichVu.Columns["colSoLuong"].Index)
            {
                UpdateThanhTien(e.RowIndex);
            }
        }

        private void UpdateThanhTien(int rowIndex)
        {
            try
            {
                var row = dgvDichVu.Rows[rowIndex];
                int giaDichVu = Convert.ToInt32(row.Cells["colGiaDV"].Value);
                int soLuong = Convert.ToInt32(row.Cells["colSoLuong"].Value);
                row.Cells["colThanhTien"].Value = giaDichVu * soLuong;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính Thành Tiền: " + ex.Message);
            }
        }

        private void btnAddDV_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn dịch vụ chưa
                if (comboBoxDV.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ trước!");
                    return;
                }

                var selectedService = (dynamic)comboBoxDV.SelectedItem;
                int maDichVu = selectedService.Value;
                string tenDichVu = selectedService.Name;
                decimal giaDichVu = _dichVuViewModel.GetGiaDichVuById(maDichVu);

                // Kiểm tra nếu dịch vụ đã tồn tại trong DataGridView
                foreach (DataGridViewRow row in dgvDichVu.Rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua dòng mới

                    int existingMaDichVu = Convert.ToInt32(row.Cells["colMaDV"].Value);
                    if (existingMaDichVu == maDichVu)
                    {
                        MessageBox.Show("Dịch vụ này đã được thêm rồi!", "Thông báo");
                        return; // Nếu đã tồn tại, không thêm dịch vụ nữa
                    }
                }

                // Kiểm tra số lượng người dùng nhập vào
                int soLuong = (int)numericUpDown1.Value;

                // Thêm dịch vụ vào DataGridView
                dgvDichVu.Rows.Add(maDichVu, tenDichVu, giaDichVu, soLuong, giaDichVu * soLuong);  // Lưu ý: tính thành tiền ngay từ đầu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dịch vụ: " + ex.Message);
            }
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng hóa đơn
                var hoaDon = new HoaDon
                {
                    MaHD = string.IsNullOrWhiteSpace(txtMaHD.Text) ? 0 : Convert.ToInt32(txtMaHD.Text),
                    ThoiGianHD = dtpThoiGianHD.Value,
                    TrangThaiHD = cmbTrangThaiHD.SelectedItem?.ToString(),
                    MANV = Convert.ToInt32(txtMANV.Text),
                    MaPhong = Convert.ToInt32(txtMaPhong.Text)
                };

                // Lưu hóa đơn vào cơ sở dữ liệu
                _hoaDonViewModel.AddHoaDon(hoaDon);

                // Sau khi lưu hóa đơn, lấy MaHD mới được tạo
                int maHD = hoaDon.MaHD;

                List<HoaDonDichVu> danhSachDichVu = new List<HoaDonDichVu>();

                // Thêm các dịch vụ vào danh sách HoaDonDichVu
                foreach (DataGridViewRow row in dgvDichVu.Rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua dòng mới

                    var hoaDonDichVu = new HoaDonDichVu
                    {
                        MaHD = maHD, // Sử dụng MaHD đã được tạo từ hóa đơn
                        MaDV = Convert.ToInt32(row.Cells["colMaDV"].Value),
                        SoLuongDV = Convert.ToInt32(row.Cells["colSoLuong"].Value),
                        TienDV = Convert.ToInt32(row.Cells["colThanhTien"].Value)
                    };

                    danhSachDichVu.Add(hoaDonDichVu);
                }

                // Thêm các dịch vụ vào bảng hoadon_dichvu
                foreach (var hoaDonDichVu in danhSachDichVu)
                {
                    _hoaDonDichVuViewModel.AddHoaDonDichVu(hoaDonDichVu);
                }

                MessageBox.Show("Lưu hóa đơn thành công!", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu hóa đơn: " + ex.Message);
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
