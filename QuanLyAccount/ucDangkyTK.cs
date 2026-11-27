using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class ucDangkyTK : UserControl
    {
        DBConnection connect = new DBConnection();
        public ucDangkyTK()
        {
            InitializeComponent();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "" || txtMK.Text == "" || txtNhaplaiMK.Text == "" || txtTen.Text == "" || txtSDT.Text == "" || txtEmail.Text == ""
                || txtDC.Text == "" || rbtnNam.Checked == false && rbtnNu.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            using (SqlConnection conn = connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO TaiKhoan (TenDangNhap, MatKhau, VaiTro)
                                   VALUES 
                                   (@TenDangNhap, @MatKhau, @VaiTro)
                                   
                                    INSERT INTO DocGia (HoTen, NgaySinh, GioiTinh, DiaChi, SDT, Email)
                                    VALUES
                                    (@HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @Email)";
                    using(SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        //Account
                        cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar, 50).Value = txtTenDN.Text.Trim();
                        cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar, 100).Value = txtMK.Text.Trim();
                        do
                        {
                            if (txtNhaplaiMK.Text.Trim() == txtMK.Text.Trim())
                                break;
                            throw new Exception("Nhập lại mật khẩu chưa khớp!");
                        } while (txtNhaplaiMK.Text.Trim() != txtMK.Text.Trim());
                            cmd.Parameters.Add("@VaiTro", SqlDbType.NVarChar, 20).Value = "User";
                        //Info
                        cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = txtTen.Text.Trim();
                        cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dtNgaySinh.Value;
                        if (rbtnNam.Checked)
                            cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10).Value = "Nam";
                        else
                            cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10).Value = "Nu";
                        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200).Value = txtDC.Text;
                        cmd.Parameters.Add("@SDT", SqlDbType.VarChar, 15).Value = txtSDT.Text;
                        cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = txtEmail.Text;
                        //Kiểm tra số dòng thực hiện thành công
                        if (cmd.ExecuteNonQuery() > 0)
                            MessageBox.Show("Đăng ký thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void ucDangkyTK_Load(object sender, EventArgs e)
        {
            
        }
    }
}
