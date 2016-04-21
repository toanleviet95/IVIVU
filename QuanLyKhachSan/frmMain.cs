using System;
using System.Drawing;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyKhachSan
{
    public partial class frmMain : Form
    {
        private KhachHangBUS busKH = new KhachHangBUS();
        public KhachHangDTO kh;

        public frmMain()
        {
            InitializeComponent();
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblDangNhap_MouseHover(object sender, EventArgs e)
        {
            lblDangNhap.ForeColor = lblDienThoai.ForeColor;
        }

        private void lblDangNhap_MouseLeave(object sender, EventArgs e)
        {
            lblDangNhap.ForeColor = Color.White;
        }

        private void lblDangKy_MouseHover(object sender, EventArgs e)
        {
            lblDangKy.ForeColor = lblDienThoai.ForeColor;
        }

        private void lblDangKy_MouseLeave(object sender, EventArgs e)
        {
            lblDangKy.ForeColor = Color.White;
        }

        private void txtTenDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text == "...Tên đăng nhập...")
                txtTenDangNhap.Text = "";
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "...Mật khẩu...")
            {
                txtMatKhau.Text = "";
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
                txtTenDangNhap.Text = "...Tên đăng nhập...";
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.Text = "...Mật khẩu...";
            }
        }

        private void lblDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frm = new frmDangKy();
            frm.Show();
        }

        private void lblDangXuat_MouseHover(object sender, EventArgs e)
        {
            lblDangXuat.ForeColor = lblDienThoai.ForeColor;
        }

        private void lblDangXuat_MouseLeave(object sender, EventArgs e)
        {
            lblDangXuat.ForeColor = Color.White;
        }

        private void HideLogin()
        {
            txtTenDangNhap.Visible = false;
            txtMatKhau.Visible = false;
            lblDangNhap.Visible = false;
            picDangNhap.Visible = false;
        }

        private void ShowLogin()
        {
            txtTenDangNhap.Visible = true;
            txtMatKhau.Visible = true;
            lblDangNhap.Visible = true;
            picDangNhap.Visible = true;
        }

        private void HideLogout()
        {
            lblTenDangNhap.Visible = false;
            lblDangXuat.Visible = false;
            picDangXuat.Visible = false;
            btnDatPhong.Enabled = false;
            btnLapHoaDon.Enabled = false;
            btnThongKe.Enabled = false;
            btnTraCuu.Text = "Tra cứu khách sạn";
            kh.TenDangNhap = "";
            kh.MatKhau = "";
        }

        private void ShowLogout(string TenDangNhap, int PhanQuyen)
        {
            if(PhanQuyen == 1)
            {
                TenDangNhap = "Nhân viên: " + TenDangNhap;
            }
            else
            {
                TenDangNhap = "Khách hàng: " + TenDangNhap;
            }
            lblTenDangNhap.Text = TenDangNhap;
            lblTenDangNhap.Visible = true;
            lblDangXuat.Visible = true;
            picDangXuat.Visible = true;
        }

        private void lblDangXuat_Click(object sender, EventArgs e)
        {
            HideLogout();
            ShowLogin();
        }

        private void picDangXuat_Click(object sender, EventArgs e)
        {
            HideLogout();
            ShowLogin();
        }

        private void DangNhap()
        {
            string TenDangNhap = txtTenDangNhap.Text.Trim();
            string MatKhau = txtMatKhau.Text.Trim();
            if (TenDangNhap == "...Tên đăng nhập...")
                TenDangNhap = "";
            if (MatKhau == "...Mật khẩu...")
                MatKhau = "";
            int KetQuaTraVe = busKH.DangNhap(TenDangNhap, MatKhau);
            if (KetQuaTraVe == -1)
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin Tên đăng nhập và Mật khẩu !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(KetQuaTraVe == 0)
            {
                MessageBox.Show("Tài khoản này không hợp lệ !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kh = new KhachHangDTO();
                kh.TenDangNhap = TenDangNhap;
                kh.MatKhau = MatKhau;
                HideLogin();
                ShowLogout(TenDangNhap, KetQuaTraVe);
                if (KetQuaTraVe == 1)
                {
                    btnLapHoaDon.Enabled = true;
                    btnThongKe.Enabled = true;
                    btnDatPhong.Enabled = false;
                    btnTraCuu.Text = "Tra cứu hóa đơn";
                }
                else
                {
                    btnDatPhong.Enabled = true;
                    btnLapHoaDon.Enabled = false;
                    btnThongKe.Enabled = false;
                    btnTraCuu.Text = "Tra cứu khách sạn";
                }
            }
        }

        private void lblDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void picDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (btnTraCuu.Text == "Tra cứu khách sạn")
            {
                frmTraCuuKhachSan frm = new frmTraCuuKhachSan();
                frm.ShowDialog();
            }
            else
            {
                frmTraCuuHoaDon frm = new frmTraCuuHoaDon();
                frm.ShowDialog();
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            frmDatPhong frm = new frmDatPhong();
            frm.ShowDialog();
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            frmLapHoaDon frm = new frmLapHoaDon();
            frm.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.ShowDialog();
        }
    }
}
