namespace QuanLyAccount
{
    partial class FrmNhanVien
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
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.Pnl_Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCreatUser = new System.Windows.Forms.Button();
            this.btnQLSach = new System.Windows.Forms.Button();
            this.btnQLDocGia = new System.Windows.Forms.Button();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.btnQLPhieuMuon = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnQLSetting = new System.Windows.Forms.Button();
            this.pnl_Main.SuspendLayout();
            this.Pnl_Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.pnl_Content);
            this.pnl_Main.Controls.Add(this.pnl_Top);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(209, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(926, 590);
            this.pnl_Main.TabIndex = 7;
            // 
            // pnl_Content
            // 
            this.pnl_Content.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Content.Location = new System.Drawing.Point(0, 85);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(926, 505);
            this.pnl_Content.TabIndex = 1;
            // 
            // pnl_Top
            // 
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(926, 81);
            this.pnl_Top.TabIndex = 0;
            // 
            // Pnl_Sidebar
            // 
            this.Pnl_Sidebar.Controls.Add(this.pictureBox1);
            this.Pnl_Sidebar.Controls.Add(this.btnCreatUser);
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
            this.Pnl_Sidebar.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyAccount.Properties.Resources.logo_thuvien__1_;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 77);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCreatUser
            // 
            this.btnCreatUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreatUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnCreatUser.Image = global::QuanLyAccount.Properties.Resources.tao_tai_khoan_doc_gia_32x32;
            this.btnCreatUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreatUser.Location = new System.Drawing.Point(0, 85);
            this.btnCreatUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreatUser.Name = "btnCreatUser";
            this.btnCreatUser.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnCreatUser.Size = new System.Drawing.Size(198, 47);
            this.btnCreatUser.TabIndex = 8;
            this.btnCreatUser.Text = "Tạo hồ sơ Độc giả";
            this.btnCreatUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreatUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreatUser.UseVisualStyleBackColor = true;
            this.btnCreatUser.Click += new System.EventHandler(this.btnCreatUser_Click);
            // 
            // btnQLSach
            // 
            this.btnQLSach.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnQLSach.Image = global::QuanLyAccount.Properties.Resources.sach;
            this.btnQLSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSach.Location = new System.Drawing.Point(0, 132);
            this.btnQLSach.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLSach.Name = "btnQLSach";
            this.btnQLSach.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnQLSach.Size = new System.Drawing.Size(198, 47);
            this.btnQLSach.TabIndex = 2;
            this.btnQLSach.Text = "Quản lý Sách";
            this.btnQLSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLSach.UseVisualStyleBackColor = true;
            // 
            // btnQLDocGia
            // 
            this.btnQLDocGia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnQLDocGia.Image = global::QuanLyAccount.Properties.Resources.account;
            this.btnQLDocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDocGia.Location = new System.Drawing.Point(0, 179);
            this.btnQLDocGia.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLDocGia.Name = "btnQLDocGia";
            this.btnQLDocGia.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnQLDocGia.Size = new System.Drawing.Size(198, 47);
            this.btnQLDocGia.TabIndex = 3;
            this.btnQLDocGia.Text = "Quản lý Độc giả";
            this.btnQLDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDocGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLDocGia.UseVisualStyleBackColor = true;
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnQLNhanVien.Image = global::QuanLyAccount.Properties.Resources.phieu_phat;
            this.btnQLNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanVien.Location = new System.Drawing.Point(0, 226);
            this.btnQLNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnQLNhanVien.Size = new System.Drawing.Size(198, 47);
            this.btnQLNhanVien.TabIndex = 4;
            this.btnQLNhanVien.Text = "Quản lý Nhân viên";
            this.btnQLNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnQLPhieuMuon
            // 
            this.btnQLPhieuMuon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLPhieuMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLPhieuMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnQLPhieuMuon.Image = global::QuanLyAccount.Properties.Resources.tong_quan;
            this.btnQLPhieuMuon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPhieuMuon.Location = new System.Drawing.Point(0, 273);
            this.btnQLPhieuMuon.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLPhieuMuon.Name = "btnQLPhieuMuon";
            this.btnQLPhieuMuon.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnQLPhieuMuon.Size = new System.Drawing.Size(198, 47);
            this.btnQLPhieuMuon.TabIndex = 5;
            this.btnQLPhieuMuon.Text = "Quản lý Phiếu mượn";
            this.btnQLPhieuMuon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPhieuMuon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnThongKe.Image = global::QuanLyAccount.Properties.Resources.thong_ke;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 320);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(0);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(198, 47);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnQLSetting
            // 
            this.btnQLSetting.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnQLSetting.Image = global::QuanLyAccount.Properties.Resources.nhan_vien;
            this.btnQLSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSetting.Location = new System.Drawing.Point(0, 367);
            this.btnQLSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLSetting.Name = "btnQLSetting";
            this.btnQLSetting.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnQLSetting.Size = new System.Drawing.Size(198, 47);
            this.btnQLSetting.TabIndex = 7;
            this.btnQLSetting.Text = "Cài đặt";
            this.btnQLSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLSetting.UseVisualStyleBackColor = true;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 590);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.Pnl_Sidebar);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.pnl_Main.ResumeLayout(false);
            this.Pnl_Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.FlowLayoutPanel Pnl_Sidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQLSach;
        private System.Windows.Forms.Button btnQLDocGia;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.Button btnQLPhieuMuon;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnQLSetting;
        private System.Windows.Forms.Button btnCreatUser;
    }
}