using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongQuanLyTTHV;

namespace HeThongQuanLyTTHV
{
    public partial class DSKQHT : Form
    {
        public DSKQHT()
        {
            InitializeComponent();
        }
                
        private void DSKQHT_Load(object sender, EventArgs e)
        {
            //ĐN columns listview
            listView1.View = View.Details;
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

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            int kt = 0;
            for (int i = 0; i <= listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[2].Text == txtT.Text)
                {
                    kt += 1;
                    break;
                }
            }
            if (kt == 0)
            {
                MessageBox.Show("Không tồn tại học viên có CCCD này\n " +
                    "Bạn hãy điền lại");
            }
        }

        private void btThemm_Click(object sender, EventArgs e)
        {
            Them f = new Them();
            f.ShowDialog();
        }

        private void btChinh_Click(object sender, EventArgs e)
        {
            ChinhSua f = new ChinhSua();    
            f.ShowDialog();
        }

        private void btThongBao_Click(object sender, EventArgs e)
        {
            ThongBao f = new ThongBao();
            f.ShowDialog();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
