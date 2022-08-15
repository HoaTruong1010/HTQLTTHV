using HeThongQuanLyTTHV.QLHV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = System.Windows.Forms.Application;
using ComboBox = System.Windows.Forms.ComboBox;

namespace HeThongQuanLyTTHV.QLTKB
{
    public partial class XemTKB : Form
    {
        public XemTKB()
        {
            InitializeComponent();
        }

        List<ThoiKhoaBieu> listTKB = new List<ThoiKhoaBieu>(1000);
        //Để sắp xếp vào đây

        string pathKhoa;
        string pathCap;
        string pathLop;
        string text;

        private void XemTKB_Load(object sender, EventArgs e)
        {
            ThemTKB f = new ThemTKB();
            cbbDang.Focus();
            f.DocFileDSTKB();

            
            
            

            //ComboBox chọn dạng xem TKB
            cbbDang.Items.Add("----Chọn----");
            cbbDang.Items.Add("Xem theo khoá học");
            cbbDang.Items.Add("Xem theo cấp học");
            cbbDang.Items.Add("Xem theo lớp học");
            cbbDang.SelectedIndex = 0;

            //ComboBox chọn item xem TKB
            cbbChon.Items.Clear();
            cbbChon.Items.Add("----Chọn----");
            cbbChon.SelectedIndex = 0;

            //ListView - xem tkb các khoá học
            lvTKB.View = View.Details;
            lvTKB.GridLines = true;
            lvTKB.FullRowSelect = true;            
        }

        private void Check(string path, ComboBox box, string keys)
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

        private void cbbDang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Data\DSTKB.txt";
            if (cbbDang.SelectedIndex != 0)
            {                
                cbbChon.Items.Clear();
                Check(path, cbbChon, "");
                cbbChon.SelectedIndex = 0;
                text = cbbDang.SelectedItem.ToString();
                switch (cbbDang.Text)
                {
                    case "Xem theo khoá học":
                        pathKhoa = Application.StartupPath + @"\Data\SubjectList.txt";
                        text = "K" + text.Substring(text.Length - 2, 2);
                        //duyệt qua từng dòng trong file dstkb
                        // kiểm tra dòng đó có bắt đầu bằng "K" + text
                        //nếu có thì thêm dòng đó vào list view
                        try
                        {
                            if (File.Exists(path))
                            {
                                using (StreamReader s = new StreamReader(path))
                                {
                                    string line;
                                    string[] attributes;
                                    ListViewItem item;
                                    while (s.Peek() >= 0)
                                    {
                                        line = s.ReadLine();
                                        attributes = line.Split(new string[] { "#" }, StringSplitOptions.None);
                                        item = new ListViewItem(attributes);
                                        lvTKB.Items.Add(item);
                                        ThoiKhoaBieu t = new ThoiKhoaBieu(attributes[0], attributes[1], attributes[2],
                                                                          attributes[3], attributes[4], attributes[5], attributes[6],
                                                                          attributes[7], attributes[8], attributes[9]);
                                        Check(pathKhoa, cbbChon, "");
                                        listTKB.Add(t);
                                    }
                                }
                            }
                            else
                                MessageBox.Show("Danh sách rỗng!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case "Xem theo cấp học":
                        pathCap = Application.StartupPath + @"\Data\LevelList.txt";
                        text = "C" + text.Substring(3, 2);
                        try
                        {
                            if (File.Exists(path))
                            {
                                using (StreamReader s = new StreamReader(path))
                                {
                                    string line;
                                    string[] attributes;
                                    ListViewItem item;
                                    while (s.Peek() >= 0)
                                    {
                                        line = s.ReadLine();
                                        attributes = line.Split(new string[] { "#" }, StringSplitOptions.None);
                                        item = new ListViewItem(attributes);
                                        lvTKB.Items.Add(item);
                                        ThoiKhoaBieu t = new ThoiKhoaBieu(attributes[0], attributes[1], attributes[2],
                                                                          attributes[3], attributes[4], attributes[5], attributes[6],
                                                                          attributes[7], attributes[8], attributes[9]);
                                        Check(pathCap, cbbChon, text);
                                        listTKB.Add(t);
                                    }
                                }
                            }
                            else
                                MessageBox.Show("Danh sách rỗng!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case "Xem theo lớp học":
                        pathLop = Application.StartupPath + @"\Data\ClassList.txt";
                        text = "2" + text.Substring(1, 6);
                        try
                        {
                            if (File.Exists(path))
                            {
                                using (StreamReader s = new StreamReader(path))
                                {
                                    string line;
                                    string[] attributes;
                                    ListViewItem item;
                                    while (s.Peek() >= 0)
                                    {
                                        line = s.ReadLine();
                                        attributes = line.Split(new string[] { "#" }, StringSplitOptions.None);
                                        item = new ListViewItem(attributes);
                                        lvTKB.Items.Add(item);
                                        ThoiKhoaBieu t = new ThoiKhoaBieu(attributes[0], attributes[1], attributes[2],
                                                                          attributes[3], attributes[4], attributes[5], attributes[6],
                                                                          attributes[7], attributes[8], attributes[9]);
                                        Check(pathLop, cbbChon, text);
                                        listTKB.Add(t);
                                    }
                                }
                            }
                            else
                                MessageBox.Show("Danh sách rỗng!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        break;
                    default:
                        break;
                }    
                
            }    
            
        }

        private void rjSapXep_Click(object sender, EventArgs e)
        {
            //Sắp xếp theo tên khoá học
            ListViewItem item;
            string[] attributes;
            lvTKB.Items.Clear();
            foreach (ThoiKhoaBieu t in listTKB)
            {
                listTKB.Sort((x1, x2) =>
                {
                    return x1.TenKH.CompareTo(x2.TenKH);
                });
            }
            foreach (ThoiKhoaBieu t in listTKB)
            {
                attributes = new string[] { t.MaLich, t.TenKH, t.CapLop, t.Lop, t.Thu,
                                            t.KhungGioHoc, t.Phong, t.TenGV};
                item = new ListViewItem(attributes);
                lvTKB.Items.Add(item);
            }
        }

        private void rjBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
