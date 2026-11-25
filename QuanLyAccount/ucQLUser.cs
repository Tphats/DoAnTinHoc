using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class ucQLUser : UserControl
    {
        DBConnection Connect = new DBConnection();
        public ucQLUser()
        {
            InitializeComponent();

        }
        private void hienthidanhsach()
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"select * from DocGia";
                    SqlDataAdapter Adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    Adapter.Fill(dt);
                    dgvDsUser.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void ucQLUser_Load(object sender, EventArgs e)
        {
            hienthidanhsach();   
        }
        private void dgvDsUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvDsUser.Rows.Count)
                return;

            DataGridViewRow row = dgvDsUser.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaUser.Text = row.Cells["MaDocGia"].Value?.ToString() ?? "";
            txtTenUser.Text = row.Cells["HoTen"].Value?.ToString() ?? "";

            if (row.Cells["NgaySinh"].Value != DBNull.Value)
                dtNS.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

            string gioiTinh = row.Cells["GioiTinh"].Value?.ToString();

            rNam.Checked = gioiTinh == "Nam";
            rNu.Checked = gioiTinh == "Nu";

            txtDiachi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
            txtSDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connect.GetConnection())
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"UPDATE DocGia
                                    SET HoTen = @HoTen,
                                        NgaySinh = @NgaySinh,
                                        GioiTinh = @GioiTinh,
                                        DiaChi = @DiaChi,
                                        SDT = @SDT,
                                        Email = @Email
                                        WHERE MaDocGia = @MaUser";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaUser", SqlDbType.Int).Value = txtMaUser.Text.Trim();
                        cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = txtTenUser.Text.Trim();
                        cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dtNS.Value;
                        if (rNam.Checked)
                            cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10).Value = "Nam";
                        else
                            cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10).Value = "Nu";
                        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200).Value = txtDiachi.Text.Trim();
                        cmd.Parameters.Add("@SDT", SqlDbType.VarChar, 15).Value = txtSDT.Text.Trim();
                        cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = txtEmail.Text.Trim();
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
    }
}
