using DTO;
using DAO;

namespace BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAO dao = new KhachHangDAO();
        public int ThemHocSinh(KhachHangDTO kh)
        {
            return dao.ThemKhachHang(kh);
        }

        public int DangNhap(string TenDangNhap, string MatKhau)
        {
            return dao.DangNhap(TenDangNhap, MatKhau);
        }
    }
}
