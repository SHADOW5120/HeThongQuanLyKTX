using HeThongQuanLyKTX.Database;
using HeThongQuanLyKTX.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace HeThongQuanLyKTX.ViewModels
{
    internal class NguoiThanViewModel
    {
        private readonly DatabaseHelper _dbHelper;

        public NguoiThanViewModel()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Lấy danh sách người thân
        public List<NguoiThan> GetAllNguoiThan()
        {
            string query = "SELECT * FROM nguoithan";
            DataTable dt = _dbHelper.ExecuteQueryAndReturnDataTable(query);
            List<NguoiThan> nguoiThanList = new List<NguoiThan>();

            foreach (DataRow row in dt.Rows)
            {
                nguoiThanList.Add(new NguoiThan
                {
                    MaNT = Convert.ToInt32(row["MaNT"]),
                    TenNT = row["TenNT"].ToString(),
                    SdtNT = row["SdtNT"].ToString(),
                    DiaChiNT = row["DiaChiNT"].ToString(),
                    MaSV = Convert.ToInt32(row["MaSV"])
                });
            }

            return nguoiThanList;
        }

        // Thêm mới người thân
        public void AddNguoiThan(NguoiThan nguoiThan)
        {
            string query = "INSERT INTO nguoithan (TenNT, SdtNT, DiaChiNT, MaSV) " +
                           "VALUES (@TenNT, @SdtNT, @DiaChiNT, @MaSV)";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@TenNT", nguoiThan.TenNT),
                new MySqlParameter("@SdtNT", nguoiThan.SdtNT),
                new MySqlParameter("@DiaChiNT", nguoiThan.DiaChiNT),
                new MySqlParameter("@MaSV", nguoiThan.MaSV)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Cập nhật thông tin người thân
        public void UpdateNguoiThan(NguoiThan nguoiThan)
        {
            string query = "UPDATE nguoithan SET TenNT = @TenNT, SdtNT = @SdtNT, DiaChiNT = @DiaChiNT, MaSV = @MaSV " +
                           "WHERE MaNT = @MaNT";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@TenNT", nguoiThan.TenNT),
                new MySqlParameter("@SdtNT", nguoiThan.SdtNT),
                new MySqlParameter("@DiaChiNT", nguoiThan.DiaChiNT),
                new MySqlParameter("@MaSV", nguoiThan.MaSV),
                new MySqlParameter("@MaNT", nguoiThan.MaNT)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Xóa người thân
        public void DeleteNguoiThan(int maNT)
        {
            string query = "DELETE FROM nguoithan WHERE MaNT = @MaNT";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaNT", maNT)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Lấy danh sách người thân theo mã sinh viên
        public List<NguoiThan> GetNguoiThanByMaSV(int maSV)
        {
            string query = "SELECT * FROM nguoithan WHERE MaSV = @MaSV";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaSV", maSV)
            };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);
            List<NguoiThan> nguoiThanList = new List<NguoiThan>();

            foreach (DataRow row in dt.Rows)
            {
                nguoiThanList.Add(new NguoiThan
                {
                    MaNT = Convert.ToInt32(row["MaNT"]),
                    TenNT = row["TenNT"].ToString(),
                    SdtNT = row["SdtNT"].ToString(),
                    DiaChiNT = row["DiaChiNT"].ToString(),
                    MaSV = Convert.ToInt32(row["MaSV"])
                });
            }

            return nguoiThanList;
        }
    }
}
