using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyTTHV
{
    internal class PhieuKetQua
    {
        private string[] maPhieu;
        private string[] hoTen;
        private int[] cCCD;
        private string[] capHoc;
        private string[] khoaHoc;
        private string[] lop;
        private int[] sDT;
        private string[] ngaySinh;
        private int[] diem;
        private string[] gioiTinh;
        private string[] ghiChu;

        public string[] MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string[] HoTen { get => hoTen; set => hoTen = value; }
        public int[] CCCD { get => cCCD; set => cCCD = value; }
        public string[] CapHoc { get => capHoc; set => capHoc = value; }
        public string[] KhoaHoc { get => khoaHoc; set => khoaHoc = value; }
        public string[] Lop { get => lop; set => lop = value; }
        public int[] SDT { get => sDT; set => sDT = value; }
        public string[] NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int[] Diem { get => diem; set => diem = value; }
        public string[] GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string[] GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
