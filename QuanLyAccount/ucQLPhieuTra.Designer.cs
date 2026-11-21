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
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.conboBoxTrangThai = new System.Windows.Forms.ComboBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuaHan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDangMuon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuongPM = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChiTiet);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.conboBoxTrangThai);
            this.panel2.Controls.Add(this.txtMa);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 98);
            this.panel2.TabIndex = 2;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btnChiTiet.Location = new System.Drawing.Point(571, 25);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(110, 64);
            this.btnChiTiet.TabIndex = 12;
            this.btnChiTiet.Text = "Chi tiết Phiếu";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.Location = new System.Drawing.Point(476, 63);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 26);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.Location = new System.Drawing.Point(395, 63);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 26);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThem.Location = new System.Drawing.Point(395, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(156, 32);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Lập Phiếu trả";
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
            this.conboBoxTrangThai.Location = new System.Drawing.Point(30, 65);
            this.conboBoxTrangThai.Name = "conboBoxTrangThai";
            this.conboBoxTrangThai.Size = new System.Drawing.Size(335, 24);
            this.conboBoxTrangThai.TabIndex = 8;
            // 
            // txtMa
            // 
            this.txtMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMa.Location = new System.Drawing.Point(30, 33);
            this.txtMa.Multiline = true;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(335, 26);
            this.txtMa.TabIndex = 7;
            this.txtMa.Text = "Nhập mã phiếu trả hoặc mã độc giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(27, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtQuaHan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDangMuon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSoLuongPM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 75);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(348, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quá hạn";
            // 
            // txtQuaHan
            // 
            this.txtQuaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtQuaHan.Location = new System.Drawing.Point(351, 28);
            this.txtQuaHan.Multiline = true;
            this.txtQuaHan.Name = "txtQuaHan";
            this.txtQuaHan.ReadOnly = true;
            this.txtQuaHan.Size = new System.Drawing.Size(56, 35);
            this.txtQuaHan.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(181, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đúng hạn";
            // 
            // txtDangMuon
            // 
            this.txtDangMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtDangMuon.Location = new System.Drawing.Point(195, 28);
            this.txtDangMuon.Multiline = true;
            this.txtDangMuon.Name = "txtDangMuon";
            this.txtDangMuon.ReadOnly = true;
            this.txtDangMuon.Size = new System.Drawing.Size(56, 35);
            this.txtDangMuon.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(27, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng Phiếu";
            // 
            // txtSoLuongPM
            // 
            this.txtSoLuongPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSoLuongPM.Location = new System.Drawing.Point(40, 28);
            this.txtSoLuongPM.Multiline = true;
            this.txtSoLuongPM.Name = "txtSoLuongPM";
            this.txtSoLuongPM.ReadOnly = true;
            this.txtSoLuongPM.Size = new System.Drawing.Size(56, 35);
            this.txtSoLuongPM.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 171);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(786, 165);
            this.dataGridView2.TabIndex = 4;
            // 
            // ucQLPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ucQLPhieuTra";
            this.Size = new System.Drawing.Size(792, 339);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
