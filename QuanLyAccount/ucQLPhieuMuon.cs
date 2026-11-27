using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class ucQLPhieuMuon : UserControl
    {
        DBConnection Connect = new DBConnection();
        public ucQLPhieuMuon()
        {
            InitializeComponent();
            LoadMaPM();
            LoadTen_Search();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
                FrmLapPhieuMuon frm = new FrmLapPhieuMuon();
                frm.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (cboMaPM.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phiếu trả hoặc mã độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmChiTietPhieu frm = new FrmChiTietPhieu(cboMaPM.Text.Trim(), txtMaDG.Text, "PM");
            frm.Show(); 
        }
        private void btnXemDS_Click(object sender, EventArgs e)
        {
            LoadDgv();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            int maDG = Convert.ToInt32(cboMaDG_Search.SelectedValue.ToString());
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"select PhieuMuon.MaPM as 'Mã Phiếu mượn', DocGia.MaDocGia as 'Mã độc giả'
                                        , DocGia.HoTen as 'Họ và Tên', TrangThai as 'Trạng Thái', NgayMuon as 'Ngày mượn', HanTra as 'Hạn trả'
                                        ,ChiTietPhieuMuon.SoLuong as 'Số sách mượn',Sach.MaSach as 'Mã sách'
                                        , TenSach as 'Tên sách', TenTheLoai as 'Thể loại'
                                        ,TenTacGia as 'Tác giả', TenNXB as 'Nhà xuất bản'
                                        from DocGia
                                        join PhieuMuon on DocGia.MaDocGia=PhieuMuon.MaDocGia
                                        join ChiTietPhieuMuon on PhieuMuon.MaPM=ChiTietPhieuMuon.MaPM
                                        join Sach on Sach.MaSach=ChiTietPhieuMuon.MaSach
                                        join TheLoai on TheLoai.MaTheLoai = Sach.MaTheLoai
                                        join TacGia on Sach.MaTacGia = TacGia.MaTacGia
                                        join NhaXuatBan on NhaXuatBan.MaNXB = Sach.MaNXB
                                        
                                        where DocGia.MaDocGia = @MaDG";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaDG", SqlDbType.Int).Value = maDG;
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvPM.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void dgvPM_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvPM.Rows[e.RowIndex];

            cboMaPM.Text = row.Cells["Mã Phiếu mượn"].Value?.ToString();
            txtMaDG.Text = row.Cells["Mã Độc giả"].Value?.ToString();
            cboTrangThai.Text = row.Cells["Trạng Thái"].Value?.ToString();
            txtMaSach.Text = row.Cells["Mã Sách"].Value.ToString();
        }
        private void LoadMaPM()
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT MaPM FROM PhieuMuon";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cboMaPM.DataSource = dt;
                        cboMaPM.DisplayMember = "MaPM";
                        cboMaPM.ValueMember = "MaPM";
                        cboMaPM.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void LoadMaDG()
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql_layMaDG = @"SELECT MaDocGia FROM PhieuMuon
                                  WHERE MaPM = @MaPM";
                    using(SqlCommand cmd = new SqlCommand(sql_layMaDG, conn))
                    {
                        cmd.Parameters.Add("@MaPM", SqlDbType.Int).Value = Convert.ToInt32(cboMaPM.SelectedValue);
                        object kq = cmd.ExecuteScalar();
                        if (kq != null && kq != DBNull.Value)
                        {
                            txtMaDG.Text = kq.ToString();
                        }
                        else
                        {
                            txtMaDG.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }



        private void LoadTen_Search()
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT MaDocGia, HoTen FROM DocGia";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cboMaDG_Search.DataSource = dt;
                        cboMaDG_Search.DisplayMember = "HoTen";
                        cboMaDG_Search.ValueMember = "MaDocGia";
                        cboMaDG_Search.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void cboMaPM_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadMaDG();
        }
        private void ucQLPhieuMuon_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }
        private void LoadTongQuan()
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql_TongPM = @"select count(*) from PhieuMuon";
                    using (SqlCommand cmd = new SqlCommand(sql_TongPM, conn))
                    {
                        //int tongPhieuMuon = (int)cmd.ExecuteScalar();
                        txtSoLuongPM.Text = cmd.ExecuteScalar().ToString();
                    }
                    string sql_DM_QH = @"
                                         SELECT
                                         COUNT(CASE
                                         WHEN TrangThai = N'Đang mượn'
                                         THEN 1 END) AS TongDangMuon,

                                         COUNT(CASE
                                         WHEN TrangThai = N'Đang mượn'
                                         AND HanTra < CAST(GETDATE() AS DATE)
                                         THEN 1 END) AS TongQuaHan

                                         FROM PhieuMuon";

                    using (SqlCommand cmd = new SqlCommand(sql_DM_QH, conn))
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            txtDangMuon.Text = rd["TongDangMuon"].ToString();
                            txtQuaHan.Text = rd["TongQuaHan"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void LoadDgv()
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql_DGV = @"select PhieuMuon.MaPM as 'Mã Phiếu mượn', DocGia.MaDocGia as 'Mã độc giả'
                                        , DocGia.HoTen as 'Họ và Tên', TrangThai as 'Trạng Thái', NgayMuon as 'Ngày mượn', HanTra as 'Hạn trả'
                                        ,ChiTietPhieuMuon.SoLuong as 'Số sách mượn',Sach.MaSach as 'Mã sách'
                                        , TenSach as 'Tên sách', TenTheLoai as 'Thể loại'
                                        ,TenTacGia as 'Tác giả', TenNXB as 'Nhà xuất bản'
                                        from DocGia
                                        join PhieuMuon on DocGia.MaDocGia=PhieuMuon.MaDocGia
                                        join ChiTietPhieuMuon on PhieuMuon.MaPM=ChiTietPhieuMuon.MaPM
                                        join Sach on Sach.MaSach=ChiTietPhieuMuon.MaSach
                                        join TheLoai on TheLoai.MaTheLoai = Sach.MaTheLoai
                                        join TacGia on Sach.MaTacGia = TacGia.MaTacGia
                                        join NhaXuatBan on NhaXuatBan.MaNXB = Sach.MaNXB";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql_DGV, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPM.DataSource = dt;
                    LoadTongQuan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"delete from ChiTietPhieuMuon 
                                    where MaPM = @MaPM AND MaSach = @MaSach";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPM", cboMaPM.Text);
                        cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            LoadDgv();
                            MessageBox.Show("Xóa thành công");
                        }    
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
