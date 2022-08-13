using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace HeThongQuanLyTTHV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new QLHV.Main_QLHV());
=======
            Application.Run(new DSKQHT());
>>>>>>> ea8baeaac415933346fb2b1bdb24c42c01648e77
        }
    }
}
