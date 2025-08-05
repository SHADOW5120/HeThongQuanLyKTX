using HeThongQuanLyKTX.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKTX.Views.BieuMau
{
    public partial class FormTaoPDK : Form
    {
        private PhieuDangKy phieuDangKy { get; set; }

        public FormTaoPDK()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        internal FormTaoPDK(PhieuDangKy phieuDangKy) : this()
        {
            txtMaPhieu.Text = phieuDangKy.MaPhieu.ToString();
            dtpNgayDangKy.Value = phieuDangKy.NgayDangKy;
            cboTrangThaiPDK.SelectedItem = phieuDangKy.TrangThaiPDK;
            txtMaNV.Text = phieuDangKy.MANV.ToString();
            txtMaPhong.Text = phieuDangKy.MaPhong.ToString();
            txtMaSV.Text = phieuDangKy.MaSV.ToString();
        }

        internal PhieuDangKy GetPhieuDangKy()
        {
            return phieuDangKy;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhieu = int.Parse(txtMaPhieu.Text);
                DateTime ngayDangKy = dtpNgayDangKy.Value;
                string trangThaiPDK = cboTrangThaiPDK.SelectedItem.ToString();
                int maNV = int.Parse(txtMaNV.Text);
                int maPhong = int.Parse(txtMaPhong.Text);
                int maSV = int.Parse(txtMaSV.Text);

                phieuDangKy = new PhieuDangKy(maPhieu, ngayDangKy, trangThaiPDK, maNV, maPhong, maSV);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
