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
    public partial class ucQLPhieu_Chung : UserControl
    {
        public ucQLPhieu_Chung()
        {
            InitializeComponent();
            btnPM.PerformClick();
        }
        private void HienthiUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnl_Content.Controls.Clear();
            pnl_Content.Controls.Add(uc);
        }
        private void DoiTrangThaiButton(Button btn)
        {
            foreach (Control ctrl in pnl_sidebar.Controls)
            {
                ctrl.Font = new Font(ctrl.Font, FontStyle.Regular);
                ctrl.BackColor = Color.White;
                ctrl.ForeColor = Color.Black;
            }
            btn.Font = new Font(btn.Font, FontStyle.Bold);
            btn.BackColor = Color.LightBlue;
            btn.ForeColor = Color.Blue;
        }
        private void btnPM_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnPM);
            HienthiUserControl(new ucQLPhieuMuon());
        }

        private void btnPT_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnPT);
            HienthiUserControl(new ucQLPhieuTra());
        }
    }
}
