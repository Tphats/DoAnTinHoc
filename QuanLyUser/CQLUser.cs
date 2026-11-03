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
        private bool _trangthaiTK;
        // User
        private string _TenUser;
        private string _CCCD_User;
        private string _SDT_User;
        private string _Email_User;
        private string _DiaChi_User;
        private string _GioiTinh_User;
        private DateTime _NgaySinh_User;
        // Account properties
        public string LoaiUser { get { return _LoaiUser; } set { _LoaiUser = value; } }
        public string MaUser { get { return _maUser; } set { _maUser = value; } }
        public string TenDangNhap { get {return _tenDangNhap; } set {_tenDangNhap = value; } }
        public string MatKhau { get {return _matKhau; } set {_matKhau = value; } }
        public DateTime NgayTaoTK { get {return _ngayTaoTK; } set {_ngayTaoTK = value; } }
        public bool TrangthaiTK { get { return _trangthaiTK; } set { _trangthaiTK = value; } }
        // User properties
        public string TenUser { get { return _TenUser; } set { _TenUser = value; } }
        public string CCCD_User { get { return _CCCD_User; } set { _CCCD_User = value; } }
        public string SDT_User { get { return _SDT_User; } set { _SDT_User = value; } }
        public string Email_User { get { return _Email_User; } set { _Email_User = value; } }
        public string DiaChi_User { get { return _DiaChi_User; } set { _DiaChi_User = value; } }
        public string GioiTinh_User { get { return _GioiTinh_User; } set { _GioiTinh_User = value; } }
        public DateTime NgaySinh_User { get { return _NgaySinh_User; } set { _NgaySinh_User = value; } }

        public CQLUser(string LoaiUser, string MaUser, string TenDangNhap, string MatKhau, DateTime NgayTaoTK, bool TrangthaiTK)
        {
            this.LoaiUser = LoaiUser;
            this.MaUser = MaUser;
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
            this.NgayTaoTK = NgayTaoTK;
            this.TrangthaiTK = TrangthaiTK;
        }
        public CQLUser():this("", "", "", "", DateTime.Now, true)
        {
          
        }
    }
}
