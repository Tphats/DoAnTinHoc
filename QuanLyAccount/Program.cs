using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<<< HEAD:QuanLyAccount/Program.cs
namespace QuanLyAccount
========
namespace QUAN_LY_SACH
>>>>>>>> thanhphuc:QUAN_LY_SACH/Program.cs
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
<<<<<<<< HEAD:QuanLyAccount/Program.cs
            //Application.Run(new FrmDangNhap());
            Application.Run(new FrmNhanVien());
            //Application.Run(new FrmTest());
========
            Application.Run(new FormQuanLySach());
>>>>>>>> thanhphuc:QUAN_LY_SACH/Program.cs
        }
    }
}
