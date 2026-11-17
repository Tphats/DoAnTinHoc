using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_SACH
{
    internal class CTheLoai
    {
        private string matheloai;
        private string tentheloai;

        public CTheLoai()
        {
            this.matheloai = null;
            this.tentheloai = null;
        }
        public CTheLoai(string matheloai, string tentheloai)
        {
            this.matheloai = matheloai;
            this.tentheloai = tentheloai;
        }
        public string Matheloai
        {
            get { return this.matheloai; }
            set { this.matheloai = value; }
        }
        public string Tentheloai
        {
            get { return this.tentheloai; }
            set { this.tentheloai = value; }
        }
    }
}
