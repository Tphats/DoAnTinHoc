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
            GetHanTra();
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
    }
}
