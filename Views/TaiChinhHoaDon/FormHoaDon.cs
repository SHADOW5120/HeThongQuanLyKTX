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
using HeThongQuanLyKTX.Models;

namespace HeThongQuanLyKTX.Views.TaiChinhHoaDon
{
    public partial class FormHoaDon : Form
    {
        private List<ThongTinHoaDon> danhSachHoaDon = new List<ThongTinHoaDon>();
        private ThongTinHoaDon thongTinHoaDon = new ThongTinHoaDon();
        private PhongViewModel phongViewModel = new PhongViewModel();
        private List<int> maPhong = new List<int>();
        

        public FormHoaDon()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitDanhSachHoaDon();
            List<Phong> dsMaPhong = phongViewModel.GetAllPhong();
            foreach(var value in dsMaPhong)
            {
                maPhong.Add(value.MaPhong);
            }
            cmbFilterByRoom.Items.AddRange(maPhong.Select(mp => mp.ToString()).ToArray());
        }

        private void InitDanhSachHoaDon()
        {
            // Tạm thời thêm một số dữ liệu mẫu
            danhSachHoaDon = thongTinHoaDon.GetDanhSachHoaDon();

            // Hiển thị danh sách phòng lên DataGridView
            dgvInvoiceList.DataSource = null;
            dgvInvoiceList.DataSource = danhSachHoaDon;
            dgvInvoiceList.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvInvoiceList.Columns[1].HeaderText = "Dịch Vụ (Số lượng)";
            dgvInvoiceList.Columns[2].HeaderText = "Tổng Tiền";
            dgvInvoiceList.Columns[3].HeaderText = "Thời Gian";
            dgvInvoiceList.Columns[4].HeaderText = "Trạng Thái";
            dgvInvoiceList.Columns[5].HeaderText = "Mã Nhân Viên Xử Lý";
            dgvInvoiceList.Columns[6].HeaderText = "Mã Phòng";
        }

        private void dgvInvoiceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddHD_Click(object sender, EventArgs e)
        {
            FormThemSuaHoaDon formThemSuaHoaDon = new FormThemSuaHoaDon();
            formThemSuaHoaDon.ShowDialog();
            InitDanhSachHoaDon();
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            
            // Kiểm tra nếu người dùng đã chọn một hóa đơn trong DataGridView
            if (dgvInvoiceList.SelectedRows.Count > 0)
            {
                // Lấy MaHD của hóa đơn được chọn từ DataGridView
                int selectedMaHD = Convert.ToInt32(dgvInvoiceList.SelectedRows[0].Cells["MaHD"].Value);

                // Hiển thị hộp thoại xác nhận
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Xóa hóa đơn
                    bool isDeleted = thongTinHoaDon.DeleteHoaDon(selectedMaHD);

                    if (isDeleted)
                    {
                        MessageBox.Show("Hóa đơn đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InitDanhSachHoaDon(); // Cập nhật lại danh sách hóa đơn
                    }
                    else
                    {
                        MessageBox.Show("Xóa hóa đơn không thành công. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            string selectedRoom = cmbFilterByRoom.SelectedItem?.ToString();
            DateTime? selectedDate = dtpFilterByDate.Value;

            // Lọc danh sách hóa đơn theo tiêu chí
            var filteredList = danhSachHoaDon.Where(hoaDon =>
                (string.IsNullOrEmpty(searchText) ||
                    hoaDon.MaHD.ToString().Contains(searchText) ||
                    hoaDon.DanhSachDVSoLuong.ToLower().Contains(searchText) ||
                    hoaDon.TrangThaiHD.ToLower().Contains(searchText) ||
                    hoaDon.MaPhong.ToString().Contains(searchText)) &&
                (string.IsNullOrEmpty(selectedRoom) || hoaDon.MaPhong.ToString() == selectedRoom)).ToList();

            // Cập nhật DataGridView với danh sách đã lọc
            dgvInvoiceList.DataSource = null;
            dgvInvoiceList.DataSource = filteredList;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbFilterByRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFilterByDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            // Thiết lập để cột tự động điều chỉnh chiều rộng để chiếm hết không gian trong dgv
            dgvInvoiceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
