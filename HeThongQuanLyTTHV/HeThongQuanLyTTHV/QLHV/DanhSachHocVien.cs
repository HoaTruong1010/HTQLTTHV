using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyTTHV.QLHV
{
    public partial class DanhSachHocVien : Form
    {
        public DanhSachHocVien()
        {
            InitializeComponent();
        }

        List<HocVien> hocViens = new List<HocVien>(1000);

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void DanhSachHocVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void DanhSachHocVien_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Data\StudentList.txt";
            try
            {
                listHV.Width = lbTitle.Width = Screen.PrimaryScreen.WorkingArea.Width;
                foreach (ColumnHeader item in listHV.Columns)
                {
                    item.Width = (int)(listHV.Width * (0.1));
                }
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
                            listHV.Items.Add(item);
                            HocVien h = new HocVien(attributes[0], attributes[1], attributes[2],
                            attributes[3], attributes[4], attributes[5], attributes[6], attributes[7],
                            attributes[8], attributes[9]);
                            hocViens.Add(h);
                        }
                    }
                    txtSum.Text = hocViens.Count.ToString();
                }
                else
                    MessageBox.Show("Danh sách rỗng!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            string[] attributes;
            listHV.Items.Clear();
            foreach (HocVien h in hocViens)
            {
                hocViens.Sort((x1, x2) =>
                {
                    return x1.Name.CompareTo(x2.Name);
                });
            }
            foreach (HocVien h in hocViens)
            {
                attributes = new string[] { h.Id, h.Name, h.Dob, h.Gender, h.Email, h.PhoneNumber,
                    h.Adress, h.KhoaHoc, h.CapHoc, h.Lop };
                item = new ListViewItem(attributes);
                listHV.Items.Add(item);
            }
            
        }
    }
}
