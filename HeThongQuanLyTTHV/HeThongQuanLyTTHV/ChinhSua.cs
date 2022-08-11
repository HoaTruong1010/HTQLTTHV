using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyTTHV
{
    public partial class ChinhSua : Form
    {
        public ChinhSua()
        {
            InitializeComponent();
        }

         private void ChinhSua_Load(object sender, EventArgs e)
        {
            //ĐN columns listview
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns[0].Width = (int)(listView1.Width * 0.09);
            listView1.Columns[1].Width = (int)(listView1.Width * 0.12);
            listView1.Columns[2].Width = (int)(listView1.Width * 0.1);
            listView1.Columns[3].Width = (int)(listView1.Width * 0.1);
            listView1.Columns[4].Width = (int)(listView1.Width * 0.1);
            listView1.Columns[5].Width = (int)(listView1.Width * 0.1);
            listView1.Columns[6].Width = (int)(listView1.Width * 0.1);
            listView1.Columns[7].Width = (int)(listView1.Width * 0.1);
            listView1.Columns[8].Width = (int)(listView1.Width * 0.08);
            listView1.Columns[9].Width = (int)(listView1.Width * 0.1);
            listView1.Columns[10].Width = (int)(listView1.Width * 0.1);

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            
            
        }
        bool kTra;
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            int kt=0;
            for (int i = 0; i <= listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[2].Text == txt.Text)
                {
                      
                    txtMP.Text = listView1.Items[i].SubItems[0].Text;
                    txtHT.Text = listView1.Items[i].SubItems[1].Text;
                    txtCCCd.Text = listView1.Items[i].SubItems[2].Text;
                    txtCapHoc.Text = listView1.Items[i].SubItems[3].Text;
                    txtKhoaHoc.Text = listView1.Items[i].SubItems[4].Text;
                    txtLopp.Text = listView1.Items[i].SubItems[5].Text;
                    txtSDt.Text = listView1.Items[i].SubItems[6].Text;
                    dtNS.Text = listView1.Items[i].SubItems[7].Text;
                    txtD.Text = listView1.Items[i].SubItems[8].Text;
                    if (listView1.Items[i].SubItems[9].Text == "Nam")
                    {
                        rbN.Checked = true;
                    }
                    else
                    {
                        rbNU.Checked = true;
                    }
                    txtGC.Text = listView1.Items[i].SubItems[10].Text;
                    kt += 1;
                    kTra = true;
                    break;
                }
            }
            if (kt==0)
            {
                MessageBox.Show("Không tồn tại học viên có CCCD này\n " +
                    "Bạn hãy điền lại");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtMP.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtHT.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtCCCd.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtCapHoc.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtKhoaHoc.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txtLopp.Text = listView1.SelectedItems[0].SubItems[5].Text;
                txtSDt.Text = listView1.SelectedItems[0].SubItems[6].Text;
                dtNS.Text = listView1.SelectedItems[0].SubItems[7].Text;
                txtD.Text = listView1.SelectedItems[0].SubItems[8].Text;
                if (listView1.Items[0].SubItems[9].Text == "Nam")
                {
                    rbN.Checked = true;
                }
                else
                {
                    rbNU.Checked = true;
                }
                txtGC.Text = listView1.SelectedItems[0].SubItems[10].Text;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                MessageBox.Show("Xóa Thành Công!");
            }
            else
            {
                MessageBox.Show("Phải chọn ít nhất một dòng!");
            }    
        }

        private void btT_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            //Xử lý không điền đủ thông tin
            if (string.IsNullOrEmpty(txtMP.Text) || string.IsNullOrEmpty(txtHT.Text)
                || string.IsNullOrEmpty(txtCCCd.Text) || string.IsNullOrEmpty(txtD.Text)
                || string.IsNullOrEmpty(txtSDt.Text) || string.IsNullOrEmpty(txtLopp.Text)
                || string.IsNullOrEmpty(txtKhoaHoc.Text) || string.IsNullOrEmpty(txtCapHoc.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                // Thêm Items
                if (txtMP.Text != "")
                {
                    item = new ListViewItem(txtMP.Text);
                    item.SubItems.Add(txtHT.Text);
                    item.SubItems.Add(txtCCCd.Text);
                    item.SubItems.Add(txtCapHoc.Text);
                    item.SubItems.Add(txtKhoaHoc.Text);
                    item.SubItems.Add(txtLopp.Text);
                    item.SubItems.Add(txtSDt.Text);
                    item.SubItems.Add(dtNS.Value.ToShortDateString());
                    item.SubItems.Add(txtD.Text);
                    item.SubItems.Add(rbN.Checked ? "Nam" : "Nữ");
                    item.SubItems.Add(txtGC.Text);

                    listView1.Items.Add(item);
                    txtMP.Text = "";
                    txtCCCd.Text = "";
                    txtMP.Focus();
                }
            }
        }

        private void btChinhSua_Click(object sender, EventArgs e)
        {
            if (kTra==true || listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i <= listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[2].Text == txt.Text)
                    {
                        listView1.Items[i].SubItems[0].Text = txtMP.Text;
                        listView1.Items[i].SubItems[1].Text = txtHT.Text;
                        listView1.Items[i].SubItems[2].Text = txtCCCd.Text;
                        listView1.Items[i].SubItems[3].Text = txtCapHoc.Text;
                        listView1.Items[i].SubItems[4].Text = txtKhoaHoc.Text;
                        listView1.Items[i].SubItems[5].Text = txtLopp.Text;
                        listView1.Items[i].SubItems[6].Text = txtSDt.Text;
                        listView1.Items[i].SubItems[7].Text = dtNS.Value.ToShortDateString(); ;
                        listView1.Items[i].SubItems[8].Text = txtD.Text;
                        listView1.Items[i].SubItems[9].Text = rbN.Checked ? "Nam" : "Nữ";
                        listView1.Items[i].SubItems[10].Text = txtGC.Text;
                        break;
                    }
                } 
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để sửa");

            }    
        }
    }
}
