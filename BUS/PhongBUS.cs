using System;
using System.Collections.Generic;
using DTO;
using DAO;

namespace BUS
{
    public class PhongBUS
    {
        PhongDAO dao = new PhongDAO();
        public List<PhongDTO> LayDanhSachPhongTheoLoaiPhong(int MaLoaiPhong)
        {
            return dao.LayDanhSachPhongTheoLoaiPhong(MaLoaiPhong);
        }
        public int DatPhong(KhachHangDTO kh, int MaKS, int MaPhong, DateTime NgayDat, DateTime NgayBatDau, DateTime NgayTraPhong)
        {
            return dao.DatPhong(kh, MaKS, MaPhong, NgayDat, NgayBatDau, NgayTraPhong);
        }
    }
}
