using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HeThongQuanLyTTHV.QLHV
{
    public partial class ThongTinHocVien : Form
    {
        //Tạo 1 biến chức năng để lưu người dùng chọn chức năng nào
        private string chucNang;
        //Tạo danh sách học viên để làm việc với chương trình
        private List<HocVien> listHV = new List<HocVien>(1000);

        public string ChucNang { get => chucNang; set => chucNang = value; }
        internal List<HocVien> ListHV { get => listHV; set => listHV = value; }

        public ThongTinHocVien()
        {
            InitializeComponent();
        }

        string path;
        int index = -1, idTemp;
        string selectedText;

        //ghi đối tượng học viên vào file từ listhv, mỗi học viên 1 dòng, các thuộc tính cách nhau bằng dấu #
        private void GhiFileStudentList(string path, List<HocVien> ts)
        {
            if(File.Exists(path))
                File.Delete(path);
            if (listHV.Count > 0)
                using (StreamWriter s = new StreamWriter(path))
                {
                    foreach (HocVien h in ts)
                    {
                        s.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}#{7}#{8}#{9}",
                        h.Id, h.Name, h.Dob, h.Gender, h.Email, h.PhoneNumber, h.Adress,
                        h.KhoaHoc, h.CapHoc, h.Lop);
                    }
                }
            else
                return;
        }

        //lấy thông tin học viên từ file gán vào list hv
        private void StudentListFromFile()
        {
            try
            {
                path = Application.StartupPath + @"\Data\StudentList.txt";
                if (File.Exists(path))
                    using (StreamReader s = new StreamReader(path))
                    {
                        string line;
                        string[] attributes;
                        while (s.Peek() >= 0)
                        {
                            line = s.ReadLine();
                            attributes = line.Split(new string[] { "#" }, StringSplitOptions.None);
                            HocVien h = new HocVien(attributes[0], attributes[1], attributes[2],
                                attributes[3], attributes[4], attributes[5], attributes[6],
                                attributes[7], attributes[8], attributes[9]);
                            ListHV.Add(h);
                        }
                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Lấy thông tin khóa học từ file gán vào combobox
        private void SubInfoItemsFromFile(string path, ComboBox box, string keys)
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

        //Hàm tìm kiếm học viên trong list hv bằng id 
        private int SearchStudent(String id)
        {
            if (ListHV.Count > 0)
            {
                for (int i = 0; i < ListHV.Count; i++)
                {
                    if (ListHV[i].Id == id)
                        return i;
                }
                return -1;
            }
                
            return -1;
        }

        //Hàm reset các controls
        private void Reset()
        {
            txtID.Text = txtName.Text = txtEmail.Text = txtPhone.Text = txtAdress.Text = "";
            dtpDOB.Value = DateTime.Now;
            rdFemale.Checked = rdMale.Checked = false;
            cbKhoaHoc.SelectedIndex = 0;
            cbCapHoc.Items.Clear();
            cbCapHoc.Items.Add("No selected item");
            cbCapHoc.SelectedIndex = 0;
            cbLop.Items.Clear();
            cbLop.Items.Add("No selected item");
            cbLop.SelectedIndex = 0;
        }

        private void ThongTinHocVien_Load(object sender, EventArgs e)
        {
            txtID.Focus();
            StudentListFromFile();

            path = Application.StartupPath + @"\Data\SubjectList.txt";

            cbKhoaHoc.Items.Clear();
            SubInfoItemsFromFile(path, cbKhoaHoc, "");
            cbKhoaHoc.SelectedIndex = 0;
            cbCapHoc.Items.Add("No selected item");
            cbCapHoc.SelectedIndex = 0;
            cbLop.Items.Add("No selected item");
            cbLop.SelectedIndex = 0;

            if (chucNang != "Delete")
            {
                btDel.Visible = false;
                btSave.Visible = true;
            }
            else
            {
                btDel.Visible = true;
                btSave.Visible = false;
            }    
                
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\Data\StudentList.txt";
            GhiFileStudentList(path, ListHV);
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string gender;
            try
            {
                if (txtID.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtAdress.Text == "" ||
                    txtName.Text == "" || cbKhoaHoc.SelectedIndex == 0|| cbCapHoc.SelectedIndex == 0 ||
                    cbLop.SelectedIndex == 0 || (!rdFemale.Checked && !rdMale.Checked))
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                else
                {
                    if (rdFemale.Checked)
                        gender = "Nữ";
                    else
                        gender = "Nam";
                    HocVien h = new HocVien(txtID.Text, txtName.Text, dtpDOB.Value.ToString(), gender, txtEmail.Text,
                        txtPhone.Text, txtAdress.Text, cbKhoaHoc.SelectedItem.ToString(), cbCapHoc.SelectedItem.ToString(),
                         cbLop.SelectedItem.ToString());
                    if (chucNang == "Edit")//nếu chỉnh sửa 1 học viên thì lấy thông tin gán lại cho thuộc tính
                        //đây t làm xóa r mới add lại nên đoạn này m có thể làm theo ý m
                        listHV.RemoveAt(idTemp);
                    listHV.Add(h);
                    MessageBox.Show("Lưu thành công!");
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //ràng buộc giá trị cccd vs sđt chỉ được nhập bằng phím số
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập vào 1 số!");
            }    
        }

        //Hàm này được gọi sau khi giá trị ở ô cccd được nhập xong
        private void txtName_Click(object sender, EventArgs e)
        {
            index = SearchStudent(txtID.Text);//lấy vị trí của đối tượng tìm thấy trong list
            try
            {
                if (index != -1)
                {
                    if(chucNang == "Add")//nếu là chức năng thêm mà vị trí khác -1 thì tức là tồn tại rồi nên k cho thêm
                    {
                        MessageBox.Show("Học viên đã tồn tại!\nVui lòng chọn chức năng chỉnh sửa!",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Reset();//có reset
                    }    

                    if (chucNang == "Edit" || chucNang == "Delete")//nếu tìm thấy tồn tại trong list thì 2 chức năng này sẽ show lên tthv tìm được
                    {
                        idTemp = index;
                        txtName.Text = ListHV[index].Name;
                        txtEmail.Text = ListHV[index].Email;
                        txtPhone.Text = ListHV[index].PhoneNumber;
                        txtAdress.Text = ListHV[index].Adress;
                        dtpDOB.Value = DateTime.Parse(ListHV[index].Dob);
                        txtName.SelectionStart = txtName.Text.Length;
                        cbKhoaHoc.SelectedItem = ListHV[idTemp].KhoaHoc;
                        cbCapHoc.SelectedItem = ListHV[idTemp].CapHoc;
                        cbLop.SelectedItem = ListHV[idTemp].Lop;
                        if (ListHV[index].Gender == "Nam")
                        {
                            rdMale.Checked = true;
                            rdFemale.Checked = false;
                        }
                        else
                        {
                            rdMale.Checked = false;
                            rdFemale.Checked = true;
                        }
                    }
                }
                
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //nhấn esc để thoát form
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        //hỏi bạn có muốn thoát k?
        private void ThongTinHocVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;

        }

        //2 hàm này là ràng buộc về mặt dữ liệu cho giá trị của combobox cấp học, lớp
        //Nếu giá trị ở combobox khóa học bằng 2020 thì sẽ có những cấp học liên quan đến khóa 2020 được hiển thị, ngược lại thì k
        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKhoaHoc.SelectedIndex != 0)            
            {
                selectedText = cbKhoaHoc.Text;
                selectedText = "K" + selectedText.Substring(selectedText.Length - 2, 2);
                path = Application.StartupPath + @"\Data\LevelList.txt";
                SubInfoItemsFromFile(path, cbCapHoc, selectedText);
            }
        }

        private void cbCapHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCapHoc.SelectedIndex != 0)
            {
                selectedText = cbCapHoc.SelectedItem.ToString();
                selectedText = selectedText.Substring(0, 5);
                path = Application.StartupPath + @"\Data\ClassList.txt";
                SubInfoItemsFromFile(path, cbLop, selectedText);
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                listHV.RemoveAt(index);
                MessageBox.Show("Xóa thành công!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtID.Focus();
                txtID.SelectionStart = txtID.Text.Length;
                MessageBox.Show("Học viên không tồn tại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }
    }
}
