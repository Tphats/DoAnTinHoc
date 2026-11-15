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
        private void btnCreatUser_Click(object sender, EventArgs e)
        {
            HienthiUserControl(new ucDangkyTK());
        }

        private void btnQLAccount_Click(object sender, EventArgs e)
        {
            HienthiUserControl(new ucQLAccount());
        }

        private void btnQLDocGia_Click(object sender, EventArgs e)
        {
            HienthiUserControl(new ucQLUser());
        }
    }
}
