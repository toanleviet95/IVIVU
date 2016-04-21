using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmThongKePhongTrong : Form
    {
        private KhachSanBUS ksBus = new KhachSanBUS();
        private LoaiPhongBUS lpBus = new LoaiPhongBUS();

        private List<ThongTinPhongTrong> duLieu = new List<ThongTinPhongTrong>();


        public frmThongKePhongTrong()
        {
            InitializeComponent();
            cmbThuTu.SelectedIndex = 0;
            LoadDuLieu();
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadDuLieu()
        {
            List<KhachSanDTO> DanhSachKhachSan = ksBus.LayDanhSachKhachSan(0, "", 0, 0);
            if (DanhSachKhachSan == null)
            {
                MessageBox.Show("Không tìm thấy khách sạn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (KhachSanDTO ks in DanhSachKhachSan)
            {
                List<LoaiPhongDTO> DanhSachLoaiPhong = lpBus.LayDanhSachLoaiPhongTheoKhachSan(ks.MaKS);
                foreach (LoaiPhongDTO lp in DanhSachLoaiPhong)
                    duLieu.Add(new ThongTinPhongTrong(
                            ks.TenKS,
                            ks.SoSao,
                            ks.ThanhPho,
                            lp.TenloaiPhong,
                            lp.SlTrong    
                        ));
            }
            dtgvPhongTrong.DataSource = duLieu;
            dtgvPhongTrong.Columns["TenKS"].HeaderText = "Tên KS";
            dtgvPhongTrong.Columns["SoSao"].HeaderText = "Số sao";
            dtgvPhongTrong.Columns["ThanhPho"].HeaderText = "Thành phố";
            dtgvPhongTrong.Columns["TenLoaiPhong"].HeaderText = "Loại phòng";
            dtgvPhongTrong.Columns["SlTrong"].HeaderText = "Số lượng trống";
        }

        private void cmbTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            XuLySapXep();
        }

        private void cmbThuTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            XuLySapXep();
        }

        private void XuLySapXep()
        {
            if (cmbTieuChi.SelectedIndex == 0)
            {
                if (cmbThuTu.SelectedIndex == 0)
                    duLieu.Sort(SoSanhTheoThanhPho_TangDan);
                else
                    duLieu.Sort(SoSanhTheoThanhPho_GiamDan);
            }
            else if (cmbTieuChi.SelectedIndex == 1)
            {
                if (cmbThuTu.SelectedIndex == 0)
                    duLieu.Sort(SoSanhTheoSoSao_TangDan);
                else
                    duLieu.Sort(SoSanhTheoSoSao_GiamDan);
            }

            dtgvPhongTrong.Refresh();
        }


        private int SoSanhTheoSoSao_TangDan(ThongTinPhongTrong x, ThongTinPhongTrong y)
        {
            int ret = x.SoSao.CompareTo(y.SoSao);
            if (ret == 0)
                return x.TenKS.CompareTo(y.TenKS);
            return ret;
        }

        private int SoSanhTheoSoSao_GiamDan(ThongTinPhongTrong x, ThongTinPhongTrong y)
        {
            int ret = y.SoSao.CompareTo(x.SoSao);
            if (ret == 0)
                return x.TenKS.CompareTo(y.TenKS);
            return ret;
        }

        private int SoSanhTheoThanhPho_TangDan(ThongTinPhongTrong x, ThongTinPhongTrong y)
        {
            int ret = x.ThanhPho.CompareTo(y.ThanhPho);
            if (ret == 0)
                return x.TenKS.CompareTo(y.TenKS);
            return ret;
        }

        private int SoSanhTheoThanhPho_GiamDan(ThongTinPhongTrong x, ThongTinPhongTrong y)
        {
            int ret = y.ThanhPho.CompareTo(x.ThanhPho);
            if (ret == 0)
                return x.TenKS.CompareTo(y.TenKS);
            return ret;
        }

    }

    public class ThongTinPhongTrong
    {
        private string _tenKS;
        private int _soSao;
        private string _thanhPho;
        private string _tenloaiPhong;
        private int _slTrong;

        public string TenKS
        {
            get
            {
                return _tenKS;
            }

            set
            {
                _tenKS = value;
            }
        }

        public int SoSao
        {
            get
            {
                return _soSao;
            }

            set
            {
                _soSao = value;
            }
        }

        public string ThanhPho
        {
            get
            {
                return _thanhPho;
            }

            set
            {
                _thanhPho = value;
            }
        }

        public string TenloaiPhong
        {
            get
            {
                return _tenloaiPhong;
            }

            set
            {
                _tenloaiPhong = value;
            }
        }

        public int SlTrong
        {
            get
            {
                return _slTrong;
            }

            set
            {
                _slTrong = value;
            }
        }

        public ThongTinPhongTrong(string tenKs, int soSao, string thanhPho, string tenLoaiPhong, int slTrong)
        {
            _tenKS = tenKs;
            _soSao = soSao;
            _thanhPho = thanhPho;
            _tenloaiPhong = tenLoaiPhong;
            _slTrong = slTrong;
        }
    }
    
}
