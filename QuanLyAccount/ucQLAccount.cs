using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class ucQLAccount : UserControl
    {
        private List<CQLAccount> dsuser = DuLieuDungChung.dsuser_account;
        public ucQLAccount()
        {
            InitializeComponent();
            DuLieuDungChung.LoadData();
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
            rBtnThuThu.Checked = false;
            rBtnUser.Checked = false;
        }
        private CQLAccount timUser(string maUs)
        {
            foreach (CQLAccount us in dsuser)
            {
                if (us.MaUser == maUs)
                    return us;
            }
            return null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CQLAccount us = new CQLAccount();
            if (timUser(txtMaUser.Text) == null)
            {
                us.MaUser = DuLieuDungChung.TaoMaUser();
                us.TenDangNhap = txtTenDangNhap.Text;
                us.MatKhau = txtMatKhau.Text;
                if (rBtnThuThu.Checked)
                    us.LoaiUser = CQLAccount.VaiTro.Librarian;
                else
                    us.LoaiUser = CQLAccount.VaiTro.User;
                dsuser.Add(us);
                hienthidanhsach();
                ClearData();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maUs = txtMaUser.Text;
            CQLAccount us = new CQLAccount();
            if (timUser(maUs) != null && timUser(maUs).LoaiUser != CQLAccount.VaiTro.Admin)
            {
                dsuser.Remove(timUser(maUs));
                hienthidanhsach();
            }
            else if (timUser(maUs) != null && timUser(maUs).LoaiUser == CQLAccount.VaiTro.Admin)
            {
                MessageBox.Show("Không thể xóa user có vai trò Admin!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy user có mã " + maUs);
            }
        }

        private void dgvDsUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvDsUser.Rows.Count)
            {
                return;
            }
            DataGridViewRow row = dgvDsUser.Rows[e.RowIndex];
            if (row.IsNewRow)
                return;
            txtMaUser.Text = dgvDsUser.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
            txtTenDangNhap.Text = dgvDsUser.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";
            txtMatKhau.Text = dgvDsUser.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";
            if (dgvDsUser.Rows[e.RowIndex].Cells[0].Value?.ToString() == "Librarian")
                rBtnThuThu.Checked = true;
            else
                rBtnUser.Checked = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maUs = txtMaUser.Text;

            CQLAccount us = timUser(maUs);
            us.TenDangNhap = txtTenDangNhap.Text;
            us.MatKhau = txtMatKhau.Text;
            if (rBtnThuThu.Checked)
                us.LoaiUser = CQLAccount.VaiTro.Librarian;
            else
                us.LoaiUser = CQLAccount.VaiTro.User;
            hienthidanhsach();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            CQLAccount us = timUser(txtTimKiem.Text);
            if (us == null)
            {
                MessageBox.Show("Không tìm thấy user có mã " + txtTimKiem.Text);
            }
            else
            {
                int index = dsuser.IndexOf(us);// Lấy dòng của user trong danh sách
                dgvDsUser.ClearSelection(); // Xóa lựa chọn hiện tại
                dgvDsUser.Rows[index].Selected = true; // Chọn dòng tương ứng với user tìm thấy
                txtMaUser.Text = us.MaUser;
                txtTenDangNhap.Text = us.TenDangNhap;
                txtMatKhau.Text = us.MatKhau;
                if (us.LoaiUser == CQLAccount.VaiTro.Librarian)
                    rBtnThuThu.Checked = true;
                else
                    rBtnUser.Checked = true;
            }
        }
    }
}
