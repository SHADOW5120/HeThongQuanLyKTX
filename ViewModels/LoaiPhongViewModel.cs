using HeThongQuanLyKTX.Database;
using HeThongQuanLyKTX.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace HeThongQuanLyKTX.ViewModels
{
    internal class LoaiPhongViewModel
    {
        private readonly DatabaseHelper _dbHelper;

        public LoaiPhongViewModel()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Lấy danh sách loại phòng
        public List<LoaiPhong> GetAllLoaiPhong()
        {
            string query = "SELECT * FROM loaiphong";
            DataTable dt = _dbHelper.ExecuteQueryAndReturnDataTable(query);
            List<LoaiPhong> loaiPhongList = new List<LoaiPhong>();

            foreach (DataRow row in dt.Rows)
            {
                loaiPhongList.Add(new LoaiPhong
                {
                    MaLP = Convert.ToInt32(row["MaLP"]),
                    DienTichLP = Convert.ToDecimal(row["DienTichLP"]),
                    SoSVToiDa = Convert.ToInt32(row["SoSVToiDa"]),
                    TienLP = Convert.ToDecimal(row["TienLP"])
                });
            }

            return loaiPhongList;
        }

        // Thêm mới loại phòng
        public void AddLoaiPhong(LoaiPhong loaiPhong)
        {
            string query = "INSERT INTO loaiphong (DienTichLP, SoSVToiDa, TienLP) " +
                           "VALUES (@DienTichLP, @SoSVToiDa, @TienLP)";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@DienTichLP", loaiPhong.DienTichLP),
                new MySqlParameter("@SoSVToiDa", loaiPhong.SoSVToiDa),
                new MySqlParameter("@TienLP", loaiPhong.TienLP)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Cập nhật thông tin loại phòng
        public void UpdateLoaiPhong(LoaiPhong loaiPhong)
        {
            string query = "UPDATE loaiphong SET DienTichLP = @DienTichLP, SoSVToiDa = @SoSVToiDa, TienLP = @TienLP " +
                           "WHERE MaLP = @MaLP";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@DienTichLP", loaiPhong.DienTichLP),
                new MySqlParameter("@SoSVToiDa", loaiPhong.SoSVToiDa),
                new MySqlParameter("@TienLP", loaiPhong.TienLP),
                new MySqlParameter("@MaLP", loaiPhong.MaLP)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Xóa loại phòng
        public void DeleteLoaiPhong(int maLP)
        {
            string query = "DELETE FROM loaiphong WHERE MaLP = @MaLP";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaLP", maLP)
            };

            _dbHelper.ExecuteQueryWithParameters(query, parameters);
        }

        // Lấy thông tin loại phòng theo mã
        public LoaiPhong GetLoaiPhongByMaLP(int maLP)
        {
            string query = "SELECT * FROM loaiphong WHERE MaLP = @MaLP";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@MaLP", maLP)
            };

            DataTable dt = _dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new LoaiPhong
                {
                    MaLP = Convert.ToInt32(row["MaLP"]),
                    DienTichLP = Convert.ToDecimal(row["DienTichLP"]),
                    SoSVToiDa = Convert.ToInt32(row["SoSVToiDa"]),
                    TienLP = Convert.ToDecimal(row["TienLP"])
                };
            }

            return null; // Trả về null nếu không tìm thấy
        }
    }
}
