using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKTX.Services.QuenMK
{
    internal class SendOTP
    {
        public void SendOtpEmail(string recipientEmail, string otp)
        {
            string smtpServer = "smtp.gmail.com";  // Hoặc SMTP server của dịch vụ email bạn đang dùng
            int smtpPort = 587;
            string senderEmail = "shadowhung512004@gmail.com";  // Email của bạn
            string senderPassword = "mkgt sfoe xfff eovm";  // Mật khẩu email của bạn

            try
            {
                var smtpClient = new SmtpClient(smtpServer)
                {
                    Port = smtpPort,
                    Credentials = new NetworkCredential(senderEmail, senderPassword),
                    EnableSsl = true
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(senderEmail),
                    Subject = "Mã OTP để đặt lại mật khẩu",
                    Body = $"Mã OTP của bạn là: {otp}",
                    IsBodyHtml = false,
                };

                mailMessage.To.Add(recipientEmail);

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email: {ex.Message}");
            }
        }

    }
}
