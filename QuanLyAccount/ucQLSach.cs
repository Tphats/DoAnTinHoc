using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_SACH
{
	public partial class ucQLSach : UserControl
	{
        List<CSach> danhsachsach = new List<CSach>();
        public ucQLSach()
        {
            InitializeComponent();
            hienthidanhsach(danhsachsach);
        }

        private void hienthidanhsach(List<CSach> danhsachsach)
        {
            dgv_dssach.DataSource = danhsachsach.ToList();
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

		private void btn_timkiem_Click(object sender, EventArgs e)
		{
			
		}

		private void btn_xemdanhsach_Click(object sender, EventArgs e)
		{
		
		}

		private void btn_thoat_Click(object sender, EventArgs e)
		{
		
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
