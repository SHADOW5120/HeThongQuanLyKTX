using HeThongQuanLyKTX.Database;
using HeThongQuanLyKTX.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace HeThongQuanLyKTX.ViewModels
{
    internal class SinhVienViewModel
    {
        private readonly DatabaseHelper _dbHelper;

        public SinhVienViewModel()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Lấy danh sách sinh viên
        public List<SinhVien> GetAllSinhVien()
        {
            string query = "SELECT * FROM sinhvien";
            DataTable dt = _dbHelper.ExecuteQueryAndReturnDataTable(query);

            List<SinhVien> sinhVienList = new List<SinhVien>();
            foreach (DataRow row in dt.Rows)
            {
                SinhVien sv = new SinhVien
                {
                    MaSV = Convert.ToInt32(row["MaSV"]),
                    TenSV = row["TenSV"].ToString(),
                    NgaySinhSV = Convert.ToDateTime(row["NgaySinhSV"]),
                    GioiTinhSV = row["GioiTinhSV"].ToString(),
                    SdtSV = row["SdtSV"].ToString(),
                    QueQuanSV = row["QueQuanSV"].ToString(),
                    EmailSV = row["EmailSV"].ToString()
                };
                sinhVienList.Add(sv);
            }
            return sinhVienList;
        }

        // Thêm sinh viên mới
        public void AddSinhVien(SinhVien sv)
        {
            string query = "INSERT INTO sinhvien (TenSV, NgaySinhSV, GioiTinhSV, SdtSV, QueQuanSV, EmailSV) " +
                           "VALUES (@TenSV, @NgaySinhSV, @GioiTinh, @SdtSV, @QueQuanSV, @EmailSV)";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@TenSV", sv.TenSV),
                new MySqlParameter("@NgaySinhSV", sv.NgaySinhSV),
                new MySqlParameter("@GioiTinhSV", sv.GioiTinhSV),
                new MySqlParameter("@SdtSV", sv.SdtSV),
                new MySqlParameter("@QueQuanSV", sv.QueQuanSV),
                new MySqlParameter("@EmailSV", sv.EmailSV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Cập nhật thông tin sinh viên
        public void UpdateSinhVien(SinhVien sv)
        {
            string query = "UPDATE sinhvien SET TenSV = @TenSV, NgaySinhSV = @NgaySinhSV, GioiTinhSV = @GioiTinhSV, " +
                           "SdtSV = @SdtSV, QueQuanSV = @QueQuanSV, EmailSV = @EmailSV WHERE MaSV = @MaSV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaSV", sv.MaSV),
                new MySqlParameter("@TenSV", sv.TenSV),
                new MySqlParameter("@NgaySinhSV", sv.NgaySinhSV),
                new MySqlParameter("@GioiTinhSV", sv.GioiTinhSV),
                new MySqlParameter("@SdtSV", sv.SdtSV),
                new MySqlParameter("@QueQuanSV", sv.QueQuanSV),
                new MySqlParameter("@EmailSV", sv.EmailSV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Xóa sinh viên
        public void DeleteSinhVien(int maSV)
        {
            string query = "DELETE FROM sinhvien WHERE MaSV = @MaSV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaSV", maSV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Tìm kiếm sinh viên theo tên
        public List<SinhVien> SearchSinhVienByName(string tenSV)
        {
            string query = "SELECT * FROM sinhvien WHERE TenSV LIKE @TenSV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@TenSV", "%" + tenSV + "%")
            };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);

            List<SinhVien> sinhVienList = new List<SinhVien>();
            foreach (DataRow row in dt.Rows)
            {
                SinhVien sv = new SinhVien
                {
                    MaSV = Convert.ToInt32(row["MaSV"]),
                    TenSV = row["TenSV"].ToString(),
                    NgaySinhSV = Convert.ToDateTime(row["NgaySinhSV"]),
                    GioiTinhSV = row["GioiTinhSV"].ToString(),
                    SdtSV = row["SdtSV"].ToString(),
                    QueQuanSV = row["QueQuanSV"].ToString(),
                    EmailSV = row["EmailSV"].ToString()
                };
                sinhVienList.Add(sv);
            }
            return sinhVienList;
        }
    }
}
