using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class CQLUser
    {
        public enum GioiTinh { Nam, Nu }
        // User
        private string _MaUser;
        private string _TenUser;
        private string _SDT_User;
        private string _Email_User;
        private string _DiaChi_User;
        private GioiTinh _GioiTinh_User;
        private DateTime _NgaySinh_User;
        // User properties
        public string MaUser { get { return _MaUser; } set { _MaUser = value; } }
        public string TenUser { get { return _TenUser; } set { _TenUser = value; } }
        public string SDT_User { get { return _SDT_User; } set { _SDT_User = value; } }
        public string Email_User { get { return _Email_User; } set { _Email_User = value; } }
        public string DiaChi_User { get { return _DiaChi_User; } set { _DiaChi_User = value; } }
        public GioiTinh GioiTinh_User { get { return _GioiTinh_User; } set { _GioiTinh_User = value; } }
        public DateTime NgaySinh_User { get { return _NgaySinh_User; } set { _NgaySinh_User = value; } }
        public CQLUser(string MaUser, string TenUser, string SDT_User, string Email_User, string DiaChi_User, GioiTinh GioiTinh_User, DateTime NgaySinh_User)
        {
            this.MaUser = MaUser;
            this.TenUser = TenUser;
            this.SDT_User = SDT_User;
            this.Email_User = Email_User;
            this.DiaChi_User = DiaChi_User;
            this.GioiTinh_User = GioiTinh_User;
            this.NgaySinh_User = NgaySinh_User;
        }
        public CQLUser() : this("", "", "", "", "", GioiTinh.Nam, DateTime.Now)
        {
        }
    }
}
