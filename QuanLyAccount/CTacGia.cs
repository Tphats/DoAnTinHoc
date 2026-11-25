using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class CTacGia
    {
        private string matacgia;
        private string tentacgia;

        public CTacGia()
        {
            this.matacgia = null;
            this.tentacgia = null;
        }
        public CTacGia(string matacgia, string tentacgia)
        {
            this.matacgia = matacgia;
            this.tentacgia = tentacgia;
        }
        public string Matacgia
        {
            get { return this.matacgia; }
            set { this.matacgia = value; }
        }
        public string Tentacgia
        {
            get { return this.tentacgia; }
            set { this.tentacgia = value; }
        }
    }
}
