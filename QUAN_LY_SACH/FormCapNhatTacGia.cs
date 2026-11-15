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
    public partial class FormCapNhatTacGia : Form
    {
        List<CTacGia> danhsachtacgia = new List<CTacGia>();
        public FormCapNhatTacGia()
        {
            InitializeComponent();
            hienthidanhsach(danhsachtacgia);
        }

        private void hienthidanhsach(List<CTacGia> danhsachtacgia)
        {
            dgv_dstacgia.DataSource = danhsachtacgia.ToList();
        }
        private bool ktnhapduthongtin()
        {
            if (txt_matacgia.Text == "" || txt_tentacgia.Text == "")
            {
                return false;
            }
            return true;
        }
        private bool kttratontaimatacgia(string ma)
        {
            foreach (CTacGia tg in this.danhsachtacgia)
            {
                if (tg.Matacgia == ma)
                {
                    return true;
                }
            }
            return false;
        }
        private CTacGia timtacgiatheoma(string ma)
        {
            foreach (CTacGia tg in this.danhsachtacgia)
            {
                if (tg.Matacgia == ma)
                {
                    return tg;
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
            CTacGia tgmoi = new CTacGia();
            tgmoi.Matacgia = txt_matacgia.Text;
            tgmoi.Tentacgia = txt_tentacgia.Text;
            if (kttratontaimatacgia(tgmoi.Matacgia))
            {
                MessageBox.Show(
                    "Không thêm được (mã tác giả bị trùng)",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            this.danhsachtacgia.Add(tgmoi);
            hienthidanhsach(danhsachtacgia);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_matacgia.Text == "")
            {
                MessageBox.Show(
                    "Không tìm thấy mã tác giả này để xóa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (!kttratontaimatacgia(txt_matacgia.Text))
            {
                MessageBox.Show(
                    "Không xóa được (không tìm thấy mã)",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            CTacGia tg = timtacgiatheoma(txt_matacgia.Text);
            if (tg == null)
            {
                MessageBox.Show(
                    "Không xóa được (không tìm thấy mã)",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            this.danhsachtacgia.Remove(tg);
            hienthidanhsach(danhsachtacgia);
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
            CTacGia tgmoi = new CTacGia();
            tgmoi.Matacgia = txt_matacgia.Text;
            tgmoi.Tentacgia = txt_tentacgia.Text;
            CTacGia tgCu = timtacgiatheoma(tgmoi.Matacgia);
            if (tgCu == null)
            {
                MessageBox.Show(
                    $"Không tìm thấy tác giả có mã {txt_matacgia.Text} để sửa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            tgCu.Tentacgia = tgmoi.Tentacgia;
            hienthidanhsach(danhsachtacgia);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
