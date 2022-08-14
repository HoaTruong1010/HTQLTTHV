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
        
        private string maPhieu, hoTen, capHoc, khoaHoc, lop, ngaysinh, score, gioiTinh, ghiChu, cccd, sdt;
        private double  diem;// cccd vs sđt là kiểu string nha, điểm là double

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string CapHoc { get => capHoc; set => capHoc = value; }
        public string KhoaHoc { get => khoaHoc; set => khoaHoc = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Score { get => score; set => score = value; }
        public double Diem { get => diem; set => diem = value; }

        public PhieuKetQua()
        {
            MaPhieu = HoTen = CapHoc = KhoaHoc = Lop = Ngaysinh = GioiTinh = GhiChu = Cccd = Sdt = Score = null;
            Diem=0;    
        }
        public PhieuKetQua(string maPhieu, string hoTen, string capHoc, string khoaHoc, string lop, string ngaysinh,
            string gioiTinh, string ghiChu, string cccd, string sdt, string score)
        {
            this.MaPhieu = maPhieu;
            this.HoTen = hoTen;
            this.CapHoc = capHoc;
            this.KhoaHoc = khoaHoc;
            this.Lop = lop;
            this.Ngaysinh = ngaysinh;
            this.GioiTinh = gioiTinh;
            this.GhiChu = ghiChu;
            this.Cccd = cccd;
            this.Sdt= sdt;
            this.Score = score; 
        }  
        public PhieuKetQua(double diem)
        {
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
            this.Cccd=p.Cccd;   
            this.Sdt=p.Sdt; 
            this.Diem=p.Diem;
            this.Score=p.Score; 
        }
    }
}
