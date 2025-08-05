using HeThongQuanLyKTX.Database;
using HeThongQuanLyKTX.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace HeThongQuanLyKTX.ViewModels
{
    internal class DichVuViewModel
    {
        private readonly DatabaseHelper _dbHelper;

        public DichVuViewModel()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Lấy danh sách dịch vụ
        public List<DichVu> GetAllDichVu()
        {
            string query = "SELECT * FROM dichvu";
            DataTable dt = _dbHelper.ExecuteQueryAndReturnDataTable(query);
            List<DichVu> dichVuList = new List<DichVu>();

            foreach (DataRow row in dt.Rows)
            {
                dichVuList.Add(new DichVu
                {
                    MaDV = Convert.ToInt32(row["MaDV"]),
                    TenDV = row["TenDV"].ToString(),
                    DonViDV = row["DonViDV"].ToString(),
                    GiaDV = Convert.ToDecimal(row["GiaDV"])
                });
            }

            return dichVuList;
        }

        // Thêm mới dịch vụ
        public void AddDichVu(DichVu dichVu)
        {
            string query = "INSERT INTO dichvu (TenDV, DonViDV, GiaDV) " +
                           "VALUES (@TenDV, @DonViDV, @GiaDV)";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@TenDV", dichVu.TenDV),
                new MySqlParameter("@DonViDV", dichVu.DonViDV),
                new MySqlParameter("@GiaDV", dichVu.GiaDV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Cập nhật thông tin dịch vụ
        public void UpdateDichVu(DichVu dichVu)
        {
            string query = "UPDATE dichvu SET TenDV = @TenDV, DonViDV = @DonViDV, GiaDV = @GiaDV " +
                           "WHERE MaDV = @MaDV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@TenDV", dichVu.TenDV),
                new MySqlParameter("@DonViDV", dichVu.DonViDV),
                new MySqlParameter("@GiaDV", dichVu.GiaDV),
                new MySqlParameter("@MaDV", dichVu.MaDV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Xóa dịch vụ
        public void DeleteDichVu(int maDV)
        {
            string query = "DELETE FROM dichvu WHERE MaDV = @MaDV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaDV", maDV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Lấy thông tin dịch vụ theo mã dịch vụ
        public DichVu GetDichVuByMaDV(int maDV)
        {
            string query = "SELECT * FROM dichvu WHERE MaDV = @MaDV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaDV", maDV)
            };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new DichVu
                {
                    MaDV = Convert.ToInt32(row["MaDV"]),
                    TenDV = row["TenDV"].ToString(),
                    DonViDV = row["DonViDV"].ToString(),
                    GiaDV = Convert.ToDecimal(row["GiaDV"])
                };
            }

            return null; // Trả về null nếu không tìm thấy
        }

        public decimal GetGiaDichVuById(int maDV)
        {
            string query = "SELECT GiaDV FROM dichvu WHERE MaDV = @MaDV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaDV", maDV)
            };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToDecimal(dt.Rows[0]["GiaDV"]);
            }

            return 0; // Trả về 0 nếu không tìm thấy
        }

    }
}
