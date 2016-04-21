using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyKhachSan
{
    public partial class frmTraCuuKhachSan : Form
    {
        private KhachSanBUS bus = new KhachSanBUS();
        public frmTraCuuKhachSan()
        {
            InitializeComponent();
        }

        private void LoadDanhSachSoSao()
        {
            List<int> DanhSachSoSao = bus.LayDanhSachSoSao();
            cmbSoSao.Items.Add("Số sao");
            foreach (int sao in DanhSachSoSao)
            {
                cmbSoSao.Items.Add(sao);
            }
            cmbSoSao.SelectedIndex = 0;
        }

        private void LoadDanhSachThanhPho()
        {
            List<string> DanhSachThanhPho = bus.LayDanhSachThanhPho();
            cmbThanhPho.Items.Add("Thành phố");
            foreach (string tp in DanhSachThanhPho)
            {
                cmbThanhPho.Items.Add(tp);
            }
            cmbThanhPho.SelectedIndex = 0;
        }

        private void LoadDanhSachGia()
        {
            List<string> DanhSachGia = new List<string>() { "100$ - 300$", "300$ - 500$", "500$ - 700$", "700$ - 900$" };
            cmbGia.Items.Add("Giá");
            foreach(string gia in DanhSachGia)
            {
                cmbGia.Items.Add(gia);
            }
            cmbGia.SelectedIndex = 0;
        }

        private void frmTraCuuKhachSan_Load(object sender, EventArgs e)
        {
            LoadDanhSachSoSao();
            LoadDanhSachThanhPho();
            LoadDanhSachGia();
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string strSoSao = cmbSoSao.SelectedItem.ToString();
            string ThanhPho = cmbThanhPho.SelectedItem.ToString();
            string strGia = cmbGia.SelectedItem.ToString();
            int SoSao = 0;
            decimal GiaMin = 0;
            decimal GiaMax = 0;
            if (strSoSao == "Số sao")
            {
                SoSao = 0;
            }
            else
            {
                SoSao = int.Parse(strSoSao);
            }
            if (ThanhPho == "Thành phố")
                ThanhPho = "";
            if (strGia == "Giá")
            {
                GiaMin = 0;
                GiaMax = 0;
            }
            else
            {
                if (strGia == "100$ - 300$")
                {
                    GiaMin = 100;
                    GiaMax = 300;
                }
                else if (strGia == "300$ - 500$")
                {
                    GiaMin = 300;
                    GiaMax = 500;
                }
                else if(strGia == "500$ - 700$")
                {
                    GiaMin = 500;
                    GiaMax = 700;
                }
                else
                {
                    GiaMin = 700;
                    GiaMax = 900;
                }
            }
            List<KhachSanDTO> DanhSachKhachSan = bus.LayDanhSachKhachSan(SoSao, ThanhPho, GiaMin, GiaMax);
            if (DanhSachKhachSan == null)
                MessageBox.Show("Không tìm thấy khách sạn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (dtgvKhachSan.Columns["STT"] == null)
                    dtgvKhachSan.Columns.Add("STT", "STT");
                dtgvKhachSan.DataSource = DanhSachKhachSan;
                for (int i = 1; i <= dtgvKhachSan.RowCount; i++)
                {
                    dtgvKhachSan[0, i - 1].Value = i;
                }
                dtgvKhachSan.Columns["MaKS"].Visible = false;
                dtgvKhachSan.Columns["TenKS"].HeaderText = "Tên KS";
                dtgvKhachSan.Columns["SoSao"].HeaderText = "Số sao";
                dtgvKhachSan.Columns["SoNha"].HeaderText = "Số nhà";
                dtgvKhachSan.Columns["Duong"].HeaderText = "Đường";
                dtgvKhachSan.Columns["Quan"].HeaderText = "Quận";
                dtgvKhachSan.Columns["ThanhPho"].HeaderText = "Thành phố";
                dtgvKhachSan.Columns["GiaTB"].HeaderText = "Giá TB($)";
                dtgvKhachSan.Columns["MoTa"].Visible = false;
            }
        }
    }
}
