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
    public partial class ucTheLoai : UserControl
    {
        List<CTheLoai> danhsachtheloai = new List<CTheLoai>();

        public ucTheLoai()
        {
            InitializeComponent();
            hienthidanhsach(danhsachtheloai);
        }

        private void hienthidanhsach(List<CTheLoai> danhsachtheloai)
        {
            dgv_dstheloai.DataSource = danhsachtheloai.ToList();
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

        private void ucTheLoai_Load(object sender, EventArgs e)
        {

        }
    }
}
