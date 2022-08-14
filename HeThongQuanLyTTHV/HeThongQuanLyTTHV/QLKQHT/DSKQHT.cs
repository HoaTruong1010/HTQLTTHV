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
            //dùng f.ChucNang để gọi thuộc tính chức năng, gán bằng giá trị Add hoặc dì cũng được
            f.Show();
        }

        private void btChinh_Click(object sender, EventArgs e)
        {
            Them f = new Them();
            f.Chucnang = "chinh";//Tương tự nha 
            f.Show();
        }

        //Thiếu form xem danh sách nè, form chỉnh sửa vs them có thể dùng chung thông qua thuộc tính chức năng

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Them f = new Them();
            f.Chucnang = "xoa";//Tương tự nha 
            f.Show();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            XemDS f=new XemDS();
            f.Show();
        }
    }
}
