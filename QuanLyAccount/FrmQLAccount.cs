using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyAccount
{
    public partial class FrmQLAccount : Form
    {
        private List<CQLAccount> dsuser = DuLieuDungChung.dsuser;
        public FrmQLAccount()
        {
            InitializeComponent();
            DuLieuDungChung.LoadData();
            dsuser = DuLieuDungChung.dsuser;
            hienthidanhsach();
        }
        private void hienthidanhsach()
        {
            dgvDsUser.DataSource = null;
            dgvDsUser.DataSource = dsuser;
        }
        private void ClearData()
        {
            txtMaUser.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            rBtnAdmin.Checked = false;
            rBtnUser.Checked = false;
        }
        private CQLAccount timUser(string maUs)
        {
            foreach(CQLAccount us in dsuser)
            {
                if(us.MaUser == maUs)
                   return us;
            }
            return null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CQLAccount us = new CQLAccount();
            if(timUser(txtMaUser.Text) == null)
            {
                us.MaUser = txtMaUser.Text;
                us.TenDangNhap = txtTenDangNhap.Text;
                us.MatKhau = txtMatKhau.Text;
                if(rBtnAdmin.Checked)
                    us.LoaiUser = "Admin";
                else
                    us.LoaiUser = "User";
                dsuser.Add(us);
                hienthidanhsach();
                ClearData();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maUs = txtMaUser.Text;
            CQLAccount us = new CQLAccount();
            if(timUser(maUs) == null)
            {
                MessageBox.Show("Không tìm thấy user có mã " + maUs);
            }
            else
            {
                us = timUser(maUs);
                dsuser.Remove(us);
                hienthidanhsach();
            }
        }

        private void dgvDsUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.RowIndex >= dgvDsUser.Rows.Count)
            {
                return;
            }
            DataGridViewRow row = dgvDsUser.Rows[e.RowIndex];
            if (row.IsNewRow)
                return;
            txtMaUser.Text = dgvDsUser.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
            txtTenDangNhap.Text = dgvDsUser.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";
            txtMatKhau.Text = dgvDsUser.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";
            if (dgvDsUser.Rows[e.RowIndex].Cells[0].Value?.ToString() == "Admin")
                rBtnAdmin.Checked = true;
            else
                rBtnUser.Checked = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maUs = txtMaUser.Text;
            if(timUser(maUs) == null)
            {
                MessageBox.Show("Không tìm thấy user có mã " + maUs);
            }
            else
            {
                CQLAccount us = timUser(maUs);
                us.TenDangNhap = txtTenDangNhap.Text;
                us.MatKhau = txtMatKhau.Text;
                if (rBtnAdmin.Checked)
                    us.LoaiUser = "Admin";
                else
                    us.LoaiUser = "User";
                hienthidanhsach();
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            CQLAccount us = new CQLAccount();
            us.MaUser = txtTimKiem.Text;
            if (timUser(us.MaUser) == null)
            {
                MessageBox.Show("Không tìm thấy user có mã " + us.MaUser);
            }
            else
            {
                us = timUser(us.MaUser);
                txtMaUser.Text = us.MaUser;
                txtTenDangNhap.Text = us.TenDangNhap;
                txtMatKhau.Text = us.MatKhau;
                if (us.LoaiUser == "Admin")
                    rBtnAdmin.Checked = true;
                else
                    rBtnUser.Checked = true;
            }
        }
    }
}
