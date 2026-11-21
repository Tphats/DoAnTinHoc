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
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.Pnl_Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQLAccount = new System.Windows.Forms.Button();
            this.btnQLThuThu = new System.Windows.Forms.Button();
            this.btnDSDocGia = new System.Windows.Forms.Button();
            this.btnDSSach = new System.Windows.Forms.Button();
            this.btnDSPhieuMuon = new System.Windows.Forms.Button();
            this.btnDSQuaHan = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_TaiKhoan = new System.Windows.Forms.Button();
            this.pnl_Main.SuspendLayout();
            this.Pnl_Sidebar.SuspendLayout();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnl_Main.Controls.Add(this.pnl_Content);
            this.pnl_Main.Controls.Add(this.Pnl_Sidebar);
            this.pnl_Main.Controls.Add(this.pnl_Top);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1135, 590);
            this.pnl_Main.TabIndex = 8;
            // 
            // pnl_Content
            // 
            this.pnl_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Content.Location = new System.Drawing.Point(274, 116);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(792, 446);
            this.pnl_Content.TabIndex = 2;
            // 
            // Pnl_Sidebar
            // 
            this.Pnl_Sidebar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Pnl_Sidebar.Controls.Add(this.btnQLAccount);
            this.Pnl_Sidebar.Controls.Add(this.btnQLThuThu);
            this.Pnl_Sidebar.Controls.Add(this.btnDSDocGia);
            this.Pnl_Sidebar.Controls.Add(this.btnDSSach);
            this.Pnl_Sidebar.Controls.Add(this.btnDSPhieuMuon);
            this.Pnl_Sidebar.Controls.Add(this.btnDSQuaHan);
            this.Pnl_Sidebar.Controls.Add(this.btnSetting);
            this.Pnl_Sidebar.Location = new System.Drawing.Point(3, 90);
            this.Pnl_Sidebar.Name = "Pnl_Sidebar";
            this.Pnl_Sidebar.Size = new System.Drawing.Size(209, 497);
            this.Pnl_Sidebar.TabIndex = 6;
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnl_Top.Controls.Add(this.pictureBox1);
            this.pnl_Top.Controls.Add(this.label3);
            this.pnl_Top.Controls.Add(this.btn_TaiKhoan);
            this.pnl_Top.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_Top.Location = new System.Drawing.Point(3, 3);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(1132, 81);
            this.pnl_Top.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Calibri", 35F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(447, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 58);
            this.label3.TabIndex = 12;
            this.label3.Text = "GIAO DIỆN ADMIN";
            // 
            // btnQLAccount
            // 
            this.btnQLAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnQLAccount.BackColor = System.Drawing.Color.AliceBlue;
            this.btnQLAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQLAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnQLAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnQLAccount.Image")));
            this.btnQLAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLAccount.Location = new System.Drawing.Point(0, 0);
            this.btnQLAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLAccount.Name = "btnQLAccount";
            this.btnQLAccount.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnQLAccount.Size = new System.Drawing.Size(209, 47);
            this.btnQLAccount.TabIndex = 11;
            this.btnQLAccount.Text = "Quản lý tài khoản";
            this.btnQLAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLAccount.UseVisualStyleBackColor = false;
            this.btnQLAccount.Click += new System.EventHandler(this.btnQLAccount_Click);
            // 
            // btnQLThuThu
            // 
            this.btnQLThuThu.BackColor = System.Drawing.Color.AliceBlue;
            this.btnQLThuThu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLThuThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLThuThu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQLThuThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnQLThuThu.Image = ((System.Drawing.Image)(resources.GetObject("btnQLThuThu.Image")));
            this.btnQLThuThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLThuThu.Location = new System.Drawing.Point(0, 47);
            this.btnQLThuThu.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLThuThu.Name = "btnQLThuThu";
            this.btnQLThuThu.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnQLThuThu.Size = new System.Drawing.Size(209, 47);
            this.btnQLThuThu.TabIndex = 8;
            this.btnQLThuThu.Text = "Quản Lý Thủ Thư";
            this.btnQLThuThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLThuThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLThuThu.UseVisualStyleBackColor = false;
            // 
            // btnDSDocGia
            // 
            this.btnDSDocGia.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDSDocGia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDSDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSDocGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDSDocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnDSDocGia.Image = ((System.Drawing.Image)(resources.GetObject("btnDSDocGia.Image")));
            this.btnDSDocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSDocGia.Location = new System.Drawing.Point(0, 94);
            this.btnDSDocGia.Margin = new System.Windows.Forms.Padding(0);
            this.btnDSDocGia.Name = "btnDSDocGia";
            this.btnDSDocGia.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnDSDocGia.Size = new System.Drawing.Size(209, 47);
            this.btnDSDocGia.TabIndex = 3;
            this.btnDSDocGia.Text = "Xem DS Độc Giả";
            this.btnDSDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSDocGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDSDocGia.UseVisualStyleBackColor = false;
            this.btnDSDocGia.Click += new System.EventHandler(this.btnDSDocGia_Click);
            // 
            // btnDSSach
            // 
            this.btnDSSach.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDSSach.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDSSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSSach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDSSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnDSSach.Image = ((System.Drawing.Image)(resources.GetObject("btnDSSach.Image")));
            this.btnDSSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSSach.Location = new System.Drawing.Point(0, 141);
            this.btnDSSach.Margin = new System.Windows.Forms.Padding(0);
            this.btnDSSach.Name = "btnDSSach";
            this.btnDSSach.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnDSSach.Size = new System.Drawing.Size(209, 47);
            this.btnDSSach.TabIndex = 2;
            this.btnDSSach.Text = "Xem DS Sách";
            this.btnDSSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDSSach.UseVisualStyleBackColor = false;
            this.btnDSSach.Click += new System.EventHandler(this.btnDSSach_Click);
            // 
            // btnDSPhieuMuon
            // 
            this.btnDSPhieuMuon.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDSPhieuMuon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDSPhieuMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDSPhieuMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnDSPhieuMuon.Image = ((System.Drawing.Image)(resources.GetObject("btnDSPhieuMuon.Image")));
            this.btnDSPhieuMuon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSPhieuMuon.Location = new System.Drawing.Point(0, 188);
            this.btnDSPhieuMuon.Margin = new System.Windows.Forms.Padding(0);
            this.btnDSPhieuMuon.Name = "btnDSPhieuMuon";
            this.btnDSPhieuMuon.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnDSPhieuMuon.Size = new System.Drawing.Size(209, 47);
            this.btnDSPhieuMuon.TabIndex = 5;
            this.btnDSPhieuMuon.Text = "Xem DS Phiếu Mượn";
            this.btnDSPhieuMuon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSPhieuMuon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDSPhieuMuon.UseVisualStyleBackColor = false;
            // 
            // btnDSQuaHan
            // 
            this.btnDSQuaHan.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDSQuaHan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDSQuaHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSQuaHan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDSQuaHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnDSQuaHan.Image = ((System.Drawing.Image)(resources.GetObject("btnDSQuaHan.Image")));
            this.btnDSQuaHan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSQuaHan.Location = new System.Drawing.Point(0, 235);
            this.btnDSQuaHan.Margin = new System.Windows.Forms.Padding(0);
            this.btnDSQuaHan.Name = "btnDSQuaHan";
            this.btnDSQuaHan.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnDSQuaHan.Size = new System.Drawing.Size(209, 47);
            this.btnDSQuaHan.TabIndex = 10;
            this.btnDSQuaHan.Text = "Xem DS Quá Hạn";
            this.btnDSQuaHan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSQuaHan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDSQuaHan.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 282);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(209, 47);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 84);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_TaiKhoan
            // 
            this.btn_TaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TaiKhoan.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_TaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_TaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_TaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btn_TaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaiKhoan.Image")));
            this.btn_TaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaiKhoan.Location = new System.Drawing.Point(983, 20);
            this.btn_TaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_TaiKhoan.Name = "btn_TaiKhoan";
            this.btn_TaiKhoan.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_TaiKhoan.Size = new System.Drawing.Size(140, 47);
            this.btn_TaiKhoan.TabIndex = 9;
            this.btn_TaiKhoan.Text = "Tài khoản";
            this.btn_TaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TaiKhoan.UseVisualStyleBackColor = false;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 590);
            this.Controls.Add(this.pnl_Main);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.pnl_Main.ResumeLayout(false);
            this.Pnl_Sidebar.ResumeLayout(false);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.FlowLayoutPanel Pnl_Sidebar;
        private System.Windows.Forms.Button btnQLAccount;
        private System.Windows.Forms.Button btnQLThuThu;
        private System.Windows.Forms.Button btnDSDocGia;
        private System.Windows.Forms.Button btnDSSach;
        private System.Windows.Forms.Button btnDSPhieuMuon;
        private System.Windows.Forms.Button btnDSQuaHan;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_TaiKhoan;
    }
}