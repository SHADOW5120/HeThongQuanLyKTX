using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HeThongQuanLyKTX.Models;
using HeThongQuanLyKTX.ViewModels;

namespace HeThongQuanLyKTX.Views
{
    public partial class FormLoaiPhong : Form
    {
        private List<LoaiPhong> danhSachLoaiPhong = new List<LoaiPhong>();
        private LoaiPhongViewModel loaiPhongViewModel = new LoaiPhongViewModel();

        public FormLoaiPhong()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitDanhSachLoaiPhong();
        }

        private void InitDanhSachLoaiPhong()
        {
            // Lấy danh sách loại phòng từ ViewModel
            danhSachLoaiPhong = loaiPhongViewModel.GetAllLoaiPhong();

            // Hiển thị danh sách loại phòng lên DataGridView
            dgvRoomTypes.DataSource = null;
            dgvRoomTypes.DataSource = danhSachLoaiPhong;
            dgvRoomTypes.Columns[0].HeaderText = "Mã Loại Phòng";
            dgvRoomTypes.Columns[1].HeaderText = "Diện Tích";
            dgvRoomTypes.Columns[2].HeaderText = "Số SV Tối Đa";
            dgvRoomTypes.Columns[3].HeaderText = "Tiền Loại Phòng";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormThemSuaLoaiPhong formDetails = new FormThemSuaLoaiPhong())
            {
                if (formDetails.ShowDialog() == DialogResult.OK)
                {
                    danhSachLoaiPhong.Add(formDetails.GetLoaiPhong());
                    loaiPhongViewModel.AddLoaiPhong(formDetails.GetLoaiPhong());
                    InitDanhSachLoaiPhong();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRoomTypes.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvRoomTypes.SelectedRows[0].Index;
                LoaiPhong selectedLoaiPhong = danhSachLoaiPhong[selectedIndex];

                using (FormThemSuaLoaiPhong formDetails = new FormThemSuaLoaiPhong(selectedLoaiPhong))
                {
                    if (formDetails.ShowDialog() == DialogResult.OK)
                    {
                        danhSachLoaiPhong[selectedIndex] = formDetails.GetLoaiPhong();
                        loaiPhongViewModel.UpdateLoaiPhong(selectedLoaiPhong);
                        InitDanhSachLoaiPhong();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRoomTypes.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvRoomTypes.SelectedRows[0].Index;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa loại phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    loaiPhongViewModel.DeleteLoaiPhong(danhSachLoaiPhong[selectedIndex].MaLP);
                    danhSachLoaiPhong.RemoveAt(selectedIndex);
                    InitDanhSachLoaiPhong();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            string filter = cmbSearchFilter.SelectedItem?.ToString();

            var filteredList = danhSachLoaiPhong.Where(lp =>
               filter == "Mã loại phòng" && lp.MaLP.ToString().ToLower().Contains(searchText)).ToList();

            dgvRoomTypes.DataSource = null;
            dgvRoomTypes.DataSource = filteredList;
        }

        private void dgvRoomTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}
