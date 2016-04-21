using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class LoaiPhongDAO : AbstractDAO
    {
        public List<LoaiPhongDTO> LayDanhSachLoaiPhongTheoKhachSan(int MaKS)
        {
            using (SqlConnection con = Connect())
            {
                con.Open();
                string strQuery = string.Format("select maLoaiPhong, tenLoaiPhong, slTrong from LoaiPhong where maKS = {0}", MaKS);
                SqlCommand cmd = new SqlCommand(strQuery, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                List<LoaiPhongDTO> DanhSachLoaiPhong = new List<LoaiPhongDTO>();
                foreach (DataRow r in dt.Rows)
                {
                    LoaiPhongDTO lp = new LoaiPhongDTO();
                    lp.MaLoaiPhong = (int)r["maLoaiPhong"];
                    lp.TenloaiPhong = r["tenLoaiPhong"].ToString();
                    lp.SlTrong = (int)r["slTrong"];
                    DanhSachLoaiPhong.Add(lp);
                }
                con.Close();
                return DanhSachLoaiPhong;
            }
        }
    }
}
