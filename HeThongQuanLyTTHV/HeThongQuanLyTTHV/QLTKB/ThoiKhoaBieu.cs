using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyTTHV.QLTKB
{
    class ThoiKhoaBieu
    {
        private string maLich, tenKH, capLop, lop, thu, khungGioHoc, phong, tenGV;
        private int soBuoi, soLuongHV;

        public ThoiKhoaBieu()
        {
            maLich = tenKH = capLop = lop = thu = khungGioHoc = phong = tenGV = null;
            soBuoi = soLuongHV = 0;
        }

        public string MaLich { get => maLich; set => maLich = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string CapLop { get => capLop; set => capLop = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Thu { get => thu; set => thu = value; }
        public string KhungGioHoc { get => khungGioHoc; set => khungGioHoc = value; }
        public string Phong { get => phong; set => phong = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }
        public int SoBuoi { get => soBuoi; set => soBuoi = value; }
        public int SoLuongHV { get => soLuongHV; set => soLuongHV = value; }

        public ThoiKhoaBieu(string maLich, string tenKH, string capLop, string lop, string thu, string khungGioHoc, string phong, string tenGV, int soBuoi, int soLuongHV)
        {
            this.MaLich = maLich;
            this.TenKH = tenKH;
            this.CapLop = capLop;
            this.Lop = lop;
            this.Thu = thu;
            this.KhungGioHoc = khungGioHoc;
            this.Phong = phong;
            this.TenGV = tenGV;
            this.SoBuoi = soBuoi;
            this.SoLuongHV = soLuongHV;
        }

        public ThoiKhoaBieu(ThoiKhoaBieu t)
        {
            this.MaLich = t.maLich;
            this.TenKH = t.tenKH;
            this.CapLop = t.capLop;
            this.Lop = t.lop;
            this.Thu = t.thu;
            this.KhungGioHoc = t.khungGioHoc;
            this.Phong = t.phong;
            this.TenGV = t.tenGV;
            this.SoBuoi = t.soBuoi;
            this.SoLuongHV = t.soLuongHV;
        }
    }
}
