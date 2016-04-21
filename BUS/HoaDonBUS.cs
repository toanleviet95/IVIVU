using System;
using System.Collections.Generic;
using DTO;
using DAO;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO dao = new HoaDonDAO();
        public List<HoaDonDTO> LayDanhSachHoaDon(KhachHangDTO NhanVien, int MaKH, DateTime NgayLap, decimal ThanhTien)
        {
            return dao.LayDanhSachHoaDon(NhanVien, MaKH, NgayLap, ThanhTien);
        }

        public int LapHoaDon(KhachHangDTO NhanVien, int MaDP)
        {
            return dao.LapHoaDon(NhanVien, MaDP);
        }
    }
}
