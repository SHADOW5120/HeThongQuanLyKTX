using HeThongQuanLyKTX.Database;
using HeThongQuanLyKTX.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace HeThongQuanLyKTX.ViewModels
{
    internal class HoaDonDichVuViewModel
    {
        private readonly DatabaseHelper _dbHelper;

        public HoaDonDichVuViewModel()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Lấy danh sách hóa đơn dịch vụ
        public List<HoaDonDichVu> GetAllHoaDonDichVu()
        {
            string query = "SELECT * FROM hoadon_dichvu";
            DataTable dt = _dbHelper.ExecuteQueryAndReturnDataTable(query);
            List<HoaDonDichVu> hoaDonDichVuList = new List<HoaDonDichVu>();

            foreach (DataRow row in dt.Rows)
            {
                hoaDonDichVuList.Add(new HoaDonDichVu
                {
                    MaHD = Convert.ToInt32(row["MaHD"]),
                    MaDV = Convert.ToInt32(row["MaDV"]),
                    SoLuongDV = Convert.ToInt32(row["SoLuongDV"]),
                    TienDV = Convert.ToInt32(row["TienDV"])
                });
            }

            return hoaDonDichVuList;
        }

        // Thêm hóa đơn dịch vụ mới
        public void AddHoaDonDichVu(HoaDonDichVu hoaDonDichVu)
        {
            string query = "INSERT INTO hoadon_dichvu (MaHD, MaDV, SoLuongDV, TienDV) " +
                           "VALUES (@MaHD, @MaDV, @SoLuongDV, @TienDV)";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaHD", hoaDonDichVu.MaHD),
                new MySqlParameter("@MaDV", hoaDonDichVu.MaDV),
                new MySqlParameter("@SoLuongDV", hoaDonDichVu.SoLuongDV),
                new MySqlParameter("@TienDV", hoaDonDichVu.TienDV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Cập nhật thông tin hóa đơn dịch vụ
        public void UpdateHoaDonDichVu(HoaDonDichVu hoaDonDichVu)
        {
            string query = "UPDATE hoadon_dichvu SET SoLuongDV = @SoLuongDV, TienDV = @TienDV " +
                           "WHERE MaHD = @MaHD AND MaDV = @MaDV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@SoLuongDV", hoaDonDichVu.SoLuongDV),
                new MySqlParameter("@TienDV", hoaDonDichVu.TienDV),
                new MySqlParameter("@MaHD", hoaDonDichVu.MaHD),
                new MySqlParameter("@MaDV", hoaDonDichVu.MaDV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Xóa hóa đơn dịch vụ
        public void DeleteHoaDonDichVu(int maHD, int maDV)
        {
            string query = "DELETE FROM hoadon_dichvu WHERE MaHD = @MaHD AND MaDV = @MaDV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaHD", maHD),
                new MySqlParameter("@MaDV", maDV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Lấy thông tin hóa đơn dịch vụ theo mã hóa đơn và mã dịch vụ
        public HoaDonDichVu GetHoaDonDichVuByMaHDMaDV(int maHD, int maDV)
        {
            string query = "SELECT * FROM hoadon_dichvu WHERE MaHD = @MaHD AND MaDV = @MaDV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaHD", maHD),
                new MySqlParameter("@MaDV", maDV)
            };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new HoaDonDichVu
                {
                    MaHD = Convert.ToInt32(row["MaHD"]),
                    MaDV = Convert.ToInt32(row["MaDV"]),
                    SoLuongDV = Convert.ToInt32(row["SoLuongDV"]),
                    TienDV = Convert.ToInt32(row["TienDV"])
                };
            }

            return null; // Trả về null nếu không tìm thấy
        }
    }
}
