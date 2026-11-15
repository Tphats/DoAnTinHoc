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
    public partial class ucDangkyTK : UserControl
    {
        public ucDangkyTK()
        {
            InitializeComponent();
        }
        private bool KiemTraSDT(string sdt)
        {
            foreach (CQLUser us in DuLieuDungChung.dsuser_info)
            {
                if (us.SDT_User == sdt)
                    return true;
            }
            return false;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "" || txtMK.Text == "" || txtNhaplaiMK.Text == "" || txtTen.Text == "" || txtSDT.Text == "" || txtEmail.Text == ""
                || txtDC.Text == "" || rbtnNam.Checked == false && rbtnNu.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            //Tạo tài khoản cho user
            CQLAccount dk_TK_user = new CQLAccount();
            dk_TK_user.LoaiUser = CQLAccount.VaiTro.User;
            dk_TK_user.MaUser = DuLieuDungChung.TaoMaUser();
            dk_TK_user.TenDangNhap = txtTenDN.Text;
            //Password
            if (txtMK.Text != txtNhaplaiMK.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
                return;
            }
            dk_TK_user.MatKhau = txtMK.Text;
            //Thêm thông tin cá nhân cho user
            CQLUser dk_user = new CQLUser();
            dk_user.MaUser = dk_TK_user.MaUser;
            dk_user.TenUser = txtTen.Text;
            if(KiemTraSDT(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại!");
                return;
            }
            else if (txtSDT.Text.Length != 10 || !txtSDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập đúng định dạng số điện thoại (10 chữ số).");
                return;
            }
            else
                dk_user.SDT_User = txtSDT.Text;

            dk_user.Email_User = txtEmail.Text;
            dk_user.DiaChi_User = txtDC.Text;
            if (rbtnNam.Checked)
            {
                dk_user.GioiTinh_User = CQLUser.GioiTinh.Nam;
            }
            else
            {
                dk_user.GioiTinh_User = CQLUser.GioiTinh.Nu;
            }
            DuLieuDungChung.dsuser_account.Add(dk_TK_user);
            DuLieuDungChung.dsuser_info.Add(dk_user);
            MessageBox.Show("Đăng ký tài khoản thành công! Mã User của bạn là: " + dk_TK_user.MaUser);
        }
    }
}
