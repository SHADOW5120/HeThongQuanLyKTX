using HeThongQuanLyKTX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyKTX.ViewModels
{
    internal class SoPhongTrongTheoKVViewModel
    {
        private readonly PhongViewModel _phongViewModel;
        private readonly KhuVucViewModel _khuVucViewModel;

        public SoPhongTrongTheoKVViewModel()
        {
            _phongViewModel = new PhongViewModel();
            _khuVucViewModel = new KhuVucViewModel();
        }

        // Lấy danh sách khu vực
        public List<KhuVuc> GetAllKhuVuc()
        {
            return _khuVucViewModel.GetAllKhuVuc();
        }

        // Lấy danh sách số phòng trống theo khu vực
        public Dictionary<string, int> GetEmptyRoomsByArea(string area)
        {
            var allRooms = _phongViewModel.GetAllPhong(); // Danh sách phòng
            var allRoomTypes = new LoaiPhongViewModel().GetAllLoaiPhong(); // Danh sách loại phòng
            var allAreas = _khuVucViewModel.GetAllKhuVuc(); // Danh sách khu vực

            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var khuVuc in allAreas)
            {
                if (area == "Tất cả" || area == khuVuc.TenKV)
                {
                    // Kết hợp thông tin phòng và loại phòng
                    int emptyRoomsCount = allRooms
                        .Where(p => p.MaKV == khuVuc.MaKV)
                        .Join(allRoomTypes,
                              phong => phong.MaLP,         // Khóa từ bảng phòng
                              loaiPhong => loaiPhong.MaLP, // Khóa từ bảng loại phòng
                              (phong, loaiPhong) => new { phong, loaiPhong })
                        .Where(combined => combined.phong.SoSVHienTai < combined.loaiPhong.SoSVToiDa) // Phòng trống
                        .Count();

                    result[khuVuc.TenKV] = emptyRoomsCount;
                }
            }

            return result;
        }

    }
}
