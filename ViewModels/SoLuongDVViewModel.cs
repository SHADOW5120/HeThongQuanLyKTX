using HeThongQuanLyKTX.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKTX.ViewModels
{
    internal class SoLuongDVViewModel
    {
        public string TenDV { get; set; }
        public int TongSoLuong { get; set; }

        private readonly DatabaseHelper _dbHelper;

        public SoLuongDVViewModel()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Lấy danh sách số lượng dịch vụ theo tháng và năm
        public List<SoLuongDVViewModel> GetSoLuongDVByMonthYear(int month, int year)
        {
            string query = @"
                SELECT 
                    dv.TenDV,
                    SUM(hddv.SoLuongDV) AS TongSoLuong
                FROM 
                    hoadon_dichvu hddv
                JOIN 
                    hoadon hd ON hddv.MaHD = hd.MaHD
                JOIN 
                    dichvu dv ON hddv.MaDV = dv.MaDV
                WHERE 
                    MONTH(hd.ThoiGianHD) = @Month
                    AND YEAR(hd.ThoiGianHD) = @Year
                GROUP BY 
                    dv.TenDV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@Month", month),
                new MySqlParameter("@Year", year)
            };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);
            List<SoLuongDVViewModel> soLuongDVList = new List<SoLuongDVViewModel>();

            foreach (DataRow row in dt.Rows)
            {
                soLuongDVList.Add(new SoLuongDVViewModel
                {
                    TenDV = row["TenDV"].ToString(),
                    TongSoLuong = Convert.ToInt32(row["TongSoLuong"])
                });
            }

            return soLuongDVList;
        }
    }
}
