using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DatPhongDAO : AbstractDAO
    {
        public List<DatPhongDTO> LayDanhSachDatPhongTheoMaKH(int MaKH)
        {
            using (SqlConnection con = Connect())
            {
                con.Open();
                string strQuery = string.Format("select maDP, maPhong, ngayDat, ngayBatDau, ngayTraPhong, donGia from DatPhong where maKH={0} and tinhTrang = 0", MaKH);
                SqlCommand cmd = new SqlCommand(strQuery, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                List<DatPhongDTO> DanhSachDatPhong = new List<DatPhongDTO>();
                foreach (DataRow r in dt.Rows)
                {
                    DatPhongDTO dp = new DatPhongDTO();
                    dp.MaDP = (int)r["maDP"];
                    dp.MaPhong = (int)r["maPhong"];
                    dp.NgayDat = DateTime.Parse(r["ngayDat"].ToString());
                    dp.NgayBatDau = DateTime.Parse(r["ngayBatDau"].ToString());
                    dp.NgayTraPhong = DateTime.Parse(r["ngayTraPhong"].ToString());
                    dp.DonGia = (decimal)r["donGia"];
                    DanhSachDatPhong.Add(dp);
                }
                con.Close();
                return DanhSachDatPhong;
            }
        }
    }
}
