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
    public partial class FrmTacGia : Form
    {
        public FrmTacGia()
        {
            InitializeComponent();
            LoadTacGia();
        }
        private void LoadTacGia()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM TacGia";

                SqlDataAdapter da =
                    new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvTacGia.DataSource = dt;

                dgvTacGia.Columns["MaTacGia"].HeaderText = "Mã tác giả";
                dgvTacGia.Columns["TenTacGia"].HeaderText = "Tên tác giả";

                dgvTacGia.AutoSizeColumnsMode =
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
                    @"INSERT INTO TacGia(TenTacGia)
              VALUES(@TenTacGia)";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@TenTacGia",
                        txtTenTacGia.Text.Trim()
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm thành công");

                    LoadTacGia();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvTacGia_CellClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvTacGia.Rows[e.RowIndex];

            txtMaTacGia.Text =
                row.Cells["MaTacGia"].Value.ToString();

            txtTenTacGia.Text =
                row.Cells["TenTacGia"].Value.ToString();
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
                    "DELETE FROM TacGia WHERE MaTacGia=@MaTacGia";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@MaTacGia",
                        txtMaTacGia.Text
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công");

                    LoadTacGia();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            UPDATE TacGia
            SET TenTacGia=@TenTacGia
            WHERE MaTacGia=@MaTacGia";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@MaTacGia",
                        txtMaTacGia.Text
                    );

                    cmd.Parameters.AddWithValue(
                        "@TenTacGia",
                        txtTenTacGia.Text.Trim()
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sửa thành công");

                    LoadTacGia();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
        SELECT *
        FROM TacGia
        WHERE TenTacGia
        LIKE @TuKhoa";

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

                dgvTacGia.DataSource = dt;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTacGia.Clear();
            txtTenTacGia.Clear();
            txtTimKiem.Clear();

            LoadTacGia();
        }

        private void FrmTacGia_Load(object sender, EventArgs e)
        {

        }
    }
}
