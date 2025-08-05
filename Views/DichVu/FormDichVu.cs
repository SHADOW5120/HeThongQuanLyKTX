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
    public partial class FormDichVu : Form
    {
        private List<DichVu> danhSachDichVu = new List<DichVu>();
        private DichVuViewModel dichVuViewModel = new DichVuViewModel();

        public FormDichVu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitDanhSachDichVu();
        }

        private void InitDanhSachDichVu()
        {
            // Lấy danh sách dịch vụ từ ViewModel
            danhSachDichVu = dichVuViewModel.GetAllDichVu();

            // Hiển thị danh sách dịch vụ lên DataGridView
            dgvServices.DataSource = null;
            dgvServices.DataSource = danhSachDichVu;
            dgvServices.Columns[0].HeaderText = "Mã Dịch Vụ";
            dgvServices.Columns[1].HeaderText = "Tên Dịch Vụ";
            dgvServices.Columns[2].HeaderText = "Đơn Vị Tính";
            dgvServices.Columns[3].HeaderText = "Giá";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            string filter = cmbSearchFilter.SelectedItem?.ToString();

            var filteredList = danhSachDichVu.Where(dv =>
                (filter == "Mã dịch vụ" && dv.MaDV.ToString().Contains(searchText)) ||
                (filter == "Tên dịch vụ" && dv.TenDV.ToLower().Contains(searchText)) ||
                (filter == "Đơn vị" && dv.DonViDV.ToLower().Contains(searchText)) ||
                (filter == "Giá" && dv.GiaDV.ToString().Contains(searchText))).ToList();

            dgvServices.DataSource = null;
            dgvServices.DataSource = filteredList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormThemSuaDichVu formDetails = new FormThemSuaDichVu())
            {
                if (formDetails.ShowDialog() == DialogResult.OK)
                {
                    DichVu newDichVu = formDetails.GetDichVu();
                    danhSachDichVu.Add(newDichVu);
                    dichVuViewModel.AddDichVu(newDichVu);
                    InitDanhSachDichVu();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvServices.SelectedRows[0].Index;
                DichVu selectedDichVu = danhSachDichVu[selectedIndex];

                using (FormThemSuaDichVu formDetails = new FormThemSuaDichVu(selectedDichVu))
                {
                    if (formDetails.ShowDialog() == DialogResult.OK)
                    {
                        danhSachDichVu[selectedIndex] = formDetails.GetDichVu();
                        dichVuViewModel.UpdateDichVu(selectedDichVu);
                        InitDanhSachDichVu();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvServices.SelectedRows[0].Index;
                DichVu selectedDichVu = danhSachDichVu[selectedIndex];

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    danhSachDichVu.RemoveAt(selectedIndex);
                    dichVuViewModel.DeleteDichVu(selectedDichVu.MaDV);
                    InitDanhSachDichVu();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Xử lý khi người dùng click vào ô trong DataGridView
        }
    }
}
