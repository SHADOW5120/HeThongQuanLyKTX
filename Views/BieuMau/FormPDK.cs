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

namespace HeThongQuanLyKTX.Views.BieuMau
{
    public partial class FormPDK : Form
    {
        private List<PhieuDangKy> danhSachPhieuDangKy = new List<PhieuDangKy>();
        private PhieuDangKyViewModel phieuDangKyViewModel = new PhieuDangKyViewModel();

        public FormPDK()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitDanhSachPhieuDangKy();
            this.cmbStudent.Items.AddRange(new object[] {
            "Mã phiếu",
            "Ngày đăng ký",
            "Trạng thái",
            "Mã nhân viên",
            "Mã phòng",
            "Mã sinh viên"});
        }

        private void InitDanhSachPhieuDangKy()
        {
            danhSachPhieuDangKy = phieuDangKyViewModel.GetAllPhieuDangKy();
            dgvRegistration.DataSource = null;
            dgvRegistration.DataSource = danhSachPhieuDangKy;
            dgvRegistration.Columns[0].HeaderText = "Mã Phiếu";
            dgvRegistration.Columns[1].HeaderText = "Ngày Đăng Ký";
            dgvRegistration.Columns[2].HeaderText = "Trạng Thái";
            dgvRegistration.Columns[3].HeaderText = "Mã Nhân Viên xử lý";
            dgvRegistration.Columns[4].HeaderText = "Mã Phòng";
            dgvRegistration.Columns[5].HeaderText = "Mã Sinh Viên Đăng Ký";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            string filter = cmbStudent.SelectedItem?.ToString();
            //DateTime? fromDate = dtpFromDate.Value;
            //DateTime? toDate = dtpToDate.Value;

            var filteredList = danhSachPhieuDangKy.Where(p =>
                ((filter == "Mã phiếu" && p.MaPhieu.ToString().Contains(searchText)) ||
                 (filter == "Ngày đăng ký" && p.NgayDangKy.ToString("yyyy-MM-dd").Contains(searchText)) ||
                 (filter == "Trạng thái" && p.TrangThaiPDK.ToString().ToLower().Contains(searchText)) ||
                 (filter == "Mã nhân viên" && p.MANV.ToString().Contains(searchText)) ||
                 (filter == "Mã phòng" && p.MaPhong.ToString().Contains(searchText)) ||
                 (filter == "Mã sinh viên" && p.MaSV.ToString().Contains(searchText)))
            ).ToList();

            dgvRegistration.DataSource = null;
            dgvRegistration.DataSource = filteredList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormTaoPDK formDetails = new FormTaoPDK())
            {
                if (formDetails.ShowDialog() == DialogResult.OK)
                {
                    danhSachPhieuDangKy.Add(formDetails.GetPhieuDangKy());
                    phieuDangKyViewModel.AddPhieuDangKy(formDetails.GetPhieuDangKy());
                    InitDanhSachPhieuDangKy();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRegistration.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvRegistration.SelectedRows[0].Index;
                PhieuDangKy selectedPhieuDangKy = danhSachPhieuDangKy[selectedIndex];

                using (FormTaoPDK formDetails = new FormTaoPDK(selectedPhieuDangKy))
                {
                    if (formDetails.ShowDialog() == DialogResult.OK)
                    {
                        danhSachPhieuDangKy[selectedIndex] = formDetails.GetPhieuDangKy();
                        phieuDangKyViewModel.UpdatePhieuDangKy(selectedPhieuDangKy);
                        InitDanhSachPhieuDangKy();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRegistration.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvRegistration.SelectedRows[0].Index;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    danhSachPhieuDangKy.RemoveAt(selectedIndex);
                    phieuDangKyViewModel.DeletePhieuDangKy(danhSachPhieuDangKy[selectedIndex].MaPhieu);
                    InitDanhSachPhieuDangKy();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvRegistration_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional logic for cell content click
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
