using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class CQLAccount
    {
        public enum VaiTro
        {
            Admin,
            User,
            Librarian
        }
        // Account
        private VaiTro _LoaiUser;
        private string _maUser;
        private string _tenDangNhap;
        private string _matKhau;
 
        // Account properties
        public VaiTro LoaiUser { get { return _LoaiUser; } set { _LoaiUser = value; } }
        public string MaUser { get { return _maUser; } set { _maUser = value; } }
        public string TenDangNhap { get {return _tenDangNhap; } set {_tenDangNhap = value; } }
        public string MatKhau { get {return _matKhau; } set {_matKhau = value; } }

        public CQLAccount(VaiTro LoaiUser, string MaUser, string TenDangNhap, string MatKhau)
        {
            this.LoaiUser = LoaiUser;
            this.MaUser = MaUser;
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
        }
        public CQLAccount():this(VaiTro.User, "", "", "")
        {
          
        }
    }
}
