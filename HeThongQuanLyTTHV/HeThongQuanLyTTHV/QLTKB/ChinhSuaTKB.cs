using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyTTHV.QLTKB
{
    public partial class ChinhSuaTKB : Form
    {
        public ChinhSuaTKB()
        {
            InitializeComponent();
        }

        List<ThoiKhoaBieu> listTKB = new List<ThoiKhoaBieu>(1000);
        int viTri = -1, vtMaLich;

        private void ChinhSuaTKB_Load(object sender, EventArgs e)
        {

        }

        private int TimTKB(String maLich)
        {
            if (listTKB.Count > 0)
            {
                for (int i = 0; i < listTKB.Count; i++)
                {
                    if (listTKB[i].MaLich == maLich)
                        return i;
                }
                return -1;
            }
            return -1;
        }

        public void Clear()
        {
            rjMaLich.Texts = "";
            rjTenGV.Texts = "";
            rjSoBuoi.Texts = "";
            rjSLHV.Texts = "";
            rjPhong.Texts = "";
            cbbCTDT.SelectedIndex = 0;
            cbbCapLop.SelectedIndex = 0;
            cbbLop.SelectedIndex = 0;
            cbbThu.SelectedIndex = 0;
            cbbKhungGioHoc.SelectedIndex = 0;
        }

        private void rjXoa_Click(object sender, EventArgs e)
        {
            string maLich = rjMaLich.Texts;
            if (maLich.Length == 0)
            {
                MessageBox.Show("Chưa chọn TKB muốn xoá!");
                return;
            }

            ListView.SelectedListViewItemCollection list = lvDSKH.SelectedItems;
            foreach (ListViewItem item in list)
            {
                if (item.Text == maLich)
                {
                    lvDSKH.Items.Remove(item);
                    MessageBox.Show("Xóa thành công");
                    return;
                }
            }    
                
        }

        private void rjCapNhat_Click(object sender, EventArgs e)
        {
            int i = 0;

            for (i = 0; i < lvDSKH.Items.Count; i++)
            {
                if (lvDSKH.Items[i].Text == rjMaLich.Texts)
                {
                    lvDSKH.Items[i].SubItems[1].Text = cbbCTDT.Text;
                    lvDSKH.Items[i].SubItems[2].Text = cbbCapLop.Text;
                    lvDSKH.Items[i].SubItems[2].Text = cbbLop.Text;
                    lvDSKH.Items[i].SubItems[2].Text = rjSoBuoi.Texts;
                    lvDSKH.Items[i].SubItems[2].Text = rjSLHV.Texts;
                    lvDSKH.Items[i].SubItems[2].Text = cbbThu.Text;
                    lvDSKH.Items[i].SubItems[2].Text = cbbKhungGioHoc.Text;
                    lvDSKH.Items[i].SubItems[2].Text = rjPhong.Texts;
                    lvDSKH.Items[i].SubItems[2].Text = rjTenGV.Texts;
                    return;
                }

            }
            System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(new string[] {
                                rjMaLich.Texts, cbbCTDT.Text, cbbCapLop.Text, cbbLop.Text, rjSoBuoi.Texts,
                                rjSLHV.Texts, cbbThu.Text, cbbKhungGioHoc.Text, rjPhong.Texts, rjTenGV.Texts});
            //Thêm đối tượng
            this.lvDSKH.Items.Add(item);
        }

        private void rjBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaLich_Click(object sender, EventArgs e)
        {
            viTri = TimTKB(txtMaLich.Text);
            if (viTri != -1)
            {
                vtMaLich = viTri;
                cbbCTDT.Text = listTKB[viTri].TenKH;
                cbbCapLop.Text = listTKB[viTri].CapLop;
                cbbLop.Text = listTKB[viTri].Lop;
                rjSoBuoi.Texts = listTKB[viTri].SoBuoi.ToString();
                rjPhong.Texts = listTKB[viTri].Phong;
                cbbThu.Text = listTKB[viTri].Thu;
                cbbKhungGioHoc.Text = listTKB[viTri].KhungGioHoc;
                rjSLHV.Texts = listTKB[viTri].SoLuongHV.ToString();
                rjTenGV.Texts = listTKB[viTri].TenGV;
            }            
        }
    }
}
