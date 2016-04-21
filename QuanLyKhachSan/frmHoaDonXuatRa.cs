using System;
using System.Windows.Forms;
using DTO;

namespace QuanLyKhachSan
{
    public partial class frmHoaDonXuatRa : Form
    {
        public frmHoaDonXuatRa(DatPhongDTO dp, int tongTien)
        {
            InitializeComponent();
            rptHoaDon Report = new rptHoaDon();
            Report.SetParameterValue("parMaDP", dp.MaDP);
            Report.SetParameterValue("parMaPhong", dp.MaPhong);
            Report.SetParameterValue("parNgayDat", dp.NgayDat);
            Report.SetParameterValue("parNgayBatDau", dp.NgayBatDau);
            Report.SetParameterValue("parNgayTraPhong", dp.NgayTraPhong);
            Report.SetParameterValue("parDonGia", dp.DonGia);
            Report.SetParameterValue("parTongTien", tongTien);
            crystalReportViewerHoaDon.ReportSource = Report;
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
