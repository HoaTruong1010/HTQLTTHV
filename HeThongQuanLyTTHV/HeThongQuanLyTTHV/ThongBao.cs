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

namespace HeThongQuanLyTTHV
{
    public partial class ThongBao : Form
    {
        public ThongBao()
        {
            InitializeComponent();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            int kt = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[2].Text == txtTK.Text)
                {

                    txtMP.Text = listView1.Items[i].SubItems[0].Text;
                    txtHT.Text = listView1.Items[i].SubItems[1].Text;
                    txtCCCd.Text = listView1.Items[i].SubItems[2].Text;
                    txtCH.Text = listView1.Items[i].SubItems[3].Text;
                    txtKhH.Text = listView1.Items[i].SubItems[4].Text;
                    txtL.Text = listView1.Items[i].SubItems[5].Text;
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
                    //kTra = true;
                    txtTK.Text = "";
                    break;
                }
            }
            if (kt == 0)
            {
                MessageBox.Show("Không tồn tại học viên có CCCD này\n " +
                    "Bạn hãy điền lại");
                txtTK.Text = "";
            }
        }

        private void btTroLai_Click(object sender, EventArgs e)
        {
            DSKQHT f = new DSKQHT();
            f.ShowDialog();
            Application.Exit();
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;
            string duongDan = @"D:\FileLog.txt";
            //Kiểm tra nếu chưa có file thì tạo mới
            //Có rồi thì ghi đè nội dung vào
            if (!File.Exists(duongDan))//chưa có tạo mới
            {
                streamWriter = new StreamWriter(duongDan);//tạo mới
                //Ghi nội dung vào file đã tạo
                foreach (string item in listView1.Items)
                {
                    streamWriter.WriteLine(item);
                }
                streamWriter.Close();
            }
            else//có rồi -> ghi thêm vào
            {
                //streamWriter = File.AppendText(duongDan);
                //foreach (string item in listAccessLog.Items)
                //{
                //    streamWriter.WriteLine(item);
                //}
                //streamWriter.Close();

                using (StreamWriter s = File.AppendText(duongDan))
                {
                    foreach (string item in listView1.Items)
                    {
                        s.WriteLine(item);
                    }
                }
            }
        }
    }
}
