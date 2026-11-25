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
    public partial class ucQLPhieuTra : UserControl
    {
        public ucQLPhieuTra()
        {
            InitializeComponent();
        }
        private void txtMa_Enter(object sender, EventArgs e)
        {
            txtMa.Text = "";
        }

        private void txtMa_Leave(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
                txtMa.Text = "Nhập mã phiếu trả hoặc mã độc giả";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMa.Text == "Nhập mã phiếu trả hoặc mã độc giả" || txtMa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phiếu trả hoặc mã độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                FrmLapPhieuTra frm = new FrmLapPhieuTra(txtMa.Text);
                frm.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "Nhập mã phiếu trả hoặc mã độc giả" || txtMa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phiếu trả hoặc mã độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                //FrmChiTietPhieu frm = new FrmChiTietPhieu(Convert.ToInt32(txtMa.Text), "PT");
                //frm.Show();
        }
    }
}
