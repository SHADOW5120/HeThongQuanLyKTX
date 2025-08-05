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
using HeThongQuanLyKTX.ViewModels;
using HeThongQuanLyKTX.Views;

namespace HeThongQuanLyKTX
{
    public partial class FormSinhVien : Form
    {
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        private SinhVienViewModel sinhVienViewModel = new SinhVienViewModel();
        private PhieuDangKyViewModel phieuDangKyViewModel = new PhieuDangKyViewModel();
        private int maPhong = 0;

        public FormSinhVien()
        {
            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitDanhSachSinhVien();
        }

        internal FormSinhVien(int maPhong) : this()
        {
            
            this.maPhong = maPhong;
            initDanhSachSinhVienByMaPhong(maPhong);
        }

        private void InitDanhSachSinhVien()
        {
            // Tạm thời thêm một số dữ liệu mẫu
            danhSachSinhVien = sinhVienViewModel.GetAllSinhVien();

            // Hiển thị danh sách phòng lên DataGridView
            dgvStudents.DataSource = null;
            
            dgvStudents.DataSource = danhSachSinhVien; dgvStudents.DataSource = danhSachSinhVien;
            dgvStudents.Columns[0].HeaderText = "Mã Sinh Viên";
            dgvStudents.Columns[1].HeaderText = "Tên Sinh Viên";
            dgvStudents.Columns[2].HeaderText = "Ngày Sinh";
            dgvStudents.Columns[3].HeaderText = "Giới tính";
            dgvStudents.Columns[4].HeaderText = "Số điện thoại";
            dgvStudents.Columns[5].HeaderText = "Quên quán";
            dgvStudents.Columns[6].HeaderText = "Email";

        }

        private void initDanhSachSinhVienByMaPhong(int maPhong)
        {
            danhSachSinhVien =  phieuDangKyViewModel.GetSinhVienByMaPhong(maPhong);

            // Hiển thị danh sách phòng lên DataGridView

            dgvStudents.DataSource = null;

            dgvStudents.DataSource = danhSachSinhVien;
            dgvStudents.DataSource = danhSachSinhVien; dgvStudents.DataSource = danhSachSinhVien;
            dgvStudents.Columns[0].HeaderText = "Mã Sinh Viên";
            dgvStudents.Columns[1].HeaderText = "Tên Sinh Viên";
            dgvStudents.Columns[2].HeaderText = "Ngày Sinh";
            dgvStudents.Columns[3].HeaderText = "Giới Tính";
            dgvStudents.Columns[4].HeaderText = "Số Điện Thoại";
            dgvStudents.Columns[5].HeaderText = "Quên Quán";
            dgvStudents.Columns[6].HeaderText = "Email";
        }

       

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            string filter = cmbSearchFilter.SelectedItem?.ToString();

            var filteredList = danhSachSinhVien.Where(p =>
                (filter == "Mã sinh viên" && p.MaSV.ToString().Contains(searchText)) ||
                (filter == "Ngày sinh" && p.NgaySinhSV.ToString("yyyy-MM-dd").Contains(searchText)) ||
                (filter == "Giới tính" && p.GioiTinhSV.ToString().ToLower().Contains(searchText)) ||
                (filter == "Số điện thoại" && p.SdtSV.ToString().ToLower().Contains(searchText)) ||
                (filter == "Quê quán" && p.QueQuanSV.ToString().ToLower().Contains(searchText)) ||
                (filter == "Tên sinh viên" && p.TenSV.ToString().ToLower().Contains(searchText)) ||
                (filter == "Email" && p.EmailSV.ToString().ToLower().Contains(searchText))).ToList();

            dgvStudents.DataSource = null;
            dgvStudents.DataSource = filteredList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormThemSuaSinhVien formDetails = new FormThemSuaSinhVien())
            {
                if (formDetails.ShowDialog() == DialogResult.OK)
                {
                    danhSachSinhVien.Add(formDetails.GetSinhVien());
                    sinhVienViewModel.AddSinhVien(formDetails.GetSinhVien());
                    if(maPhong != 0)
                    {
                        initDanhSachSinhVienByMaPhong(maPhong);
                    }
                    else
                    {
                        InitDanhSachSinhVien();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvStudents.SelectedRows[0].Index;
                SinhVien selectedSinhVien = danhSachSinhVien[selectedIndex];

                using (FormThemSuaSinhVien formDetails = new FormThemSuaSinhVien(selectedSinhVien))
                {
                    if (formDetails.ShowDialog() == DialogResult.OK)
                    {
                        danhSachSinhVien[selectedIndex] = formDetails.GetSinhVien();
                        sinhVienViewModel.UpdateSinhVien(selectedSinhVien);
                        if (maPhong != 0)
                        {
                            initDanhSachSinhVienByMaPhong(maPhong);
                        }
                        else
                        {
                            InitDanhSachSinhVien();
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
            if (dgvStudents.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvStudents.SelectedRows[0].Index;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    danhSachSinhVien.RemoveAt(selectedIndex);
                    sinhVienViewModel.DeleteSinhVien(danhSachSinhVien[selectedIndex].MaSV);
                    if (maPhong != 0)
                    {
                        initDanhSachSinhVienByMaPhong(maPhong);
                    }
                    else
                    {
                        InitDanhSachSinhVien();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
