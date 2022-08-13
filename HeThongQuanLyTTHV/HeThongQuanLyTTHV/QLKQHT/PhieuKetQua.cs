using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyTTHV
{
    internal class PhieuKetQua
    {
        
        private string maPhieu, hoTen, capHoc, khoaHoc, lop, ngaysinh, gioiTinh, ghiChu;
        private int cCCD, sDT, diem;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string CapHoc { get => capHoc; set => capHoc = value; }
        public string KhoaHoc { get => khoaHoc; set => khoaHoc = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int CCCD { get => cCCD; set => cCCD = value; }
        public int SDT { get => sDT; set => sDT = value; }
        public int Diem { get => diem; set => diem = value; }

        public PhieuKetQua()
        {
            MaPhieu = HoTen = CapHoc = KhoaHoc = Lop = Ngaysinh = GioiTinh = GhiChu = null;
            CCCD=SDT=Diem=0;    
        }
        public PhieuKetQua(string maPhieu, string hoTen, string capHoc, string khoaHoc, string lop, string ngaysinh, string gioiTinh, string ghiChu, int cCCD, int sDT, int diem)
        {
            this.MaPhieu = maPhieu;
            this.HoTen = hoTen;
            this.CapHoc = capHoc;
            this.KhoaHoc = khoaHoc;
            this.Lop = lop;
            this.Ngaysinh = ngaysinh;
            this.GioiTinh = gioiTinh;
            this.GhiChu = ghiChu;
            this.CCCD = cCCD;
            this.SDT = sDT;
            this.Diem = diem;
        }   

        public PhieuKetQua(PhieuKetQua p)
        {
            this.MaPhieu = p.MaPhieu;
            this.HoTen=p.HoTen; 
            this.CapHoc=p.CapHoc;   
            this.KhoaHoc=p.KhoaHoc; 
            this.Lop=p.Lop;
            this.Ngaysinh=p.Ngaysinh;   
            this.GioiTinh=p.GioiTinh;   
            this.GhiChu=p.GhiChu;   
            this.CCCD=p.CCCD;   
            this.SDT=p.SDT; 
            this.Diem=p.Diem;
        }
    }
}
