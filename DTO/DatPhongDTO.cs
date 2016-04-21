using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatPhongDTO
    {
        int _maDP;
        int _maPhong;
        int _maKH;
        DateTime _ngayBatDau;
        DateTime _ngayTraPhong;
        DateTime _ngayDat;
        decimal _donGia;
        string _moTa;
        int _tinhTrang;

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

        public int MaPhong
        {
            get
            {
                return _maPhong;
            }

            set
            {
                _maPhong = value;
            }
        }

        public int MaKH
        {
            get
            {
                return _maKH;
            }

            set
            {
                _maKH = value;
            }
        }

        public DateTime NgayBatDau
        {
            get
            {
                return _ngayBatDau;
            }

            set
            {
                _ngayBatDau = value;
            }
        }

        public DateTime NgayTraPhong
        {
            get
            {
                return _ngayTraPhong;
            }

            set
            {
                _ngayTraPhong = value;
            }
        }

        public DateTime NgayDat
        {
            get
            {
                return _ngayDat;
            }

            set
            {
                _ngayDat = value;
            }
        }

        public decimal DonGia
        {
            get
            {
                return _donGia;
            }

            set
            {
                _donGia = value;
            }
        }

        public string MoTa
        {
            get
            {
                return _moTa;
            }

            set
            {
                _moTa = value;
            }
        }

        public int TinhTrang
        {
            get
            {
                return _tinhTrang;
            }

            set
            {
                _tinhTrang = value;
            }
        }
    }
}
