using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class ucQLAccount : UserControl
    {
        private List<CQLAccount> dsuser = DuLieuDungChung.dsuser_account;
        DatabaseConnection Connect = new DatabaseConnection();
        public ucQLAccount()
        {
            InitializeComponent();
        }
        private void hienthidanhsach()
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT * FROM TaiKhoan tk
                                  JOIN DocGia dg ON tk.MaTK = dg.MaDocGia";
                SqlDataAdapter Adapter = new SqlDataAdapter(sql,conn);
                DataTable dt = new DataTable();
                Adapter.Fill(dt);
                dgvDsUser.DataSource = dt;
            }
        }
        private void ClearData()
        {
            txtMaUser.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            rBtnThuThu.Checked = false;
            rBtnUser.Checked = false;
        }
        private CQLAccount timUser(string maUs)
        {
            foreach (CQLAccount us in dsuser)
            {
                if (us.MaUser == maUs)
                    return us;
            }
            return null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CQLAccount us = new CQLAccount();
            if (timUser(txtMaUser.Text) == null)
            {
                us.MaUser = DuLieuDungChung.TaoMaUser();
                us.TenDangNhap = txtTenDangNhap.Text;
                us.MatKhau = txtMatKhau.Text;
                if (rBtnThuThu.Checked)
                    us.LoaiUser = CQLAccount.VaiTro.Librarian;
                else
                    us.LoaiUser = CQLAccount.VaiTro.User;
                dsuser.Add(us);
                hienthidanhsach();
                ClearData();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"DELETE FROM TaiKhoan WHERE MaTK = @MaAccount
                                   DELETE FROM DocGia WHERE MaDocGia = @MaUser";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaAccount", SqlDbType.Int).Value = txtMaUser.Text.Trim();
                        cmd.Parameters.Add("@MaUser", SqlDbType.Int).Value = txtMaUser.Text.Trim();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            hienthidanhsach();
                            MessageBox.Show("Xóa thành công");
                        }    
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: ", ex.Message);
                }
            }
        }

        private void dgvDsUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvDsUser.Rows.Count)
            {
                return;
            }
            DataGridViewRow row = dgvDsUser.Rows[e.RowIndex];
            if (row.IsNewRow)
                return;
            txtMaUser.Text = dgvDsUser.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
            txtTenDangNhap.Text = dgvDsUser.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
            txtMatKhau.Text = dgvDsUser.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";
            if (dgvDsUser.Rows[e.RowIndex].Cells[3].Value?.ToString() == "Librarian")
                rBtnThuThu.Checked = true;
            else
                rBtnUser.Checked = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"UPDATE TaiKhoan
                                    SET TenDangNhap = @TenDN,
                                         MatKhau = @MK,
                                         VaiTro = @VaiTro
                                         WHERE MaTK = @MaUser";      
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaUser", SqlDbType.Int).Value = txtMaUser.Text.Trim();
                        cmd.Parameters.Add("@TenDN", SqlDbType.VarChar, 50).Value = txtTenDangNhap.Text.Trim();
                        cmd.Parameters.Add("@MK", SqlDbType.VarChar, 100).Value = txtMatKhau.Text.Trim();
                        if (rBtnUser.Checked)
                            cmd.Parameters.Add("@VaiTro", SqlDbType.NVarChar, 20).Value = CQLAccount.VaiTro.User;
                        else
                            cmd.Parameters.Add("@VaiTro", SqlDbType.NVarChar, 20).Value = CQLAccount.VaiTro.Librarian;
                        //Kiểm tra số dòng thực hiện thành công
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            hienthidanhsach();
                            MessageBox.Show("Sửa thành công");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = "select * from TaiKhoan where MaTK = @MaUser";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaUser", SqlDbType.Int).Value = txtTimKiem.Text.Trim();
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if(reader.Read())
                            txtMaUser.Text = reader["MaTK"].ToString();
                            txtTenDangNhap.Text = reader["TenDangNhap"].ToString();
                            txtMatKhau.Text = reader["MatKhau"].ToString();
                            if (reader["VaiTro"].ToString() == CQLAccount.VaiTro.Librarian.ToString())
                                rBtnThuThu.Checked = true;
                            else
                                rBtnUser.Checked = true;
                        }

                    }
                    }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void ucQLAccount_Load(object sender, EventArgs e)
        {


            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT * FROM TaiKhoan tk
                                  JOIN DocGia dg ON tk.MaTK = dg.MaDocGia";
                    SqlDataAdapter Adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    Adapter.Fill(dt);
                    dgvDsUser.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
