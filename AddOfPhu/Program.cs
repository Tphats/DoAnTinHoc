using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_THU_VIEN
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         //   Application.Run(new FrmQuanLySach());
          //  Application.Run(new FrmTacGia());
           // Application.Run(new FrmNhaXuatBan());
            Application.Run(new FrmTheLoai());
        }
    }
}
