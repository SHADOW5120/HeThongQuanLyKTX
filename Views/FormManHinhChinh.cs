using HeThongQuanLyKTX.Models;
using HeThongQuanLyKTX.Views;
using HeThongQuanLyKTX.Views.BaoCaoThongKe;
using HeThongQuanLyKTX.Views.BieuMau;
using HeThongQuanLyKTX.Views.TaiChinhHoaDon;
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
    public partial class FormManHinhChinh : Form
    {
        private int maNV;

        public FormManHinhChinh()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        internal FormManHinhChinh(int maNV) : this()
        {
            this.maNV = maNV;
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            FormPhong formPhong = new FormPhong();
            this.Hide();
            formPhong.ShowDialog();
            this.Show();
        }

        private void btnDSSinhVien_Click(object sender, EventArgs e)
        {
            FormSinhVien formSinhVien = new FormSinhVien();
            this.Hide();
            formSinhVien.ShowDialog();
            this.Show();
        }

        private void btnDSNguoiThan_Click(object sender, EventArgs e)
        {
            FormNguoiThan formNguoiThan = new FormNguoiThan();
            this.Hide();
            formNguoiThan.ShowDialog();
            this.Show();
        }

        private void btnDSKhu_Click(object sender, EventArgs e)
        {
            FormKhuVuc formKhu = new FormKhuVuc();
            this.Hide();
            formKhu.ShowDialog();
            this.Show();
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            FormLoaiPhong formLoaiPhong = new FormLoaiPhong();
            this.Hide();
            formLoaiPhong.ShowDialog();
            this.Show();
        }



        private void btnDichVu_Click(object sender, EventArgs e)
        {
            FormDichVu formDichVu = new FormDichVu();
            this.Hide();
            formDichVu.ShowDialog();
            this.Show();
        }

        private void btnBieuMau_Click(object sender, EventArgs e)
        {
            FormPDK formPDK = new FormPDK();
            this.Hide();
            formPDK.ShowDialog();
            this.Show();
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            FormBaoCaoThongke formBaoCaoThongke = new FormBaoCaoThongke();
            this.Hide();
            formBaoCaoThongke.ShowDialog();
            this.Show();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormNhanVien formNhanVien = new FormNhanVien(maNV);
            this.Hide();
            formNhanVien.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            this.Hide();
            formDangNhap.Show();
            this.Close();
        }

        private void btnTaiChinhHoaDon_Click(object sender, EventArgs e)
        {
            FormHoaDon formHoaDon = new FormHoaDon();
            this.Hide();
            formHoaDon.ShowDialog();
            this.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        //protected override void OnFormClosed(FormClosedEventArgs e)
        //{
        //    base.OnFormClosed(e);
        //    Application.Exit(); // Đóng toàn bộ ứng dụng
        //}

    }
}
