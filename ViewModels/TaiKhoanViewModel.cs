using HeThongQuanLyKTX.Database;
using HeThongQuanLyKTX.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace HeThongQuanLyKTX.ViewModels
{
    internal class TaiKhoanViewModel
    {
        private readonly DatabaseHelper _dbHelper;

        public TaiKhoanViewModel()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Lấy danh sách tài khoản
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            string query = "SELECT * FROM taikhoan";
            DataTable dt = _dbHelper.ExecuteQueryAndReturnDataTable(query);
            List<TaiKhoan> taiKhoanList = new List<TaiKhoan>();

            foreach (DataRow row in dt.Rows)
            {
                taiKhoanList.Add(new TaiKhoan
                {
                    TenDangNhap = row["TenDangNhap"].ToString(),
                    MatKhau = row["MatKhau"].ToString(),
                    MANV = Convert.ToInt32(row["MANV"])
                });
            }

            return taiKhoanList;
        }

        // Thêm mới tài khoản
        public void AddTaiKhoan(TaiKhoan taiKhoan)
        {
            string query = "INSERT INTO taikhoan (TenDangNhap, MatKhau, MANV) " +
                           "VALUES (@TenDangNhap, @MatKhau, @MANV)";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@TenDangNhap", taiKhoan.TenDangNhap),
                new MySqlParameter("@MatKhau", taiKhoan.MatKhau),
                new MySqlParameter("@MANV", taiKhoan.MANV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Cập nhật thông tin tài khoản
        public void UpdateTaiKhoan(TaiKhoan taiKhoan)
        {
            string query = "UPDATE taikhoan SET MatKhau = @MatKhau, MANV = @MANV WHERE TenDangNhap = @TenDangNhap";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MatKhau", taiKhoan.MatKhau),
                new MySqlParameter("@MANV", taiKhoan.MANV),
                new MySqlParameter("@TenDangNhap", taiKhoan.TenDangNhap)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Xóa tài khoản
        public void DeleteTaiKhoan(string tenDangNhap)
        {
            string query = "DELETE FROM taikhoan WHERE TenDangNhap = @TenDangNhap";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@TenDangNhap", tenDangNhap)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Lấy thông tin tài khoản theo tên đăng nhập
        public TaiKhoan GetTaiKhoanByTenDangNhap(string tenDangNhap)
        {
            string query = "SELECT * FROM taikhoan WHERE TenDangNhap = @TenDangNhap";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@TenDangNhap", tenDangNhap)
            };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new TaiKhoan
                {
                    TenDangNhap = row["TenDangNhap"].ToString(),
                    MatKhau = row["MatKhau"].ToString(),
                    MANV = Convert.ToInt32(row["MANV"])
                };
            }

            return null; // Trả về null nếu không tìm thấy
        }

        public TaiKhoan GetTaiKhoanByMaNV(int maNV)
        {
            string query = "SELECT * FROM taikhoan WHERE MANV = @MANV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MANV", maNV)
            };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new TaiKhoan
                {
                    TenDangNhap = row["TenDangNhap"].ToString(),
                    MatKhau = row["MatKhau"].ToString(),
                    MANV = Convert.ToInt32(row["MANV"])
                };
            }

            return null; // Trả về null nếu không tìm thấy
        }
    }
}
