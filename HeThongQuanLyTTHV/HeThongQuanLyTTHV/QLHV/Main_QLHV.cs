using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyTTHV.QLHV
{
    public partial class Main_QLHV : Form
    {
        public Main_QLHV()
        {
            InitializeComponent();
        }

        private void thêmThôngTinHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHV.ThongTinHocVien frmTTHV = new ThongTinHocVien();
            frmTTHV.ChucNang = "Add";
            frmTTHV.Show();
        }

        private void xemDanhSáchThôngTinHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHV.DanhSachHocVien frmDSHV = new DanhSachHocVien();
            frmDSHV.Show();
        }

        private void chỉnhSửaThôngTinHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHV.ThongTinHocVien frmTTHV = new ThongTinHocVien();
            frmTTHV.ChucNang = "Edit";
            frmTTHV.Show();
        }

        private void xóaThôngTinHọcViênKhỏiDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHV.frmXoaHV frmXoa = new frmXoaHV();
            frmXoa.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
