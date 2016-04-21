using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class KhachHangDAO : AbstractDAO
    {
        public int ThemKhachHang(KhachHangDTO kh)
        {
            using (SqlConnection con = Connect())
            {
                con.Open();
                string strStoredProcedure = "spThemKhachHang";
                SqlCommand cmd = new SqlCommand(strStoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@hoTen", kh.HoTen);
                cmd.Parameters.AddWithValue("@tenDangNhap", kh.TenDangNhap);
                cmd.Parameters.AddWithValue("@matKhau", kh.MatKhau);
                cmd.Parameters.AddWithValue("@soCMND", kh.SoCMND);
                cmd.Parameters.AddWithValue("@diaChi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@soDienThoai", kh.SoDienThoai);
                cmd.Parameters.AddWithValue("@moTa", kh.MoTa);
                cmd.Parameters.AddWithValue("@email", kh.Email);
                cmd.Connection = con;
                SqlParameter parKQ = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                parKQ.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                int KetQuaTraVe = (int)parKQ.Value;
                con.Close();
                return KetQuaTraVe;
            }
        }

        public int DangNhap(string TenDangNhap, string MatKhau)
        {
            using (SqlConnection con = Connect())
            {
                con.Open();
                string strStoredProcedure = "spDangNhap";
                SqlCommand cmd = new SqlCommand(strStoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenDangNhap", TenDangNhap);
                cmd.Parameters.AddWithValue("@matKhau", MatKhau);
                cmd.Connection = con;
                SqlParameter parKQ = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                parKQ.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                int KetQuaTraVe = (int)parKQ.Value;
                con.Close();
                return KetQuaTraVe;
            }
        }
    }
}
