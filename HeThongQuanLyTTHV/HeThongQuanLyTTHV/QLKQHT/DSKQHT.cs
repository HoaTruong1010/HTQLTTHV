using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongQuanLyTTHV;

namespace HeThongQuanLyTTHV.QLKQHT
{
    public partial class DSKQHT : Form
    {
        public DSKQHT()
        {
            InitializeComponent();
        }

        private void btThemm_Click(object sender, EventArgs e)
        {
            Them f = new Them();
            f.Chucnang = "add";
            f.Show();
        }

        private void btChinh_Click(object sender, EventArgs e)
        {
            Them f = new Them();
            f.Chucnang = "chinh";//Tương tự nha 
            f.Show();
        }


        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Them f = new Them();
            f.Chucnang = "xoa";
            f.Show();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            XemDS f=new XemDS();
            f.Show();
        }
    }
}
