using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace QUAN_LY_THU_VIEN
{
    public partial class FrmQuanLySach : Form
    {
        public FrmQuanLySach()
        {
            InitializeComponent();
            LoadSach();
            LoadTacGia();
            LoadNXB();
            LoadTheLoai();
        
        }
        private void LoadSach()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT
    s.MaSach,
    s.TenSach,
    tg.TenTacGia,
    nxb.TenNXB,
    tl.TenTheLoai,
    s.SoLuong,
    s.NamXuatBan
FROM Sach s
INNER JOIN TacGia tg
    ON s.MaTacGia = tg.MaTacGia
INNER JOIN NhaXuatBan nxb
    ON s.MaNXB = nxb.MaNXB
INNER JOIN TheLoai tl
    ON s.MaTheLoai = tl.MaTheLoai
";

                SqlDataAdapter da =
                    new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);


                dgvSach.DataSource = dt;
                dgvSach.AutoSizeColumnsMode =
    DataGridViewAutoSizeColumnsMode.Fill;
                dgvSach.Columns["MaSach"].HeaderText = "Mã sách";
                dgvSach.Columns["TenSach"].HeaderText = "Tên sách";
                dgvSach.Columns["TenTacGia"].HeaderText = "Tác giả";
                dgvSach.Columns["TenNXB"].HeaderText = "Nhà xuất bản";
                dgvSach.Columns["TenTheLoai"].HeaderText = "Thể loại";
                dgvSach.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvSach.Columns["NamXuatBan"].HeaderText = "Năm xuất bản";

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenSach.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập tên sách!");
                    return;
                }

                if (txtSoLuong.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập số lượng!");
                    return;
                }

                int soLuong;

                if (!int.TryParse(txtSoLuong.Text, out soLuong))
                {
                    MessageBox.Show("Số lượng phải là số!");
                    return;
                }

                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
            INSERT INTO Sach
            (
                TenSach,
                MaTacGia,
                MaNXB,
                MaTheLoai,
                NamXuatBan,
                SoLuong,
                SoLuongCon
            )
            VALUES
            (
                @TenSach,
                @MaTacGia,
                @MaNXB,
                @MaTheLoai,
                @NamXuatBan,
                @SoLuong,
                @SoLuongCon
            )";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@TenSach",
                        txtTenSach.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@MaTacGia",
                        cmbTacGia.SelectedValue
                    );

                    cmd.Parameters.AddWithValue(
                        "@MaNXB",
                        cmbNXB.SelectedValue
                    );

                    cmd.Parameters.AddWithValue(
                        "@MaTheLoai",
                        cmbTheLoai.SelectedValue
                    );

                    cmd.Parameters.AddWithValue(
                        "@NamXuatBan",
                        dtpNamXB.Value.Date
                    );

                    cmd.Parameters.AddWithValue(
                        "@SoLuong",
                        soLuong
                    );

                    // Khi mới thêm sách thì số lượng còn = số lượng nhập
                    cmd.Parameters.AddWithValue(
                        "@SoLuongCon",
                        soLuong
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm sách thành công!");

                    LoadSach();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void LoadTacGia()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM TacGia";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbTacGia.DataSource = dt;
                cmbTacGia.DisplayMember = "TenTacGia";
                cmbTacGia.ValueMember = "MaTacGia";
            }
        }
        private void LoadNXB()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM NhaXuatBan";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbNXB.DataSource = dt;
                cmbNXB.DisplayMember = "TenNXB";
                cmbNXB.ValueMember = "MaNXB";
            }
        }
        private void LoadTheLoai()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM TheLoai";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbTheLoai.DataSource = dt;
                cmbTheLoai.DisplayMember = "TenTheLoai";
                cmbTheLoai.ValueMember = "MaTheLoai";
            }
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvSach.Rows[e.RowIndex];

                txtMaSach.Text =
                    row.Cells["MaSach"].Value.ToString();

                txtTenSach.Text =
                    row.Cells["TenSach"].Value.ToString();

                cmbTacGia.Text =
                    row.Cells["TenTacGia"].Value.ToString();

                cmbNXB.Text =
                    row.Cells["TenNXB"].Value.ToString();

                cmbTheLoai.Text =
                    row.Cells["TenTheLoai"].Value.ToString();

                txtSoLuong.Text =
                    row.Cells["SoLuong"].Value.ToString();

                if (
                    row.Cells["NamXuatBan"].Value != null &&
                    row.Cells["NamXuatBan"].Value != DBNull.Value
                )
                {
                    dtpNamXB.Value =
                        Convert.ToDateTime(
                            row.Cells["NamXuatBan"].Value
                        );
                }
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSach.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng chọn sách cần sửa!");
                    return;
                }

                int soLuong;

                if (!int.TryParse(txtSoLuong.Text, out soLuong))
                {
                    MessageBox.Show("Số lượng phải là số!");
                    return;
                }

                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
            UPDATE Sach
            SET
                TenSach = @TenSach,
                MaTacGia = @MaTacGia,
                MaNXB = @MaNXB,
                MaTheLoai = @MaTheLoai,
                NamXuatBan = @NamXuatBan,
                SoLuong = @SoLuong
            WHERE MaSach = @MaSach";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@MaSach",
                        Convert.ToInt32(txtMaSach.Text)
                    );

                    cmd.Parameters.AddWithValue(
                        "@TenSach",
                        txtTenSach.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@MaTacGia",
                        cmbTacGia.SelectedValue
                    );

                    cmd.Parameters.AddWithValue(
                        "@MaNXB",
                        cmbNXB.SelectedValue
                    );

                    cmd.Parameters.AddWithValue(
                        "@MaTheLoai",
                        cmbTheLoai.SelectedValue
                    );

                    cmd.Parameters.AddWithValue(
                        "@NamXuatBan",
                        dtpNamXB.Value.Date
                    );

                    cmd.Parameters.AddWithValue(
                        "@SoLuong",
                        soLuong
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sửa thành công!");

                    LoadSach();
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
                if (txtMaSach.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng chọn sách cần xóa!");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa sách này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    return;
                }

                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
            DELETE FROM Sach
            WHERE MaSach = @MaSach";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@MaSach",
                        Convert.ToInt32(txtMaSach.Text)
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công!");

                    LoadSach();

                    txtMaSach.Clear();
                    txtTenSach.Clear();
                    txtSoLuong.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
            SELECT
                s.MaSach,
                s.TenSach,
                tg.TenTacGia,
                nxb.TenNXB,
                tl.TenTheLoai,
                s.SoLuong,
                s.NamXuatBan
            FROM Sach s
            INNER JOIN TacGia tg
                ON s.MaTacGia = tg.MaTacGia
            INNER JOIN NhaXuatBan nxb
                ON s.MaNXB = nxb.MaNXB
            INNER JOIN TheLoai tl
                ON s.MaTheLoai = tl.MaTheLoai
            WHERE s.TenSach LIKE @TuKhoa";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@TuKhoa",
                        "%" + txtTimKiem.Text.Trim() + "%"
                    );

                    SqlDataAdapter da =
                        new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvSach.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();

            LoadSach();
        }
    }
}