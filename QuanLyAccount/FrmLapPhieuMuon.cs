using System;
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
        private string maDG;
        private int maPM;
        DBConnection Connect = new DBConnection();
        public FrmLapPhieuMuon(string maDocGia)
        {
            maDG = maDocGia;
            dtHanTra.Value = dtNgayMuon.Value.AddDays(120);
            InitializeComponent();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (txtMaDG.Text == "" || txtMaDG.Text != maDG)
                return;
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO ChiTietPhieuMuon(MaPM, MaSach, SoLuong)
                                   VALUES (@MaPM, @MaSach, @SoLuong)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaPM", SqlDbType.Int).Value = maPM;
                        cmd.Parameters.Add("@MaSach", SqlDbType.Int).Value = Convert.ToInt32(txtMaSach.Text);
                        cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = Convert.ToInt32(txtSoCuon.Text);
                        if (cmd.ExecuteNonQuery() > 0)
                            MessageBox.Show("Lập Phiếu thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnLapPM_Click(object sender, EventArgs e)
        {
            if (txtMaDG.Text == "" || txtMaDG.Text != maDG)
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
                        cmd.Parameters.Add("@MaDocGia", SqlDbType.Int).Value = maDG;
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
            }
        }
    }
}
