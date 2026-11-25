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

namespace QuanLyThuVien
{
    public partial class FrmChiTietPhieu : Form
    {
        private string maPh, maDG;
        private string loaiPh;
        DBConnection Connect = new DBConnection();
        private void FrmChiTietPhieu_Load(object sender, EventArgs e)
        {
            if (loaiPh == "PM")
            {
                using(SqlConnection conn = Connect.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string sql = @"select * from PhieuMuon PM
                                        join ChiTietPhieuMuon CTPM on PM.MaPM=CTPM.MaPM
                                        where PM.MaDocGia = @MaDG and PM.MaPM = @MaPM";
                        using(SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.Add("@MaDG", SqlDbType.Int).Value = maDG;
                            cmd.Parameters.Add("@MaPM", SqlDbType.Int).Value = maPh;
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvChiTietP.DataSource = dt;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }    
            }
            else
            {
                
            }
        }

        public FrmChiTietPhieu(string MaPhieu,string MaDocGia, string LoaiPhieu)
        {
            InitializeComponent();
            maPh = MaPhieu;
            loaiPh = LoaiPhieu;
            maDG = MaDocGia;
        }
    }
}
