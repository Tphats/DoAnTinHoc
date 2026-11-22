using QuanLyThuVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        private void HienthiUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnl_Content.Controls.Clear();
            pnl_Content.Controls.Add(uc);
        }
        private void DoiTrangThaiButton(Button btn)
        {
            foreach (Control ctrl in Pnl_Sidebar.Controls)
            {
                ctrl.Font = new Font(ctrl.Font, FontStyle.Regular);
                ctrl.BackColor = Color.White;
                ctrl.ForeColor = Color.Black;
            }
            btn.Font = new Font(btn.Font, FontStyle.Bold);
            btn.BackColor = Color.LightBlue;
            btn.ForeColor = Color.Blue;
        }
        private void btnCreatUser_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnCreatUser);
            HienthiUserControl(new ucDangkyTK());
        }

        private void btnQLAccount_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnQLAccount);
            HienthiUserControl(new ucQLAccount());
        }

        private void btnQLDocGia_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnQLDocGia);
            HienthiUserControl(new ucQLUser());
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnQLSach);
            HienthiUserControl(new ucQLSach_Chung());
        }

        private void btnQLPhieuMuon_Click(object sender, EventArgs e)
        {
            DoiTrangThaiButton(btnQLPhieuMuon);
            HienthiUserControl(new ucQLPhieu_Chung());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            DatabaseConnection db = new DatabaseConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Kết nối SQL Server thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }
    }
}
