using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyKhachSan
{
    public partial class frmLapHoaDon : Form
    {
        private DatPhongBUS busDP = new DatPhongBUS();
        private HoaDonBUS busHD = new HoaDonBUS();
        public frmLapHoaDon()
        {
            InitializeComponent();
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool isNumeric(string Number)
        {
            int So;
            return int.TryParse(Number, out So);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmMain TempForm = (frmMain)Application.OpenForms["frmMain"];
            if (TempForm.kh.TenDangNhap == "" || TempForm.kh.MatKhau == "")
            {
                MessageBox.Show("Bạn đã đăng xuất khỏi chương trình !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int MaKH = 0;
                string strMaKH = txtMaKH.Text.Trim();
                if (strMaKH == "Mã khách hàng...")
                    strMaKH = "";
                if ((strMaKH != "" && !isNumeric(strMaKH)))
                {
                    MessageBox.Show("Dữ liệu nhập vào phải là số !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (strMaKH == "")
                    MaKH = 0;
                else
                    MaKH = int.Parse(strMaKH);
                List<DatPhongDTO> DanhSachDatPhong = busDP.LayDanhSachDatPhongTheoMaKH(MaKH);
                if (DanhSachDatPhong == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin đặt phòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dtgvDatPhong.DataSource = DanhSachDatPhong;
                    dtgvDatPhong.Columns["MaDP"].HeaderText = "Mã ĐP";
                    dtgvDatPhong.Columns["MaPhong"].HeaderText = "Mã phòng";
                    dtgvDatPhong.Columns["NgayDat"].HeaderText = "Ngày đặt";
                    dtgvDatPhong.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
                    dtgvDatPhong.Columns["NgayTraPhong"].HeaderText = "Ngày trả phòng";
                    dtgvDatPhong.Columns["DonGia"].HeaderText = "Đơn giá($)";
                    dtgvDatPhong.Columns["MaKH"].Visible = false;
                    dtgvDatPhong.Columns["MoTa"].Visible = false;
                    dtgvDatPhong.Columns["TinhTrang"].Visible = false;
                }
            }
        }

        private void txtMaKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "..Mã khách hàng..")
                txtMaKH.Text = "";
        }

        private void txtMaKH_Leave(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
                txtMaKH.Text = "..Mã khách hàng..";
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            if (dtgvDatPhong.RowCount <= 0)
            {
                MessageBox.Show("Bạn chưa chọn thông tin đặt phòng !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DataGridViewRow dtgvr = dtgvDatPhong.SelectedRows[0];
                frmMain TempForm = (frmMain)Application.OpenForms["frmMain"];
                string strMaDP = "";
                if (dtgvr.Cells["MaDP"].Value != null)
                    strMaDP = dtgvr.Cells["MaDP"].Value.ToString();
                int MaDP = int.Parse(strMaDP);
                int KetQuaTraVe = busHD.LapHoaDon(TempForm.kh, MaDP);
                if(KetQuaTraVe == -1)
                {
                    MessageBox.Show("Bạn đã đăng xuất khỏi chương trình !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(KetQuaTraVe == -2)
                {
                    MessageBox.Show("Mã đặt phòng không tồn tại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (KetQuaTraVe == -3)
                {
                    MessageBox.Show("Mã đặt phòng này đã được thanh toán hóa đơn rồi !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Tạo hóa đơn thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    DatPhongDTO dp = new DatPhongDTO
                    {
                        MaDP = MaDP,
                        MaPhong = int.Parse(dtgvr.Cells["MaPhong"].Value.ToString()),
                        NgayDat = DateTime.Parse(dtgvr.Cells["NgayDat"].Value.ToString()).Date,
                        NgayBatDau = DateTime.Parse(dtgvr.Cells["NgayBatDau"].Value.ToString()).Date,
                        NgayTraPhong = DateTime.Parse(dtgvr.Cells["NgayTraPhong"].Value.ToString()).Date,
                        DonGia = decimal.Parse(dtgvr.Cells["DonGia"].Value.ToString())
                    };
                    frmHoaDonXuatRa frm = new frmHoaDonXuatRa(dp, KetQuaTraVe);
                    frm.ShowDialog();
                }
            }
        }
    }
}
