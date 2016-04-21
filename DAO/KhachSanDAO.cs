using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class KhachSanDAO : AbstractDAO
    {
        public List<int> LayDanhSachSoSao()
        {
            using (SqlConnection con = Connect())
            {
                con.Open();
                string strQuery = "select distinct soSao from KhachSan";
                SqlCommand cmd = new SqlCommand(strQuery, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                List<int> DanhSachSoSao = new List<int>();
                foreach (DataRow r in dt.Rows)
                {
                    DanhSachSoSao.Add((int)r["soSao"]);
                }
                con.Close();
                return DanhSachSoSao;
            }
        }

        public List<string> LayDanhSachThanhPho()
        {
            using (SqlConnection con = Connect())
            {
                con.Open();
                string strQuery = "select distinct thanhPho from KhachSan";
                SqlCommand cmd = new SqlCommand(strQuery, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                List<string> DanhSachThanhPho = new List<string>();
                foreach (DataRow r in dt.Rows)
                {
                    DanhSachThanhPho.Add(r["thanhPho"].ToString());
                }
                con.Close();
                return DanhSachThanhPho;
            }
        }

        public List<KhachSanDTO> LayDanhSachKhachSan()
        {
            using (SqlConnection con = Connect())
            {
                con.Open();
                string strQuery = "select maKS, tenKS from KhachSan";
                SqlCommand cmd = new SqlCommand(strQuery, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                List<KhachSanDTO> DanhSachKhachSan = new List<KhachSanDTO>();
                foreach (DataRow r in dt.Rows)
                {
                    KhachSanDTO ks = new KhachSanDTO();
                    ks.MaKS = (int)r["maKS"];
                    ks.TenKS = r["tenKS"].ToString();
                    DanhSachKhachSan.Add(ks);
                }
                con.Close();
                return DanhSachKhachSan;
            }
        }

        public List<KhachSanDTO> LayDanhSachKhachSan(int SoSao, string ThanhPho, decimal GiaMin, decimal GiaMax)
        {
            using (SqlConnection con = Connect())
            {
                con.Open();
                string strStoredProcedure = "spTimKiemKhachSan";
                SqlCommand cmd = new SqlCommand(strStoredProcedure);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@soSao", SoSao);
                cmd.Parameters.AddWithValue("@thanhPho", ThanhPho);
                cmd.Parameters.AddWithValue("@giaMin", GiaMin);
                cmd.Parameters.AddWithValue("@giaMax", GiaMax);
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                List<KhachSanDTO> DanhSachKhachSan = new List<KhachSanDTO>();
                foreach (DataRow r in dt.Rows)
                {
                    KhachSanDTO ks = new KhachSanDTO();
                    ks.MaKS = (int)r["makS"];
                    ks.TenKS = r["tenKS"].ToString();
                    ks.SoSao = (int)r["soSao"];
                    ks.SoNha = r["soNha"].ToString();
                    ks.Duong = r["duong"].ToString();
                    ks.Quan = r["quan"].ToString();
                    ks.ThanhPho = r["thanhPho"].ToString();
                    ks.GiaTB = (decimal)r["giaTB"];
                    ks.MoTa = r["moTa"].ToString();
                    DanhSachKhachSan.Add(ks);
                }
                con.Close();
                return DanhSachKhachSan;
            }
        }
    }
}
