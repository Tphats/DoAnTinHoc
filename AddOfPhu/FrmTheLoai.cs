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
    public partial class FrmTheLoai : Form
    {
        public FrmTheLoai()
        {
            InitializeComponent();
            LoadTheLoai();
        }
        private void LoadTheLoai()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM TheLoai";

                SqlDataAdapter da =
                    new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvTheLoai.DataSource = dt;

                dgvTheLoai.Columns["MaTheLoai"].HeaderText =
                    "Mã thể loại";

                dgvTheLoai.Columns["TenTheLoai"].HeaderText =
                    "Tên thể loại";

                dgvTheLoai.AutoSizeColumnsMode =
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
                    @"INSERT INTO TheLoai(TenTheLoai)
              VALUES(@TenTheLoai)";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@TenTheLoai",
                        txtTenTheLoai.Text.Trim()
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm thành công");

                    LoadTheLoai();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvTheLoai_CellClick(
    object sender,
    DataGridViewCellEventArgs e)
        {

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"UPDATE TheLoai
              SET TenTheLoai=@TenTheLoai
              WHERE MaTheLoai=@MaTheLoai";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@MaTheLoai",
                        txtMaTheLoai.Text
                    );

                    cmd.Parameters.AddWithValue(
                        "@TenTheLoai",
                        txtTenTheLoai.Text.Trim()
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sửa thành công");

                    LoadTheLoai();
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
                    "DELETE FROM TheLoai WHERE MaTheLoai=@MaTheLoai";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@MaTheLoai",
                        txtMaTheLoai.Text
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công");

                    LoadTheLoai();
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

                string sql =
                @"SELECT *
          FROM TheLoai
          WHERE TenTheLoai
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

                dgvTheLoai.DataSource = dt;
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTheLoai.Clear();
            txtTenTheLoai.Clear();
            txtTimKiem.Clear();

            LoadTheLoai();
        }
        private void FrmTheLoai_Load(object sender, EventArgs e)
        {

        }
    }
}
