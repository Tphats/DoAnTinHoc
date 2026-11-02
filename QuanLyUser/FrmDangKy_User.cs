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
    public partial class FrmDangKy_User : Form
    {
        public FrmDangKy_User()
        {
            InitializeComponent();
        }
        private string taoMaUser()
        {
            string ma;
            do
            {
                ma = "U" + Guid.NewGuid() //radom kí tự định danh ngẫu nhiên (bao gồm dấu "-")
                    .ToString("N") // loại bỏ dấu "-" trong chuỗi định danh
                    .Substring(0, 8) // lấy 8 kí tự đầu tiên
                    .ToUpper(); // chuyển đổi thành chữ hoa
            } while (DuLieuDungChung.dsuser.Any(u => u.MaUser == ma));
            return ma;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(txtTenDN.Text == "" || txtMK.Text == "" || txtNhaplaiMK.Text == "" || txtTen.Text == "" || txtCCCD.Text == "" || txtSDT.Text == "" || txtEmail.Text == ""
                || txtDC.Text == "" || rbtnNam.Checked == false && rbtnNu.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            CQLUser dk_user = new CQLUser();
            dk_user.LoaiUser = "User";
            dk_user.MaUser = taoMaUser();
            dk_user.TenDangNhap = txtTenDN.Text;
            //Password
            if(txtMK.Text != txtNhaplaiMK.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
                return;
            }
            dk_user.MatKhau = txtMK.Text;
            //
            dk_user.NgayTaoTK = DateTime.Now;
            dk_user.TenUser = txtTen.Text;
            dk_user.CCCD_User = txtCCCD.Text;
            dk_user.SDT_User = txtSDT.Text;
            dk_user.Email_User = txtEmail.Text;
            dk_user.DiaChi_User = txtDC.Text;
            if(rbtnNam.Checked)
            {
                dk_user.GioiTinh_User = "Nam";
            }
            else
            {
                dk_user.GioiTinh_User = "Nữ";
            }
            DuLieuDungChung.dsuser.Add(dk_user);
            FrmDangNhap frmDN = new FrmDangNhap();
            frmDN.Show();
            this.Hide();
        }

       
    }
}
