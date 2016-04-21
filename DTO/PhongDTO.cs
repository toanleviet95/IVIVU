using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongDTO
    {
        private int _maPhong;
        private int _maLoaiPhong;
        private int _soPhong;

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

        public int SoPhong
        {
            get
            {
                return _soPhong;
            }

            set
            {
                _soPhong = value;
            }
        }
    }
}
