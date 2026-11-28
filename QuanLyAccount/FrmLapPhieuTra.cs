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
    public partial class FrmLapPhieuTra : Form
    {
        DBConnection Connect = new DBConnection();
        private decimal TP;
        public FrmLapPhieuTra()
        {
            InitializeComponent();
            XuLyDuLieu.CapNhatTrangThaiQuaHan();
            LoadTenDG();
        }
        private Decimal TienPhat(DateTime NgayTra, DateTime HanTra)
        {
            decimal tienphat = 0;
            if(NgayTra > HanTra)
            {
               int songay = (NgayTra.Date - HanTra.Date).Days;
                tienphat = 2000 * songay;
            }
            return tienphat;

        }
        private void GetHanTra()
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"select HanTra from PhieuMuon where MaPM = @MaPM";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPM", Convert.ToInt32(txtMaPM.Text));
                        object kq = cmd.ExecuteScalar();
                        if (kq != null && kq != DBNull.Value)
                        {
                            dtHanTra.Value = Convert.ToDateTime(kq.ToString());
                        }
                        else
                            dtHanTra.Value = DateTime.Now;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLapPT_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"insert into PhieuTra (MaPM, NgayTra, TienPhat)
                                    values (@MaPM, @NgayTra, @TienPhat)";
                    using (SqlCommand cmd = new SqlCommand(sql,conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPM", Convert.ToInt32(txtMaPM.Text));
                        cmd.Parameters.AddWithValue("@NgayTra", dtNgayTra.Value);
                        cmd.Parameters.AddWithValue("@TienPhat", TienPhat(dtNgayTra.Value, dtHanTra.Value));
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Lập phiếu phạt thành công");
                            string sql_updateTT = @"UPDATE PhieuMuon
                                            SET TrangThai = N'Đã trả'
                                            WHERE MaPM = @MaPM";

                            using (SqlCommand cmdUpdate = new SqlCommand(sql_updateTT, conn))
                            {
                                cmdUpdate.Parameters.AddWithValue("@MaPM", Convert.ToInt32(txtMaPM.Text));
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    
        }

        private void btnXemTP_Click(object sender, EventArgs e)
        {
            decimal TP = TienPhat(dtNgayTra.Value, dtHanTra.Value);
            txtTienPhat.Text = Convert.ToString(TP);
        }

        private void bnt_XemDSPM_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"select PM.MaPM, PM.MaDocGia, HoTen, NgayMuon
                                    , HanTra, TrangThai, CT.SoLuong as 'Số sách mượn' 
                                    from PhieuMuon PM 
                                    join ChiTietPhieuMuon CT on PM.MaPM=CT.MaPM
                                    join DocGia DG on PM.MaDocGia=DG.MaDocGia
                                    where PM.MaDocGia = @MaDG";
                    using(SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDG", Convert.ToInt32(cboDG.SelectedValue));
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvDSPM.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void LoadTenDG()
        {
            using(SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    string sql = @"select MaDocGia, HoTen from DocGia";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cboDG.DataSource = dt;
                    cboDG.DisplayMember = "HoTen";
                    cboDG.ValueMember = "MaDocGia";
                    cboDG.SelectedIndex = -1;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        private void txtMaPM_TextChanged(object sender, EventArgs e)
        {
            GetHanTra();
        }

        private void dgvDSPM_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dgvDSPM.Rows[e.RowIndex];
            txtMaPM.Text = row.Cells["MaPM"].Value?.ToString();
            //dtHanTra.Value = Convert.ToDateTime(row.Cells["HanTra"].Value);
        }
    }
}
