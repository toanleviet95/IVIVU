using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyKhachSan
{
    public partial class frmDatPhong : Form
    {
        KhachSanBUS busKS = new KhachSanBUS();
        LoaiPhongBUS busLP = new LoaiPhongBUS();
        PhongBUS busPhong = new PhongBUS();
        public frmDatPhong()
        {
            InitializeComponent();
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            List<KhachSanDTO> DSKhachSan = busKS.LayDanhSachKhachSan();
            cmbKhachSan.DataSource = DSKhachSan;
            cmbKhachSan.ValueMember = "MaKS";
            cmbKhachSan.DisplayMember = "TenKS";
        }

        private bool isNumeric(string Number)
        {
            int So;
            return int.TryParse(Number, out So);
        }

        private void cmbKhachSan_SelectedValueChanged(object sender, EventArgs e)
        {
            string strMaKS = cmbKhachSan.SelectedValue.ToString();
            if (isNumeric(strMaKS))
            {
                int MaKS = int.Parse(strMaKS);
                List<LoaiPhongDTO> DSLoaiPhong = busLP.LayDanhSachLoaiPhongTheoKhachSan(MaKS);
                cmbLoaiPhong.DataSource = DSLoaiPhong;
                cmbLoaiPhong.ValueMember = "MaLoaiPhong";
                cmbLoaiPhong.DisplayMember = "TenLoaiPhong";
            }
        }

        private void btnTimPhong_Click(object sender, EventArgs e)
        {
            frmMain TempForm = (frmMain)Application.OpenForms["frmMain"];
            if (TempForm.kh.TenDangNhap == "" || TempForm.kh.MatKhau == "")
            {
                MessageBox.Show("Bạn đã đăng xuất khỏi chương trình !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string strMaLP = cmbLoaiPhong.SelectedValue.ToString();
                if (isNumeric(strMaLP))
                {
                    int MaLoaiPhong = int.Parse(strMaLP);
                    List<PhongDTO> DSPhong = busPhong.LayDanhSachPhongTheoLoaiPhong(MaLoaiPhong);
                    dtgvDanhSachPhong.DataSource = DSPhong;
                    dtgvDanhSachPhong.Columns["MaPhong"].HeaderText = "Mã phòng";
                    dtgvDanhSachPhong.Columns["SoPhong"].HeaderText = "Số phòng";
                    dtgvDanhSachPhong.Columns["MaLoaiPhong"].Visible = false;
                }
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachPhong.RowCount <= 0)
            {
                MessageBox.Show("Bạn chưa chọn phòng đặt !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DataGridViewRow dtgvr = dtgvDanhSachPhong.SelectedRows[0];
                frmMain TempForm = (frmMain)Application.OpenForms["frmMain"];
                string strMaKS = cmbKhachSan.SelectedValue.ToString();
                string strMaPhong = "";
                if (dtgvr.Cells["MaPhong"].Value != null)
                    strMaPhong = dtgvr.Cells["MaPhong"].Value.ToString();
                int MaPhong = int.Parse(strMaPhong);
                int MaKS = int.Parse(strMaKS);
                DateTime NgayDat = DateTime.Now.Date;
                DateTime NgayBatDau = dtpBatDau.Value.Date;
                DateTime NgayKetThuc = dtpKetThuc.Value.Date;
                
                if (DateTime.Compare(NgayBatDau,NgayDat) == -1 || DateTime.Compare(NgayBatDau, NgayKetThuc) == 1 || DateTime.Compare(NgayKetThuc, NgayDat) == -1)
                {
                    MessageBox.Show("Thông tin ngày bạn chọn chưa chính xác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (strMaPhong == "")
                {
                    MessageBox.Show("Bạn chưa chọn phòng đặt !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int KetQuaTraVe = busPhong.DatPhong(TempForm.kh, MaKS, MaPhong, NgayDat, NgayBatDau, NgayKetThuc);
                if (KetQuaTraVe == -1)
                {
                    MessageBox.Show("Bạn đã đăng xuất khỏi chương trình !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (KetQuaTraVe == -2)
                {
                    MessageBox.Show("Phòng chọn không hợp lệ !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (KetQuaTraVe == -3)
                {
                    MessageBox.Show("Loại phòng này không thuộc khách sạn này !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (KetQuaTraVe == -4)
                {
                    MessageBox.Show("Phòng này không còn trống !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Đặt phòng thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
