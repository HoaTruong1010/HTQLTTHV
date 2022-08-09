using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HeThongQuanLyTTHV
{
    public partial class ThemTKB : Form
    {
        public ThemTKB()
        {
            InitializeComponent();
        }

        private void ThemTKB_Load(object sender, EventArgs e)
        {
            //ComboBox chọn chương trình đạo tạo
            cbbCTDT.Items.Add("Tiếng Anh tổng quát thiếu nhi");
            cbbCTDT.Items.Add("Tiếng Anh tổng quát người lớn");
            cbbCTDT.Items.Add("Tiếng Anh giao tiếp");
            cbbCTDT.Items.Add("LUYỆN THI TOEIC");
            cbbCTDT.Items.Add("LUYỆN THI IELTS");

            //ListView - xem để thêm các khoá học vào danh sách tkb
            lvDSKH.View = View.Details;
            lvDSKH.GridLines = true;
            lvDSKH.FullRowSelect = true;
            //Tiêu đề các cột trong lvDSKH
            lvDSKH.Columns.Add("Chọn", 20);
            lvDSKH.Columns.Add("Cấp lớp", 50);
            lvDSKH.Columns.Add("Lớp", 35);
            lvDSKH.Columns.Add("Số buổi", 25);
            lvDSKH.Columns.Add("Số lượng", 25);
            lvDSKH.Columns.Add("Còn lại", 25);
            lvDSKH.Columns.Add("Thời khoá biểu", 200);

            //ListView - xem các khoá học đã thêm vào danh sách tkb
            lvDSKHThemTC.View = View.Details;
            lvDSKHThemTC.GridLines = true;
            lvDSKHThemTC.FullRowSelect = true;
            //Tiêu đề các cột trong lvDSKHThemTC
            lvDSKHThemTC.Columns.Add("Xoá", 20);
            lvDSKHThemTC.Columns.Add("Cấp lớp", 50);
            lvDSKHThemTC.Columns.Add("Lớp", 35);
            lvDSKHThemTC.Columns.Add("Số buổi", 25);
            lvDSKHThemTC.Columns.Add("Ngày đăng ký", 50);
            lvDSKHThemTC.Columns.Add("Thời khoá biểu", 200);
        }

        private void cbbChon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvDSKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
