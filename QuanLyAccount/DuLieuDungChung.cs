using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal static class DuLieuDungChung
    {
        public static List<CQLAccount> dsuser_account = new List<CQLAccount>();
        public static List<CQLUser> dsuser_info = new List<CQLUser>();
        public static List<CSach> dssach_info= new List<CSach>();
        public static List<CQLThuThu> dsthuthu_info= new List<CQLThuThu>();
        public static List<CPhieuMuon> dsphieumuon_info= new List<CPhieuMuon>();
        public static string TaoMaUser()
        {
            int maxSoThuTu = 1;
            while(dsuser_info.Any(u => u.MaUser == "U" + maxSoThuTu.ToString("D5")) || dsuser_account.Any(u => u.MaUser == "U" + maxSoThuTu.ToString("D5")))
            {
                maxSoThuTu++;
            }
            return "U" + maxSoThuTu.ToString("D5");
        }
        public static void LoadData()
        {
            if (dsuser_account.Count > 0)
                return;

            
            for (int i = 1; i <= 10; i++)
            {
                string tendangnhap;
                tendangnhap = "U" + Guid.NewGuid() //radom kí tự định danh ngẫu nhiên (bao gồm dấu "-")
                    .ToString("N") // loại bỏ dấu "-" trong chuỗi định danh
                    .Substring(0, 8); // lấy 8 kí tự đầu tiên
                dsuser_account.Add(new CQLAccount(CQLAccount.VaiTro.Librarian,//Vai trò
                                          "LIB" + i.ToString("D2"), //Mã Librarian = "LIB" + số thứ tự (2 chữ số)
                                          tendangnhap, //tendangnhap = random 8 kí tự
                                          "123456")); //Mật khẩu mặc định
            }
            for(int i = 1; i <= 10; i++)
            {
                dsuser_account.Add(new CQLAccount(CQLAccount.VaiTro.User,//Vai trò
                                          "MEM" + i.ToString("D2"), //Mã Member = "MEM" + số thứ tự (2 chữ số)
                                          "user" + i, //tendangnhap = random 8 kí tự
                                          "123456")); //Mật khẩu mặc định
            }
            dsuser_account.Add(new CQLAccount(CQLAccount.VaiTro.Admin,//Vai trò
                                          "ADMIN0", //Mã Admin = "ADMIN"
                                          "admin0", //tendangnhap = random 8 kí tự
                                          "123456")); //Mật khẩu mặc định))
            dsuser_account.Add(new CQLAccount(CQLAccount.VaiTro.Librarian,//Vai trò
                                          "LIB0", //Mã Librarian = "LIB" + số thứ tự (2 chữ số)
                                          "librarian0", //tendangnhap = random 8 kí tự
                                          "123456")); //Mật khẩu mặc định))
        }
    }
}
