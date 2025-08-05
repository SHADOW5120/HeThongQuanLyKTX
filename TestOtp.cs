using HeThongQuanLyKTX.Services.QuenMK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongQuanLyKTX.Services;

namespace HeThongQuanLyKTX
{
    public partial class TestOtp : Form
    {
        public TestOtp()
        {
            InitializeComponent();
        }

        private OtpManager otpManager = new OtpManager();
        private SendOTP sendOTP = new SendOTP();

        private void btnSendOtp_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;  // Lấy email từ người dùng
            //if (CheckIfEmailExists(email))  // Kiểm tra email tồn tại trong cơ sở dữ liệu
            //{
                string otp = otpManager.GenerateOtp();  // Tạo OTP
                sendOTP.SendOtpEmail(email, otp);  // Gửi OTP qua email
                otpManager.SaveOtp(email, otp);  // Lưu OTP vào bộ nhớ

                MessageBox.Show("Mã OTP đã được gửi đến email của bạn.");
            //}
            //else
            //{
            //    MessageBox.Show("Email không tồn tại trong hệ thống.");
            //}
        }

        private void btnVerifyOtp_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string otp = txtOtp.Text;  // Lấy OTP người dùng nhập vào

            if (otpManager.VerifyOtp(email, otp))  // Kiểm tra OTP
            {
                MessageBox.Show("OTP hợp lệ. Bạn có thể thay đổi mật khẩu.");
                // Chuyển đến giao diện thay đổi mật khẩu hoặc thực hiện thay đổi mật khẩu
            }
            else
            {
                MessageBox.Show("OTP không hợp lệ hoặc đã hết hạn.");
            }
        }

        private void TestOtp_Load(object sender, EventArgs e)
        {

        }
    }
}
