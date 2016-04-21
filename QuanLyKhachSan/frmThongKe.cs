using System;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKePhongTrong frm = new frmThongKePhongTrong();
            frm.ShowDialog();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            frmBaoCaoDoanhThu frm = new frmBaoCaoDoanhThu();
            frm.ShowDialog();
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
