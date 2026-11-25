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

namespace QUAN_LY_THU_VIEN
{
    public partial class FrmNhaXuatBan : Form
    {
        public FrmNhaXuatBan()
        {
            InitializeComponent();
            LoadNXB();
        }

        private void LoadNXB()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM NhaXuatBan";

                SqlDataAdapter da =
                    new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvNhaXuatBan.DataSource = dt;

                dgvNhaXuatBan.Columns["MaNXB"].HeaderText =
                    "Mã NXB";

                dgvNhaXuatBan.Columns["TenNXB"].HeaderText =
                    "Tên Nhà Xuất Bản";
                dgvNhaXuatBan.Columns["DiaChi"].HeaderText =
    "Địa chỉ";

                dgvNhaXuatBan.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql =
                 @"INSERT INTO NhaXuatBan
(
    TenNXB,
    DiaChi
)
VALUES
(
    @TenNXB,
    @DiaChi
)";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@TenNXB",
                        txtTenNXB.Text.Trim()
                    );
                    cmd.Parameters.AddWithValue(
    "@DiaChi",
    txtDiaChi.Text.Trim()
);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm thành công");

                    LoadNXB();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvNhaXuatBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvNhaXuatBan.Rows[e.RowIndex];

            txtMaNXB.Text =
                row.Cells["MaNXB"].Value.ToString();

            txtTenNXB.Text =
                row.Cells["TenNXB"].Value.ToString();
            txtDiaChi.Text =
    row.Cells["DiaChi"].Value.ToString();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
UPDATE NhaXuatBan
SET
    TenNXB = @TenNXB,
    DiaChi = @DiaChi
WHERE MaNXB = @MaNXB";
                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@MaNXB",
                        txtMaNXB.Text
                    );

                    cmd.Parameters.AddWithValue(
                        "@TenNXB",
                        txtTenNXB.Text.Trim()
                    );
                    cmd.Parameters.AddWithValue(
    "@DiaChi",
    txtDiaChi.Text.Trim()
);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sửa thành công");

                    LoadNXB();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql =
                        "DELETE FROM NhaXuatBan WHERE MaNXB=@MaNXB";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@MaNXB",
                        txtMaNXB.Text
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công");

                    LoadNXB();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
        SELECT *
        FROM NhaXuatBan
        WHERE TenNXB LIKE @TuKhoa";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@TuKhoa",
                    "%" + txtTimKiem.Text + "%"
                );

                SqlDataAdapter da =
                    new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvNhaXuatBan.DataSource = dt;
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNXB.Clear();
            txtTenNXB.Clear();
            txtDiaChi.Clear();
            txtTimKiem.Clear();

            LoadNXB();
        }

    }

}
