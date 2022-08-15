using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyTTHV.QLTKB
{
    public partial class XemTKB : Form
    {
        public XemTKB()
        {
            InitializeComponent();
        }

        private void XemTKB_Load(object sender, EventArgs e)
        {
            //ComboBox chọn chương trình đạo tạo
            cbbCTDT.Items.Add("Tiếng Anh tổng quát thiếu nhi");
            cbbCTDT.Items.Add("Tiếng Anh tổng quát người lớn");
            cbbCTDT.Items.Add("Tiếng Anh giao tiếp");
            cbbCTDT.Items.Add("LUYỆN THI TOEIC");
            cbbCTDT.Items.Add("LUYỆN THI IELTS");


            //ListView - xem tkb các khoá học
            lvTKB.View = View.Details;
            lvTKB.GridLines = true;
            lvTKB.FullRowSelect = true;
            //Tiêu đề các cột trong lvDSKH
            lvTKB.Columns.Add("Cấp lớp", 50);
            lvTKB.Columns.Add("Lớp", 35);
            lvTKB.Columns.Add("Số buổi", 25);
            lvTKB.Columns.Add("Phòng", 35);
            lvTKB.Columns.Add("Thứ", 25);
            lvTKB.Columns.Add("Thời gian bắt đầu", 25);
            lvTKB.Columns.Add("Thời gian kết thúc", 25);
            lvTKB.Columns.Add("Thời gian học", 100);
        }

        private void cbbCTDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            
        }
    }
}
