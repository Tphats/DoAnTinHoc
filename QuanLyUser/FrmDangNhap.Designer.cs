namespace QuanLyUser
{
    partial class FrmDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.rbtnAnMK = new System.Windows.Forms.RadioButton();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.grAdminOrUser = new System.Windows.Forms.GroupBox();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.txtPhanQuyen = new System.Windows.Forms.TextBox();
            this.rbtnUser = new System.Windows.Forms.RadioButton();
            this.label_MaAdmin = new System.Windows.Forms.Label();
            this.grAdminOrUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(114, 198);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(236, 23);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(356, 198);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(75, 23);
            this.Thoat.TabIndex = 3;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(114, 36);
            this.txtTenDN.Multiline = true;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(317, 28);
            this.txtTenDN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chưa có tài khoản";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(211, 243);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(220, 23);
            this.btnDangKy.TabIndex = 7;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // rbtnAnMK
            // 
            this.rbtnAnMK.AutoSize = true;
            this.rbtnAnMK.Location = new System.Drawing.Point(437, 84);
            this.rbtnAnMK.Name = "rbtnAnMK";
            this.rbtnAnMK.Size = new System.Drawing.Size(43, 17);
            this.rbtnAnMK.TabIndex = 8;
            this.rbtnAnMK.TabStop = true;
            this.rbtnAnMK.Text = "<o>";
            this.rbtnAnMK.UseVisualStyleBackColor = true;
            this.rbtnAnMK.Click += new System.EventHandler(this.rbtnAnMK_Click);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(114, 81);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(317, 20);
            this.txtMK.TabIndex = 9;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // grAdminOrUser
            // 
            this.grAdminOrUser.Controls.Add(this.label_MaAdmin);
            this.grAdminOrUser.Controls.Add(this.rbtnUser);
            this.grAdminOrUser.Controls.Add(this.txtPhanQuyen);
            this.grAdminOrUser.Controls.Add(this.rbtnAdmin);
            this.grAdminOrUser.Location = new System.Drawing.Point(114, 116);
            this.grAdminOrUser.Name = "grAdminOrUser";
            this.grAdminOrUser.Size = new System.Drawing.Size(317, 76);
            this.grAdminOrUser.TabIndex = 10;
            this.grAdminOrUser.TabStop = false;
            this.grAdminOrUser.Text = "Bạn là Admin hay User?";
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Location = new System.Drawing.Point(17, 19);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(54, 17);
            this.rbtnAdmin.TabIndex = 0;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Admin";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            this.rbtnAdmin.CheckedChanged += new System.EventHandler(this.rbtnAdmin_CheckedChanged);
            // 
            // txtPhanQuyen
            // 
            this.txtPhanQuyen.Location = new System.Drawing.Point(196, 19);
            this.txtPhanQuyen.Name = "txtPhanQuyen";
            this.txtPhanQuyen.Size = new System.Drawing.Size(100, 20);
            this.txtPhanQuyen.TabIndex = 2;
            // 
            // rbtnUser
            // 
            this.rbtnUser.AutoSize = true;
            this.rbtnUser.Location = new System.Drawing.Point(17, 42);
            this.rbtnUser.Name = "rbtnUser";
            this.rbtnUser.Size = new System.Drawing.Size(47, 17);
            this.rbtnUser.TabIndex = 3;
            this.rbtnUser.TabStop = true;
            this.rbtnUser.Text = "User";
            this.rbtnUser.UseVisualStyleBackColor = true;
            // 
            // label_MaAdmin
            // 
            this.label_MaAdmin.AutoSize = true;
            this.label_MaAdmin.Location = new System.Drawing.Point(136, 23);
            this.label_MaAdmin.Name = "label_MaAdmin";
            this.label_MaAdmin.Size = new System.Drawing.Size(54, 13);
            this.label_MaAdmin.TabIndex = 4;
            this.label_MaAdmin.Text = "Mã Admin";
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 294);
            this.Controls.Add(this.grAdminOrUser);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.rbtnAnMK);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmDangNhap";
            this.Text = "FrmDangNhap";
            this.grAdminOrUser.ResumeLayout(false);
            this.grAdminOrUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.RadioButton rbtnAnMK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.GroupBox grAdminOrUser;
        private System.Windows.Forms.TextBox txtPhanQuyen;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.RadioButton rbtnUser;
        private System.Windows.Forms.Label label_MaAdmin;
    }
}