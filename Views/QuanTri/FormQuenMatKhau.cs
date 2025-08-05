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
using HeThongQuanLyKTX.Services.QuenMK;
using HeThongQuanLyKTX.ViewModels;
using HeThongQuanLyKTX.Views;

namespace HeThongQuanLyKTX
{
    public partial class FormQuenMatKhau : Form
    {
        private OtpManager otpManager = new OtpManager();
        private SendOTP sendOTP = new SendOTP();
        private NhanVienViewModel nhanVienViewModel = new NhanVienViewModel();
        private TaiKhoanViewModel taiKhoanViewModel = new TaiKhoanViewModel();
        private int maNV;

        public FormQuenMatKhau()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            string email = txtEmail.Text;
            NhanVien nhanVien = nhanVienViewModel.GetNhanVienByEmailNV(email);
            // Lấy email từ người dùng
            if (nhanVien != null)  // Kiểm tra email tồn tại trong cơ sở dữ liệu
            {
                this.maNV = nhanVien.MaNV;
                string otp = otpManager.GenerateOtp();  // Tạo OTP
                sendOTP.SendOtpEmail(email, otp);  // Gửi OTP qua email
                otpManager.SaveOtp(email, otp);  // Lưu OTP vào bộ nhớ

                MessageBox.Show("Mã OTP đã được gửi đến email của bạn.");
            }
            else
            {
                MessageBox.Show("Email không tồn tại trong hệ thống.");
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string otp = txtOTP.Text;  // Lấy OTP người dùng nhập vào

            if (otpManager.VerifyOtp(email, otp))  // Kiểm tra OTP
            {
                using (FormDatLaiMatKhau formDatLaiMK = new FormDatLaiMatKhau())
                {
                    TaiKhoan taiKhoan = taiKhoanViewModel.GetTaiKhoanByMaNV(this.maNV);
                    if (formDatLaiMK.ShowDialog() == DialogResult.OK)
                    {
                        taiKhoan = new TaiKhoan(taiKhoan.TenDangNhap, formDatLaiMK.GetMK(), taiKhoan.MANV);
                        taiKhoanViewModel.UpdateTaiKhoan(taiKhoan);
                        
                    }
                }
                FormDatLaiMatKhau formDatLaiMatKhau = new FormDatLaiMatKhau();
                this.Hide();
                formDatLaiMatKhau.Show();
                // Chuyển đến giao diện thay đổi mật khẩu hoặc thực hiện thay đổi mật khẩu
            }
            else
            {
                MessageBox.Show("OTP không hợp lệ hoặc đã hết hạn.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
