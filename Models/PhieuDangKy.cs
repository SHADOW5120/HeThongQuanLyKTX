using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKTX.Models
{
    internal class PhieuDangKy
    {
        // Properties
        public int MaPhieu { get; set; }
        public DateTime NgayDangKy { get; set; }
        public string TrangThaiPDK { get; set; } // Consider using an enum for predefined statuses
        public int MANV { get; set; }
        public int MaPhong { get; set; }
        public int MaSV { get; set; }

        // Constructor
        public PhieuDangKy(int maPhieu, DateTime ngayDangKy, string trangThaiPDK, int maNV, int maPhong, int maSV)
        {
            MaPhieu = maPhieu;
            NgayDangKy = ngayDangKy;
            TrangThaiPDK = trangThaiPDK;
            MANV = maNV;
            MaPhong = maPhong;
            MaSV = maSV;
        }

        // Default Constructor
        public PhieuDangKy()
        {
        }

        // Method to Display Info (Optional for Debugging)
        public override string ToString()
        {
            return $"MaPhieu: {MaPhieu}, NgayDangKy: {NgayDangKy.ToShortDateString()}, TrangThaiPDK: {TrangThaiPDK}, MANV: {MANV}, MaPhong: {MaPhong}, MaSV: {MaSV}";
        }
    }
}
