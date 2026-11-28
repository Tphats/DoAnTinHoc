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
            timerLoadTQ.Start();
            LoadMaPM();
            LoadTen_Search();
            XuLyDuLieu.CapNhatTrangThaiQuaHan();
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
            txtMaSach.Text = row.Cells["Mã Sách"].Value?.ToString();
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

        private void LoadMaSach()
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql_layMaDG = @"SELECT MaSach FROM PhieuMuon
                                  WHERE MaPM = @MaPM";
                    using (SqlCommand cmd = new SqlCommand(sql_layMaDG, conn))
                    {
                        cmd.Parameters.Add("@MaPM", SqlDbType.Int).Value = Convert.ToInt32(cboMaPM.SelectedValue);
                        object kq = cmd.ExecuteScalar();
                        if (kq != null && kq != DBNull.Value)
                        {
                            txtMaSach.Text = kq.ToString();
                        }
                        else
                        {
                            txtMaSach.Clear();
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
            LoadMaSach();
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
                    //Đếm tổng Phiếu
                    string sql_TongPM = @"select count(*) from PhieuMuon";
                    using (SqlCommand cmd = new SqlCommand(sql_TongPM, conn))
                    {
                        txtSoLuongPM.Text = cmd.ExecuteScalar().ToString();
                    }
                    //Đếm Đang mượn
                    string sql_DM = @"SELECT COUNT(TrangThai)
                                        from PhieuMuon
                                        where TrangThai = N'Đang Mượn'";

                    using (SqlCommand cmd = new SqlCommand(sql_DM, conn))
                    {
                        object kq = cmd.ExecuteScalar();
                        if(kq != null && kq != DBNull.Value)
                        {
                            txtDangMuon.Text = kq.ToString();
                        }

                    }
                    //đếm Quá hạn
                    string sql_QH = @"SELECT COUNT(TrangThai)
                                        from PhieuMuon
                                        where TrangThai = N'Quá Hạn'";

                    using (SqlCommand cmd = new SqlCommand(sql_QH, conn))
                    {
                        object kq = cmd.ExecuteScalar();
                        if (kq != null && kq != DBNull.Value)
                        {
                            txtQuaHan.Text = kq.ToString();
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
                                        from PhieuMuon
                                        left join  DocGia on DocGia.MaDocGia=PhieuMuon.MaDocGia
                                        left join ChiTietPhieuMuon on PhieuMuon.MaPM=ChiTietPhieuMuon.MaPM
                                        left join Sach on Sach.MaSach=ChiTietPhieuMuon.MaSach
                                        left join TheLoai on TheLoai.MaTheLoai = Sach.MaTheLoai
                                        left join TacGia on Sach.MaTacGia = TacGia.MaTacGia
                                        left join NhaXuatBan on NhaXuatBan.MaNXB = Sach.MaNXB
";
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
            DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn xóa toàn bộ phiếu mượn này?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );
            if (result != DialogResult.Yes)
                return;
            using (SqlConnection conn = Connect.GetConnection())
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        //Kiểm tra trạng thái phiếu mượn
                        string sql_KiemTra = @"
                                                SELECT TrangThai
                                                FROM PhieuMuon
                                                WHERE MaPM = @MaPM";

                        string trangThai;
                        int maPM = Convert.ToInt32(cboMaPM.Text);

                        using (SqlCommand cmd = new SqlCommand(sql_KiemTra, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@MaPM", maPM);

                            object kq = cmd.ExecuteScalar();

                            if (kq == null)
                                throw new Exception("Không tìm thấy phiếu mượn!");

                            trangThai = kq.ToString();
                        }

                        //Chỉ cho xóa phiếu đang mượn để tránh cộng kho hai lần
                        if (trangThai != "Đang Mượn")
                            throw new Exception("Chỉ được xóa phiếu đang mượn!");

                        //Cập nhật số lượng của sách
                        string sql_UpdateSL = @"update Sach
                                            set Sach.SoLuongCon = SoLuongCon + CT.SoLuong
                                            from Sach join ChiTietPhieuMuon CT on Sach.MaSach=CT.MaSach
                                            where CT.MaPM = @MaPM";
                        using (SqlCommand cmd = new SqlCommand(sql_UpdateSL, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@MaPM", maPM);
                            cmd.ExecuteNonQuery();
                        }
                        //Xóa tất cả chi tiết phiếu mượn
                        string sql_XoaCT = @"
                                            DELETE FROM ChiTietPhieuMuon
                                            WHERE MaPM = @MaPM";

                        using (SqlCommand cmd = new SqlCommand(sql_XoaCT, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@MaPM", maPM);
                            cmd.ExecuteNonQuery();
                        }
                        //Xóa Phiếu mươn
                        string sql = @"delete from PhieuMuon 
                                    where MaPM = @MaPM";
                        using (SqlCommand cmd = new SqlCommand(sql, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@MaPM", maPM);
                            if (cmd.ExecuteNonQuery() == 0)
                            {
                                LoadDgv();
                                MessageBox.Show("Xóa Phiếu mươn không thành công!");
                            }
                        }
                        tran.Commit();
                        LoadMaPM();
                        LoadDgv();
                        MessageBox.Show("Xóa toàn bộ Phiếu mượn thành công!");
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        

        private void timerLoadTQ_Tick(object sender, EventArgs e)
        {
            LoadTongQuan();
            XuLyDuLieu.CapNhatTrangThaiQuaHan();
        }

    }
}
