using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhongDTO
    {
        int _maLoaiPhong;
        string _tenloaiPhong;
        int _maKS;
        decimal _donGia;
        string _moTa;
        int _slTrong;

        public int MaLoaiPhong
        {
            get
            {
                return _maLoaiPhong;
            }

            set
            {
                _maLoaiPhong = value;
            }
        }

        public string TenloaiPhong
        {
            get
            {
                return _tenloaiPhong;
            }

            set
            {
                _tenloaiPhong = value;
            }
        }

        public int MaKS
        {
            get
            {
                return _maKS;
            }

            set
            {
                _maKS = value;
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

        public int SlTrong
        {
            get
            {
                return _slTrong;
            }

            set
            {
                _slTrong = value;
            }
        }
    }
}
