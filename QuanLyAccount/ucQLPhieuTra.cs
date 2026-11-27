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
    public partial class ucQLPhieuTra : UserControl
    {
        DBConnection Connect = new DBConnection();
        public ucQLPhieuTra()
        {
            InitializeComponent();
            LoadMaPM();
            LoadDgv();
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
        private void txtMa_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtMa_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmLapPhieuTra frm = new FrmLapPhieuTra();
            frm.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            //if (txtMa.Text == "Nhập mã phiếu trả hoặc mã độc giả" || txtMa.Text == "")
            //{
            //    MessageBox.Show("Vui lòng nhập mã phiếu trả hoặc mã độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //FrmChiTietPhieu frm = new FrmChiTietPhieu(Convert.ToInt32(txtMa.Text), "PT");
            //    //frm.Show();
        }
        private void LoadDgv()
        {
            using (SqlConnection conn = Connect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql_DGV = @"select * from PhieuTra";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql_DGV, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPT.DataSource = dt;
                    //LoadTongQuan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
