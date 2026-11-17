using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace QUAN_LY_SACH
{
    internal class CSach
    {
        private string masach;
        private string tensach;
        private string matacgia;
        private string manxb;
        private string matheloai;
        private DateTime namxuatban;
        private int soluong;

        // Hàm khởi tạo rỗng
        public CSach()
        {
            this.masach = null;
            this.tensach = null;
            this.matacgia = null;
            this.manxb = null;
            this.matheloai = null;
            this.namxuatban = DateTime.Now;
            this.soluong = 0;
        }

        // Hàm khởi tạo đầy đủ
        public CSach(string masach, string tensach, string matacgia, string tentacgia,
                     string maNXB, string matheloai, DateTime namxuatban,
                     int soluong)
        {
            this.masach = masach;
            this.tensach = tensach;
            this.matacgia = matacgia;
            this.manxb = maNXB;
            this.matheloai = matheloai;
            this.namxuatban = namxuatban;
            this.soluong = soluong;
        }

        public string Masach
        {
            get { return this.masach; }
            set { this.masach = value; }
        }
        public string Tensach
        {
            get { return this.tensach; }
            set { this.tensach = value; }
        }
        public string Matacgia
        {
            get { return this.matacgia; }
            set { this.matacgia = value; }
        }
        public string MaNXB
        {
            get { return this.manxb; }
            set { this.manxb = value; }
        }
        public string Matheloai
        {
            get { return this.matheloai; }
            set { this.matheloai = value; }
        }
        public DateTime Namxuatban
        {
            get { return this.namxuatban; }
            set { this.namxuatban = value; }
        }
        public int Soluong
        {
            get { return this.soluong; }
            set { this.soluong = value; }
        }
    }
}
