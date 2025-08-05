using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKTX.Models
{
    internal class DichVu
    {
        // Properties
        public int MaDV { get; set; }
        public string TenDV { get; set; }
        public string DonViDV { get; set; }
        public decimal GiaDV { get; set; }

        // Constructor
        public DichVu(int maDV, string tenDV, string donViDV, decimal giaDV)
        {
            MaDV = maDV;
            TenDV = tenDV;
            DonViDV = donViDV;
            GiaDV = giaDV;
        }

        // Default Constructor
        public DichVu()
        {
        }

        // Method to Display Info (Optional for Debugging)
        public override string ToString()
        {
            return $"MaDV: {MaDV}, TenDV: {TenDV}, DonViDV: {DonViDV}, GiaDV: {GiaDV:C}";
        }
    }
}
