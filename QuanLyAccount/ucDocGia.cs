using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyAccount.cDocGia;

namespace QuanLyAccount
{
    public partial class ucDocGia : UserControl
    {
        private CXuLyDocGia xl;

        public ucDocGia()
        {
            InitializeComponent();
        }
        private void hienDSDocGia(List<CDocGia> ds)
        {
            dgvDocGia.DataSource = ds;
        }
        private void lamMoi()
        {
            txtMaDG.Clear();                                
            txtHoTen.Clear();
            dtpNgaySinh.Value = new DateTime(2000, 1, 1);   
            radNam.Checked = true;                         
            txtDiaChi.Clear();
            txtSoDT.Clear();
            txtEmail.Clear();
            txtMaDG.ReadOnly = false;                       
            txtMaDG.Focus();                              
        }
        private CDocGia layDuLieuTuForm()
        {
            CDocGia d = new CDocGia();
            d.MaDG = txtMaDG.Text.Trim().ToUpper();   
            d.HoTen = txtHoTen.Text.Trim();
            d.NgaySinh = dtpNgaySinh.Value.Date;      
            d.Phai = radNam.Checked;                 
            d.DiaChi = txtDiaChi.Text.Trim();
            d.SoDT = txtSoDT.Text.Trim();
            d.Email = txtEmail.Text.Trim();
            return d;
        }
        private bool laSoDienThoai(string s)
        {
            if (s.Length != 10)             
                return false;
            if (s[0] != '0')               
                return false;
            foreach (char c in s)          
            {
                if (!char.IsDigit(c))      
                    return false;
            }
            return true;                    
        }
        private bool laEmail(string s)
        {
            int at = s.IndexOf('@');       
            if (at <= 0)
                return false;
            if (s.IndexOf('.', at) <= at + 1)  
                return false;
            if (s.Contains(" ") || s.EndsWith("."))
                return false;
            return true;
        }
        private bool kiemTraDuLieu()
        {
            if (txtMaDG.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã độc giả!");
                txtMaDG.Focus();
                return false;
            }
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return false;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!");
                txtDiaChi.Focus();
                return false;
            }
            if (!laSoDienThoai(txtSoDT.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số và bắt đầu bằng số 0!");
                txtSoDT.Focus();
                return false;
            }
            if (!laEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email không hợp lệ! Ví dụ: abc@gmail.com");
                txtEmail.Focus();
                return false;
            }
            return true;
        }
        private void luuFile()
        {
            try
            {
                xl.ghiFile();
            }
            catch (Exception ex)    
            {
                MessageBox.Show("Lỗi khi lưu file: " + ex.Message);
            }
        }

        private void ucDocGia_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            xl = new CXuLyDocGia();                 
            xl.docFile();                           
            dtpNgaySinh.MaxDate = DateTime.Today;    
            dgvDocGia.AutoGenerateColumns = false;   
            hienDSDocGia(xl.layDSDocGia());          
            lamMoi();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!kiemTraDuLieu())                   
                return;
            CDocGia d = layDuLieuTuForm();          
            if (xl.them(d))                          
            {
                luuFile();
                hienDSDocGia(xl.layDSDocGia());     
                lamMoi();
                MessageBox.Show("Thêm độc giả thành công!");
            }
            else
                MessageBox.Show("Mã độc giả " + d.MaDG + " đã tồn tại. Không thêm được.");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaDG.Text.Trim().ToUpper();
            if (ma == "")
            {
                MessageBox.Show("Hãy chọn độc giả cần xóa trong bảng!");
                return;
            }
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả " + ma + "?",
                                              "Xác nhận xóa",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                if (xl.xoa(ma))
                {
                    luuFile();
                    hienDSDocGia(xl.layDSDocGia());
                    lamMoi();
                }
                else
                    MessageBox.Show("Không tìm thấy độc giả cần xóa.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDG.Text.Trim() == "")
            {
                MessageBox.Show("Hãy chọn độc giả cần sửa trong bảng!");
                return;
            }
            if (!kiemTraDuLieu())
                return;

            CDocGia d = layDuLieuTuForm();
            if (xl.sua(d))
            {
                luuFile();
                hienDSDocGia(xl.layDSDocGia());
                lamMoi();
                MessageBox.Show("Cập nhật thành công!");
            }
            else
                MessageBox.Show("Không tìm thấy độc giả cần sửa.");
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        //private void btnTimKiem_Click(object sender, EventArgs e)
        //{
        //    hienDSDocGia(xl.timKiem(txt));
        //}

        private void dgvDocGia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtMaDG.Text = dgvDocGia.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDocGia.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpNgaySinh.Value = (DateTime)dgvDocGia.Rows[e.RowIndex].Cells[2].Value;
            if (dgvDocGia.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam")
                radNam.Checked = true;
            else
                radNu.Checked = true;

            txtDiaChi.Text = dgvDocGia.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSoDT.Text = dgvDocGia.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmail.Text = dgvDocGia.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtMaDG.ReadOnly = true;
        }
        //private void loadUC(UserControl uc)
        //{
        //    panelContent.Controls.Clear();    
        //    uc.Dock = DockStyle.Fill;         
        //    panelContent.Controls.Add(uc);   
        //}
        //private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        //{
        //    loadUC(new ucDocGia());           
        //}
    }
}

