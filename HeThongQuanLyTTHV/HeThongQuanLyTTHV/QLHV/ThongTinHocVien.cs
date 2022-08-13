using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HeThongQuanLyTTHV.QLHV
{
    public partial class ThongTinHocVien : Form
    {
        private string chucNang;
        private List<HocVien> listHV;

        public string ChucNang { get => chucNang; set => chucNang = value; }
        internal List<HocVien> ListHV { get => listHV; set => listHV = value; }

        public ThongTinHocVien()
        {
            InitializeComponent();
        }

        string listHVPath = Application.StartupPath + @"StudentList.txt";
        string listHocPath = Application.StartupPath + @"HocVien_MonHoc.txt";
        int index = -1, idTemp;

        private void ThongTinHocVien_Load(object sender, EventArgs e)
        {
            txtID.Focus();
            ListHV = new List<HocVien>(1000);
            StudentListFromFile();
            cbKhoaHoc.SelectedIndex = cbCapHoc.SelectedIndex = cbLop.SelectedIndex = 0;
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

        private void StudentListFromFile()
        {
            try
            {
                if(File.Exists(listHVPath))
                using (StreamReader s = new StreamReader(listHVPath))
                {
                    string line;
                    string[] attributes;
                    while (s.Peek() >= 0)
                    {
                        line = s.ReadLine();
                        attributes = line.Split(new string[] { "#" }, StringSplitOptions.None);
                        HocVien h = new HocVien(attributes[0], attributes[1], attributes[2],
                            attributes[3], attributes[4], attributes[5], attributes[6]);
                        ListHV.Add(h);
                    }                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private int SearchStudent(String id)
        {
            if(ListHV.Count > 0)
            {
                for (int i = 0; i < ListHV.Count; i++)
                {
                    if (ListHV[i].Id == id)
                        return i;
                }
                return -1;
            }
            else
                return -1;
        }

        private void Reset()
        {
            txtID.Text = txtName.Text = txtEmail.Text = txtPhone.Text = txtAdress.Text = "";
            dtpDOB.Value = DateTime.Now;
            rdFemale.Checked = rdMale.Checked = false;
            cbKhoaHoc.SelectedIndex = cbCapHoc.SelectedIndex = cbLop.SelectedIndex = 0;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            PhuongThuc.GhiFileStudentList(listHVPath, ListHV);
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string gender;
            try
            {
                if (txtID.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtAdress.Text == "" ||
                    txtName.Text == "" || cbKhoaHoc.SelectedIndex == 0 || cbCapHoc.SelectedIndex == 0 ||
                    cbLop.SelectedIndex == 0 || (!rdFemale.Checked && !rdMale.Checked))
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                else
                {
                    if (rdFemale.Checked)
                        gender = "Nữ";
                    else
                        gender = "Nam";
                    HocVien h = new HocVien(txtID.Text, txtName.Text, dtpDOB.Value.ToString(), gender, txtEmail.Text,
                        txtPhone.Text, txtAdress.Text);
                    switch (chucNang)
                    {
                        case "Add":
                            listHV.Add(h);
                            break;
                        case "Edit":
                            listHV.RemoveAt(idTemp);
                            listHV.Add(h);
                            break;
                    }
                    if (!File.Exists(listHocPath))
                    {
                        using (StreamWriter s = new StreamWriter(listHocPath))
                        {
                            s.WriteLine("{0}#{1}#{2}#{3}",
                                h.Id, cbKhoaHoc.SelectedItem.ToString(), cbCapHoc.SelectedItem.ToString(), cbLop.SelectedItem.ToString());
                        }
                    }
                    else
                    {
                        using (StreamWriter s = File.AppendText(listHocPath))
                        {
                            s.WriteLine("{0}#{1}#{2}#{3}",
                                h.Id, cbKhoaHoc.SelectedItem.ToString(), cbCapHoc.SelectedItem.ToString(), cbLop.SelectedItem.ToString());
                        }
                    }
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
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập vào 1 số!");
            }    
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            index = SearchStudent(txtID.Text);
            try
            {
                if (index != -1)
                {
                    txtName.Text = ListHV[index].Name;
                    txtEmail.Text = ListHV[index].Email;
                    txtPhone.Text = ListHV[index].PhoneNumber;
                    txtAdress.Text = ListHV[index].Adress;
                    dtpDOB.Value = DateTime.Parse(ListHV[index].Dob);
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
                    txtName.SelectionStart = txtName.Text.Length;
                    if (chucNang == "Edit")
                    {
                        idTemp = index;
                    }
                }
                else
                {
                    if (chucNang == "Add")
                    {
                        String id = txtID.Text;
                        Reset();
                        txtID.Text = id;
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

        private void btDel_Click(object sender, EventArgs e)
        {

        }
    }
}
