using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyTTHV
{
    internal class Lich
    {
        private string maLich, phong, diaDiem;
        private static int count = 0;



        public string MaLich { get => maLich; set => maLich = value; }
        public string Phong { get => phong; set => phong = value; }
        public string DiaDiem { get => diaDiem; set => diaDiem = value; }
    }
}
