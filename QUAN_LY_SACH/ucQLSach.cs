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
        CQuanLySach qlsach = new CQuanLySach();
        public ucQLSach()
        {
            InitializeComponent();
            DanhSachMau.NapDanhSachMau(qlsach.Danhsachsach);
            hienthidanhsach(qlsach.Danhsachsach);
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
            if (qlsach.Them(sachmoi))
            {
                hienthidanhsach(qlsach.Danhsachsach);
            }
            else
            {
                MessageBox.Show(
                    "Không thêm được (mã số trùng)",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
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
            if (qlsach.Xoa(txt_masach.Text))
            {
                hienthidanhsach(qlsach.Danhsachsach);
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
            CSach sachmoi = new CSach();
            sachmoi.Masach = txt_masach.Text;
            sachmoi.Tensach = txt_tensach.Text;
            sachmoi.Matacgia = txt_matacgia.Text;
            sachmoi.MaNXB = txt_manxb.Text;
            sachmoi.Matheloai = txt_matheloai.Text;
            sachmoi.Namxuatban = dtp_nxb.Value.Date;
            sachmoi.Soluong = int.Parse(txt_soluongtong.Text);
            if (qlsach.Sua(sachmoi))
            {
                hienthidanhsach(qlsach.Danhsachsach);
            }
            else
            {
                MessageBox.Show(
                    $"Không tìm thấy sách có mã {txt_masach.Text} để sửa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
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
            CSach sach = qlsach.timsachtheoma(txt_timkiem.Text);
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
            hienthidanhsach(qlsach.Danhsachsach);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.ParentForm?.Close();
        }

        private void ucQLSach_Load(object sender, EventArgs e)
        {

        }
    }
}
