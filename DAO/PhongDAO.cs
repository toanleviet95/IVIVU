using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class PhongDAO : AbstractDAO
    {
        public List<PhongDTO> LayDanhSachPhongTheoLoaiPhong(int MaLoaiPhong)
        { 
            using (SqlConnection con = Connect())
            {
                con.Open();
                string strQuery = string.Format("select maPhong, soPhong from Phong where loaiPhong = {0}", MaLoaiPhong);
                SqlCommand cmd = new SqlCommand(strQuery, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                List<PhongDTO> DanhSachPhong = new List<PhongDTO>();
                foreach (DataRow r in dt.Rows)
                {
                    PhongDTO p = new PhongDTO();
                    p.MaPhong = (int)r["maPhong"];
                    p.SoPhong = (int)r["soPhong"];
                    DanhSachPhong.Add(p);
                }
                con.Close();
                return DanhSachPhong;
            }
        }

        public int DatPhong(KhachHangDTO kh, int MaKS, int MaPhong, DateTime NgayDat, DateTime NgayBatDau, DateTime NgayTraPhong)
        {
            using (SqlConnection con = Connect())
            {
                con.Open();
                string strStoredProcedure = "spDatPhong";
                SqlCommand cmd = new SqlCommand(strStoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenDangNhap", kh.TenDangNhap);
                cmd.Parameters.AddWithValue("@matKhau", kh.MatKhau);
                cmd.Parameters.AddWithValue("@maKS", MaKS);
                cmd.Parameters.AddWithValue("@maPhong", MaPhong);
                cmd.Parameters.AddWithValue("@ngayDat", NgayDat);
                cmd.Parameters.AddWithValue("@ngayBatDau", NgayBatDau);
                cmd.Parameters.AddWithValue("@ngayTraPhong", NgayTraPhong);
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
