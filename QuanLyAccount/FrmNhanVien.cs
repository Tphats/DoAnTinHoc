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
        private void HienThiForm(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.None;

            frm.Size = new Size(815, 441);

            pnl_Content.Controls.Add(frm);

            frm.Location = new Point(
                (pnl_Content.ClientSize.Width - frm.Width) / 2,
                (pnl_Content.ClientSize.Height - frm.Height) / 2
            );

            frm.Show();
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
    }
}
