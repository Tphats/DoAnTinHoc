using QUAN_LY_SACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyAccount
{
    internal static class Program
    {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// 

		[DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
		[STAThread]
        static void Main()
        {
            SetProcessDPIAware ();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDangNhap());
            Application.Run(new FrmNhanVien());
            //Application.Run(new FrmTest());

        }
    }
}
