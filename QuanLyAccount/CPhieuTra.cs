using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class CPhieuTra
    {
        private const decimal Muc_Phat = 100000;
        private string maPhieuTra;
        private string maPhieuMuon;
        private DateTime ngayTra;
        public string MaPhieuTra { get => maPhieuTra; set => maPhieuTra = value; }
        public string MaPhieuMuon { get => maPhieuMuon; set => maPhieuMuon = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
        public decimal TienPhat (CPhieuMuon pm)
        {
            int soNgayQuaHan = (ngayTra.Date - pm.HanTra.Date).Days;
            if(soNgayQuaHan <= 0)
            {
                return 0;
            }
            return soNgayQuaHan * Muc_Phat;
        }
    }
}
