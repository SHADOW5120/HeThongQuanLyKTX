using HeThongQuanLyKTX.Database;
using HeThongQuanLyKTX.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace HeThongQuanLyKTX.ViewModels
{
    internal class KhuVucViewModel
    {
        private readonly DatabaseHelper _dbHelper;

        public KhuVucViewModel()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Lấy danh sách khu vực
        public List<KhuVuc> GetAllKhuVuc()
        {
            string query = "SELECT * FROM khuvuc";
            DataTable dt = _dbHelper.ExecuteQueryAndReturnDataTable(query);
            List<KhuVuc> khuVucList = new List<KhuVuc>();

            foreach (DataRow row in dt.Rows)
            {
                khuVucList.Add(new KhuVuc
                {
                    MaKV = Convert.ToInt32(row["MaKV"]),
                    TenKV = row["TenKV"].ToString()
                });
            }

            return khuVucList;
        }

        // Thêm mới khu vực
        public void AddKhuVuc(KhuVuc khuVuc)
        {
            string query = "INSERT INTO khuvuc (TenKV) VALUES (@TenKV)";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@TenKV", khuVuc.TenKV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Cập nhật thông tin khu vực
        public void UpdateKhuVuc(KhuVuc khuVuc)
        {
            string query = "UPDATE khuvuc SET TenKV = @TenKV WHERE MaKV = @MaKV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@TenKV", khuVuc.TenKV),
                new MySqlParameter("@MaKV", khuVuc.MaKV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Xóa khu vực
        public void DeleteKhuVuc(int maKV)
        {
            string query = "DELETE FROM khuvuc WHERE MaKV = @MaKV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaKV", maKV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Lấy thông tin khu vực theo mã
        public KhuVuc GetKhuVucByMaKV(int maKV)
        {
            string query = "SELECT * FROM khuvuc WHERE MaKV = @MaKV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaKV", maKV)
            };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new KhuVuc
                {
                    MaKV = Convert.ToInt32(row["MaKV"]),
                    TenKV = row["TenKV"].ToString()
                };
            }

            return null; // Trả về null nếu không tìm thấy
        }
    }
}
