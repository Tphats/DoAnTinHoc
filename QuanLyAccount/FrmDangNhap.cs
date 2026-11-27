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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
            
        }
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = true;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtnAnMK_Click(object sender, EventArgs e)
        {
            if (txtMK.UseSystemPasswordChar == true)
            {
                txtMK.UseSystemPasswordChar = false;
                rbtnAnMK.Checked = true;
        }
            else
            {
                txtMK.UseSystemPasswordChar = true;
                rbtnAnMK.Checked = false;
            }
        }
    }
}
