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
    public partial class ucNhaXuatBan : UserControl
    {


        public ucNhaXuatBan()
        {
            InitializeComponent();
        }

        private void hienthidanhsach()
        {
        }

        private bool ktnhapduthongtin()
        {
            if (txt_manxb.Text == "" || txt_tennxb.Text == "" || txt_diachi.Text == "")
            {
                return false;
            }
            return true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
        }
        private void ucNhaXuatBan_Load(object sender, EventArgs e)
        {

        }
    }
}
