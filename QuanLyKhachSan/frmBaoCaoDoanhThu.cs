using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyKhachSan
{
    public partial class frmBaoCaoDoanhThu : Form
    {
        private HoaDonBUS bus = new HoaDonBUS();
        private List<HoaDonDTO> duLieu;

        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
            cmbThang.SelectedIndex = 0;
            frmMain TempForm = (frmMain)Application.OpenForms["frmMain"];
            duLieu = bus.LayDanhSachHoaDon(TempForm.kh, -1, new DateTime(2016,1,1), 0);
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
            if (duLieu == null)
                MessageBox.Show("Không tìm thấy hóa đơn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (!isNumeric(txtNam.Text))
                {
                    MessageBox.Show("Dữ liệu nhập vào phải là số !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<HoaDonDTO> danhSach = new List<HoaDonDTO>();

                int nam = int.Parse(txtNam.Text);
                int doanhThu = 0;

                if (cmbThang.SelectedIndex == 0)
                {
                    foreach (HoaDonDTO hd in duLieu)
                    {
                        if (hd.NgayThanhToan.Year == nam)
                        {
                            danhSach.Add(hd);
                            doanhThu += (int)hd.TongTien;
                        }
                    }
                }
                else
                {
                    foreach (HoaDonDTO hd in duLieu)
                    {
                        if (hd.NgayThanhToan.Month == cmbThang.SelectedIndex &&
                            hd.NgayThanhToan.Year == nam)
                        {
                            danhSach.Add(hd);
                            doanhThu += (int)hd.TongTien;
                        }
                    }
                }

                dtgvHoaDon.DataSource = danhSach;
                dtgvHoaDon.Columns["MaHD"].HeaderText = "Mã hoá đơn";
                dtgvHoaDon.Columns["NgayThanhToan"].HeaderText = "Ngày thanh toán";
                dtgvHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";
                dtgvHoaDon.Columns["MaDP"].Visible = false;

                lblDoanhThu.Text = doanhThu.ToString() + "$";
            }
        }
    }
}
