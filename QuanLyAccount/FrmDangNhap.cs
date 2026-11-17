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
        private List<CQLAccount> dsaccount = DuLieuDungChung.dsuser_account;
        public FrmDangNhap()
        {
            InitializeComponent();
            
        }
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            DuLieuDungChung.LoadData();
            txtMK.UseSystemPasswordChar = true;
            dsaccount = DuLieuDungChung.dsuser_account;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDN.Text.Trim();
            string mk = txtMK.Text.Trim();
                foreach (CQLAccount us in dsaccount)
                {
                    if (us.TenDangNhap == tenDN && us.MatKhau == mk)
                    {
                        if(us.LoaiUser == CQLAccount.VaiTro.Librarian)
                        {
                            FrmNhanVien frm = new FrmNhanVien();
                            frm.Show();
                            this.Hide();
                            return;
                        }
                        else if(us.LoaiUser == CQLAccount.VaiTro.Admin)
                        {
                            //FrmAdmin frm = new FrmAdmin();
                            //frm.Show();
                            //this.Hide();
                            //return;
                        }
                        else if (us.LoaiUser == CQLAccount.VaiTro.User)
                        {
                            //FrmDangKy_User frm = new FrmDangKy_User();
                            //frm.Show();
                            //this.Hide();
                            return;
                        }
                    }
                }
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                        return;
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
