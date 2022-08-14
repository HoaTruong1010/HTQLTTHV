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
using HeThongQuanLyTTHV.QLHV;
using ComboBox = System.Windows.Forms.ComboBox;

namespace HeThongQuanLyTTHV.QLTKB
{
    public partial class ThemTKB : Form
    {
        public ThemTKB()
        {
            InitializeComponent();
        }

        //Tạo list TKB
        List<ThoiKhoaBieu> listTKB = new List<ThoiKhoaBieu>(1000);
        internal List<ThoiKhoaBieu> ListTKB { get => listTKB; set => listTKB = value; }

        string path;
        string text;

        private void GhiFileDSTKB(string path, List<ThoiKhoaBieu> tkb)
        {
            if (File.Exists(path))
                File.Delete(path);
            if (listTKB.Count > 0)
                using (StreamWriter s = new StreamWriter(path))
                {
                    foreach (ThoiKhoaBieu t in tkb)
                    {
                        s.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}#{7}#{8}#{9}",
                        t.MaLich, t.TenKH, t.CapLop, t.Lop, t.SoBuoi,
                        t.SoLuongHV, t.Thu, t.KhungGioHoc, t.TenGV);
                    }
                }
            else
                return;
        }

        private void DocFileDSTKB()
        {
            try
            {
                path = Application.StartupPath + @"\Data\DSTKB.txt";
                if (File.Exists(path))
                    using (StreamReader s = new StreamReader(path))
                    {
                        string line;
                        string[] attributes;
                        while (s.Peek() >= 0)
                        {
                            line = s.ReadLine();
                            attributes = line.Split(new string[] { "#" }, StringSplitOptions.None);
                            ThoiKhoaBieu t = new ThoiKhoaBieu(attributes[0], attributes[1], attributes[2],
                                attributes[3], attributes[4], attributes[5], attributes[6],
                                attributes[7], Int32.Parse(attributes[8]), Int32.Parse(attributes[9]));
                            listTKB.Add(t);
                        }
                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void ThemTKB_Load(object sender, EventArgs e)
        {
            txtMaLich.Focus();
            DocFileDSTKB();

            path = Application.StartupPath + @"\Data\SubjectList.txt";

            cbbCTDT.Items.Clear();
            CheckDataKH(path, cbbCTDT, "");
            cbbCTDT.SelectedIndex = 0;
            cbbCapLop.Items.Add("---Chọn---");
            cbbCapLop.SelectedIndex = 0;
            cbbLop.Items.Add("-Chọn-");
            cbbLop.SelectedIndex = 0;

            //ComboBox chọn thứ
            cbbThu.Items.Add("----Chọn----");
            cbbThu.Items.Add("Thứ 2-4");
            cbbThu.Items.Add("Thứ 3-5");
            cbbThu.Items.Add("Thứ 4-6");
            cbbThu.Items.Add("Thứ 7-CN");
            cbbThu.SelectedIndex = 0;

            //ComboBox chọn khung giờ học
            cbbKhungGioHoc.Items.Add("----Chọn----");
            cbbKhungGioHoc.Items.Add("Từ 7:45 - 9:45");
            cbbKhungGioHoc.Items.Add("Từ 8:30 - 10:30");
            cbbKhungGioHoc.Items.Add("Từ 17:15 - 19:15");
            cbbKhungGioHoc.Items.Add("Từ 19:15 - 21:15");
            cbbKhungGioHoc.SelectedIndex = 0;

            //ListView - xem danh sách tkb
            lvDSKH.View = View.Details;
            lvDSKH.GridLines = true;
            lvDSKH.FullRowSelect = true;
            //lvDSKH.Columns[0].Width = (int)(lvDSKH.Width * 0.09);
        }

        private void CheckDataKH(string path, ComboBox box, string keys)
        {
            try
            {
                if (File.Exists(path))
                    using (StreamReader s = new StreamReader(path))
                    {
                        string line;
                        while (s.Peek() >= 0)
                        {
                            line = s.ReadLine();
                            if (line.StartsWith(keys))
                                box.Items.Add(line);
                        }
                    }
                else
                    MessageBox.Show("Không có dữ liệu cho khóa học", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cbbCTDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCTDT.SelectedIndex != 0)
            {
                cbbCapLop.Items.Clear();
                cbbCapLop.Items.Add("---Chọn---");
                cbbCapLop.SelectedIndex = 0;
                text = cbbCTDT.SelectedItem.ToString();
                text = "K" + text.Substring(text.Length - 2, 2);
                path = Application.StartupPath + @"\Data\LevelList.txt";
                CheckDataKH(path, cbbCapLop, text);
            }
        }

        private void cbbCapLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCapLop.SelectedIndex != 0)
            {
                cbbLop.Items.Clear();
                cbbLop.Items.Add("-Chọn-");
                cbbLop.SelectedIndex = 0;
                text = cbbCapLop.SelectedItem.ToString();
                text = text.Substring(0, 5);
                path = Application.StartupPath + @"\Data\ClassList.txt";
                CheckDataKH(path, cbbLop, text);
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
                tkb.SoLuongHV = Int32.Parse(txtSLHV.Text);
                tkb.Thu = cbbThu.Text;
                tkb.KhungGioHoc = cbbKhungGioHoc.Text;
                tkb.Phong = txtPhong.Text;

                try
                {
                    if (txtMaLich.Text == "" || txtTenGV.Text == "" || txtSoBuoiHoc.Text == ""
                        || txtSLHV.Text == "" || txtPhong.Text == "" || cbbCTDT.SelectedIndex == 0
                        || cbbCapLop.SelectedIndex == 0 || cbbLop.SelectedIndex == 0 || cbbThu.SelectedIndex == 0
                        || cbbKhungGioHoc.SelectedIndex == 0)
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    }
                    else
                    {
                        item = new ListViewItem(txtMaLich.Text);
                        item.SubItems.Add(tkb.TenKH);
                        item.SubItems.Add(tkb.CapLop);
                        item.SubItems.Add(tkb.Lop);
                        item.SubItems.Add(tkb.SoBuoi.ToString());
                        item.SubItems.Add(tkb.SoLuongHV.ToString());
                        item.SubItems.Add(tkb.Thu);
                        item.SubItems.Add(tkb.KhungGioHoc);
                        item.SubItems.Add(tkb.Phong);
                        item.SubItems.Add(tkb.TenGV);

                        lvDSKH.Items.Add(item);
                        txtMaLich.Text = "";
                        txtMaLich.Focus();
                    } 
                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                                
            }    
        }

        private void txtSoBuoiHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập vào 1 số!");
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            //Xử lý không điền đủ thông tin
            try
            {
                if (txtMaLich.Text == "" || txtTenGV.Text == "" || txtSoBuoiHoc.Text == ""
                    || txtSLHV.Text == "" || txtPhong.Text == "" || cbbCTDT.SelectedIndex == 0
                    || cbbCapLop.SelectedIndex == 0 || cbbLop.SelectedIndex == 0 || cbbThu.SelectedIndex == 0
                    || cbbKhungGioHoc.SelectedIndex == 0)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                else
                { 
                    string[] item = {txtMaLich.Text, txtTenGV.Text, txtSoBuoiHoc.Text, txtSLHV.Text,
                            txtPhong.Text, cbbCTDT.SelectedItem.ToString(), cbbCapLop.SelectedItem.ToString(),
                            cbbLop.SelectedItem.ToString(), cbbThu.SelectedItem.ToString(), cbbKhungGioHoc.SelectedItem.ToString()};
                    ThoiKhoaBieu t = new ThoiKhoaBieu();
                    t.MaLich = item[0];
                    t.TenGV = item[1];
                    t.SoBuoi = Int32.Parse(item[2]);
                    t.SoLuongHV = Int32.Parse(item[3]);
                    t.Phong = item[4];
                    t.TenKH = item[5];
                    t.CapLop = item[6];
                    t.Lop = item[7];
                    t.Thu = item[8];
                    t.KhungGioHoc = item[9];  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\Data\DSTKB.txt";
            GhiFileDSTKB(path, listTKB);
            this.Close();            
        }
    }
}
