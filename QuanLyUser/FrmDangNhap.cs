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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
            txtMK.UseSystemPasswordChar = true;
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DuLieuDungChung.LoadData();
            string maUs = txtTenDN.Text.Trim();
            string mk = txtMK.Text.Trim();
            CQLUser user = DuLieuDungChung.dsuser.FirstOrDefault(u => u.TenDangNhap == maUs && u.MatKhau == mk);
            if (user == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                return;
            }
            MessageBox.Show("Đăng nhập thành công!");
            if(user.LoaiUser == "Admin")
            {
                FrmQLUser frm = new FrmQLUser();
                frm.Show();
                this.Hide();
            }
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

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FrmDangKyTK_Chung frmDK_Chung = new FrmDangKyTK_Chung();
            frmDK_Chung.Show();
            this.Hide();
        }
    }
}
