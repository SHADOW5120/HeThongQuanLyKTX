using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKTX.Models
{
    internal class LoaiPhong
    {
        // Properties
        public int MaLP { get; set; }
        public decimal DienTichLP { get; set; }
        public int SoSVToiDa { get; set; }
        public decimal TienLP { get; set; }

        // Constructor
        public LoaiPhong(int maLP, decimal dienTichLP, int soSVToiDa, decimal tienLP)
        {
            MaLP = maLP;
            DienTichLP = dienTichLP;
            SoSVToiDa = soSVToiDa;
            TienLP = tienLP;
        }

        // Default Constructor
        public LoaiPhong()
        {
        }

        // Method to Display Info (Optional for Debugging)
        public override string ToString()
        {
            return $"MaLP: {MaLP}, DienTichLP: {DienTichLP} m², SoSVToiDa: {SoSVToiDa}, TienLP: {TienLP} VNĐ";
        }
    }
}
