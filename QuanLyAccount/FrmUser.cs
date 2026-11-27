using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyAccount
{
    public partial class FrmUser : Form
    {
        private Panel panelMain;
        private FlowLayoutPanel panelContent;
        private Panel panelSideBar;
        private Panel panelTop;
        private Label lblThuVien;
        private PictureBox picLOGO;
        private DateTimePicker dtpTime;
        private Label lblSlogan;
        private Button btnDanhSachSach;
        private PictureBox pictureBox1;
        private DateTimePicker dtpTime2;
        private Button btnThoat;
        private Button btnThongTinCaNhan;
        private Button btnLichSuMuonTra;
        private Button btnDanhSachMuon;
        private string m_madocgia = "DG01";
        public string MaDocGia
        {
            get { return m_madocgia; }
            set { m_madocgia = value; }
        }
        public FrmUser()
        {
            InitializeComponent();
            this.Load += FrmUser1_Load;

            btnDanhSachSach.Click += btnDanhSachSach_Click;
            btnDanhSachMuon.Click += btnDanhSachMuon_Click;
            btnLichSuMuonTra.Click += btnLichSuMuonTra_Click;
            btnThongTinCaNhan.Click += btnThongTinCaNhan_Click;
            btnDangXuat.Click += btnDangXuat_Click;
        }
         
        private void loadUC(UserControl uc)
        {
            panelContent.Controls.Clear();     
            uc.Dock = DockStyle.Fill;          
            panelContent.Controls.Add(uc);     
        }
        private void chonMenu(Button nutDuocChon)
        {
            Button[] dsNut = new Button[] { btnDanhSachSach, btnDanhSachMuon, btnThongTinCaNhan, btnLichSuMuonTra };
            foreach (Button nut in dsNut)                          
            {
                nut.BackColor = Color.FromArgb(232, 241, 252);     
                nut.ForeColor = Color.FromArgb(30, 115, 190);
            }
            nutDuocChon.BackColor = Color.FromArgb(176, 208, 245); 
            nutDuocChon.ForeColor = Color.FromArgb(30, 115, 190);  
        }
        private void FrmUser1_Load(object sender, EventArgs e)
        {
            lblXinChao.Text = "Xin chào, " + MaDocGia;
            btnDanhSachSach_Click(this, EventArgs.Empty);
        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhSachSach_Click(object sender, EventArgs e)
        {
            chonMenu(btnDanhSachSach);

            ucDanhSachSach uc = new ucDanhSachSach();

            loadUC(uc);
        }

        private void btnDanhSachMuon_Click(object sender, EventArgs e)
        {
            chonMenu(btnDanhSachMuon);

            ucDanhSachMuon uc = new ucDanhSachMuon();

            uc.MaDocGia = MaDocGia;

            loadUC(uc);
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            chonMenu(btnThongTinCaNhan);

            ucThongTinCaNhan uc = new ucThongTinCaNhan();

            uc.MaDocGia = MaDocGia;

            loadUC(uc);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnLichSuMuonTra_Click(object sender, EventArgs e)
        {
            chonMenu(btnLichSuMuonTra);

            ucLichSuMuonTra uc = new ucLichSuMuonTra();

            uc.MaDocGia = MaDocGia;

            loadUC(uc);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.picLOGO = new System.Windows.Forms.PictureBox();
            this.lblThuVien = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpTime2 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDanhSachSach = new System.Windows.Forms.Button();
            this.btnDanhSachMuon = new System.Windows.Forms.Button();
            this.btnLichSuMuonTra = new System.Windows.Forms.Button();
            this.btnThongTinCaNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelSideBar);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Location = new System.Drawing.Point(5, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1129, 580);
            this.panelMain.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(324, 119);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(792, 446);
            this.panelContent.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.dtpTime2);
            this.panelTop.Controls.Add(this.dtpTime);
            this.panelTop.Controls.Add(this.lblSlogan);
            this.panelTop.Controls.Add(this.lblThuVien);
            this.panelTop.Controls.Add(this.picLOGO);
            this.panelTop.Location = new System.Drawing.Point(5, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1111, 117);
            this.panelTop.TabIndex = 1;
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSideBar.Controls.Add(this.btnThoat);
            this.panelSideBar.Controls.Add(this.btnThongTinCaNhan);
            this.panelSideBar.Controls.Add(this.btnLichSuMuonTra);
            this.panelSideBar.Controls.Add(this.btnDanhSachMuon);
            this.panelSideBar.Controls.Add(this.btnDanhSachSach);
            this.panelSideBar.Controls.Add(this.pictureBox1);
            this.panelSideBar.Location = new System.Drawing.Point(3, 119);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(322, 446);
            this.panelSideBar.TabIndex = 2;
            // 
            // picLOGO
            // 
            this.picLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picLOGO.Image")));
            this.picLOGO.Location = new System.Drawing.Point(3, 0);
            this.picLOGO.Name = "picLOGO";
            this.picLOGO.Size = new System.Drawing.Size(154, 108);
            this.picLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLOGO.TabIndex = 0;
            this.picLOGO.TabStop = false;
            // 
            // lblThuVien
            // 
            this.lblThuVien.AutoSize = true;
            this.lblThuVien.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuVien.ForeColor = System.Drawing.Color.White;
            this.lblThuVien.Location = new System.Drawing.Point(168, 0);
            this.lblThuVien.Name = "lblThuVien";
            this.lblThuVien.Size = new System.Drawing.Size(340, 60);
            this.lblThuVien.TabIndex = 1;
            this.lblThuVien.Text = "THƯ VIỆN STU";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.Location = new System.Drawing.Point(172, 60);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(495, 31);
            this.lblSlogan.TabIndex = 2;
            this.lblSlogan.Text = "Tri Thức Hôm Nay - Thành Công Ngày Mai";
            // 
            // dtpTime
            // 
            this.dtpTime.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpTime.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(792, 3);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(316, 34);
            this.dtpTime.TabIndex = 3;
            // 
            // dtpTime2
            // 
            this.dtpTime2.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpTime2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTime2.Location = new System.Drawing.Point(792, 43);
            this.dtpTime2.Name = "dtpTime2";
            this.dtpTime2.Size = new System.Drawing.Size(316, 34);
            this.dtpTime2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDanhSachSach
            // 
            this.btnDanhSachSach.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDanhSachSach.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachSach.ForeColor = System.Drawing.Color.Black;
            this.btnDanhSachSach.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachSach.Image")));
            this.btnDanhSachSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachSach.Location = new System.Drawing.Point(5, 83);
            this.btnDanhSachSach.Name = "btnDanhSachSach";
            this.btnDanhSachSach.Size = new System.Drawing.Size(313, 59);
            this.btnDanhSachSach.TabIndex = 1;
            this.btnDanhSachSach.Text = "Danh Sách Sách";
            this.btnDanhSachSach.UseVisualStyleBackColor = false;
            // 
            // btnDanhSachMuon
            // 
            this.btnDanhSachMuon.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDanhSachMuon.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachMuon.ForeColor = System.Drawing.Color.Black;
            this.btnDanhSachMuon.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachMuon.Image")));
            this.btnDanhSachMuon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachMuon.Location = new System.Drawing.Point(5, 148);
            this.btnDanhSachMuon.Name = "btnDanhSachMuon";
            this.btnDanhSachMuon.Size = new System.Drawing.Size(313, 59);
            this.btnDanhSachMuon.TabIndex = 2;
            this.btnDanhSachMuon.Text = "Danh Sách Mượn";
            this.btnDanhSachMuon.UseVisualStyleBackColor = false;
            // 
            // btnLichSuMuonTra
            // 
            this.btnLichSuMuonTra.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLichSuMuonTra.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSuMuonTra.ForeColor = System.Drawing.Color.Black;
            this.btnLichSuMuonTra.Image = ((System.Drawing.Image)(resources.GetObject("btnLichSuMuonTra.Image")));
            this.btnLichSuMuonTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSuMuonTra.Location = new System.Drawing.Point(6, 213);
            this.btnLichSuMuonTra.Name = "btnLichSuMuonTra";
            this.btnLichSuMuonTra.Size = new System.Drawing.Size(313, 59);
            this.btnLichSuMuonTra.TabIndex = 3;
            this.btnLichSuMuonTra.Text = "Lịch Sử Mượn Trả";
            this.btnLichSuMuonTra.UseVisualStyleBackColor = false;
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnThongTinCaNhan.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinCaNhan.ForeColor = System.Drawing.Color.Black;
            this.btnThongTinCaNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTinCaNhan.Image")));
            this.btnThongTinCaNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(6, 278);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(313, 59);
            this.btnThongTinCaNhan.TabIndex = 4;
            this.btnThongTinCaNhan.Text = "Thông Tin Cá Nhân";
            this.btnThongTinCaNhan.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(4, 374);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(313, 59);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Đăng Xuất";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // FrmUser
            // 
            this.ClientSize = new System.Drawing.Size(1133, 582);
            this.Controls.Add(this.panelMain);
            this.Name = "FrmUser";
            this.panelMain.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLOGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
