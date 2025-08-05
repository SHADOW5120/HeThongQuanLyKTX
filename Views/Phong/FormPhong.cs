using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HeThongQuanLyKTX.Views;
using HeThongQuanLyKTX.Models;
using HeThongQuanLyKTX.ViewModels;

namespace HeThongQuanLyKTX
{
    public partial class FormPhong : Form
    {
        private List<ThongTinPhongViewModel> danhSachPhong = new List<ThongTinPhongViewModel>();
        private ThongTinPhongViewModel thongTinPhongViewModel = new ThongTinPhongViewModel();
        private PhongViewModel phongViewModel = new PhongViewModel();
        private int maKV = 0;

        public FormPhong()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitDanhSachPhong();
        }

        internal FormPhong(int maKV) : this()
        {
            this.maKV = maKV;
            initDanhSachPhongByKhuVuc(maKV);
        }

        private void cmbSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Your logic here
        }

        private void InitDanhSachPhong()
        {
            // Tạm thời thêm một số dữ liệu mẫu
            danhSachPhong = thongTinPhongViewModel.GetAllRooms();

            // Hiển thị danh sách phòng lên DataGridView
            dgvRooms.DataSource = null;
            dgvRooms.DataSource = danhSachPhong;
            dgvRooms.Columns[0].HeaderText = "Mã Phòng";
            dgvRooms.Columns[1].HeaderText = "Số SV Hiện Tại";
            dgvRooms.Columns[2].HeaderText = "Tình Trạng Phòng";
            dgvRooms.Columns[3].HeaderText = "Loại Phòng";
            dgvRooms.Columns[4].HeaderText = "Khu Vực";
            dgvRooms.Columns[5].HeaderText = "Số SV Tối Đa";
        }

        private void initDanhSachPhongByKhuVuc(int maKV)
        {
            danhSachPhong = thongTinPhongViewModel.GetAllRoomsByMaKV(maKV);

            // Hiển thị danh sách phòng lên DataGridView
            dgvRooms.DataSource = null;
            dgvRooms.DataSource = danhSachPhong;
            dgvRooms.Columns[0].HeaderText = "Mã Phòng";
            dgvRooms.Columns[1].HeaderText = "Số SV Hiện Tại";
            dgvRooms.Columns[2].HeaderText = "Tình Trạng Phòng";
            dgvRooms.Columns[3].HeaderText = "Loại Phòng";
            dgvRooms.Columns[4].HeaderText = "Khu Vực";
            dgvRooms.Columns[5].HeaderText = "Số SV Tối Đa";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormThemSuaPhong formDetails = new FormThemSuaPhong())
            {
                if (formDetails.ShowDialog() == DialogResult.OK)
                {
                    phongViewModel.AddPhong(formDetails.GetPhong());
                    if(maKV != 0)
                    {
                        initDanhSachPhongByKhuVuc(maKV);
                    }
                    else
                    {
                        InitDanhSachPhong();
                    }
                    
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvRooms.SelectedRows[0].Index;
                //ThongTinPhongViewModel selectedPhong = danhSachPhong[selectedIndex];
                Phong selectedPhong = phongViewModel.GetPhongByMaPhong(danhSachPhong[selectedIndex].MaPhong);

                using (FormThemSuaPhong formDetails = new FormThemSuaPhong(selectedPhong))
                {
                    if (formDetails.ShowDialog() == DialogResult.OK)
                    {
                        phongViewModel.UpdatePhong(formDetails.GetPhong());
                        if (maKV != 0)
                        {
                            initDanhSachPhongByKhuVuc(maKV);
                        }
                        else
                        {
                            InitDanhSachPhong();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvRooms.SelectedRows[0].Index;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    phongViewModel.DeletePhong(danhSachPhong[selectedIndex].MaPhong);
                    if (maKV != 0)
                    {
                        initDanhSachPhongByKhuVuc(maKV);
                    }
                    else
                    {
                        InitDanhSachPhong();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            string filter = cmbSearchFilter.SelectedItem?.ToString();

            var filteredList = danhSachPhong.Where(p =>
                (filter == "Mã phòng" && p.MaPhong.ToString().Contains(searchText)) ||
                (filter == "Tình trạng" && p.TinhTrangPhong.ToLower().Contains(searchText)) ||
                (filter == "Loại phòng" && p.MaLP.ToString().ToLower().Contains(searchText)) ||
                (filter == "Khu vực" && p.TenKV.ToString().ToLower().Contains(searchText))).ToList();

            dgvRooms.DataSource = null;
            dgvRooms.DataSource = filteredList;
        }

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bạn có thể thêm các hành động khi click vào một cell cụ thể
            if (e.RowIndex >= 0) // Kiểm tra nếu hàng được nhấn là hợp lệ
            {
                // Lấy hàng được click
                DataGridViewRow selectedRow = dgvRooms.Rows[e.RowIndex];

                // Lấy thông tin của hàng
                int maPhong = int.Parse(selectedRow.Cells["MaPhong"].Value.ToString());
                

                FormSinhVien formSinhVien = new FormSinhVien(maPhong);
                formSinhVien.ShowDialog();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }

   

  

  
}
