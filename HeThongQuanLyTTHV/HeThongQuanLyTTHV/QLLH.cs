using HeThongQuanLyTTHV.QLTKB;
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
    public partial class QLLH : Form
    {
        public QLLH()
        {
            InitializeComponent();
        }

        List<ThoiKhoaBieu> dstkb = new List<ThoiKhoaBieu>();
        public static QLLH frmQLLH;

        private void btThemTKB_Click(object sender, EventArgs e)
        {
            frmQLLH = this;
            frmQLLH.Hide();
            
            Button bt = (Button)sender;
            string chon = bt.Text;
            switch(chon)
            {
                case "Thêm TKB":
                    ThemTKB frmThemTKB = new ThemTKB();
                    frmThemTKB.ShowDialog();
                    break;
                case "Xem TKB":
                    XemTKB frmXemTKB = new XemTKB();
                    frmXemTKB.ShowDialog();
                    break;
                case "Chỉnh sửa TKB":
                    ChinhSuaTKB frmChinhSuaTKB = new ChinhSuaTKB();
                    frmChinhSuaTKB.ShowDialog();
                    break;
                case "Thông báo TKB":
                    ThongBaoTKB frmThongBaoTKB = new ThongBaoTKB();
                    frmThongBaoTKB.ShowDialog();
                    break;
                case "Thông báo lịch nghỉ":
                    ThongBaoLichNghi frmThongBaoLichNghi = new ThongBaoLichNghi();
                    frmThongBaoLichNghi.ShowDialog();
                    break;
            }    
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
