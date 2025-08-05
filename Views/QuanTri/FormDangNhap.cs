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
using HeThongQuanLyKTX.ViewModels;

namespace HeThongQuanLyKTX
{
    public partial class FormDangNhap : Form
    {
        private TaiKhoanViewModel taiKhoanViewModel = new TaiKhoanViewModel();

        public FormDangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = taiKhoanViewModel.GetTaiKhoanByTenDangNhap(txtUsername.Text);

            if (taiKhoan == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản! Có thể do bạn không được cấp quyền truy cập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (taiKhoan.MatKhau != txtPassword.Text)
            {
                MessageBox.Show("Mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int maNV = taiKhoan.MANV;
                FormManHinhChinh dbs = new FormManHinhChinh(maNV);
                
                dbs.Show();
                this.Hide();

            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            FormQuenMatKhau forgotPasswordForm = new FormQuenMatKhau();
            forgotPasswordForm.ShowDialog(); // Hiển thị form "Quên mật khẩu" dưới dạng dialog
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}