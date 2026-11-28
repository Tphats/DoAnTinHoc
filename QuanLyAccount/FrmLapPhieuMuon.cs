using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FrmLapPhieuMuon : Form
    {
        private int maPM;
        DBConnection Connect = new DBConnection();
        public FrmLapPhieuMuon()
        {
            InitializeComponent();
            LoadTenSach();

        }
        private void hienthids()
        {
            LoadDgv();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (cboMaDG.Text == "")
                return;
            using (SqlConnection conn = Connect.GetConnection())
            {
                SqlTransaction tran = null;
                try
                {
                    conn.Open();
                    tran = conn.BeginTransaction(); //Kiểm tra giao dịch thành công hết hoặc hủy tất cả
                    if (txtSoCuon.Text == "")
                        throw new Exception("Hãy nhập số sách cần mượn");
                    int maSach = Convert.ToInt32(cboMaSach.Text);
                    int slMuon = Convert.ToInt32(txtSoCuon.Text);
                    //Kiểm tra SL sách còn lại
                    string sql_SLCon = @"select SoLuongCon from Sach where MaSach = @MaSach";
                    int slCon;
                    using(SqlCommand cmd = new SqlCommand(sql_SLCon, conn, tran))
                    {
                        cmd.Parameters.Add("@MaSach", SqlDbType.Int).Value = maSach;
                        object kq = cmd.ExecuteScalar();
                        if (kq == null || kq == DBNull.Value)
                            throw new Exception("Không tìm thấy sách!");
                        slCon = Convert.ToInt32(kq);
                    }
                    //Kiểm tra SL mượn
                    if (slMuon <= 0)
                        throw new Exception("Số lượng mượn phải lớn hơn 0!");
                    if(slCon < slMuon)
                        throw new Exception("Số lượng sách không đủ");
                    // Kiểm tra sách đã tồn tại trong phiếu chưa
                    string sql_KiemTra = @"SELECT COUNT(*)
                                   FROM ChiTietPhieuMuon
                                   WHERE MaPM = @MaPM
                                   AND MaSach = @MaSach";

                    int tonTai;

                    using (SqlCommand cmd = new SqlCommand(sql_KiemTra, conn, tran))
                    {
                        cmd.Parameters.Add("@MaPM", SqlDbType.Int).Value = maPM;
                        cmd.Parameters.Add("@MaSach", SqlDbType.Int).Value = maSach;

                        tonTai = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Nếu tồn tại thì UPDATE, chưa tồn tại thì INSERT
                    string sql;

                    if (tonTai > 0)
                    {
                        sql = @"UPDATE ChiTietPhieuMuon
                        SET SoLuong = SoLuong + @SoLuong
                        WHERE MaPM = @MaPM AND MaSach = @MaSach";
                    }
                    else
                    {
                        sql = @"INSERT INTO ChiTietPhieuMuon
                        (MaPM, MaSach, SoLuong)
                        VALUES (@MaPM, @MaSach, @SoLuong)";
                    }
                    using (SqlCommand cmd = new SqlCommand(sql, conn, tran))
                    {
                        cmd.Parameters.Add("@MaPM", SqlDbType.Int).Value = maPM;
                        cmd.Parameters.Add("@MaSach", SqlDbType.Int).Value = maSach;
                        cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = slMuon;

                        cmd.ExecuteNonQuery();
                    }
                    //Cập nhật số lượng sách còn
                    string sql_UpdateSLCon = @"UPDATE Sach
                                       SET SoLuongCon = SoLuongCon - @SLMuon
                                       WHERE MaSach = @MaSach";
                    using (SqlCommand cmd = new SqlCommand(sql_UpdateSLCon, conn, tran))
                    {
                        cmd.Parameters.Add("@SLMuon", SqlDbType.Int).Value = slMuon;
                        cmd.Parameters.Add("@MaSach", SqlDbType.Int).Value = maSach;

                        cmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                    hienthids();
                    MessageBox.Show("Thêm sách vào phiếu mượn thành công!");
                }
                catch (Exception ex)
                {
                    if (tran != null)
                        tran.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnLapPM_Click(object sender, EventArgs e)
        {
            if (cboMaDG.Text == "")
                return;
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO PhieuMuon (MaDocGia, NgayMuon, HanTra, TrangThai)
                                    VALUES (@MaDocGia, @NgayMuon, @HanTra, @TrangThai);
                                    SELECT CAST(SCOPE_IDENTITY() AS INT);";//ép kiểu MãPM thành int
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaDocGia", SqlDbType.Int).Value = Convert.ToInt32(cboMaDG.SelectedValue);
                        cmd.Parameters.Add("@NgayMuon", SqlDbType.Date).Value = dtNgayMuon.Value;
                        cmd.Parameters.Add("@HanTra", SqlDbType.Date).Value = dtHanTra.Value;
                        cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 30).Value = "Đang Mượn";
                        maPM = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                //Hiện chức năng thêm sách
                labelMaSach.Visible = true;
                labelSoCuon.Visible = true;
                cboMaSach.Visible = true;
                txtSoCuon.Visible = true;
                btnThemSach.Visible = true;
                label_SL.Visible = true;
                txtSLSachCon.Visible = true;
                btnLapPM.Enabled = false;
            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadMaDG()
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT MaDocGia, HoTen FROM DocGia";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cboMaDG.DataSource = dt;
                        cboMaDG.DisplayMember = "HoTen";
                        cboMaDG.ValueMember = "MaDocGia";
                        cboMaDG.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void FrmLapPhieuMuon_Load(object sender, EventArgs e)
        {
            dtHanTra.Value = dtNgayMuon.Value.AddDays(120);
            //Ẩn mục chọn sách trước khi tạo Phiếu
            labelMaSach.Visible = false;
            labelSoCuon.Visible = false;
            cboMaSach.Visible = false;
            txtSoCuon.Visible = false;
            btnThemSach.Visible = false;
            label_SL.Visible = false;
            txtSLSachCon.Visible = false;
            LoadMaDG();
            LoadDgv();
        }

        private void cboMaDG_SelectionChangeCommitted(object sender, EventArgs e) //Sau khi chọn mãDG thì sẽ hiện tênDG
        {
            
        }

        private void dgvDSSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dgvDSSach.Rows[e.RowIndex];
            cboMaSach.Text = row.Cells["MaSach"].Value?.ToString();
            txtSLSachCon.Text = row.Cells["SoLuongCon"].Value?.ToString();
        }
        private void LoadTenSach()
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT MaSach, TenSach FROM Sach";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cboMaSach.DataSource = dt;
                        cboMaSach.DisplayMember = "TenSach";
                        cboMaSach.ValueMember = "MaSach";
                        cboMaSach.SelectedIndex = -1;
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
            using(SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"
                                    SELECT
                                        S.MaSach,
                                        S.TenSach,
                                        S.SoLuongCon,
                                        TG.TenTacGia,
                                        NXB.TenNXB,
                                        TL.TenTheLoai
                                    FROM Sach S
                                    LEFT JOIN TacGia TG ON S.MaTacGia = TG.MaTacGia
                                    LEFT JOIN NhaXuatBan NXB ON S.MaNXB = NXB.MaNXB
                                    LEFT JOIN TheLoai TL ON S.MaTheLoai = TL.MaTheLoai";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDSSach.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            dtHanTra.Value = dtNgayMuon.Value.AddDays(120);
        }
    }
}
