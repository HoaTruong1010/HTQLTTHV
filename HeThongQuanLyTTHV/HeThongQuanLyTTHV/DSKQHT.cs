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
    public partial class DSKQHT : Form
    {
        public DSKQHT()
        {
            InitializeComponent();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Them f = new Them();
            f.MdiParent = this;
            f.Show();
        }

        private void thôngBáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
