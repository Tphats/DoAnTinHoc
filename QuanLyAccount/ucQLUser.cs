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
    public partial class ucQLUser : UserControl
    {
        public ucQLUser()
        {
            InitializeComponent();
            hienthidanhsach();
        }
        private List<CQLUser> dsuser_info = DuLieuDungChung.dsuser_info;
        private void hienthidanhsach()
        {
            dgvDsUser.DataSource = null;
            dgvDsUser.DataSource = DuLieuDungChung.dsuser_info;
        }
        

        private void ucQLUser_Load(object sender, EventArgs e)
        {
            dsuser_info = DuLieuDungChung.dsuser_info;
        }
        private CQLUser timUser(string maUs)
        {
            foreach (CQLUser us in dsuser_info)
            {
                if (us.MaUser == maUs)
                {
                    return us;
                }
            }
            return null;
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
            string maUser = dgvDsUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            CQLUser user = timUser(maUser);
            if (user != null)
            {
                txtMaUser.Text = user.MaUser;
                txtTenUser.Text = user.TenUser;
                txtSDT.Text = user.SDT_User;
                txtEmail.Text = user.Email_User;
                txtDiachi.Text = user.DiaChi_User;
                dtNS.Value = user.NgaySinh_User;
                if(user.GioiTinh_User == CQLUser.GioiTinh.Nam)
                {
                    rNam.Checked = true;
                }
                else
                {
                    rNu.Checked = true;
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maUser = txtMaUser.Text;
            CQLUser userToRemove = dsuser_info.FirstOrDefault(u => u.MaUser == maUser);//tìm User theo mã
            if (userToRemove != null)
            {
                dsuser_info.Remove(userToRemove);
                hienthidanhsach();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maUser = txtMaUser.Text;
            CQLUser userToUpdate = dsuser_info.FirstOrDefault(u => u.MaUser == maUser);//tìm User theo mã
            if (userToUpdate != null)
            {
                userToUpdate.TenUser = txtTenUser.Text;
                userToUpdate.SDT_User = txtSDT.Text;
                userToUpdate.Email_User = txtEmail.Text;
                userToUpdate.DiaChi_User = txtDiachi.Text;
                userToUpdate.NgaySinh_User = dtNS.Value;
                if (rNam.Checked)
                {
                    userToUpdate.GioiTinh_User = CQLUser.GioiTinh.Nam;
                }
                else
                {
                    userToUpdate.GioiTinh_User = CQLUser.GioiTinh.Nu;
                }
                hienthidanhsach();
            }
        }
    }
}
