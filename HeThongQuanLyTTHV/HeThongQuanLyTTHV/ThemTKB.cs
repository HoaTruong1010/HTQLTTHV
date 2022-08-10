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
            //ComboBox chọn chương trình đạo tạo/tên khoá học
            cbbCTDT.Items.Add("----Chọn----");
            cbbCTDT.Items.Add("Tiếng Anh tổng quát thiếu nhi");
            cbbCTDT.Items.Add("Tiếng Anh tổng quát người lớn");
            cbbCTDT.Items.Add("Tiếng Anh giao tiếp");
            cbbCTDT.Items.Add("Luyện thi TOEIC");
            cbbCTDT.Items.Add("Luyện thi IELTS");

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
            //Hiển thị danh sách từ trong file
           
        }

        private void cbbCTDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox chọn cấp học
            string chonCap = cbbCTDT.Text;
            switch (chonCap)
            {
                case "Tiếng Anh tổng quát thiếu nhi":
                    cbbCapLop.Items.Add("----Chọn----");
                    cbbCapLop.Items.Add("Căn Bản");
                    cbbCapLop.Items.Add("Sơ Cấp");
                    cbbCapLop.Items.Add("Trung Cấp");
                    cbbCapLop.Items.Add("Cao Cấp");
                    break;
                case "Tiếng Anh tổng quát người lớn":
                    cbbCapLop.Items.Add("----Chọn----");
                    cbbCapLop.Items.Add("Căn Bản");
                    cbbCapLop.Items.Add("Sơ Cấp");
                    cbbCapLop.Items.Add("Trung Cấp");
                    cbbCapLop.Items.Add("Cao Cấp");
                    break;
                case "Tiếng Anh giao tiếp":
                    cbbCapLop.Items.Add("----Chọn----");
                    cbbCapLop.Items.Add("Căn Bản");
                    cbbCapLop.Items.Add("Sơ Cấp");
                    cbbCapLop.Items.Add("Trung Cấp");
                    cbbCapLop.Items.Add("Cao Cấp");
                    break;
                case "Luyện thi TOEIC":
                    cbbCapLop.Items.Add("----Chọn----");
                    cbbCapLop.Items.Add("TOEIC 100-200");
                    cbbCapLop.Items.Add("TOEIC 200-400");
                    cbbCapLop.Items.Add("TOEIC 400-600");
                    cbbCapLop.Items.Add("TOEIC 600-750");
                    break;
                case "Luyện thi IELTS":
                    cbbCapLop.Items.Add("----Chọn----");
                    cbbCapLop.Items.Add("Pre-IELTS");
                    cbbCapLop.Items.Add("IELTS 4.0-5.0");
                    cbbCapLop.Items.Add("IELTS 5.0-6.5");
                    cbbCapLop.Items.Add("IELTS 6.5-7.5");
                    cbbCapLop.Items.Add("Luyện giải đề IELTS");
                    break;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
            QLLH.frmQLLH.Show();
        }
    }
}
