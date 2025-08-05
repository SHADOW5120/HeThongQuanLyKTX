using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKTX.Services.QuenMK
{
    internal class OtpManager
    {
        // Từ điển lưu OTP và thời gian tạo OTP
        private Dictionary<string, (string otp, DateTime createdAt)> otpStore = new Dictionary<string, (string, DateTime)>();

        // Tạo mã OTP ngẫu nhiên
        public string GenerateOtp(int length = 6)
        {
            Random random = new Random();
            string otp = string.Empty;
            for (int i = 0; i < length; i++)
            {
                otp += random.Next(0, 10).ToString();
            }
            return otp;
        }

        // Lưu OTP tạm thời trong bộ nhớ
        public void SaveOtp(string email, string otp)
        {
            otpStore[email] = (otp, DateTime.Now);  // Lưu OTP và thời gian tạo
        }

        // Kiểm tra OTP khi người dùng nhập
        public bool VerifyOtp(string email, string otp)
        {
            if (otpStore.ContainsKey(email))
            {
                var otpData = otpStore[email];

                // Kiểm tra thời gian hết hạn của OTP (giả sử OTP có hiệu lực trong 10 phút)
                if ((DateTime.Now - otpData.createdAt).TotalMinutes <= 10)
                {
                    if (otpData.otp == otp)
                    {
                        otpStore.Remove(email);  // Xóa OTP sau khi xác thực thành công
                        return true;
                    }
                }

                otpStore.Remove(email);  // Xóa OTP nếu hết hạn
            }

            return false;  // OTP không hợp lệ hoặc hết hạn
        }
    }

}

