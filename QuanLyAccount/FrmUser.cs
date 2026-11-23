using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyAccount
{
    public partial class FrmUser : Form
    {
        private string m_madocgia = "DG01";
        public string MaDocGia
        {
            get { return m_madocgia; }
            set { m_madocgia = value; }
        }
        public FrmUser()
        {
            InitializeComponent();
            this.Load += FrmUser1_Load;

            btnDanhSachSach.Click += btnDanhSachSach_Click;
            btnDanhSachMuon.Click += btnDanhSachMuon_Click;
            btnLichSuMuonTra.Click += btnLichSuMuonTra_Click;
            btnThongTinCaNhan.Click += btnThongTinCaNhan_Click;
            btnDangXuat.Click += btnDangXuat_Click;
        }
         
        private void loadUC(UserControl uc)
        {
            panelContent.Controls.Clear();     
            uc.Dock = DockStyle.Fill;          
            panelContent.Controls.Add(uc);     
        }
        private void chonMenu(Button nutDuocChon)
        {
            Button[] dsNut = new Button[] { btnDanhSachSach, btnDanhSachMuon, btnThongTinCaNhan, btnLichSuMuonTra };
            foreach (Button nut in dsNut)                          
            {
                nut.BackColor = Color.FromArgb(232, 241, 252);     
                nut.ForeColor = Color.FromArgb(30, 115, 190);
            }
            nutDuocChon.BackColor = Color.FromArgb(176, 208, 245); 
            nutDuocChon.ForeColor = Color.FromArgb(30, 115, 190);  
        }
        private void FrmUser1_Load(object sender, EventArgs e)
        {
            lblXinChao.Text = "Xin chào, " + MaDocGia;
            btnDanhSachSach_Click(this, EventArgs.Empty);
        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhSachSach_Click(object sender, EventArgs e)
        {
            chonMenu(btnDanhSachSach);

            ucDanhSachSach uc = new ucDanhSachSach();

            loadUC(uc);
        }

        private void btnDanhSachMuon_Click(object sender, EventArgs e)
        {
            chonMenu(btnDanhSachMuon);

            ucDanhSachMuon uc = new ucDanhSachMuon();

            uc.MaDocGia = MaDocGia;

            loadUC(uc);
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            chonMenu(btnThongTinCaNhan);

            ucThongTinCaNhan uc = new ucThongTinCaNhan();

            uc.MaDocGia = MaDocGia;

            loadUC(uc);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnLichSuMuonTra_Click(object sender, EventArgs e)
        {
            chonMenu(btnLichSuMuonTra);

            ucLichSuMuonTra uc = new ucLichSuMuonTra();

            uc.MaDocGia = MaDocGia;

            loadUC(uc);
        }

        
    }
}
