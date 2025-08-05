using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKTX.Models
{
    internal class TaiKhoan
    {
        // Properties
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int MANV { get; set; }

        // Constructor
        public TaiKhoan(string tenDangNhap, string matKhau, int maNV)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            MANV = maNV;
        }

        // Default Constructor
        public TaiKhoan()
        {
        }

        // Method to Display Info (Optional for Debugging)
        public override string ToString()
        {
            return $"TenDangNhap: {TenDangNhap}, MANV: {MANV}";
        }
    }
}
