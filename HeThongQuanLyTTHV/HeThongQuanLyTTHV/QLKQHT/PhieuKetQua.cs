using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyTTHV
{
    internal class PhieuKetQua
    {
        //Dữ Liệu
        private string[] maPhieu/*, hoTen, capHoc, khoaHoc, lop, ngaysinh, gioiTinh, ghiChu*/;
        //private int cCCCD, sDT, diem;
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

        //Thuộc Tính
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

        //Phương thức khởi tạo
        //public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        //public string HoTen { get => hoTen; set => hoTen = value; }
        //public string CapHoc { get => capHoc; set => capHoc = value; }
        //public string KhoaHoc { get => khoaHoc; set => khoaHoc = value; }
        //public string Lop { get => lop; set => lop = value; }
        //public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        //public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        //public string GhiChu { get => ghiChu; set => ghiChu = value; }
        //public int CCCD { get => cCCCD; set => cCCCD = value; }
        //public int SDT { get => sDT; set => sDT = value; }
        //public int Diem { get => diem; set => diem = value; }

        public PhieuKetQua()
        {
            maPhieu = { };
            hoTen = { };
            cCCD = 0;
            capHoc = { };
            khoaHoc = { };
            lop = { };
            sDT = 0;
            ngaySinh = { };
            diem = 0;
            gioiTinh = { };
            ghiChu = { };
        }

        public PhieuKetQua(string[] maPhieu,string[] hoTen, int[] cCCD, string[] capHoc,string[] khoaHoc,
             string[] lop, int[] sDt, string[] ngaySinh, int[] diem, string[] gioiTinh, string[] ghiChu)
        {
            this.MaPhieu = maPhieu;
            this.HoTen = hoTen;
            this.CCCD = cCCD;
            this.CapHoc = capHoc;
            this.KhoaHoc = khoaHoc;
            this.Lop = lop;
            this.SDT = sDT;
            this.NgaySinh = ngaySinh;
            this.Diem = diem;
            this.GioiTinh = gioiTinh;
            this.GhiChu = ghiChu;
        }       
    }
}
