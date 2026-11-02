namespace QuanLyUser
{
    partial class FrmQLUser
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
            this.groupBoxLoaiTK = new System.Windows.Forms.GroupBox();
            this.rBtnUser = new System.Windows.Forms.RadioButton();
            this.rBtnAdmin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaUser = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.dtNgayTaoTK = new System.Windows.Forms.DateTimePicker();
            this.dgvDsUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.groupBoxLoaiTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsUser)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLoaiTK
            // 
            this.groupBoxLoaiTK.Controls.Add(this.rBtnUser);
            this.groupBoxLoaiTK.Controls.Add(this.rBtnAdmin);
            this.groupBoxLoaiTK.Location = new System.Drawing.Point(30, 30);
            this.groupBoxLoaiTK.Name = "groupBoxLoaiTK";
            this.groupBoxLoaiTK.Size = new System.Drawing.Size(103, 84);
            this.groupBoxLoaiTK.TabIndex = 1;
            this.groupBoxLoaiTK.TabStop = false;
            this.groupBoxLoaiTK.Text = "Loại Tài khoản";
            // 
            // rBtnUser
            // 
            this.rBtnUser.AutoSize = true;
            this.rBtnUser.Location = new System.Drawing.Point(6, 42);
            this.rBtnUser.Name = "rBtnUser";
            this.rBtnUser.Size = new System.Drawing.Size(80, 17);
            this.rBtnUser.TabIndex = 1;
            this.rBtnUser.TabStop = true;
            this.rBtnUser.Text = "Người dùng";
            this.rBtnUser.UseVisualStyleBackColor = true;
            // 
            // rBtnAdmin
            // 
            this.rBtnAdmin.AutoSize = true;
            this.rBtnAdmin.Location = new System.Drawing.Point(6, 19);
            this.rBtnAdmin.Name = "rBtnAdmin";
            this.rBtnAdmin.Size = new System.Drawing.Size(85, 17);
            this.rBtnAdmin.TabIndex = 0;
            this.rBtnAdmin.TabStop = true;
            this.rBtnAdmin.Text = "Quản trị viên";
            this.rBtnAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày tạo Tài khoản";
            // 
            // txtMaUser
            // 
            this.txtMaUser.Location = new System.Drawing.Point(269, 27);
            this.txtMaUser.Name = "txtMaUser";
            this.txtMaUser.Size = new System.Drawing.Size(509, 20);
            this.txtMaUser.TabIndex = 6;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(269, 56);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(509, 20);
            this.txtTenDangNhap.TabIndex = 7;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(269, 86);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(509, 20);
            this.txtMatKhau.TabIndex = 8;
            // 
            // dtNgayTaoTK
            // 
            this.dtNgayTaoTK.Location = new System.Drawing.Point(269, 119);
            this.dtNgayTaoTK.Name = "dtNgayTaoTK";
            this.dtNgayTaoTK.Size = new System.Drawing.Size(509, 20);
            this.dtNgayTaoTK.TabIndex = 9;
            // 
            // dgvDsUser
            // 
            this.dgvDsUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDsUser.Location = new System.Drawing.Point(30, 163);
            this.dgvDsUser.Name = "dgvDsUser";
            this.dgvDsUser.Size = new System.Drawing.Size(544, 320);
            this.dgvDsUser.TabIndex = 10;
            this.dgvDsUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsUser_RowEnter);
            this.dgvDsUser.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsUser_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "LoaiUser";
            this.Column1.HeaderText = "Loại Tài khoản";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaUser";
            this.Column2.HeaderText = "Mã Tài Khoản";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenDangNhap";
            this.Column3.HeaderText = "Tên Đăng nhập";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MatKhau";
            this.Column4.HeaderText = "Mật Khẩu";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayTaoTK";
            this.Column5.HeaderText = "Ngày Tạo";
            this.Column5.Name = "Column5";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(596, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(596, 239);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(596, 279);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(596, 317);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(677, 168);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(121, 20);
            this.txtTimKiem.TabIndex = 15;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(596, 166);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 16;
            this.btn.Text = "Tìm kiếm";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // FrmQLUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDsUser);
            this.Controls.Add(this.dtNgayTaoTK);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.txtMaUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxLoaiTK);
            this.MaximizeBox = false;
            this.Name = "FrmQLUser";
            this.Text = "FrmQLUser";
            this.groupBoxLoaiTK.ResumeLayout(false);
            this.groupBoxLoaiTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxLoaiTK;
        private System.Windows.Forms.RadioButton rBtnUser;
        private System.Windows.Forms.RadioButton rBtnAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaUser;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.DateTimePicker dtNgayTaoTK;
        private System.Windows.Forms.DataGridView dgvDsUser;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btn;
    }
}

