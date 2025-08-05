using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKTX.Models
{
    internal class HoaDon
    {
        // Properties
        public int MaHD { get; set; }
        public DateTime ThoiGianHD { get; set; }
        public string TrangThaiHD { get; set; } // Consider using an enum for predefined statuses
        public int MANV { get; set; }
        public int MaPhong { get; set; }

        // Constructor
        public HoaDon(int maHD, DateTime thoiGianHD, string trangThaiHD, int maNV, int maPhong)
        {
            MaHD = maHD;
            ThoiGianHD = thoiGianHD;
            TrangThaiHD = trangThaiHD;
            MANV = maNV;
            MaPhong = maPhong;
        }

        // Default Constructor
        public HoaDon()
        {
        }

        // Method to Display Info (Optional for Debugging)
        public override string ToString()
        {
            return $"MaHD: {MaHD}, ThoiGianHD: {ThoiGianHD}, TrangThaiHD: {TrangThaiHD}, MANV: {MANV}, MaPhong: {MaPhong}";
        }
    }
}
