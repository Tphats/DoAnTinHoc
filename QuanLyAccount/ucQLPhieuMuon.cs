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
            LoadMaDG();
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

        private void ucQLPhieuMuon_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql_DGV = @"select * from PhieuMuon
                                       join ChiTietPhieuMuon 
                                       on PhieuMuon.MaPM=ChiTietPhieuMuon.MaPM";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql_DGV, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPM.DataSource = dt;
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

            cboMaPM.Text = row.Cells["MaPM"].Value?.ToString();
            txtMaDG.Text = row.Cells["MaDocGia"].Value?.ToString();
            cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
        }
    }
}
