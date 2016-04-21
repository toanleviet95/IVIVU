using System.Collections.Generic;
using DTO;
using DAO;

namespace BUS
{
    public class KhachSanBUS
    {
        private KhachSanDAO dao = new KhachSanDAO();
        public List<int> LayDanhSachSoSao()
        {
            return dao.LayDanhSachSoSao();
        }

        public List<string> LayDanhSachThanhPho()
        {
            return dao.LayDanhSachThanhPho();
        }

        public List<KhachSanDTO> LayDanhSachKhachSan()
        {
            return dao.LayDanhSachKhachSan();
        }

        public List<KhachSanDTO> LayDanhSachKhachSan(int SoSao, string ThanhPho, decimal GiaMin, decimal GiaMax)
        {
            return dao.LayDanhSachKhachSan(SoSao, ThanhPho, GiaMin, GiaMax);
        }
    }
}
