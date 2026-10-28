using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyUser
{
    public partial class FrmQLUser : Form
    {
        private List<CQLUser> dsuser = new List<CQLUser>();
        public FrmQLUser()
        {
            InitializeComponent();
            LoadData();
            hienthidanhsach();
        }
        private void hienthidanhsach()
        {
            dgvDsUser.DataSource = null;
            dgvDsUser.DataSource = dsuser;
        }
        private void LoadData()
        {
            dsuser.Add(new CQLUser("Admin", "U001", "admin", "123456", DateTime.Now));
            dsuser.Add(new CQLUser("User", "U002", "user1", "123456", DateTime.Now));
            dsuser.Add(new CQLUser("User", "U003", "user2", "123456", DateTime.Now));
        }
        private void ClearData()
        {
            txtMaUser.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            dtNgayTaoTK.Value = DateTime.Now;
            rBtnAdmin.Checked = false;
            rBtnUser.Checked = false;
        }
        //public void timkiem()
        //{
        //    string tukhoa = txtTimKiem.Text.ToLower();
        //    var ketqua = dsuser.Where(u => u.MaUser.ToLower().Contains(tukhoa) || u.TenDangNhap.ToLower().Contains(tukhoa)).ToList();
        //    dgvDsUser.DataSource = null;
        //    dgvDsUser.DataSource = ketqua;
        //}
        private CQLUser timUser(string maUs)
        {
            foreach(CQLUser us in dsuser)
            {
                if(us.MaUser == maUs)
                   return us;
            }
            return null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CQLUser us = new CQLUser();
            if(timUser(txtMaUser.Text) == null)
            {
                us.MaUser = txtMaUser.Text;
                us.TenDangNhap = txtTenDangNhap.Text;
                us.MatKhau = txtMatKhau.Text;
                us.NgayTaoTK = dtNgayTaoTK.Value;
                if(rBtnAdmin.Checked)
                    us.LoaiUser = "Admin";
                else
                    us.LoaiUser = "User";
                dsuser.Add(us);
                hienthidanhsach();
            }
        }
    }
}
