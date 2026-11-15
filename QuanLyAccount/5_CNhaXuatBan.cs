using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_SACH
{
    internal class CNhaXuatBan
    {
        private string maNXB;
        private string tenNXB;
        private string diachi;

        public CNhaXuatBan()
        {
            this.maNXB = null;
            this.tenNXB = null;
            this.diachi = null;
        }
        public CNhaXuatBan(string maNXB, string tenNXB, string diachi)
        {
            this.maNXB = maNXB;
            this.tenNXB = tenNXB;
            this.diachi = diachi;
        }
        public string MaNXB
        {
            get { return this.maNXB; }
            set { this.maNXB = value; }
        }
        public string TenNXB
        {
            get { return this.tenNXB; }
            set { this.tenNXB = value; }
        }
        public string Diachi
        {
            get { return this.diachi; }
            set { this.diachi = value; }
        }
    }
}
