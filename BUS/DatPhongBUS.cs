using System.Collections.Generic;
using DTO;
using DAO;

namespace BUS
{
    public class DatPhongBUS
    {
        DatPhongDAO dao = new DatPhongDAO();
        public List<DatPhongDTO> LayDanhSachDatPhongTheoMaKH(int MaKH)
        {
            return dao.LayDanhSachDatPhongTheoMaKH(MaKH);
        }
    }
}
