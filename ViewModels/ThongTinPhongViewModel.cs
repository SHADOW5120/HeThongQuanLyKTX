using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using HeThongQuanLyKTX.Database;

namespace HeThongQuanLyKTX.ViewModels
{
    internal class ThongTinPhongViewModel
    {
        // Properties
        public int MaPhong { get; set; }
        public int SoSVHienTai { get; set; }
        public string TinhTrangPhong { get; set; } // Consider using an enum for predefined room statuses
        public int MaLP { get; set; }
        public string TenKV { get; set; }
        public int SoSVToiDa { get; set; }

        // Get all room information
        public List<ThongTinPhongViewModel> GetAllRooms()
        {
            List<ThongTinPhongViewModel> rooms = new List<ThongTinPhongViewModel>();
            string query = @"
                SELECT 
                    phong.MaPhong,
                    phong.SoSVHienTai,
                    phong.TinhTrangPhong,
                    phong.MaLP,
                    khuvuc.TenKV,
                    loaiphong.SoSVToiDa
                FROM phong
                INNER JOIN khuvuc ON phong.MaKV = khuvuc.MaKV
                INNER JOIN loaiphong ON phong.MaLP = loaiphong.MaLP;
            ";

            DatabaseHelper dbHelper = new DatabaseHelper();

            using (MySqlDataReader reader = dbHelper.ExecuteReader(query))
            {
                while (reader.Read())
                {
                    ThongTinPhongViewModel room = new ThongTinPhongViewModel
                    {
                        MaPhong = reader.GetInt32("MaPhong"),
                        SoSVHienTai = reader.GetInt32("SoSVHienTai"),
                        TinhTrangPhong = reader.GetString("TinhTrangPhong"),
                        MaLP = reader.GetInt32("MaLP"),
                        TenKV = reader.GetString("TenKV"),
                        SoSVToiDa = reader.GetInt32("SoSVToiDa")
                    };
                    rooms.Add(room);
                }
            }

            return rooms;
        }
        // Lấy danh sách thông tin phòng theo mã khu vực (MaKV)
            public List<ThongTinPhongViewModel> GetAllRoomsByMaKV(int maKV)
            {
                // Câu truy vấn SQL
                string query = @"
            SELECT 
                phong.MaPhong,
                phong.SoSVHienTai,
                phong.TinhTrangPhong,
                phong.MaLP,
                khuvuc.TenKV,
                loaiphong.SoSVToiDa
            FROM phong
            INNER JOIN khuvuc ON phong.MaKV = khuvuc.MaKV
            INNER JOIN loaiphong ON phong.MaLP = loaiphong.MaLP
            WHERE phong.MaKV = @MaKV";

            DatabaseHelper dbHelper = new DatabaseHelper();
            // Tham số truy vấn
            List<MySqlParameter> parameters = new List<MySqlParameter>
        {
            new MySqlParameter("@MaKV", maKV)
        };

                // Thực thi truy vấn và lấy kết quả dưới dạng DataTable
                DataTable dt = dbHelper.ExecuteQueryWithParametersAndReturnDataTable(query, parameters);
                List<ThongTinPhongViewModel> phongList = new List<ThongTinPhongViewModel>();

                // Chuyển đổi từng dòng trong DataTable thành đối tượng ThongTinPhongViewModel
                foreach (DataRow row in dt.Rows)
                {
                    phongList.Add(new ThongTinPhongViewModel
                    {
                        MaPhong = Convert.ToInt32(row["MaPhong"]),
                        SoSVHienTai = Convert.ToInt32(row["SoSVHienTai"]),
                        TinhTrangPhong = row["TinhTrangPhong"].ToString(),
                        MaLP = Convert.ToInt32(row["MaLP"]),
                        TenKV = row["TenKV"].ToString(),
                        SoSVToiDa = Convert.ToInt32(row["SoSVToiDa"])
                    });
                }

                return phongList; // Trả về danh sách các đối tượng ThongTinPhongViewModel
            }

        // Method to delete a bill and its related services by MaHD
        


    }
}
