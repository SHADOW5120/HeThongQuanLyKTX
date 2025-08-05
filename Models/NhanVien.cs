using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKTX.Models
{
    internal class NhanVien
    {
        // Properties
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string SdtNV { get; set; }
        public string EmailNV { get; set; }
        public string GioiTinhNV { get; set; } // Consider using an enum for gender if predefined values exist
        public string QueQuanNV { get; set; }
        public DateTime NgaySinhNV { get; set; }

        // Constructor
        public NhanVien(int maNV, string tenNV, string sdtNV, string emailNV, string gioiTinh, string queQuan, DateTime ngaySinhNV)
        {
            MaNV = maNV;
            TenNV = tenNV;
            SdtNV = sdtNV;
            EmailNV = emailNV;
            GioiTinhNV = gioiTinh;
            QueQuanNV = queQuan;
            NgaySinhNV = ngaySinhNV;
        }

        // Default Constructor
        public NhanVien()
        {
        }

        // Method to Display Info (Optional for Debugging)
        public override string ToString()
        {
            return $"MANV: {MaNV}, TenNV: {TenNV}, SdtNV: {SdtNV}, EmailNV: {EmailNV}, GioiTinh: {GioiTinhNV}, QueQuan: {QueQuanNV}, NgaySinhNV: {NgaySinhNV.ToShortDateString()}";
        }
    }
}
