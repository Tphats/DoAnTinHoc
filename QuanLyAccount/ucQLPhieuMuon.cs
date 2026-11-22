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
    public partial class ucQLPhieuMuon : UserControl
    {
        public ucQLPhieuMuon()
        {
            InitializeComponent();
        }

        private void txtMa_Enter(object sender, EventArgs e)
        {
            txtMa.Text = "";
        }

        private void txtMa_Leave(object sender, EventArgs e)
        {
            if(txtMa.Text == "")
                txtMa.Text = "Nhập mã phiếu mượn hoặc mã độc giả";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMa.Text == "Nhập mã phiếu mượn hoặc mã độc giả" || txtMa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phiếu mượn hoặc mã độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtMa.Text == "123")
            {
                FrmLapPhieuMuon frm = new FrmLapPhieuMuon(txtMa.Text);
                frm.Show();
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "Nhập mã phiếu trả hoặc mã độc giả" || txtMa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phiếu trả hoặc mã độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMa.Text == "123")
            {
                FrmChiTietPhieu frm = new FrmChiTietPhieu(txtMa.Text);
                frm.Show();
            }
        }
    }
}
