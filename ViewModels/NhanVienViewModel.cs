using HeThongQuanLyKTX.Database;
using HeThongQuanLyKTX.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace HeThongQuanLyKTX.ViewModels
{
    internal class NhanVienViewModel
    {
        private readonly DatabaseHelper _dbHelper;

        public NhanVienViewModel()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Lấy danh sách nhân viên
        public List<NhanVien> GetAllNhanVien()
        {
            string query = "SELECT * FROM nhanvien";
            DataTable dt = _dbHelper.ExecuteQueryAndReturnDataTable(query);
            List<NhanVien> nhanVienList = new List<NhanVien>();

            foreach (DataRow row in dt.Rows)
            {
                nhanVienList.Add(new NhanVien
                {
                    MaNV = Convert.ToInt32(row["MaNV"]),
                    TenNV = row["TenNV"].ToString(),
                    SdtNV = row["SdtNV"].ToString(),
                    EmailNV = row["EmailNV"].ToString(),
                    GioiTinhNV = row["GioiTinhNV"].ToString(),
                    QueQuanNV = row["QueQuanNV"].ToString(),
                    NgaySinhNV = Convert.ToDateTime(row["NgaySinhNV"])
                });
            }

            return nhanVienList;
        }

        // Thêm mới nhân viên
        public void AddNhanVien(NhanVien nhanVien)
        {
            string query = "INSERT INTO nhanvien (TenNV, SdtNV, EmailNV, GioiTinhNV, QueQuanNV, NgaySinhNV) " +
                           "VALUES (@TenNV, @SdtNV, @EmailNV, @GioiTinhNV, @QueQuanNV, @NgaySinhNV)";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@TenNV", nhanVien.TenNV),
                new MySqlParameter("@SdtNV", nhanVien.SdtNV),
                new MySqlParameter("@EmailNV", nhanVien.EmailNV),
                new MySqlParameter("@GioiTinhNV", nhanVien.GioiTinhNV),
                new MySqlParameter("@QueQuanNV", nhanVien.QueQuanNV),
                new MySqlParameter("@NgaySinhNV", nhanVien.NgaySinhNV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Cập nhật thông tin nhân viên
        public void UpdateNhanVien(NhanVien nhanVien)
        {
            string query = "UPDATE nhanvien SET TenNV = @TenNV, SdtNV = @SdtNV, EmailNV = @EmailNV, GioiTinhNV = @GioiTinhNV, " +
                           "QueQuanNV = @QueQuanNV, NgaySinhNV = @NgaySinhNV WHERE MaNV = @MaNV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@TenNV", nhanVien.TenNV),
                new MySqlParameter("@SdtNV", nhanVien.SdtNV),
                new MySqlParameter("@EmailNV", nhanVien.EmailNV),
                new MySqlParameter("@GioiTinhNV", nhanVien.GioiTinhNV),
                new MySqlParameter("@QueQuanNV", nhanVien.QueQuanNV),
                new MySqlParameter("@NgaySinhNV", nhanVien.NgaySinhNV),
                new MySqlParameter("@MaNV", nhanVien.MaNV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Xóa nhân viên
        public void DeleteNhanVien(int maNV)
        {
            string query = "DELETE FROM nhanvien WHERE MaNV = @MaNV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaNV", maNV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Lấy thông tin nhân viên theo mã nhân viên
        public NhanVien GetNhanVienByMaNV(int maNV)
        {
            string query = "SELECT * FROM nhanvien WHERE MaNV = @MaNV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaNV", maNV)
            };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new NhanVien
                {
                    MaNV = Convert.ToInt32(row["MaNV"]),
                    TenNV = row["TenNV"].ToString(),
                    SdtNV = row["SdtNV"].ToString(),
                    EmailNV = row["EmailNV"].ToString(),
                    GioiTinhNV = row["GioiTinhNV"].ToString(),
                    QueQuanNV = row["QueQuanNV"].ToString(),
                    NgaySinhNV = Convert.ToDateTime(row["NgaySinhNV"])
                };
            }

            return null; // Trả về null nếu không tìm thấy
        }

        public NhanVien GetNhanVienByEmailNV(string emailNV)
        {
            string query = "SELECT * FROM nhanvien WHERE EmailNV = @EmailNV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@EmailNV", emailNV)
            };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new NhanVien
                {
                    MaNV = Convert.ToInt32(row["MaNV"]),
                    TenNV = row["TenNV"].ToString(),
                    SdtNV = row["SdtNV"].ToString(),
                    EmailNV = row["EmailNV"].ToString(),
                    GioiTinhNV = row["GioiTinhNV"].ToString(),
                    QueQuanNV = row["QueQuanNV"].ToString(),
                    NgaySinhNV = Convert.ToDateTime(row["NgaySinhNV"])
                };
            }

            return null; // Trả về null nếu không tìm thấy
        }
    }
}
