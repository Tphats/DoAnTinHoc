using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyUser
{
    public partial class FrmDangKyTK_Chung : Form
    {
        public FrmDangKyTK_Chung()
        {
            InitializeComponent();
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmDangKy_User frm = new FrmDangKy_User();
            frm.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmDangKy_Admin frm = new FrmDangKy_Admin();
            frm.Show();
            this.Hide();
        }
    }
}
