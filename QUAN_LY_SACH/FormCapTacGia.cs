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
        CQuanLyTacGia qltg = new CQuanLyTacGia();

        public FormCapNhatTacGia()
        {
            InitializeComponent();
            hienthidanhsach(qltg.Danhsachtacgia);
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

            if (qltg.Them(tgmoi))
            {
                hienthidanhsach(qltg.Danhsachtacgia);
            }
            else
            {
                MessageBox.Show(
                    "Không thêm được (mã tác giả bị trùng)",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
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

            if (qltg.Xoa(txt_matacgia.Text))
            {
                hienthidanhsach(qltg.Danhsachtacgia);
            }
            else
            {
                MessageBox.Show(
                    "Không xóa được (không tìm thấy mã)",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
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

            if (qltg.Sua(tgmoi))
            {
                hienthidanhsach(qltg.Danhsachtacgia);
            }
            else
            {
                MessageBox.Show(
                    $"Không tìm thấy tác giả có mã {txt_matacgia.Text} để sửa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    internal class CQuanLyTacGia
    {
        List<CTacGia> danhsachtacgia;
        public CQuanLyTacGia()
        {
            danhsachtacgia = new List<CTacGia>();
        }
        public CQuanLyTacGia(List<CTacGia> danhsachtacgia)
        {
            this.danhsachtacgia = danhsachtacgia;
        }
        public List<CTacGia> Danhsachtacgia
        {
            get { return this.danhsachtacgia; }
            set { this.danhsachtacgia = value; }
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
        public CTacGia timtacgiatheoma(string ma)
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
        public bool Them(CTacGia tg)
        {
            if (kttratontaimatacgia(tg.Matacgia))
            {
                return false;
            }
            this.danhsachtacgia.Add(tg);
            return true;
        }
        public bool Xoa(string ma)
        {
            if (!kttratontaimatacgia(ma))
            {
                return false;
            }
            CTacGia tg = timtacgiatheoma(ma);
            if (tg == null)
            {
                return false;
            }
            this.danhsachtacgia.Remove(tg);
            return true;
        }
        public bool Sua(CTacGia tgMoi)
        {
            CTacGia tgCu = timtacgiatheoma(tgMoi.Matacgia);
            if (tgCu == null)
            {
                return false;
            }
            tgCu.Tentacgia = tgMoi.Tentacgia;
            return true;
        }
    }
    
}
