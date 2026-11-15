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
    public partial class FormQuanLySach : Form
    {
        private List<CSach> danhsachsach = new List<CSach>();
        public FormQuanLySach()
        {
            InitializeComponent();
            DanhSachMau.NapDanhSachMau(danhsachsach);
            hienthidanhsach(danhsachsach);
        }

        private void hienthidanhsach(List<CSach> danhsachsach)
        {
            dgv_dssach.DataSource = danhsachsach.ToList();
        }
        private bool ktnhapduthongtin()
        {
            if (txt_masach.Text == "" || txt_tensach.Text == "" || txt_matacgia.Text == "" ||
                txt_matheloai.Text == "" || txt_manxb.Text == "" || txt_soluongtong.Text == ""
               )
            {
                return false;
            }
            return true;
        }
        private bool kttontaimasach(string ma)
        {
            foreach (CSach c in this.danhsachsach)
            {
                if (c.Masach == ma)
                {
                    return true;
                }
            }
            return false;
        }
        private CSach timsachtheoma(string ma)
        {
            foreach (CSach c in this.danhsachsach)
            {
                if (c.Masach == ma)
                {
                    return c;
                }
            }
            return null;
        }

        // --------------------------------------------

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
            CSach sachmoi = new CSach();
            sachmoi.Masach = txt_masach.Text;
            sachmoi.Tensach = txt_tensach.Text;
            sachmoi.Matacgia = txt_matacgia.Text;
            sachmoi.MaNXB = txt_manxb.Text;
            sachmoi.Matheloai = txt_matheloai.Text;
            sachmoi.Namxuatban = dtp_nxb.Value.Date;
            sachmoi.Soluong = int.Parse(txt_soluongtong.Text);
            foreach (CSach c in this.danhsachsach)
            {
                if (c.Masach == sachmoi.Masach)
                {
                    MessageBox.Show(
                        "Không thêm được (mã số trùng)",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
            }
            hienthidanhsach(danhsachsach);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_masach.Text == "")
            {
                MessageBox.Show(
                    "Không tìm thấy mã sách này để xóa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (!kttontaimasach(txt_masach.Text))
            {
                MessageBox.Show(
                    "Không xóa được (không tìm thấy mã)",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            CSach s = timsachtheoma(txt_masach.Text);
            if (s == null)
            {
                MessageBox.Show(
                    "Không xóa được (không tìm thấy mã)",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            this.danhsachsach.Remove(s);
            hienthidanhsach(danhsachsach);
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
            CSach sachmoi = new CSach();
            sachmoi.Masach = txt_masach.Text;
            sachmoi.Tensach = txt_tensach.Text;
            sachmoi.Matacgia = txt_matacgia.Text;
            sachmoi.MaNXB = txt_manxb.Text;
            sachmoi.Matheloai = txt_matheloai.Text;
            sachmoi.Namxuatban = dtp_nxb.Value.Date;
            sachmoi.Soluong = int.Parse(txt_soluongtong.Text);
            if (!kttontaimasach(sachmoi.Masach))
            {
                MessageBox.Show(
                    $"Không tìm thấy sách có mã {txt_masach.Text} để sửa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            CSach sachcu = timsachtheoma(sachmoi.Masach);
            if (sachcu == null)
            {
                MessageBox.Show(
                    $"Không tìm thấy sách có mã {txt_masach.Text} để sửa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            sachcu.Tensach = sachmoi.Tensach;
            sachcu.Matacgia = sachmoi.Matacgia;
            sachcu.MaNXB = sachmoi.MaNXB;
            sachcu.Matheloai = sachmoi.Matheloai;
            sachcu.Namxuatban = sachmoi.Namxuatban;
            sachcu.Soluong = sachmoi.Soluong;
            hienthidanhsach(danhsachsach);
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đủ thông tin",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            CSach sach = timsachtheoma(txt_timkiem.Text);
            if (sach == null)
            {
                MessageBox.Show(
                    "Không tìm thấy sách có mã hợp lệ",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                List<CSach> danhsachdaloc = new List<CSach>();
                danhsachdaloc.Add(sach);
                hienthidanhsach(danhsachdaloc);
            }
        }

        private void btn_xemdanhsach_Click(object sender, EventArgs e)
        {
            hienthidanhsach(danhsachsach);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormQuanLySach_Load(object sender, EventArgs e)
        {

        }
    }
}
