using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKTX.Models
{
    internal class Phong
    {
        // Properties
        public int MaPhong { get; set; }
        public int SoSVHienTai { get; set; }
        public string TinhTrangPhong { get; set; } // Consider using an enum for predefined room statuses
        public int MaKV { get; set; }
        public int MaLP { get; set; }

        // Constructor
        public Phong(int maPhong, int soSVHienTai, string tinhTrangPhong, int maKV, int maLP)
        {
            MaPhong = maPhong;
            SoSVHienTai = soSVHienTai;
            TinhTrangPhong = tinhTrangPhong;
            MaKV = maKV;
            MaLP = maLP;
        }

        // Default Constructor
        public Phong()
        {
        }

        // Method to Display Info (Optional for Debugging)
        public override string ToString()
        {
            return $"MaPhong: {MaPhong}, SoSVHienTai: {SoSVHienTai}, TinhTrangPhong: {TinhTrangPhong}, MaKV: {MaKV}, MaLP: {MaLP}";
        }
    }
}
