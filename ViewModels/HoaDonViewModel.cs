using HeThongQuanLyKTX.Database;
using HeThongQuanLyKTX.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace HeThongQuanLyKTX.ViewModels
{
    internal class HoaDonViewModel
    {
        private readonly DatabaseHelper _dbHelper;

        public HoaDonViewModel()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Lấy danh sách hóa đơn
        public List<HoaDon> GetAllHoaDon()
        {
            string query = "SELECT * FROM hoadon";
            DataTable dt = _dbHelper.ExecuteQueryAndReturnDataTable(query);
            List<HoaDon> hoaDonList = new List<HoaDon>();

            foreach (DataRow row in dt.Rows)
            {
                hoaDonList.Add(new HoaDon
                {
                    MaHD = Convert.ToInt32(row["MaHD"]),
                    ThoiGianHD = Convert.ToDateTime(row["ThoiGianHD"]),
                    TrangThaiHD = row["TrangThaiHD"].ToString(),
                    MANV = Convert.ToInt32(row["MANV"]),
                    MaPhong = Convert.ToInt32(row["MaPhong"])
                });
            }

            return hoaDonList;
        }

        // Thêm hóa đơn mới
        public void AddHoaDon(HoaDon hoaDon)
        {
            string query = "INSERT INTO hoadon (ThoiGianHD, TrangThaiHD, MANV, MaPhong) " +
                           "VALUES (@ThoiGianHD, @TrangThaiHD, @MANV, @MaPhong)";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@ThoiGianHD", hoaDon.ThoiGianHD),
                new MySqlParameter("@TrangThaiHD", hoaDon.TrangThaiHD),
                new MySqlParameter("@MANV", hoaDon.MANV),
                new MySqlParameter("@MaPhong", hoaDon.MaPhong)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Cập nhật thông tin hóa đơn
        public void UpdateHoaDon(HoaDon hoaDon)
        {
            string query = "UPDATE hoadon SET ThoiGianHD = @ThoiGianHD, TrangThaiHD = @TrangThaiHD, " +
                           "MANV = @MANV, MaPhong = @MaPhong WHERE MaHD = @MaHD";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@ThoiGianHD", hoaDon.ThoiGianHD),
                new MySqlParameter("@TrangThaiHD", hoaDon.TrangThaiHD),
                new MySqlParameter("@MANV", hoaDon.MANV),
                new MySqlParameter("@MaPhong", hoaDon.MaPhong),
                new MySqlParameter("@MaHD", hoaDon.MaHD)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Xóa hóa đơn
        public void DeleteHoaDon(int maHD)
        {
            string query = "DELETE FROM hoadon WHERE MaHD = @MaHD";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaHD", maHD)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Lấy thông tin hóa đơn theo mã hóa đơn
        public HoaDon GetHoaDonByMaHD(int maHD)
        {
            string query = "SELECT * FROM hoadon WHERE MaHD = @MaHD";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaHD", maHD)
            };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new HoaDon
                {
                    MaHD = Convert.ToInt32(row["MaHD"]),
                    ThoiGianHD = Convert.ToDateTime(row["ThoiGianHD"]),
                    TrangThaiHD = row["TrangThaiHD"].ToString(),
                    MANV = Convert.ToInt32(row["MANV"]),
                    MaPhong = Convert.ToInt32(row["MaPhong"])
                };
            }

            return null; // Trả về null nếu không tìm thấy
        }
    }
}
