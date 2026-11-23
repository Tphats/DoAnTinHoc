namespace QuanLyAccount
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btn_TaiKhoan = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnThongTinCaNhan = new System.Windows.Forms.Button();
            this.btnLichSuTra = new System.Windows.Forms.Button();
            this.btnDanhSachMuon = new System.Windows.Forms.Button();
            this.btnDanhSachSach = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Location = new System.Drawing.Point(279, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1234, 726);
            this.panelMain.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContent.Location = new System.Drawing.Point(0, 104);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1234, 622);
            this.panelContent.TabIndex = 2;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panelTop.Controls.Add(this.pictureBox2);
            this.panelTop.Controls.Add(this.lblTieuDe);
            this.panelTop.Controls.Add(this.btn_TaiKhoan);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1234, 100);
            this.panelTop.TabIndex = 3;
            // 
            // btn_TaiKhoan
            // 
            this.btn_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_TaiKhoan.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_TaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_TaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_TaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btn_TaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaiKhoan.Image")));
            this.btn_TaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaiKhoan.Location = new System.Drawing.Point(1036, 22);
            this.btn_TaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_TaiKhoan.Name = "btn_TaiKhoan";
            this.btn_TaiKhoan.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btn_TaiKhoan.Size = new System.Drawing.Size(187, 58);
            this.btn_TaiKhoan.TabIndex = 9;
            this.btn_TaiKhoan.Text = "Tài khoản";
            this.btn_TaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TaiKhoan.UseVisualStyleBackColor = false;
            // 
            // panelSidebar
            // 
            this.panelSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panelSidebar.Controls.Add(this.pictureBox1);
            this.panelSidebar.Controls.Add(this.btnDangXuat);
            this.panelSidebar.Controls.Add(this.btnThongTinCaNhan);
            this.panelSidebar.Controls.Add(this.btnLichSuTra);
            this.panelSidebar.Controls.Add(this.btnDanhSachMuon);
            this.panelSidebar.Controls.Add(this.btnDanhSachSach);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(279, 726);
            this.panelSidebar.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDangXuat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(7, 334);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(245, 58);
            this.btnDangXuat.TabIndex = 13;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.BackColor = System.Drawing.Color.AliceBlue;
            this.btnThongTinCaNhan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThongTinCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinCaNhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThongTinCaNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnThongTinCaNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTinCaNhan.Image")));
            this.btnThongTinCaNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(7, 276);
            this.btnThongTinCaNhan.Margin = new System.Windows.Forms.Padding(0);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(245, 58);
            this.btnThongTinCaNhan.TabIndex = 12;
            this.btnThongTinCaNhan.Text = "Thòng Tin Cá Nhân";
            this.btnThongTinCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinCaNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongTinCaNhan.UseVisualStyleBackColor = false;
            this.btnThongTinCaNhan.Click += new System.EventHandler(this.btnThongTinCaNhan_Click);
            // 
            // btnLichSuTra
            // 
            this.btnLichSuTra.BackColor = System.Drawing.Color.AliceBlue;
            this.btnLichSuTra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLichSuTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSuTra.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLichSuTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnLichSuTra.Image = ((System.Drawing.Image)(resources.GetObject("btnLichSuTra.Image")));
            this.btnLichSuTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSuTra.Location = new System.Drawing.Point(7, 218);
            this.btnLichSuTra.Margin = new System.Windows.Forms.Padding(0);
            this.btnLichSuTra.Name = "btnLichSuTra";
            this.btnLichSuTra.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnLichSuTra.Size = new System.Drawing.Size(245, 58);
            this.btnLichSuTra.TabIndex = 11;
            this.btnLichSuTra.Text = "Lịch Sử Mượn Trả";
            this.btnLichSuTra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSuTra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLichSuTra.UseVisualStyleBackColor = false;
            this.btnLichSuTra.Click += new System.EventHandler(this.btnLichSuTra_Click);
            // 
            // btnDanhSachMuon
            // 
            this.btnDanhSachMuon.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDanhSachMuon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDanhSachMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachMuon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDanhSachMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnDanhSachMuon.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachMuon.Image")));
            this.btnDanhSachMuon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachMuon.Location = new System.Drawing.Point(-3, 160);
            this.btnDanhSachMuon.Margin = new System.Windows.Forms.Padding(0);
            this.btnDanhSachMuon.Name = "btnDanhSachMuon";
            this.btnDanhSachMuon.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnDanhSachMuon.Size = new System.Drawing.Size(245, 58);
            this.btnDanhSachMuon.TabIndex = 10;
            this.btnDanhSachMuon.Text = "Danh Sách Mượn";
            this.btnDanhSachMuon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachMuon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhSachMuon.UseVisualStyleBackColor = false;
            this.btnDanhSachMuon.Click += new System.EventHandler(this.btnDanhSachMuon_Click);
            // 
            // btnDanhSachSach
            // 
            this.btnDanhSachSach.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDanhSachSach.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDanhSachSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachSach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDanhSachSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnDanhSachSach.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachSach.Image")));
            this.btnDanhSachSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachSach.Location = new System.Drawing.Point(0, 102);
            this.btnDanhSachSach.Margin = new System.Windows.Forms.Padding(0);
            this.btnDanhSachSach.Name = "btnDanhSachSach";
            this.btnDanhSachSach.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnDanhSachSach.Size = new System.Drawing.Size(245, 58);
            this.btnDanhSachSach.TabIndex = 9;
            this.btnDanhSachSach.Text = "Danh Sách Sách";
            this.btnDanhSachSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhSachSach.UseVisualStyleBackColor = false;
            this.btnDanhSachSach.Click += new System.EventHandler(this.btnDanhSachSach_Click);
            // 
            // pictureBox1
            // 
      
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 95);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(6, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(173, 23);
            this.lblTieuDe.TabIndex = 10;
            this.lblTieuDe.Text = "GIAO DIÊN ĐỌC GIẢ";
            this.lblTieuDe.Click += new System.EventHandler(this.lblTieuDe_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // FrmUser1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 601);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelMain);
            this.Name = "FrmUser1";
            this.Text = "FrmUser1";
            this.Load += new System.EventHandler(this.FrmUser1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btn_TaiKhoan;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThongTinCaNhan;
        private System.Windows.Forms.Button btnLichSuTra;
        private System.Windows.Forms.Button btnDanhSachMuon;
        private System.Windows.Forms.Button btnDanhSachSach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}