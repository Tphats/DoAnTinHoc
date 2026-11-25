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
    public partial class ucTacGia : UserControl
    {
		List<CTacGia> danhsachtacgia = new List<CTacGia>();
		public ucTacGia() {
			InitializeComponent();
			hienthidanhsach(danhsachtacgia);
		}

		private void hienthidanhsach(List<CTacGia> danhsachtacgia) {
			dgv_dstacgia.DataSource = danhsachtacgia.ToList();
		}
		

		private void btn_them_Click(object sender, EventArgs e) {
			
		}

		private void btn_xoa_Click(object sender, EventArgs e) {
			
		}

		private void btn_sua_Click(object sender, EventArgs e) {
			
		}

		private void btn_thoat_Click(object sender, EventArgs e) {
			
		}

        private void ucTacGia_Load(object sender, EventArgs e)
        {

        }

       
    }
}
