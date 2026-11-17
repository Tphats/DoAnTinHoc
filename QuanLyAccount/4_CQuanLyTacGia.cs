using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_SACH
{
    internal class CQuanLyTacGia
    {
        List<CTacGia> danhsachtacgia;
        public CQuanLyTacGia() 
        {
            danhsachtacgia = new List<CTacGia>();
        }
        public CQuanLyTacGia(List<CTacGia> danhsachtacgia)
        {
            this.danhsachtacgia = danhsachtacgia;
        }
        public List<CTacGia> Danhsachtacgia
        {
            get { return this.danhsachtacgia; }
            set { this.danhsachtacgia = value; }
        }
        private bool kttratontaimatacgia(string ma)
        {
            foreach (CTacGia tg in this.danhsachtacgia)
            {
                if (tg.Matacgia==ma)
                {
                    return true;
                }
            }
                return false;
        }
        public CTacGia timtacgiatheoma(string ma)
        {
            foreach (CTacGia tg in this.danhsachtacgia)
            {
                if (tg.Matacgia==ma)
                {
                    return tg;
                }
            }
            return null;
        }
        public bool Them(CTacGia tg)
        {
            if (kttratontaimatacgia(tg.Matacgia))
            {
                return false;
            }
            this.danhsachtacgia.Add(tg);
            return true;
        }
        public bool Xoa(string ma)
        {
            if (!kttratontaimatacgia(ma))
            {
                return false;
            }
            CTacGia tg = timtacgiatheoma(ma);
            if (tg==null)
            {
                return false;
            }
            this.danhsachtacgia.Remove(tg);
            return true;
        }
    }
}
        