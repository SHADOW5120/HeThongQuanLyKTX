using HeThongQuanLyKTX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKTX.ViewModels
{
    internal class SoPhongDayTheoKVViewModel
    {
        private readonly PhongViewModel _phongViewModel;
        private readonly KhuVucViewModel _khuVucViewModel;

        public SoPhongDayTheoKVViewModel()
        {
            _phongViewModel = new PhongViewModel();
            _khuVucViewModel = new KhuVucViewModel();
        }

        // Lấy danh sách khu vực
        public List<KhuVuc> GetAllKhuVuc()
        {
            return _khuVucViewModel.GetAllKhuVuc();
        }

        // Lấy danh sách số phòng đầy theo khu vực
        public Dictionary<string, int> GetFullRoomsByArea(string area)
        {
            var allRooms = _phongViewModel.GetAllPhong(); // Lấy danh sách phòng
            var allRoomTypes = new LoaiPhongViewModel().GetAllLoaiPhong(); // Lấy danh sách loại phòng
            var allAreas = _khuVucViewModel.GetAllKhuVuc(); // Lấy danh sách khu vực

            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var khuVuc in allAreas)
            {
                if (area == "Tất cả" || area == khuVuc.TenKV)
                {
                    // Kết hợp thông tin phòng với loại phòng
                    int fullRoomsCount = allRooms
                        .Where(p => p.MaKV == khuVuc.MaKV)
                        .Join(allRoomTypes,
                              phong => phong.MaLP,         // Khóa trong bảng phòng
                              loaiPhong => loaiPhong.MaLP, // Khóa trong bảng loại phòng
                              (phong, loaiPhong) => new { phong, loaiPhong })
                        .Where(combined => combined.phong.SoSVHienTai == combined.loaiPhong.SoSVToiDa) // Điều kiện phòng đầy
                        .Count();

                    result[khuVuc.TenKV] = fullRoomsCount;
                }
            }

            return result;
        }
    }
}
