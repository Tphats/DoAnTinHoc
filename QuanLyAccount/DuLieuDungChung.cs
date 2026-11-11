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
                dsuser.Add(new CQLAccount("Admin", "AD" + i.ToString("D2"), "admin" + i, "123456"));
            }
            for (int i = 1; i <= 90; i++)
            {
                dsuser.Add(new CQLAccount("User", "US" + i.ToString("D2"), "user" + i, "123456"));
            }
        }
    }
}
