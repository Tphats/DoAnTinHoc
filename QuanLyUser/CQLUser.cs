using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyUser
{
    internal class CQLUser
    {
        // Account
        private string _LoaiUser;
        private string _maUser;
        private string _tenDangNhap;
        private string _matKhau;
        private DateTime _ngayTaoTK;
        private string _ma_Admin;
        // User
        private string _TenUser;
        private string _CCCD_User;
        private string _SDT_User;
        private string _Email_User;
        private string _DiaChi_User;
        private string _GioiTinh_User;
        private DateTime _NgaySinh_User;
        // Admin
        private string _TenAdmin;
        private string _CCCD_Admin;
        private string _SDT_Admin;
        private string _Email_Admin;
        private string _DiaChi_Admin;
        private string _GioiTinh_Admin;
        private DateTime _NgaySinh_Admin;
        // Account properties
        public string LoaiUser { get { return _LoaiUser; } set { _LoaiUser = value; } }
        public string MaUser { get { return _maUser; } set { _maUser = value; } }
        public string TenDangNhap { get {return _tenDangNhap; } set {_tenDangNhap = value; } }
        public string MatKhau { get {return _matKhau; } set {_matKhau = value; } }
        public DateTime NgayTaoTK { get {return _ngayTaoTK; } set {_ngayTaoTK = value; } }
        public string Ma_Admin { get { return _ma_Admin; } set { _ma_Admin = value; } }
        // User properties
        public string TenUser { get { return _TenUser; } set { _TenUser = value; } }
        public string CCCD_User { get { return _CCCD_User; } set { _CCCD_User = value; } }
        public string SDT_User { get { return _SDT_User; } set { _SDT_User = value; } }
        public string Email_User { get { return _Email_User; } set { _Email_User = value; } }
        public string DiaChi_User { get { return _DiaChi_User; } set { _DiaChi_User = value; } }
        public string GioiTinh_User { get { return _GioiTinh_User; } set { _GioiTinh_User = value; } }
        public DateTime NgaySinh_User { get { return _NgaySinh_User; } set { _NgaySinh_User = value; } }
        // Admin properties
        public string TenAdmin { get { return _TenAdmin; } set { _TenAdmin = value; } }
        public string CCCD_Admin { get { return _CCCD_Admin; } set { _CCCD_Admin = value; } }
        public string SDT_Admin { get { return _SDT_Admin; } set { _SDT_Admin = value; } }
        public string Email_Admin { get { return _Email_Admin; } set { _Email_Admin = value; } }
        public string DiaChi_Admin { get { return _DiaChi_Admin; } set { _DiaChi_Admin = value; } }
        public string GioiTinh_Admin { get { return _GioiTinh_Admin; } set { _GioiTinh_Admin = value; } }
        public DateTime NgaySinh_Admin { get { return _NgaySinh_Admin; } set { _NgaySinh_Admin = value; } }

        public CQLUser(string LoaiUser, string MaUser, string TenDangNhap, string MatKhau, DateTime NgayTaoTK)
        {
            this.LoaiUser = LoaiUser;
            this.MaUser = MaUser;
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
            this.NgayTaoTK = NgayTaoTK;
        }
        public CQLUser():this("", "", "", "", DateTime.Now)
        {
          
        }
    }
}
