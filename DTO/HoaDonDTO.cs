using System;

namespace DTO
{
    public class HoaDonDTO
    {
        private int _maHD;
        private DateTime _ngayThanhToan;
        private decimal _tongTien;
        private int _maDP;

        public int MaHD
        {
            get
            {
                return _maHD;
            }

            set
            {
                _maHD = value;
            }
        }

        public DateTime NgayThanhToan
        {
            get
            {
                return _ngayThanhToan;
            }

            set
            {
                _ngayThanhToan = value;
            }
        }

        public decimal TongTien
        {
            get
            {
                return _tongTien;
            }

            set
            {
                _tongTien = value;
            }
        }

        public int MaDP
        {
            get
            {
                return _maDP;
            }

            set
            {
                _maDP = value;
            }
        }
    }
}
