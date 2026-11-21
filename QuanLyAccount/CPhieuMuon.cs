using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    public enum TrangThai
    {
        DangMuon,
        DaTra,
        HetHan
    }
    internal class CPhieuMuon
    {
        private string maPhieuMuon;
        private string maDocGia;
        private DateTime ngayMuon;
        private TrangThai trangThai;
        public string MaPhieuMuon { get => maPhieuMuon; set => maPhieuMuon = value; }
        public string MaDocGia { get => maDocGia; set => maDocGia = value; }
        public DateTime NgayMuon { get => ngayMuon; set => ngayMuon = value; }
        public DateTime HanTra { get => ngayMuon.AddMonths(3); }
        public TrangThai TrangThai { get => trangThai; set => trangThai = value; }
        public CPhieuMuon(string maPhieuMuon, string maDocGia, DateTime ngayMuon, TrangThai trangThai)
        {
            this.maPhieuMuon = maPhieuMuon;
            this.maDocGia = maDocGia;
            this.ngayMuon = ngayMuon;
            this.trangThai = trangThai;
        }
        public CPhieuMuon():this("", "", DateTime.Now, TrangThai.DangMuon)
        {
        }
    }
}
