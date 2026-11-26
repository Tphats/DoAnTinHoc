using QuanLyThuVien;
using QuanLyAccount;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        private void HienthiUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnl_Content.Controls.Clear();
            pnl_Content.Controls.Add(uc);
        }
        private void DoiTrangThaiButton(Button btn)
        {
            foreach (Control ctrl in Pnl_Sidebar.Controls)
            {
                ctrl.Font = new Font(ctrl.Font, FontStyle.Regular);
                ctrl.BackColor = Color.White;
                ctrl.ForeColor = Color.Black;
            }
            btn.Font = new Font(btn.Font, FontStyle.Bold);
            btn.BackColor = Color.LightBlue;
            btn.ForeColor = Color.Blue;
        }
        private void btnQLAccount_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnQLAccount);
            
        }

        private void btnDSDocGia_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnDSDocGia);
            HienthiUserControl(new ucDSDocGia());
        }

        private void btnDSSach_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnDSSach);
            HienthiUserControl(new ucQLSach_Chung());
        }

        private void btnQLThuThu_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnQLThuThu);
            HienthiUserControl(new ucQLThuThu());
        }

        private void btnDSPhieuMuon_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnDSPhieuMuon);
            HienthiUserControl(new ucDSPhieuMuon());
        }
    }
}
