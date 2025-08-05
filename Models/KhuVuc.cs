using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKTX.Models
{
    internal class KhuVuc
    {
        // Properties
        public int MaKV { get; set; }
        public string TenKV { get; set; }

        // Constructor
        public KhuVuc(int maKV, string tenKV)
        {
            MaKV = maKV;
            TenKV = tenKV;
        }

        // Default Constructor
        public KhuVuc()
        {
        }

        // Method to Display Info (Optional for Debugging)
        public override string ToString()
        {
            return $"MaKV: {MaKV}, TenKV: {TenKV}";
        }
    }
}
