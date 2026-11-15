using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_SACH
{
    internal class CQuanLySach
    {
        List<CSach> danhsachsach;
        public CQuanLySach()
        {
            danhsachsach=new List<CSach>();

        }
        public CQuanLySach(List<CSach> danhsachsach)
        {
            this.danhsachsach = danhsachsach;
        }
        public List<CSach> Danhsachsach
        {
            get { return this.danhsachsach; }
            set { this.danhsachsach = value; }
        }
        private bool kttontaimasach(string ma) 
        {
            foreach (CSach c in this.danhsachsach)
            {
                if (c.Masach==ma)
                {
                    return true;
                }
            }
            return false;
        }
        public CSach timsachtheoma(string ma)
        {
            foreach (CSach c in this.danhsachsach)
            {
                if (c.Masach==ma)
                {
                    return c;
                }
            }
            return null;
        }
        public bool Them(CSach c)
        {
            if (kttontaimasach(c.Masach))
            {
                return false;
            }
            this.danhsachsach.Add(c);
            return true;
        }
        public bool Xoa(string ma)
        {
            if (!kttontaimasach(ma))
            {
                return false;
            }
            CSach s = timsachtheoma(ma);
            if (s==null)
            {
                return false;
            }
            this.danhsachsach.Remove(s);
            return true;
        }
        public bool Sua(CSach sachmoi)
        {
            if (!kttontaimasach(sachmoi.Masach))
            {
                return false;
            }
            CSach sachcu = timsachtheoma(sachmoi.Masach);
            if (sachcu == null)
            {
                return false;
            }
            sachcu.Tensach = sachmoi.Tensach;
            sachcu.Matacgia = sachmoi.Matacgia;
            sachcu.MaNXB = sachmoi.MaNXB;
            sachcu.Matheloai = sachmoi.Matheloai;
            sachcu.Namxuatban = sachmoi.Namxuatban;
            sachcu.Soluong = sachmoi.Soluong;
            return true;
        }
    }
}
