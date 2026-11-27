namespace QuanLyThuVien
{
    partial class ucQLPhieuTra
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaPM = new System.Windows.Forms.ComboBox();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.conboBoxTrangThai = new System.Windows.Forms.ComboBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboTenDG = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuaHan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDangMuon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuongPM = new System.Windows.Forms.TextBox();
            this.dgvPT = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cboMaPM);
            this.panel2.Controls.Add(this.btnChiTiet);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.conboBoxTrangThai);
            this.panel2.Controls.Add(this.txtMa);
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 138);
            this.panel2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(58, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(17, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã Phiếu Mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(33, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã Phiếu Trả";
            // 
            // cboMaPM
            // 
            this.cboMaPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboMaPM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboMaPM.FormattingEnabled = true;
            this.cboMaPM.Items.AddRange(new object[] {
            "Đang mượn",
            "Đã Trả",
            "Quá Hạn"});
            this.cboMaPM.Location = new System.Drawing.Point(150, 21);
            this.cboMaPM.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaPM.Name = "cboMaPM";
            this.cboMaPM.Size = new System.Drawing.Size(257, 28);
            this.cboMaPM.TabIndex = 13;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btnChiTiet.Location = new System.Drawing.Point(448, 18);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(208, 46);
            this.btnChiTiet.TabIndex = 12;
            this.btnChiTiet.Text = "Chi tiết Phiếu";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.Location = new System.Drawing.Point(556, 78);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 46);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.Location = new System.Drawing.Point(448, 78);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 46);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnThem.Location = new System.Drawing.Point(734, 60);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(63, 52);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "+";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // conboBoxTrangThai
            // 
            this.conboBoxTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.conboBoxTrangThai.ForeColor = System.Drawing.SystemColors.WindowText;
            this.conboBoxTrangThai.FormattingEnabled = true;
            this.conboBoxTrangThai.Items.AddRange(new object[] {
            "Đang mượn",
            "Đã Trả",
            "Quá Hạn"});
            this.conboBoxTrangThai.Location = new System.Drawing.Point(150, 93);
            this.conboBoxTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.conboBoxTrangThai.Name = "conboBoxTrangThai";
            this.conboBoxTrangThai.Size = new System.Drawing.Size(257, 28);
            this.conboBoxTrangThai.TabIndex = 8;
            // 
            // txtMa
            // 
            this.txtMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMa.Location = new System.Drawing.Point(150, 57);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMa.Multiline = true;
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(257, 31);
            this.txtMa.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(505, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên Độc giả";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.cboTenDG);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtQuaHan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDangMuon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSoLuongPM);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 92);
            this.panel1.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTimKiem.Location = new System.Drawing.Point(679, 45);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(145, 32);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cboTenDG
            // 
            this.cboTenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboTenDG.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboTenDG.FormattingEnabled = true;
            this.cboTenDG.Items.AddRange(new object[] {
            "Đang mượn",
            "Đã Trả",
            "Quá Hạn"});
            this.cboTenDG.Location = new System.Drawing.Point(427, 49);
            this.cboTenDG.Margin = new System.Windows.Forms.Padding(4);
            this.cboTenDG.Name = "cboTenDG";
            this.cboTenDG.Size = new System.Drawing.Size(244, 28);
            this.cboTenDG.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(287, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quá hạn";
            // 
            // txtQuaHan
            // 
            this.txtQuaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtQuaHan.Location = new System.Drawing.Point(291, 34);
            this.txtQuaHan.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuaHan.Multiline = true;
            this.txtQuaHan.Name = "txtQuaHan";
            this.txtQuaHan.ReadOnly = true;
            this.txtQuaHan.Size = new System.Drawing.Size(73, 42);
            this.txtQuaHan.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(169, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đúng hạn";
            // 
            // txtDangMuon
            // 
            this.txtDangMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtDangMuon.Location = new System.Drawing.Point(173, 34);
            this.txtDangMuon.Margin = new System.Windows.Forms.Padding(4);
            this.txtDangMuon.Multiline = true;
            this.txtDangMuon.Name = "txtDangMuon";
            this.txtDangMuon.ReadOnly = true;
            this.txtDangMuon.Size = new System.Drawing.Size(73, 42);
            this.txtDangMuon.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(36, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng Phiếu";
            // 
            // txtSoLuongPM
            // 
            this.txtSoLuongPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSoLuongPM.Location = new System.Drawing.Point(53, 34);
            this.txtSoLuongPM.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongPM.Multiline = true;
            this.txtSoLuongPM.Name = "txtSoLuongPM";
            this.txtSoLuongPM.ReadOnly = true;
            this.txtSoLuongPM.Size = new System.Drawing.Size(73, 42);
            this.txtSoLuongPM.TabIndex = 0;
            // 
            // dgvPT
            // 
            this.dgvPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPT.Location = new System.Drawing.Point(8, 228);
            this.dgvPT.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPT.Name = "dgvPT";
            this.dgvPT.ReadOnly = true;
            this.dgvPT.RowHeadersWidth = 51;
            this.dgvPT.Size = new System.Drawing.Size(1048, 185);
            this.dgvPT.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(715, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Lập Phiếu trả";
            // 
            // ucQLPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucQLPhieuTra";
            this.Size = new System.Drawing.Size(1056, 417);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox conboBoxTrangThai;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuaHan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDangMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuongPM;
        private System.Windows.Forms.DataGridView dgvPT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMaPM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboTenDG;
        private System.Windows.Forms.Label label8;
    }
}
