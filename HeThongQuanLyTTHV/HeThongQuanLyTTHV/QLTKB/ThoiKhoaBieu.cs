using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyTTHV.QLTKB
{
    internal class ThoiKhoaBieu
    {
        private string maLich, capLop, lop, phong, diaDiem, giangVien, thoiGianHoc;
        private static int count = 0;
        private int soBuoi, soBuoiConLai;



        public string MaLich { get => maLich; set => maLich = value; }
        public string CapLop { get => capLop; set => capLop = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Phong { get => phong; set => phong = value; }
        public string DiaDiem { get => diaDiem; set => diaDiem = value; }
        public string GiangVien { get => giangVien; set => giangVien = value; }
        public int SoBuoi { get => soBuoi; set => soBuoi = value; }
        public int SoBuoiConLai { get => soBuoiConLai; set => soBuoiConLai = value; }
        public string ThoiGianHoc { get => thoiGianHoc; set => thoiGianHoc = value; }
    }
}
