namespace QuanLyThuVien
{
    partial class FrmLapPhieuMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLapPhieuMuon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtHanTra = new System.Windows.Forms.DateTimePicker();
            this.btnLapPM = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.labelMaSach = new System.Windows.Forms.Label();
            this.labelSoCuon = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtSoCuon = new System.Windows.Forms.TextBox();
            this.cboMaDG = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.txtSLSachCon = new System.Windows.Forms.TextBox();
            this.label_SL = new System.Windows.Forms.Label();
            this.dgvDSSach = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 84);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Calibri", 35F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(278, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 58);
            this.label3.TabIndex = 13;
            this.label3.Text = "LẬP PHIẾU MƯỢN";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(230, 84);
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(16, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Độc giả";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(15, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày mượn";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(16, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hạn trả";
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNgayMuon.Location = new System.Drawing.Point(100, 175);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(174, 20);
            this.dtNgayMuon.TabIndex = 8;
            // 
            // dtHanTra
            // 
            this.dtHanTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtHanTra.Location = new System.Drawing.Point(101, 210);
            this.dtHanTra.Name = "dtHanTra";
            this.dtHanTra.Size = new System.Drawing.Size(174, 20);
            this.dtHanTra.TabIndex = 9;
            // 
            // btnLapPM
            // 
            this.btnLapPM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLapPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLapPM.Location = new System.Drawing.Point(19, 264);
            this.btnLapPM.Name = "btnLapPM";
            this.btnLapPM.Size = new System.Drawing.Size(256, 35);
            this.btnLapPM.TabIndex = 10;
            this.btnLapPM.Text = "Lập phiếu mượn";
            this.btnLapPM.UseVisualStyleBackColor = true;
            this.btnLapPM.Click += new System.EventHandler(this.btnLapPM_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThemSach.Location = new System.Drawing.Point(323, 195);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(215, 31);
            this.btnThemSach.TabIndex = 11;
            this.btnThemSach.Text = "Thêm sách";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // labelMaSach
            // 
            this.labelMaSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMaSach.AutoSize = true;
            this.labelMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMaSach.Location = new System.Drawing.Point(320, 101);
            this.labelMaSach.Name = "labelMaSach";
            this.labelMaSach.Size = new System.Drawing.Size(63, 17);
            this.labelMaSach.TabIndex = 12;
            this.labelMaSach.Text = "Mã Sách";
            // 
            // labelSoCuon
            // 
            this.labelSoCuon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSoCuon.AutoSize = true;
            this.labelSoCuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSoCuon.Location = new System.Drawing.Point(320, 149);
            this.labelSoCuon.Name = "labelSoCuon";
            this.labelSoCuon.Size = new System.Drawing.Size(62, 17);
            this.labelSoCuon.TabIndex = 13;
            this.labelSoCuon.Text = "Số Cuốn";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaSach.Location = new System.Drawing.Point(389, 99);
            this.txtMaSach.Multiline = true;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(147, 28);
            this.txtMaSach.TabIndex = 14;
            // 
            // txtSoCuon
            // 
            this.txtSoCuon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoCuon.Location = new System.Drawing.Point(389, 147);
            this.txtSoCuon.Multiline = true;
            this.txtSoCuon.Name = "txtSoCuon";
            this.txtSoCuon.Size = new System.Drawing.Size(147, 28);
            this.txtSoCuon.TabIndex = 15;
            // 
            // cboMaDG
            // 
            this.cboMaDG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboMaDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaDG.FormattingEnabled = true;
            this.cboMaDG.Location = new System.Drawing.Point(101, 99);
            this.cboMaDG.Name = "cboMaDG";
            this.cboMaDG.Size = new System.Drawing.Size(174, 21);
            this.cboMaDG.TabIndex = 18;
            this.cboMaDG.SelectionChangeCommitted += new System.EventHandler(this.cboMaDG_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(15, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tên Độc giả";
            // 
            // txtTenDG
            // 
            this.txtTenDG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenDG.Location = new System.Drawing.Point(100, 137);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(173, 20);
            this.txtTenDG.TabIndex = 20;
            // 
            // txtSLSachCon
            // 
            this.txtSLSachCon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSLSachCon.Location = new System.Drawing.Point(605, 119);
            this.txtSLSachCon.Multiline = true;
            this.txtSLSachCon.Name = "txtSLSachCon";
            this.txtSLSachCon.ReadOnly = true;
            this.txtSLSachCon.Size = new System.Drawing.Size(35, 28);
            this.txtSLSachCon.TabIndex = 22;
            // 
            // label_SL
            // 
            this.label_SL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_SL.AutoSize = true;
            this.label_SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_SL.Location = new System.Drawing.Point(564, 97);
            this.label_SL.Name = "label_SL";
            this.label_SL.Size = new System.Drawing.Size(127, 17);
            this.label_SL.TabIndex = 21;
            this.label_SL.Text = "Số lượng Sách còn";
            // 
            // dgvDSSach
            // 
            this.dgvDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSach.Location = new System.Drawing.Point(323, 241);
            this.dgvDSSach.Name = "dgvDSSach";
            this.dgvDSSach.Size = new System.Drawing.Size(431, 171);
            this.dgvDSSach.TabIndex = 23;
            this.dgvDSSach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSach_RowEnter);
            // 
            // FrmLapPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(766, 424);
            this.Controls.Add(this.dgvDSSach);
            this.Controls.Add(this.txtSLSachCon);
            this.Controls.Add(this.label_SL);
            this.Controls.Add(this.txtTenDG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMaDG);
            this.Controls.Add(this.txtSoCuon);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.labelSoCuon);
            this.Controls.Add(this.labelMaSach);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.btnLapPM);
            this.Controls.Add(this.dtHanTra);
            this.Controls.Add(this.dtNgayMuon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(698, 461);
            this.Name = "FrmLapPhieuMuon";
            this.Text = "FrmLapPhieuMuon";
            this.Load += new System.EventHandler(this.FrmLapPhieuMuon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.DateTimePicker dtHanTra;
        private System.Windows.Forms.Button btnLapPM;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Label labelMaSach;
        private System.Windows.Forms.Label labelSoCuon;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtSoCuon;
        private System.Windows.Forms.ComboBox cboMaDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.TextBox txtSLSachCon;
        private System.Windows.Forms.Label label_SL;
        private System.Windows.Forms.DataGridView dgvDSSach;
    }
}