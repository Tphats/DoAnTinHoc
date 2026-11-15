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

        private bool ktnhapduthongtin()
        {
            if (txt_matheloai.Text == "" || txt_tentheloai.Text == "")
            {
                return false;
            }
            return true;
        }

        private bool kttrataontaimatheloai(string ma)
        {
            foreach (CTheLoai tl in this.danhsachtheloai)
            {
                if (tl.Matheloai == ma)
                {
                    return true;
                }
            }
            return false;
        }

        private CTheLoai timtheloaitheoma(string ma)
        {
            foreach (CTheLoai tl in this.danhsachtheloai)
            {
                if (tl.Matheloai == ma)
                {
                    return tl;
                }
            }
            return null;
        }

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

            CTheLoai tlmoi = new CTheLoai();
            tlmoi.Matheloai = txt_matheloai.Text;
            tlmoi.Tentheloai = txt_tentheloai.Text;

            if (kttrataontaimatheloai(tlmoi.Matheloai))
            {
                MessageBox.Show(
                    "Không thêm được (mã thể loại bị trùng)",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            this.danhsachtheloai.Add(tlmoi);
            hienthidanhsach(danhsachtheloai);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_matheloai.Text == "")
            {
                MessageBox.Show(
                    "Không tìm thấy mã thể loại này để xóa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!kttrataontaimatheloai(txt_matheloai.Text))
            {
                MessageBox.Show(
                    "Không xóa được (không tìm thấy mã)",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            CTheLoai tl = timtheloaitheoma(txt_matheloai.Text);
            if (tl == null)
            {
                MessageBox.Show(
                    "Không xóa được (không tìm thấy mã)",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            this.danhsachtheloai.Remove(tl);
            hienthidanhsach(danhsachtheloai);
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

            CTheLoai tlmoi = new CTheLoai();
            tlmoi.Matheloai = txt_matheloai.Text;
            tlmoi.Tentheloai = txt_tentheloai.Text;

            CTheLoai tlCu = timtheloaitheoma(tlmoi.Matheloai);
            if (tlCu == null)
            {
                MessageBox.Show(
                    $"Không tìm thấy thể loại có mã {txt_matheloai.Text} để sửa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            tlCu.Tentheloai = tlmoi.Tentheloai;
            hienthidanhsach(danhsachtheloai);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.ParentForm?.Close();
        }
    }
}
