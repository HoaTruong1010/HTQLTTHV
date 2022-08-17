using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HeThongQuanLyTTHV.QLHV
{
    public partial class ThongTinHocVien : Form
    {
        private string chucNang;
        private HocVien hvSelected;
        private bool exit; 
        private List<HocVien> listHV = new List<HocVien>(1000);

        public string ChucNang { get => chucNang; set => chucNang = value; }
        internal List<HocVien> ListHV { get => listHV; set => listHV = value; }
        internal HocVien HvSelected { get => hvSelected; set => hvSelected = value; }
        public bool Exit { get => exit; set => exit = value; }

        public ThongTinHocVien()
        {
            InitializeComponent();
        }

        string path;
        int index, idTemp ;
        string selectedText;

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

        private void FillInfomations(HocVien h)
        {
            txtID.Text = h.Id;
            txtName.Text = h.Name;
            txtEmail.Text = h.Email;
            txtPhone.Text = h.PhoneNumber;
            txtAdress.Text = h.Adress;
            dtpDOB.Value = DateTime.Parse(h.Dob);
            cbKhoaHoc.SelectedItem = h.KhoaHoc;
            cbCapHoc.SelectedItem = h.CapHoc;
            cbLop.SelectedItem = h.Lop;
            if (h.Gender == "Nam")
            {
                rdMale.Checked = true;
                rdFemale.Checked = false;
            }
            else
            {
                rdMale.Checked = false;
                rdFemale.Checked = true;
            }
            txtID.Focus();
            txtID.SelectionStart = txtID.Text.Length;
        }

        private void Disable()
        {
            txtID.Enabled = txtName.Enabled = txtEmail.Enabled = txtPhone.Enabled = txtAdress.Enabled = false;
            cbKhoaHoc.Enabled = cbCapHoc.Enabled = cbLop.Enabled = false;
            rdFemale.Enabled = rdMale.Enabled = false;
            cbKhoaHoc.Enabled = cbCapHoc.Enabled = cbLop.Enabled = false;
            dtpDOB.Enabled = false;
        }

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
            txtID.Focus();
        }

        private void ThongTinHocVien_Load(object sender, EventArgs e)
        {
            index = idTemp = -1;
            exit = false;
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

            switch (chucNang)
            {
                case "Delete":
                    btDel.Visible = true; btSave.Visible = false;
                    FillInfomations(hvSelected);
                    Disable();
                    break;
                case "Edit":
                    idTemp = SearchStudent(hvSelected.Id);
                    btDel.Visible = false;
                    btSave.Visible = true;
                    FillInfomations(hvSelected);
                    break;
                default:
                    btDel.Visible = false;
                    btSave.Visible = true;
                    break;
            }      
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\Data\StudentList.txt";
            GhiFileStudentList(path, ListHV);
            this.Close();
            DanhSachHocVien fDS = new DanhSachHocVien();
            fDS.Show();
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
                    switch (chucNang)
                    {
                        case "Edit":
                            if(idTemp > -1)
                            {
                                if(SearchStudent(h.Id) > -1)
                                {
                                    MessageBox.Show("Số CCCD/CMND đã tồn tại!",
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtID.Focus();
                                    txtID.SelectionStart = txtID.Text.Length;
                                }
                                else
                                {
                                    listHV.RemoveAt(idTemp);
                                    listHV.Add(h);
                                    MessageBox.Show("Lưu thành công!");
                                    Reset();
                                    Exit = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Học viên không tồn tại!",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Reset();
                            }
                            break;
                        case "Add":
                            listHV.Add(h);
                            MessageBox.Show("Lưu thành công!");
                            Reset();
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox obj = (TextBox)sender;
            switch (obj.Name)
            {
                case "txtID":
                    if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                        MessageBox.Show("Vui lòng nhập vào 1 số!");
                    }
                    if (e.KeyChar == (char)Keys.Enter && txtID.Text != "")
                    {
                        index = SearchStudent(txtID.Text);
                        if (chucNang == "Edit" || chucNang == "Delete")
                        {
                            idTemp = index;
                            if(index > -1)
                            {
                                hvSelected = listHV[index];
                                FillInfomations(hvSelected);
                            }    
                            else
                            {
                                MessageBox.Show("Học viên không tồn tại!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Reset();
                            }
                        }
                    }
                    break;
                case "txtName":
                    if (e.KeyChar == (char)Keys.Enter && txtName.Text != "")
                        txtEmail.Focus();
                    break;
                case "txtEmail":
                    if (e.KeyChar == (char)Keys.Enter && txtEmail.Text != "")
                        txtPhone.Focus();
                    break;
                case "txtPhone":
                    if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                        MessageBox.Show("Vui lòng nhập vào 1 số!");
                    }
                    if (e.KeyChar == (char)Keys.Enter && txtPhone.Text != "")
                        txtAdress.Focus();
                    break;
                default:
                    break;
            }
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
                index = SearchStudent(txtID.Text);
                if (index > -1)
                {
                    if (chucNang == "Add")
                    {
                        MessageBox.Show("Học viên đã tồn tại!\nVui lòng chọn chức năng chỉnh sửa!",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Reset();
                    }
                }
            }
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

        private void ThongTinHocVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chucNang != "Watch" && MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;

        }

        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKhoaHoc.SelectedIndex != 0)            
            {
                cbCapHoc.Items.Clear();
                cbCapHoc.Items.Add("No selected item");
                cbCapHoc.SelectedIndex = 0;
                selectedText = cbKhoaHoc.SelectedItem.ToString();
                selectedText = "K" + selectedText.Substring(selectedText.Length - 2, 2);
                path = Application.StartupPath + @"\Data\LevelList.txt";
                SubInfoItemsFromFile(path, cbCapHoc, selectedText);
            }
        }

        private void cbCapHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCapHoc.SelectedIndex != 0)
            {
                cbLop.Items.Clear();
                cbLop.Items.Add("No selected item");
                cbLop.SelectedIndex = 0;
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
                Reset();
                Exit = true;
            }  
        }
    }
}
