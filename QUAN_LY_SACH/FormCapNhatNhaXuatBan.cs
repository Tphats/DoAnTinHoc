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
    public partial class FormCapNhatNhaXuatBan : Form
    {

        List<CNhaXuatBan> danhsachnhaxuatban = new List<CNhaXuatBan>();

        public FormCapNhatNhaXuatBan()
        {
            InitializeComponent();
            hienthidanhsach(danhsachnhaxuatban);
        }

        private void hienthidanhsach(List<CNhaXuatBan> danhsachnhaxuatban)
        {
            dgv_dsnhaxuatban.DataSource = danhsachnhaxuatban.ToList();
        }

        private bool ktnhapduthongtin()
        {
            if (txt_manxb.Text == "" || txt_tennxb.Text == "" || txt_diachi.Text == "")
            {
                return false;
            }
            return true;
        }

        private bool kttratontaimanhaxuatban(string ma)
        {
            foreach (CNhaXuatBan nxb in this.danhsachnhaxuatban)
            {
                if (nxb.MaNXB == ma)
                {
                    return true;
                }
            }
            return false;
        }

        private CNhaXuatBan timnhaxuatbantheoma(string ma)
        {
            foreach (CNhaXuatBan nxb in this.danhsachnhaxuatban)
            {
                if (nxb.MaNXB == ma)
                {
                    return nxb;
                }
            }
            return null;
        }

        // ------------------------------------------------
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!ktnhapduthongtin())
            {
                MessageBox.Show(
                    "Vui lòng nhập đủ thông tin",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            CNhaXuatBan nxbmoi = new CNhaXuatBan();
            nxbmoi.MaNXB = txt_manxb.Text;
            nxbmoi.TenNXB = txt_tennxb.Text;
            nxbmoi.Diachi = txt_diachi.Text;

            if (kttratontaimanhaxuatban(nxbmoi.MaNXB))
            {
                MessageBox.Show(
                    "Không thêm được (mã nhà xuất bản bị trùng)",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            this.danhsachnhaxuatban.Add(nxbmoi);
            hienthidanhsach(danhsachnhaxuatban);
        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_manxb.Text == "")
            {
                MessageBox.Show(
                    "Không tìm thấy mã nhà xuất bản này để xóa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!kttratontaimanhaxuatban(txt_manxb.Text))
            {
                MessageBox.Show(
                    "Không xóa được (không tìm thấy mã)",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            CNhaXuatBan nxb = timnhaxuatbantheoma(txt_manxb.Text);
            if (nxb == null)
            {
                MessageBox.Show(
                    "Không xóa được (không tìm thấy mã)",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            this.danhsachnhaxuatban.Remove(nxb);
            hienthidanhsach(danhsachnhaxuatban);
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (!ktnhapduthongtin())
            {
                MessageBox.Show(
                    "Vui lòng nhập đủ thông tin",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            CNhaXuatBan nxbmoi = new CNhaXuatBan();
            nxbmoi.MaNXB = txt_manxb.Text;
            nxbmoi.TenNXB = txt_tennxb.Text;
            nxbmoi.Diachi = txt_diachi.Text;

            CNhaXuatBan nxbCu = timnhaxuatbantheoma(nxbmoi.MaNXB);
            if (nxbCu == null)
            {
                MessageBox.Show(
                    $"Không tìm thấy nhà xuất bản có mã {txt_manxb.Text} để sửa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            nxbCu.TenNXB = nxbmoi.TenNXB;
            nxbCu.Diachi = nxbmoi.Diachi;
            hienthidanhsach(danhsachnhaxuatban);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
