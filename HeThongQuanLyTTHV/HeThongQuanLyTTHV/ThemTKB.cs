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
using HeThongQuanLyTTHV.QLTKB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            //ComboBox chọn thứ
            cbbThu.Items.Add("----Chọn----");
            cbbThu.Items.Add("Thứ 2-4");
            cbbThu.Items.Add("Thứ 3-5");
            cbbThu.Items.Add("Thứ 4-6");
            cbbThu.Items.Add("Thứ 7-CN");

            //ComboBox chọn khung giờ học
            cbbKhungGioHoc.Items.Add("----Chọn----");
            cbbKhungGioHoc.Items.Add("Từ 7:45 - 9:45");
            cbbKhungGioHoc.Items.Add("Từ 8:30 - 10:30");
            cbbKhungGioHoc.Items.Add("Từ 17:15 - 19:15");
            cbbKhungGioHoc.Items.Add("Từ 19:15 - 21:15");

            //ListView - xem để thêm các khoá học vào danh sách tkb
            lvDSKH.View = View.Details;
            lvDSKH.GridLines = true;
            lvDSKH.FullRowSelect = true;
            //Tiêu đề các cột trong lvDSKH
            lvDSKH.Columns[0].Width = (int)(lvDSKH.Width * 0.09);
            //lvDSKH.Columns.Add("Chọn", 20);
            //lvDSKH.Columns.Add("Cấp lớp", 50);
            //lvDSKH.Columns.Add("Lớp", 35);
            //lvDSKH.Columns.Add("Số buổi", 25);
            //lvDSKH.Columns.Add("Số lượng", 25);
            //lvDSKH.Columns.Add("Còn lại", 25);
            //lvDSKH.Columns.Add("Thời khoá biểu", 200);
            //Hiển thị danh sách từ trong file

        }

        private void cbbCTDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox chọn cấp học có sẵn
            string chonCap = cbbCTDT.Text;
            switch (chonCap)
            {
                case "Tiếng Anh tổng quát thiếu nhi":
                    //
                    cbbLop.Items.Clear();
                    cbbLop.Items.Add("----Chọn----");
                    cbbCapLop.Items.Add("Căn Bản");
                    cbbCapLop.Items.Add("Sơ Cấp");
                    cbbCapLop.Items.Add("Trung Cấp");
                    cbbCapLop.Items.Add("Cao Cấp");
                    break;
                case "Tiếng Anh tổng quát người lớn":
                    cbbLop.Items.Clear();
                    cbbLop.Items.Add("----Chọn----");
                    cbbCapLop.Items.Add("Căn Bản");
                    cbbCapLop.Items.Add("Sơ Cấp");
                    cbbCapLop.Items.Add("Trung Cấp");
                    cbbCapLop.Items.Add("Cao Cấp");
                    break;
                case "Tiếng Anh giao tiếp":
                    cbbLop.Items.Clear();
                    cbbLop.Items.Add("----Chọn----");
                    cbbCapLop.Items.Add("Căn Bản");
                    cbbCapLop.Items.Add("Sơ Cấp");
                    cbbCapLop.Items.Add("Trung Cấp");
                    cbbCapLop.Items.Add("Cao Cấp");
                    break;
                case "Luyện thi TOEIC":
                    cbbLop.Items.Clear();
                    cbbLop.Items.Add("----Chọn----");
                    cbbCapLop.Items.Add("TOEIC 100-200");
                    cbbCapLop.Items.Add("TOEIC 200-400");
                    cbbCapLop.Items.Add("TOEIC 400-600");
                    cbbCapLop.Items.Add("TOEIC 600-750");
                    break;
                case "Luyện thi IELTS":
                    cbbLop.Items.Clear();
                    cbbLop.Items.Add("----Chọn----");
                    cbbCapLop.Items.Add("Pre-IELTS");
                    cbbCapLop.Items.Add("IELTS 4.0-5.0");
                    cbbCapLop.Items.Add("IELTS 5.0-6.5");
                    cbbCapLop.Items.Add("IELTS 6.5-7.5");
                    cbbCapLop.Items.Add("Luyện giải đề IELTS");
                    break;
                default:
                    break;
            }
        }

        private void cbbCapLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Combo Box chọn lớp có sẵn
            string chonLop = cbbCapLop.Text;
            if (string.Compare(cbbCTDT.Text, "Tiếng Anh tổng quát thiếu nhi") == 0)
            {
                switch (chonLop)
                {
                    case "Căn Bản":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("KS1");
                        cbbLop.Items.Add("KS2");
                        cbbLop.Items.Add("KS3");
                        cbbLop.Items.Add("KS4");
                        break;
                    case "Sơ Cấp":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("KS5");
                        cbbLop.Items.Add("KS6");
                        cbbLop.Items.Add("KS7");
                        cbbLop.Items.Add("KS8");
                        break;
                    case "Trung Cấp":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("KS9");
                        cbbLop.Items.Add("KS10");
                        cbbLop.Items.Add("KS11");
                        cbbLop.Items.Add("KS12");
                        break;
                    case "Cao Cấp":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("KS13");
                        cbbLop.Items.Add("KS14");
                        cbbLop.Items.Add("KS15");
                        cbbLop.Items.Add("KS16");
                        break;
                    default:
                        break;
                }
            }
            if (string.Compare(cbbCTDT.Text, "Tiếng Anh tổng quát người lớn") == 0)
            {
                switch (chonLop)
                {
                    case "Căn Bản":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("GE1");
                        cbbLop.Items.Add("GE2");
                        cbbLop.Items.Add("GE3");
                        cbbLop.Items.Add("GE4");
                        break;
                    case "Sơ Cấp":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("GE5");
                        cbbLop.Items.Add("GE6");
                        cbbLop.Items.Add("GE7");
                        cbbLop.Items.Add("GE8");
                        break;
                    case "Trung Cấp":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("GE9");
                        cbbLop.Items.Add("GE10");
                        cbbLop.Items.Add("GE11");
                        cbbLop.Items.Add("GE12");
                        break;
                    case "Cao Cấp":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("GE13");
                        cbbLop.Items.Add("GE14");
                        cbbLop.Items.Add("GE15");
                        cbbLop.Items.Add("GE16");
                        break;
                    default:
                        break;
                }
            }
            if (string.Compare(cbbCTDT.Text, "Tiếng Anh giao tiếp") == 0)
            {
                switch (chonLop)
                {
                    case "Căn Bản":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("CO1");
                        cbbLop.Items.Add("CO2");
                        cbbLop.Items.Add("CO3");
                        cbbLop.Items.Add("CO4");
                        break;
                    case "Sơ Cấp":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("CO5");
                        cbbLop.Items.Add("CO6");
                        cbbLop.Items.Add("CO7");
                        cbbLop.Items.Add("CO8");
                        break;
                    case "Trung Cấp":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("CO9");
                        cbbLop.Items.Add("CO10");
                        cbbLop.Items.Add("CO11");
                        cbbLop.Items.Add("CO12");
                        break;
                    case "Cao Cấp":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("CO13");
                        cbbLop.Items.Add("CO14");
                        cbbLop.Items.Add("CO15");
                        cbbLop.Items.Add("CO16");
                        break;
                    default:
                        break;
                }
            }
            if (string.Compare(cbbCTDT.Text, "Luyện thi TOEIC") == 0)
            {
                switch (chonLop)
                {
                    case "TOEIC 100-200":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("TC1");
                        cbbLop.Items.Add("TC2");
                        break;
                    case "TOEIC 200-400":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("TC5");
                        cbbLop.Items.Add("TC6");
                        break;
                    case "TOEIC 400-600":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("TC9");
                        cbbLop.Items.Add("TC10");
                        break;
                    case "TOEIC 600-750":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("TC15");
                        cbbLop.Items.Add("TC16");
                        break;
                    default:
                        break;
                }
            }
            if (string.Compare(cbbCTDT.Text, "Luyện thi IELTS") == 0)
            {
                switch (chonLop)
                {
                    case "Pre-IELTS":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("PIE1");
                        cbbLop.Items.Add("PIE2");
                        break;
                    case "IELTS 4.0-5.0":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("IE1");
                        cbbLop.Items.Add("IE2");
                        break;
                    case "IELTS 5.0-6.5":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("IE3");
                        cbbLop.Items.Add("IE4");
                        break;
                    case "IELTS 6.5-7.5":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("IE5");
                        cbbLop.Items.Add("IE6");
                        break;
                    case "Luyện giải đề IELTS":
                        cbbLop.Items.Clear();
                        cbbLop.Items.Add("----Chọn----");
                        cbbLop.Items.Add("IET1");
                        cbbLop.Items.Add("IET2");
                        break;
                    default:
                        break;
                }
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (cbbCTDT.Text!="")
            {
                ListViewItem item = new ListViewItem();
                ThoiKhoaBieu tkb = new ThoiKhoaBieu();
                tkb.MaLich = txtMaLich.Text;
                tkb.TenKH = cbbCTDT.Text;
                tkb.TenGV = txtTenGV.Text;
                tkb.CapLop = cbbCapLop.Text;
                tkb.Lop = cbbLop.Text;
                tkb.SoBuoi = Int32.Parse(txtSoBuoiHoc.Text);
                tkb.SLHV1 = Int32.Parse(txtSLHV.Text);
                tkb.Thu = cbbThu.Text;
                tkb.KhungGioHoc = cbbKhungGioHoc.Text;
                tkb.Phong = txtPhong.Text;

                item = new ListViewItem(txtMaLich.Text);
                item.SubItems.Add(tkb.TenKH);
                item.SubItems.Add(tkb.CapLop);
                item.SubItems.Add(tkb.Lop);
                item.SubItems.Add(tkb.SoBuoi.ToString());
                item.SubItems.Add(tkb.SLHV1.ToString());
                item.SubItems.Add(tkb.Thu);
                item.SubItems.Add(tkb.KhungGioHoc);
                item.SubItems.Add(tkb.Phong);
                item.SubItems.Add(tkb.TenGV);

                lvDSKH.Items.Add(item);
                txtMaLich.Text = "";
                txtMaLich.Focus();
            }    
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
