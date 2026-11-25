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
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaDG = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(683, 84);
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
            this.label2.Location = new System.Drawing.Point(45, 155);
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
            this.label4.Location = new System.Drawing.Point(45, 212);
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
            this.label5.Location = new System.Drawing.Point(45, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hạn trả";
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNgayMuon.Location = new System.Drawing.Point(130, 212);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(174, 20);
            this.dtNgayMuon.TabIndex = 8;
            // 
            // dtHanTra
            // 
            this.dtHanTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtHanTra.Location = new System.Drawing.Point(130, 263);
            this.dtHanTra.Name = "dtHanTra";
            this.dtHanTra.Size = new System.Drawing.Size(174, 20);
            this.dtHanTra.TabIndex = 9;
            // 
            // btnLapPM
            // 
            this.btnLapPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLapPM.Location = new System.Drawing.Point(48, 317);
            this.btnLapPM.Name = "btnLapPM";
            this.btnLapPM.Size = new System.Drawing.Size(256, 35);
            this.btnLapPM.TabIndex = 10;
            this.btnLapPM.Text = "Lập phiếu mượn";
            this.btnLapPM.UseVisualStyleBackColor = true;
            this.btnLapPM.Click += new System.EventHandler(this.btnLapPM_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnThemSach.Location = new System.Drawing.Point(581, 185);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(32, 31);
            this.btnThemSach.TabIndex = 11;
            this.btnThemSach.Text = "+";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // labelMaSach
            // 
            this.labelMaSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMaSach.AutoSize = true;
            this.labelMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMaSach.Location = new System.Drawing.Point(330, 156);
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
            this.labelSoCuon.Location = new System.Drawing.Point(330, 204);
            this.labelSoCuon.Name = "labelSoCuon";
            this.labelSoCuon.Size = new System.Drawing.Size(62, 17);
            this.labelSoCuon.TabIndex = 13;
            this.labelSoCuon.Text = "Số Cuốn";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaSach.Location = new System.Drawing.Point(399, 154);
            this.txtMaSach.Multiline = true;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(147, 28);
            this.txtMaSach.TabIndex = 14;
            // 
            // txtSoCuon
            // 
            this.txtSoCuon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoCuon.Location = new System.Drawing.Point(399, 202);
            this.txtSoCuon.Multiline = true;
            this.txtSoCuon.Name = "txtSoCuon";
            this.txtSoCuon.Size = new System.Drawing.Size(147, 28);
            this.txtSoCuon.TabIndex = 15;
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHoanThanh.Location = new System.Drawing.Point(424, 249);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(122, 34);
            this.btnHoanThanh.TabIndex = 16;
            this.btnHoanThanh.Text = "Hoàn thành";
            this.btnHoanThanh.UseVisualStyleBackColor = true;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(564, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Thêm sách";
            // 
            // cboMaDG
            // 
            this.cboMaDG.FormattingEnabled = true;
            this.cboMaDG.Location = new System.Drawing.Point(130, 155);
            this.cboMaDG.Name = "cboMaDG";
            this.cboMaDG.Size = new System.Drawing.Size(174, 21);
            this.cboMaDG.TabIndex = 18;
            // 
            // FrmLapPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(683, 424);
            this.Controls.Add(this.cboMaDG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHoanThanh);
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
            this.MinimumSize = new System.Drawing.Size(699, 463);
            this.Name = "FrmLapPhieuMuon";
            this.Text = "FrmLapPhieuMuon";
            this.Load += new System.EventHandler(this.FrmLapPhieuMuon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
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
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaDG;
    }
}