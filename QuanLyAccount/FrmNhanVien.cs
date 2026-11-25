using QuanLyThuVien;
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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
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
        private void btnCreatUser_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnCreatUser);
            HienthiUserControl(new ucDangkyTK());
        }

        private void btnQLAccount_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnQLAccount);
            HienthiUserControl(new ucQLAccount());
        }

        private void btnQLDocGia_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnQLDocGia);
            HienthiUserControl(new ucQLUser());
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnQLSach);
            HienthiUserControl(new ucQLSach_Chung());
        }

        private void pnl_Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnl_Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQLPhieuMuon_Click(object sender, EventArgs e)
        {

        }

        private void btnQuaHan_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {

        }
    }
}
