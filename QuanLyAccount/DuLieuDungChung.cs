using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAccount
{
    internal static class DuLieuDungChung
    {
        public static List<CQLAccount> dsuser = new List<CQLAccount>();
        public static void LoadData()
        {
            if (dsuser.Count > 0)
                return;

            
            for (int i = 1; i <= 10; i++)
            {
                string ma;
                ma = "U" + Guid.NewGuid() //radom kí tự định danh ngẫu nhiên (bao gồm dấu "-")
                    .ToString("N") // loại bỏ dấu "-" trong chuỗi định danh
                    .Substring(0, 8); // lấy 8 kí tự đầu tiên
                dsuser.Add(new CQLAccount(CQLAccount.VaiTro.Librarian,//Vai trò
                                          "LIB" + i.ToString("D2"), //Mã Librarian = "LIB" + số thứ tự (2 chữ số)
                                          ma, //tendangnhap = random 8 kí tự
                                          "123456")); //Mật khẩu mặc định
            }
            for(int i = 1; i <= 10; i++)
            {
                dsuser.Add(new CQLAccount(CQLAccount.VaiTro.User,//Vai trò
                                          "MEM" + i.ToString("D2"), //Mã Member = "MEM" + số thứ tự (2 chữ số)
                                          "user" + i, //tendangnhap = random 8 kí tự
                                          "123456")); //Mật khẩu mặc định
            }
            dsuser.Add(new CQLAccount(CQLAccount.VaiTro.Admin,//Vai trò
                                          "ADMIN0", //Mã Admin = "ADMIN"
                                          "admin0", //tendangnhap = random 8 kí tự
                                          "123456")); //Mật khẩu mặc định))
            dsuser.Add(new CQLAccount(CQLAccount.VaiTro.Librarian,//Vai trò
                                          "LIB0", //Mã Librarian = "LIB" + số thứ tự (2 chữ số)
                                          "librarian0", //tendangnhap = random 8 kí tự
                                          "123456")); //Mật khẩu mặc định))
        }
    }
}
