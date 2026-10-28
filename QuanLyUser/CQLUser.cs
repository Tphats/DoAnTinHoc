using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyUser
{
    internal class CQLUser
    {
        private string _LoaiUser;
        private string _maUser;
        private string _tenDangNhap;
        private string _matKhau;
        private DateTime _ngayTaoTK;
        public string LoaiUser { get { return _LoaiUser; } set { _LoaiUser = value; } }
        public string MaUser { get { return _maUser; } set { _maUser = value; } }
        public string TenDangNhap { get {return _tenDangNhap; } set {_tenDangNhap = value; } }
        public string MatKhau { get {return _matKhau; } set {_matKhau = value; } }
        public DateTime NgayTaoTK { get {return _ngayTaoTK; } set {_ngayTaoTK = value; } }
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
