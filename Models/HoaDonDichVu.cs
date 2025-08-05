using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKTX.Models
{
    internal class HoaDonDichVu
    {
        // Properties
        public int MaHD { get; set; }
        public int MaDV { get; set; }
        public int SoLuongDV { get; set; }
        public int TienDV { get; set; }

        // Constructor
        public HoaDonDichVu(int maHD, int maDV, int soLuongDV, int tienDV)
        {
            MaHD = maHD;
            MaDV = maDV;
            SoLuongDV = soLuongDV;
            TienDV = tienDV;
        }

        // Default Constructor
        public HoaDonDichVu()
        {
        }

        // Method to Display Info (Optional for Debugging)
        public override string ToString()
        {
            return $"MaHD: {MaHD}, MaDV: {MaDV}, SoLuongDV: {SoLuongDV}, TienDV: {TienDV:C}";
        }
    }
}
