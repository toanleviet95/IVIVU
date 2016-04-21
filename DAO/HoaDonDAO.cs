using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class HoaDonDAO : AbstractDAO
    {
        public List<HoaDonDTO> LayDanhSachHoaDon(KhachHangDTO NhanVien, int MaKH, DateTime NgayLap, decimal ThanhTien)
        {
            using (SqlConnection con = Connect())
            {
                con.Open();
                string strStoredProcedure = "spTimKemThongTinHoaDon";
                SqlCommand cmd = new SqlCommand(strStoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenDangNhap", NhanVien.TenDangNhap);
                cmd.Parameters.AddWithValue("@matKhau", NhanVien.MatKhau);
                cmd.Parameters.AddWithValue("@maKH", MaKH);
                cmd.Parameters.AddWithValue("@ngay", NgayLap);
                cmd.Parameters.AddWithValue("@tongTien", ThanhTien);
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                List<HoaDonDTO> DanhSachHoaDon = new List<HoaDonDTO>();
                foreach (DataRow r in dt.Rows)
                {
                    HoaDonDTO hd = new HoaDonDTO();
                    hd.MaHD = (int)r["maHD"];
                    hd.NgayThanhToan = DateTime.Parse(r["ngayThanhToan"].ToString());
                    hd.TongTien = (decimal)r["tongTien"];
                    DanhSachHoaDon.Add(hd);
                }
                con.Close();
                return DanhSachHoaDon;
            }
        }

        public int LapHoaDon(KhachHangDTO NhanVien, int MaDP)
        {
            using (SqlConnection con = Connect())
            {
                con.Open();
                string strStoredProcedure = "spLapHoaDon";
                SqlCommand cmd = new SqlCommand(strStoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenDangNhap", NhanVien.TenDangNhap);
                cmd.Parameters.AddWithValue("@matKhau", NhanVien.MatKhau);
                cmd.Parameters.AddWithValue("@maDP", MaDP);
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
