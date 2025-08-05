using HeThongQuanLyKTX.Models;
using HeThongQuanLyKTX.ViewModels;
using HeThongQuanLyKTX.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKTX
{
    public partial class FormNguoiThan : Form
    {
        private List<NguoiThan> danhSachNguoiThan = new List<NguoiThan>();
        private NguoiThanViewModel nguoiThanViewModel = new NguoiThanViewModel();

        public FormNguoiThan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitDanhSachNguoiThan();
            this.cmbSearchFilter.Items.AddRange(new object[] {
           "Mã người thân",
            "Tên người thân",
            "Số điện thoại",
            "Địa chỉ",
            "Mã sinh viên"});
        }

        private void InitDanhSachNguoiThan()
        {
            // Lấy danh sách người thân từ ViewModel
            danhSachNguoiThan = nguoiThanViewModel.GetAllNguoiThan();

            // Hiển thị danh sách người thân lên DataGridView
            dgvNguoiThan.DataSource = null;
            dgvNguoiThan.DataSource = danhSachNguoiThan;
            dgvNguoiThan.Columns[0].HeaderText = "Mã Người Thân";
            dgvNguoiThan.Columns[1].HeaderText = "Tên Người Thân";
            dgvNguoiThan.Columns[2].HeaderText = "Số Điện Thoại";
            dgvNguoiThan.Columns[3].HeaderText = "Địa Chỉ";
            dgvNguoiThan.Columns[4].HeaderText = "Mã Sinh Viên";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormThemSuaNguoiThan formDetails = new FormThemSuaNguoiThan())
            {
                if (formDetails.ShowDialog() == DialogResult.OK)
                {
                    danhSachNguoiThan.Add(formDetails.GetNguoiThan());
                    nguoiThanViewModel.AddNguoiThan(formDetails.GetNguoiThan());
                    InitDanhSachNguoiThan();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNguoiThan.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvNguoiThan.SelectedRows[0].Index;
                NguoiThan selectedNguoiThan = danhSachNguoiThan[selectedIndex];

                using (FormThemSuaNguoiThan formDetails = new FormThemSuaNguoiThan(selectedNguoiThan))
                {
                    if (formDetails.ShowDialog() == DialogResult.OK)
                    {
                        danhSachNguoiThan[selectedIndex] = formDetails.GetNguoiThan();
                        nguoiThanViewModel.UpdateNguoiThan(selectedNguoiThan);
                        InitDanhSachNguoiThan();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người thân cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNguoiThan.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvNguoiThan.SelectedRows[0].Index;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa người thân này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nguoiThanViewModel.DeleteNguoiThan(danhSachNguoiThan[selectedIndex].MaNT);
                    danhSachNguoiThan.RemoveAt(selectedIndex);
                    InitDanhSachNguoiThan();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người thân cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            string filter = cmbSearchFilter.SelectedItem?.ToString();

            var filteredList = danhSachNguoiThan.Where(p =>
                (filter == "Mã người thân" && p.MaNT.ToString().Contains(searchText)) ||
                (filter == "Tên người thân" && p.TenNT.ToLower().Contains(searchText)) ||
                (filter == "Số điện thoại" && p.SdtNT.ToLower().Contains(searchText)) ||
                (filter == "Địa chỉ" && p.DiaChiNT.ToLower().Contains(searchText)) ||
                (filter == "Mã sinh viên" && p.MaSV.ToString().Contains(searchText))).ToList();

            dgvNguoiThan.DataSource = null;
            dgvNguoiThan.DataSource = filteredList;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
