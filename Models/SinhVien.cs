using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKTX.Models
{
    internal class SinhVien
    {
        // Properties
        public int MaSV { get; set; }
        public string TenSV { get; set; }
        public DateTime NgaySinhSV { get; set; }
        public string GioiTinhSV { get; set; } // Consider using an enum for predefined gender values
        public string SdtSV { get; set; }
        public string QueQuanSV { get; set; }
        public string EmailSV { get; set; }

        // Constructor
        public SinhVien(int maSV, string tenSV, DateTime ngaySinhSV, string gioiTinhSV, string sdtSV, string queQuanSV, string emailSV)
        {
            MaSV = maSV;
            TenSV = tenSV;
            NgaySinhSV = ngaySinhSV;
            GioiTinhSV = gioiTinhSV;
            SdtSV = sdtSV;
            QueQuanSV = queQuanSV;
            EmailSV = emailSV;
        }

        // Default Constructor
        public SinhVien()
        {
        }

        // Method to Display Info (Optional for Debugging)
        public override string ToString()
        {
            return $"MaSV: {MaSV}, TenSV: {TenSV}, NgaySinhSV: {NgaySinhSV.ToShortDateString()}, GioiTinhSV: {GioiTinhSV}, SdtSV: {SdtSV}, QueQuanSV: {QueQuanSV}, EmailSV: {EmailSV}";
        }
    }
}
