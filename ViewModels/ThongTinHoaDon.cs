using System;
using System.Collections.Generic;
using System.Data;
using HeThongQuanLyKTX.Database;
using MySql.Data.MySqlClient;

namespace HeThongQuanLyKTX.ViewModels
{
    internal class ThongTinHoaDon
    {
        // Properties
        public int MaHD { get; set; }
        public string DanhSachDVSoLuong { get; set; }
        public int TongTienDV { get; set; }
        public DateTime ThoiGianHD { get; set; }
        public string TrangThaiHD { get; set; }
        public int MANV { get; set; }
        public int MaPhong { get; set; }

        // Method to fetch all bills from the database
        public List<ThongTinHoaDon> GetDanhSachHoaDon()
        {
            List<ThongTinHoaDon> danhSachHoaDon = new List<ThongTinHoaDon>();
            DatabaseHelper dbHelper = new DatabaseHelper();

            string query = @"
                SELECT 
                    hoadon.MaHD,
                    hoadon.ThoiGianHD,
                    hoadon.TrangThaiHD,
                    hoadon.MANV,
                    hoadon.MaPhong,
                    GROUP_CONCAT(CONCAT(dichvu.TenDV, ' (', hoadon_dichvu.SoLuongDV, ')') SEPARATOR ', ') AS DanhSachDVSoLuong,
                    SUM(hoadon_dichvu.TienDV) AS TongTienDV
                FROM hoadon
                INNER JOIN hoadon_dichvu ON hoadon.MaHD = hoadon_dichvu.MaHD
                INNER JOIN dichvu ON hoadon_dichvu.MaDV = dichvu.MaDV
                GROUP BY hoadon.MaHD";

            DataTable dataTable = dbHelper.ExecuteQueryAndReturnDataTable(query);

            foreach (DataRow row in dataTable.Rows)
            {
                ThongTinHoaDon hoaDon = new ThongTinHoaDon
                {
                    MaHD = Convert.ToInt32(row["MaHD"]),
                    ThoiGianHD = Convert.ToDateTime(row["ThoiGianHD"]),
                    TrangThaiHD = row["TrangThaiHD"].ToString(),
                    MANV = Convert.ToInt32(row["MANV"]),
                    MaPhong = Convert.ToInt32(row["MaPhong"]),
                    DanhSachDVSoLuong = row["DanhSachDVSoLuong"].ToString(),
                    TongTienDV = Convert.ToInt32(row["TongTienDV"])
                };
                danhSachHoaDon.Add(hoaDon);
            }

            return danhSachHoaDon;
        }

        // Method to fetch a specific bill by MaHD
        public ThongTinHoaDon GetHoaDonById(int maHD)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            string query = $@"
                SELECT 
                    hoadon.MaHD,
                    hoadon.ThoiGianHD,
                    hoadon.TrangThaiHD,
                    hoadon.MANV,
                    hoadon.MaPhong,
                    GROUP_CONCAT(CONCAT(dichvu.TenDV, ' (', hoadon_dichvu.SoLuongDV, ')') SEPARATOR ', ') AS DanhSachDVSoLuong,
                    SUM(hoadon_dichvu.TienDV) AS TongTienDV
                FROM hoadon
                INNER JOIN hoadon_dichvu ON hoadon.MaHD = hoadon_dichvu.MaHD
                INNER JOIN dichvu ON hoadon_dichvu.MaDV = dichvu.MaDV
                WHERE hoadon.MaHD = @MaHD
                GROUP BY hoadon.MaHD";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaHD", maHD)
            };

            DataTable dataTable = dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new ThongTinHoaDon
                {
                    MaHD = Convert.ToInt32(row["MaHD"]),
                    ThoiGianHD = Convert.ToDateTime(row["ThoiGianHD"]),
                    TrangThaiHD = row["TrangThaiHD"].ToString(),
                    MANV = Convert.ToInt32(row["MANV"]),
                    MaPhong = Convert.ToInt32(row["MaPhong"]),
                    DanhSachDVSoLuong = row["DanhSachDVSoLuong"].ToString(),
                    TongTienDV = Convert.ToInt32(row["TongTienDV"])
                };
            }

            return null; // Return null if no record is found
        }

        // Optional: Add methods to insert, update, or delete bills as needed
        public bool DeleteHoaDon(int maHD)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            // Bắt đầu một giao dịch (Transaction) để đảm bảo xóa dữ liệu chính xác và toàn vẹn
            using (var conn = dbHelper.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Xóa dịch vụ liên quan đến hóa đơn trong bảng hoadon_dichvu
                        string deleteServicesQuery = "DELETE FROM hoadon_dichvu WHERE MaHD = @MaHD";
                        List<MySqlParameter> serviceParams = new List<MySqlParameter>
                {
                    new MySqlParameter("@MaHD", maHD)
                };
                        dbHelper.ExecuteQueryWithParametersUsingTransaction(deleteServicesQuery, serviceParams, transaction);

                        // Xóa hóa đơn trong bảng hoadon
                        string deleteBillQuery = "DELETE FROM hoadon WHERE MaHD = @MaHD";
                        dbHelper.ExecuteQueryWithParametersUsingTransaction(deleteBillQuery, serviceParams, transaction);

                        // Commit giao dịch nếu không có lỗi
                        transaction.Commit();
                        return true; // Trả về true nếu xóa thành công
                    }
                    catch (Exception)
                    {
                        // Rollback giao dịch nếu có lỗi xảy ra
                        transaction.Rollback();
                        return false; // Trả về false nếu xóa không thành công
                    }
                }
            }
        }
    }
}
