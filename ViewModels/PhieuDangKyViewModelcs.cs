using HeThongQuanLyKTX.Database;
using HeThongQuanLyKTX.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace HeThongQuanLyKTX.ViewModels
{
    internal class PhieuDangKyViewModel
    {
        private readonly DatabaseHelper _dbHelper;

        public PhieuDangKyViewModel()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Lấy danh sách phiếu đăng ký
        public List<PhieuDangKy> GetAllPhieuDangKy()
        {
            string query = "SELECT * FROM phieudangky";
            DataTable dt = _dbHelper.ExecuteQueryAndReturnDataTable(query);
            List<PhieuDangKy> phieuDangKyList = new List<PhieuDangKy>();

            foreach (DataRow row in dt.Rows)
            {
                phieuDangKyList.Add(new PhieuDangKy
                {
                    MaPhieu = Convert.ToInt32(row["MaPhieu"]),
                    NgayDangKy = Convert.ToDateTime(row["NgayDangKy"]),
                    TrangThaiPDK = row["TrangThaiPDK"].ToString(),
                    MANV = Convert.ToInt32(row["MANV"]),
                    MaPhong = Convert.ToInt32(row["MaPhong"]),
                    MaSV = Convert.ToInt32(row["MaSV"])
                });
            }

            return phieuDangKyList;
        }

        // Thêm phiếu đăng ký mới
        public void AddPhieuDangKy(PhieuDangKy phieuDangKy)
        {
            string query = "INSERT INTO phieudangky (NgayDangKy, TrangThaiPDK, MANV, MaPhong, MaSV) " +
                           "VALUES (@NgayDangKy, @TrangThaiPDK, @MANV, @MaPhong, @MaSV)";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@NgayDangKy", phieuDangKy.NgayDangKy),
                new MySqlParameter("@TrangThaiPDK", phieuDangKy.TrangThaiPDK),
                new MySqlParameter("@MANV", phieuDangKy.MANV),
                new MySqlParameter("@MaPhong", phieuDangKy.MaPhong),
                new MySqlParameter("@MaSV", phieuDangKy.MaSV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Cập nhật thông tin phiếu đăng ký
        public void UpdatePhieuDangKy(PhieuDangKy phieuDangKy)
        {
            string query = "UPDATE phieudangky SET NgayDangKy = @NgayDangKy, TrangThaiPDK = @TrangThaiPDK, " +
                           "MANV = @MANV, MaPhong = @MaPhong, MaSV = @MaSV WHERE MaPhieu = @MaPhieu";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@NgayDangKy", phieuDangKy.NgayDangKy),
                new MySqlParameter("@TrangThaiPDK", phieuDangKy.TrangThaiPDK),
                new MySqlParameter("@MANV", phieuDangKy.MANV),
                new MySqlParameter("@MaPhong", phieuDangKy.MaPhong),
                new MySqlParameter("@MaSV", phieuDangKy.MaSV),
                new MySqlParameter("@MaPhieu", phieuDangKy.MaPhieu)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Xóa phiếu đăng ký
        public void DeletePhieuDangKy(int maPhieu)
        {
            string query = "DELETE FROM phieudangky WHERE MaPhieu = @MaPhieu";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaPhieu", maPhieu)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Lấy thông tin phiếu đăng ký theo mã phiếu
        public PhieuDangKy GetPhieuDangKyByMaPhieu(int maPhieu)
        {
            string query = "SELECT * FROM phieudangky WHERE MaPhieu = @MaPhieu";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaPhieu", maPhieu)
            };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new PhieuDangKy
                {
                    MaPhieu = Convert.ToInt32(row["MaPhieu"]),
                    NgayDangKy = Convert.ToDateTime(row["NgayDangKy"]),
                    TrangThaiPDK = row["TrangThaiPDK"].ToString(),
                    MANV = Convert.ToInt32(row["MANV"]),
                    MaPhong = Convert.ToInt32(row["MaPhong"]),
                    MaSV = Convert.ToInt32(row["MaSV"])
                };
            }

            return null; // Trả về null nếu không tìm thấy
        }

        // Lấy thông tin phiếu đăng ký theo mã phiếu
        // Lấy thông tin sinh viên qua mã phòng
        public List<SinhVien> GetSinhVienByMaPhong(int maPhong)
        {
            string query = @"
            SELECT sv.MaSV, sv.TenSV, sv.NgaySinhSV, sv.GioiTinhSV, sv.SdtSV, sv.QueQuanSV, sv.EmailSV
            FROM sinhvien sv
            INNER JOIN phieudangky pdk ON sv.MaSV = pdk.MaSV
            WHERE pdk.MaPhong = @MaPhong";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaPhong", maPhong)
            };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);
            List<SinhVien> sinhVienList = new List<SinhVien>();

            foreach (DataRow row in dt.Rows)
            {
                sinhVienList.Add(new SinhVien
                {
                    MaSV = Convert.ToInt32(row["MaSV"]),
                    TenSV = row["TenSV"].ToString(),
                    NgaySinhSV = Convert.ToDateTime(row["NgaySinhSV"]),
                    GioiTinhSV = row["GioiTinhSV"].ToString(),
                    SdtSV = row["SdtSV"].ToString(),
                    QueQuanSV = row["QueQuanSV"].ToString(),
                    EmailSV = row["EmailSV"].ToString()
                });
            }

            return sinhVienList;
        }

    }
}
