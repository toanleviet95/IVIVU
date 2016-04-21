using System;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyKhachSan
{
    public partial class frmDangKy : Form
    {
        private KhachHangBUS bus = new KhachHangBUS();
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.HoTen = txtHoTen.Text.Trim();
            kh.SoCMND = txtCMND.Text.Trim();
            kh.TenDangNhap = txtTenDangNhap.Text.Trim();
            kh.MatKhau = txtMatKhau.Text.Trim();
            kh.DiaChi = txtDiaChi.Text.Trim();
            kh.Email = txtEmail.Text.Trim();
            kh.SoDienThoai = txtSoDienThoai.Text.Trim();
            kh.MoTa = "Khách hàng";
            if (kh.HoTen == "Họ tên...")
                kh.HoTen = "";
            if (kh.SoCMND == "Số CMND...")
                kh.SoCMND = "";
            if (kh.TenDangNhap == "Tên đăng nhập...")
                kh.TenDangNhap = "";
            if (kh.MatKhau == "Mật khẩu...")
                kh.MatKhau = "";
            if (kh.DiaChi == "Địa chỉ...")
                kh.DiaChi = "";
            if (kh.SoDienThoai == "Số điện thoại...")
                kh.SoDienThoai = "";
            if (kh.Email == "Email...")
                kh.Email = "";
            int KetQuaTraVe = bus.ThemHocSinh(kh);
            if(KetQuaTraVe == 0)
            {
                MessageBox.Show("Bạn vui lòng điền các thông tin bắt buộc !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(KetQuaTraVe == -1)
            {
                MessageBox.Show("Tên đăng nhập hoặc Số CMND này đã được sử dụng để đăng ký !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đăng ký thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Close();
            }
        }

        private void txtHoTen_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "Họ tên...")
                txtHoTen.Text = "";
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
                txtHoTen.Text = "Họ tên...";
        }

        private void txtCMND_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text == "Số CMND...")
                txtCMND.Text = "";
        }

        private void txtCMND_Leave(object sender, EventArgs e)
        {
            if (txtCMND.Text == "")
                txtCMND.Text = "Số CMND...";
        }

        private void txtTenDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập...")
                txtTenDangNhap.Text = "";
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
                txtTenDangNhap.Text = "Tên đăng nhập...";
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu...")
            {
                txtMatKhau.Text = "";
                txtMatKhau.UseSystemPasswordChar = true;
            } 
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.Text = "Mật khẩu...";
            }
        }

        private void txtDiaChi_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "Địa chỉ...")
                txtDiaChi.Text = "";
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "")
                txtDiaChi.Text = "Địa chỉ...";
        }

        private void txtSoDienThoai_Click(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text == "Số điện thoại...")
                txtSoDienThoai.Text = "";
        }

        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text == "")
                txtSoDienThoai.Text = "Số điện thoại...";
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email...")
                txtEmail.Text = "";
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
                txtEmail.Text = "Email...";
        }
    }
}
