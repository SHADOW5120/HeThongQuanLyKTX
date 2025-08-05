using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKTX.Models
{
    internal class NguoiThan
    {
        // Properties
        public int MaNT { get; set; }
        public string TenNT { get; set; }
        public string SdtNT { get; set; }
        public string DiaChiNT { get; set; }
        public int MaSV { get; set; }

        // Constructor
        public NguoiThan(int maNT, string tenNT, string sdtNT, string diaChiNT, int maSV)
        {
            MaNT = maNT;
            TenNT = tenNT;
            SdtNT = sdtNT;
            DiaChiNT = diaChiNT;
            MaSV = maSV;
        }

        // Default Constructor
        public NguoiThan()
        {
        }

        // Method to Display Info (Optional for Debugging)
        public override string ToString()
        {
            return $"MaNT: {MaNT}, TenNT: {TenNT}, SdtNT: {SdtNT}, DiaChiNT: {DiaChiNT}, MaSV: {MaSV}";
        }
    }
}
