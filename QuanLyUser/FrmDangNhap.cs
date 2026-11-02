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
        private List<CQLUser> dsuser = DuLieuDungChung.dsuser;
        public FrmDangNhap()
        {
            InitializeComponent();
            txtMK.UseSystemPasswordChar = true;
            label_MaAdmin.Visible = false;
            txtPhanQuyen.Visible = false;
            // Mặc định User được chọn
            rbtnUser.Checked = true;
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DuLieuDungChung.LoadData();
            string maUs = txtTenDN.Text.Trim();
            string mk = txtMK.Text.Trim();
            if(rbtnAdmin.Checked)
            {
                foreach (CQLUser us in dsuser)
                {
                    if (/*us.MaUser*/ "123" /*Thay 123 bằng mã admin thực tế sau khi có database*/ == txtPhanQuyen.Text.Trim()
                        && us.TenDangNhap == maUs && us.MatKhau == mk)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        FrmQLUser frm = new FrmQLUser();
                        frm.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                        return;
                    }
                }
            }
            else
            {
                foreach (CQLUser us in dsuser)
                {
                    if (us.LoaiUser == "User" && us.TenDangNhap == maUs && us.MatKhau == mk)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        // Thực hiện các hành động sau khi đăng nhập thành công cho User
                        // Ví dụ: Mở form giao diện chính của User hoặc thực hiện các thao tác khác
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                        return;
                    }
                }
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

        private void rbtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnAdmin.Checked)
            {
                label_MaAdmin.Visible = true;
                txtPhanQuyen.Visible = true;
            }
            else
            {
                label_MaAdmin.Visible = false;
                txtPhanQuyen.Visible = false;
            }
        }
    }
}
