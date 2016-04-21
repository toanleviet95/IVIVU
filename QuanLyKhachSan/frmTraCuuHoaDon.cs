using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyKhachSan
{
    public partial class frmTraCuuHoaDon : Form
    {
        private HoaDonBUS bus = new HoaDonBUS();
        public frmTraCuuHoaDon()
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
            int MaKH = 0;
            decimal ThanhTien = 0;
            DateTime NgayLap = dtpNgayLap.Value;
            string strMaKH = txtMaKH.Text.Trim();
            string strThanhTien = txtThanhTien.Text.Trim();
            if (strMaKH == "Mã khách hàng...")
                strMaKH = "";
            if (strThanhTien == "Thành tiền($)...")
                strThanhTien = "";
            if ((strMaKH != "" && !isNumeric(strMaKH)) || (strThanhTien != "" && !isNumeric(strThanhTien)))
            {
                MessageBox.Show("Dữ liệu nhập vào phải là số !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (strMaKH == "")
                MaKH = 0;
            else
                MaKH = int.Parse(strMaKH);
            if (strThanhTien == "")
                ThanhTien = 0;
            else
                ThanhTien = decimal.Parse(strThanhTien);
            List<HoaDonDTO> DanhSachHoaDon = bus.LayDanhSachHoaDon(TempForm.kh, MaKH, NgayLap, ThanhTien);
            if(DanhSachHoaDon == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dtgvHoaDon.DataSource = DanhSachHoaDon;
                dtgvHoaDon.Columns["MaHD"].HeaderText = "Mã hóa đơn";
                dtgvHoaDon.Columns["NgayThanhToan"].HeaderText = "Ngày thanh toán";
                dtgvHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";
                dtgvHoaDon.Columns["MaDP"].Visible = false;
            }
        }

        private void txtMaKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "Mã khách hàng...")
                txtMaKH.Text = "";
        }

        private void txtMaKH_Leave(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
                txtMaKH.Text = "Mã khách hàng...";
        }

        private void txtThanhTien_Click(object sender, EventArgs e)
        {
            if (txtThanhTien.Text == "Thành tiền($)...")
                txtThanhTien.Text = "";
        }

        private void txtThanhTien_Leave(object sender, EventArgs e)
        {
            if (txtThanhTien.Text == "")
                txtThanhTien.Text = "Thành tiền($)...";
        }
    }
}
