using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class CQLThuThu
    {
        private string mathuthu;
        private string hoten;
        private DateTime ngaysinh;
        private string gioitinh;
        private string sdt;
        private string email;

        // Hàm khởi tạo rỗng
        public CQLThuThu()
        {
            this.mathuthu = null;
            this.hoten = null;
            this.ngaysinh = DateTime.Now;
            this.gioitinh = null;
            this.sdt = null;
            this.email = null;
           
        }

        // Hàm khởi tạo đầy đủ
        public CQLThuThu(string mathuthu, string hoten, DateTime ngaysinh, string gioitinh,
                         string sdt, string email)
        {
            this.mathuthu = mathuthu;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.email = email;
        }

        public string Mathuthu
        {
            get { return this.mathuthu; }
            set { this.mathuthu = value; }
        }
        public string Hoten
        {
            get { return this.hoten; }
            set { this.hoten = value; }
        }
        public DateTime Ngaysinh
        {
            get { return this.ngaysinh; }
            set { this.ngaysinh = value; }
        }
        public string Gioitinh
        {
            get { return this.gioitinh; }
            set { this.gioitinh = value; }
        }
        public string Sdt
        {
            get { return this.sdt; }
            set { this.sdt = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
    }
}
