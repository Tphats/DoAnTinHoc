namespace QuanLyAccount
{
    partial class FrmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.Pnl_Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTongQuan = new System.Windows.Forms.Button();
            this.btnQLAccount = new System.Windows.Forms.Button();
            this.btnQLSach = new System.Windows.Forms.Button();
            this.btnQLDocGia = new System.Windows.Forms.Button();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.btnQLPhieuMuon = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnQLSetting = new System.Windows.Forms.Button();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.btn_TaiKhoan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pnl_Sidebar.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Sidebar
            // 
            this.Pnl_Sidebar.Controls.Add(this.pictureBox1);
            this.Pnl_Sidebar.Controls.Add(this.btnTongQuan);
            this.Pnl_Sidebar.Controls.Add(this.btnQLAccount);
            this.Pnl_Sidebar.Controls.Add(this.btnQLSach);
            this.Pnl_Sidebar.Controls.Add(this.btnQLDocGia);
            this.Pnl_Sidebar.Controls.Add(this.btnQLNhanVien);
            this.Pnl_Sidebar.Controls.Add(this.btnQLPhieuMuon);
            this.Pnl_Sidebar.Controls.Add(this.btnThongKe);
            this.Pnl_Sidebar.Controls.Add(this.btnQLSetting);
            this.Pnl_Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Sidebar.Name = "Pnl_Sidebar";
            this.Pnl_Sidebar.Size = new System.Drawing.Size(209, 590);
            this.Pnl_Sidebar.TabIndex = 4;
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.BackColor = System.Drawing.Color.AliceBlue;
            this.btnTongQuan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTongQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnTongQuan.Image = global::QuanLyAccount.Properties.Resources.tong_quan;
            this.btnTongQuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongQuan.Location = new System.Drawing.Point(0, 84);
            this.btnTongQuan.Margin = new System.Windows.Forms.Padding(0);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnTongQuan.Size = new System.Drawing.Size(198, 47);
            this.btnTongQuan.TabIndex = 0;
            this.btnTongQuan.Text = "Tổng quan";
            this.btnTongQuan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTongQuan.UseVisualStyleBackColor = false;
            // 
            // btnQLAccount
            // 
            this.btnQLAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnQLAccount.BackColor = System.Drawing.Color.AliceBlue;
            this.btnQLAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnQLAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnQLAccount.Image")));
            this.btnQLAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLAccount.Location = new System.Drawing.Point(0, 131);
            this.btnQLAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLAccount.Name = "btnQLAccount";
            this.btnQLAccount.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnQLAccount.Size = new System.Drawing.Size(198, 47);
            this.btnQLAccount.TabIndex = 1;
            this.btnQLAccount.Text = "Quản lý tài khoản";
            this.btnQLAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLAccount.UseVisualStyleBackColor = false;
            this.btnQLAccount.Click += new System.EventHandler(this.btnQLAccount_Click);
            // 
            // btnQLSach
            // 
            this.btnQLSach.BackColor = System.Drawing.Color.AliceBlue;
            this.btnQLSach.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnQLSach.Image = global::QuanLyAccount.Properties.Resources.sach;
            this.btnQLSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSach.Location = new System.Drawing.Point(0, 178);
            this.btnQLSach.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLSach.Name = "btnQLSach";
            this.btnQLSach.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnQLSach.Size = new System.Drawing.Size(198, 47);
            this.btnQLSach.TabIndex = 2;
            this.btnQLSach.Text = "Quản lý Sách";
            this.btnQLSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLSach.UseVisualStyleBackColor = false;
            // 
            // btnQLDocGia
            // 
            this.btnQLDocGia.BackColor = System.Drawing.Color.AliceBlue;
            this.btnQLDocGia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnQLDocGia.Image = global::QuanLyAccount.Properties.Resources.user;
            this.btnQLDocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDocGia.Location = new System.Drawing.Point(0, 225);
            this.btnQLDocGia.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLDocGia.Name = "btnQLDocGia";
            this.btnQLDocGia.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnQLDocGia.Size = new System.Drawing.Size(198, 47);
            this.btnQLDocGia.TabIndex = 3;
            this.btnQLDocGia.Text = "Quản lý Độc giả";
            this.btnQLDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDocGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLDocGia.UseVisualStyleBackColor = false;
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.BackColor = System.Drawing.Color.AliceBlue;
            this.btnQLNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnQLNhanVien.Image = global::QuanLyAccount.Properties.Resources.nhanvien;
            this.btnQLNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanVien.Location = new System.Drawing.Point(0, 272);
            this.btnQLNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnQLNhanVien.Size = new System.Drawing.Size(198, 47);
            this.btnQLNhanVien.TabIndex = 4;
            this.btnQLNhanVien.Text = "Quản lý Nhân viên";
            this.btnQLNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNhanVien.UseVisualStyleBackColor = false;
            // 
            // btnQLPhieuMuon
            // 
            this.btnQLPhieuMuon.BackColor = System.Drawing.Color.AliceBlue;
            this.btnQLPhieuMuon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLPhieuMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLPhieuMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnQLPhieuMuon.Image = global::QuanLyAccount.Properties.Resources.muon_tra;
            this.btnQLPhieuMuon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPhieuMuon.Location = new System.Drawing.Point(0, 319);
            this.btnQLPhieuMuon.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLPhieuMuon.Name = "btnQLPhieuMuon";
            this.btnQLPhieuMuon.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnQLPhieuMuon.Size = new System.Drawing.Size(198, 47);
            this.btnQLPhieuMuon.TabIndex = 5;
            this.btnQLPhieuMuon.Text = "Quản lý Phiếu mượn";
            this.btnQLPhieuMuon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPhieuMuon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLPhieuMuon.UseVisualStyleBackColor = false;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.AliceBlue;
            this.btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnThongKe.Image = global::QuanLyAccount.Properties.Resources.thong_ke;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 366);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(0);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(198, 47);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = false;
            // 
            // btnQLSetting
            // 
            this.btnQLSetting.BackColor = System.Drawing.Color.AliceBlue;
            this.btnQLSetting.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnQLSetting.Image = global::QuanLyAccount.Properties.Resources.setting;
            this.btnQLSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSetting.Location = new System.Drawing.Point(0, 413);
            this.btnQLSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLSetting.Name = "btnQLSetting";
            this.btnQLSetting.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnQLSetting.Size = new System.Drawing.Size(198, 47);
            this.btnQLSetting.TabIndex = 7;
            this.btnQLSetting.Text = "Cài đặt";
            this.btnQLSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLSetting.UseVisualStyleBackColor = false;
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.pnl_Content);
            this.pnl_Main.Controls.Add(this.pnl_Top);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(209, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(926, 590);
            this.pnl_Main.TabIndex = 5;
            // 
            // pnl_Content
            // 
            this.pnl_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Content.Location = new System.Drawing.Point(72, 116);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(792, 446);
            this.pnl_Content.TabIndex = 1;
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.label3);
            this.pnl_Top.Controls.Add(this.btn_TaiKhoan);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(926, 81);
            this.pnl_Top.TabIndex = 0;
            // 
            // btn_TaiKhoan
            // 
            this.btn_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_TaiKhoan.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_TaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_TaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btn_TaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaiKhoan.Image")));
            this.btn_TaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaiKhoan.Location = new System.Drawing.Point(724, 20);
            this.btn_TaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_TaiKhoan.Name = "btn_TaiKhoan";
            this.btn_TaiKhoan.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_TaiKhoan.Size = new System.Drawing.Size(140, 47);
            this.btn_TaiKhoan.TabIndex = 8;
            this.btn_TaiKhoan.Text = "Tài khoản";
            this.btn_TaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TaiKhoan.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyAccount.Properties.Resources.logo_thuvien__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 78);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 35F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(72, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(546, 58);
            this.label3.TabIndex = 11;
            this.label3.Text = "GIAO DIỆN QUẢN TRỊ VIÊN";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1135, 590);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.Pnl_Sidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1151, 629);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Pnl_Sidebar.ResumeLayout(false);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Pnl_Sidebar;
        private System.Windows.Forms.Button btnTongQuan;
        private System.Windows.Forms.Button btnQLAccount;
        private System.Windows.Forms.Button btnQLSach;
        private System.Windows.Forms.Button btnQLDocGia;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.Button btnQLPhieuMuon;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnQLSetting;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Button btn_TaiKhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}