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
    public partial class ucQLSach_Chung : UserControl
    {
        public ucQLSach_Chung()
        {
            InitializeComponent();
            btnSach.PerformClick();
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
        private void btnSach_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnSach);
            HienthiUserControl(new ucQLSach());
        }
        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnTheLoai);
            HienthiUserControl(new ucTheLoai());
        }
        private void btnTG_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnTG);
            HienthiUserControl(new ucTacGia());
        }
        private void btnNXB_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnNXB);
            HienthiUserControl(new ucNhaXuatBan());
        }
    }
}
