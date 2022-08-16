using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HeThongQuanLyTTHV.QLHV
{
    public partial class ThongTinHocVien : Form
    {
        private string chucNang;
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
                    if (chucNang == "Edit")
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
                        txtName.Focus();
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
            index = SearchStudent(txtID.Text);
            try
            {
                if (index != -1)
                {
                    if(chucNang == "Add")
                    {
                        MessageBox.Show("Học viên đã tồn tại!\nVui lòng chọn chức năng chỉnh sửa!",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Reset();
                    }    

                    if (chucNang == "Edit" || chucNang == "Delete")
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
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Question",
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
