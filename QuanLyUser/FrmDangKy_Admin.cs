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
    public partial class FrmDangKy_Admin : Form
    {
        public FrmDangKy_Admin()
        {
            InitializeComponent();
        }
        private string taoMaUser()
        {
            string ma;
            do
            {
                ma = "A" + Guid.NewGuid() //radom kí tự định danh ngẫu nhiên (bao gồm dấu "-")
                    .ToString("N") // loại bỏ dấu "-" trong chuỗi định danh
                    .Substring(0, 8) // lấy 8 kí tự đầu tiên
                    .ToUpper(); // chuyển đổi thành chữ hoa
            } while (DuLieuDungChung.dsuser.Any(u => u.MaUser == ma));
            return ma;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "" || txtMK.Text == "" || txtNhaplaiMK.Text == "" || txtTen.Text == "" || txtCCCD.Text == "" || txtSDT.Text == "" || txtEmail.Text == ""
                || txtDC.Text == "" || rbtnNam.Checked == false && rbtnNu.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            CQLUser dk_user = new CQLUser();
            dk_user.LoaiUser = "Admin";
            dk_user.MaUser = taoMaUser();
            dk_user.TenDangNhap = txtTenDN.Text;
            //Password
            if (txtMK.Text != txtNhaplaiMK.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
                return;
            }
            dk_user.MatKhau = txtMK.Text;
            //Profile
            dk_user.NgayTaoTK = DateTime.Now;
            dk_user.TenAdmin = txtTen.Text;
            dk_user.CCCD_Admin = txtCCCD.Text;
            dk_user.SDT_Admin = txtSDT.Text;
            dk_user.Email_Admin = txtEmail.Text;
            dk_user.DiaChi_Admin = txtDC.Text;
            if (rbtnNam.Checked)
            {
                dk_user.GioiTinh_Admin = "Nam";
            }
            else
            {
                dk_user.GioiTinh_Admin = "Nữ";
            }
            // Duyệt Admin qua mã admin được cung cấp sẵn (mã demo: 123)
            if (txtMa_Admin.Text != "123")
            {
                MessageBox.Show("Mã Admin không hợp lệ!");
                return;
            }
            DuLieuDungChung.dsuser.Add(dk_user);
            FrmDangNhap frmDN = new FrmDangNhap();
            frmDN.Show();
            this.Hide();
        }
    }
}
