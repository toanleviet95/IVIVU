using System.Collections.Generic;
using DTO;
using DAO;

namespace BUS
{
    public class LoaiPhongBUS
    {
        LoaiPhongDAO dao = new LoaiPhongDAO();
        public List<LoaiPhongDTO> LayDanhSachLoaiPhongTheoKhachSan(int MaKS)
        {
            return dao.LayDanhSachLoaiPhongTheoKhachSan(MaKS);
        }
    }
}
