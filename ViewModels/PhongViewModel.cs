using HeThongQuanLyKTX.Database;
using HeThongQuanLyKTX.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace HeThongQuanLyKTX.ViewModels
{
    internal class PhongViewModel
    {
        private readonly DatabaseHelper _dbHelper;

        public PhongViewModel()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Lấy danh sách phòng
        public List<Phong> GetAllPhong()
        {
            string query = "SELECT * FROM phong";
            DataTable dt = _dbHelper.ExecuteQueryAndReturnDataTable(query);
            List<Phong> phongList = new List<Phong>();

            foreach (DataRow row in dt.Rows)
            {
                phongList.Add(new Phong
                {
                    MaPhong = Convert.ToInt32(row["MaPhong"]),
                    SoSVHienTai = Convert.ToInt32(row["SoSVHienTai"]),
                    TinhTrangPhong = row["TinhTrangPhong"].ToString(),
                    MaKV = Convert.ToInt32(row["MaKV"]),
                    MaLP = Convert.ToInt32(row["MaLP"])
                });
            }

            return phongList;
        }

        // Thêm mới phòng
        public void AddPhong(Phong phong)
        {
            string query = "INSERT INTO phong (SoSVHienTai, TinhTrangPhong, MaKV, MaLP) " +
                           "VALUES (@SoSVHienTai, @TinhTrangPhong, @MaKV, @MaLP)";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@SoSVHienTai", phong.SoSVHienTai),
                new MySqlParameter("@TinhTrangPhong", phong.TinhTrangPhong),
                new MySqlParameter("@MaKV", phong.MaKV),
                new MySqlParameter("@MaLP", phong.MaLP)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Cập nhật thông tin phòng
        public void UpdatePhong(Phong phong)
        {
            string query = "UPDATE phong SET SoSVHienTai = @SoSVHienTai, TinhTrangPhong = @TinhTrangPhong, " +
                           "MaKV = @MaKV, MaLP = @MaLP WHERE MaPhong = @MaPhong";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@SoSVHienTai", phong.SoSVHienTai),
                new MySqlParameter("@TinhTrangPhong", phong.TinhTrangPhong),
                new MySqlParameter("@MaKV", phong.MaKV),
                new MySqlParameter("@MaLP", phong.MaLP),
                new MySqlParameter("@MaPhong", phong.MaPhong)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Xóa phòng
        public void DeletePhong(int maPhong)
        {
            string query = "DELETE FROM phong WHERE MaPhong = @MaPhong";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaPhong", maPhong)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Lấy thông tin phòng theo mã
        public Phong GetPhongByMaPhong(int maPhong)
        {
            string query = "SELECT * FROM phong WHERE MaPhong = @MaPhong";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaPhong", maPhong)
            };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Phong
                {
                    MaPhong = Convert.ToInt32(row["MaPhong"]),
                    SoSVHienTai = Convert.ToInt32(row["SoSVHienTai"]),
                    TinhTrangPhong = row["TinhTrangPhong"].ToString(),
                    MaKV = Convert.ToInt32(row["MaKV"]),
                    MaLP = Convert.ToInt32(row["MaLP"])
                };
            }

            return null; // Trả về null nếu không tìm thấy
        }

        // Lấy danh sách phòng theo mã khu vực (MaKV)
        public List<Phong> GetPhongByMaKV(int maKV)
        {
            string query = "SELECT * FROM phong WHERE MaKV = @MaKV";
            List<MySqlParameter> parameters = new List<MySqlParameter>
        {
            new MySqlParameter("@MaKV", maKV)
        };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);
            List<Phong> phongList = new List<Phong>();

            foreach (DataRow row in dt.Rows)
            {
                phongList.Add(new Phong
                {
                    MaPhong = Convert.ToInt32(row["MaPhong"]),
                    SoSVHienTai = Convert.ToInt32(row["SoSVHienTai"]),
                    TinhTrangPhong = row["TinhTrangPhong"].ToString(),
                    MaKV = Convert.ToInt32(row["MaKV"]),
                    MaLP = Convert.ToInt32(row["MaLP"])
                });
            }

            return phongList;
        }

    }
}
