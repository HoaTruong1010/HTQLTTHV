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

namespace HeThongQuanLyTTHV.QLKQHT
{
    public partial class DSKQHT : Form
    {
        public DSKQHT()
        {
            InitializeComponent();
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

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

    }
}
