namespace QuanLyThuVien
{
    partial class FrmLapPhieuTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLapPhieuTra));
            this.btnLapPT = new System.Windows.Forms.Button();
            this.dtHanTra = new System.Windows.Forms.DateTimePicker();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTienDaDong = new System.Windows.Forms.TextBox();
            this.btnXemTP = new System.Windows.Forms.Button();
            this.cboDG = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLapPT
            // 
            this.btnLapPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLapPT.Location = new System.Drawing.Point(126, 479);
            this.btnLapPT.Margin = new System.Windows.Forms.Padding(4);
            this.btnLapPT.Name = "btnLapPT";
            this.btnLapPT.Size = new System.Drawing.Size(366, 43);
            this.btnLapPT.TabIndex = 21;
            this.btnLapPT.Text = "Lập phiếu trả";
            this.btnLapPT.UseVisualStyleBackColor = true;
            this.btnLapPT.Click += new System.EventHandler(this.btnLapPT_Click);
            // 
            // dtHanTra
            // 
            this.dtHanTra.Location = new System.Drawing.Point(232, 418);
            this.dtHanTra.Margin = new System.Windows.Forms.Padding(4);
            this.dtHanTra.Name = "dtHanTra";
            this.dtHanTra.Size = new System.Drawing.Size(296, 22);
            this.dtHanTra.TabIndex = 20;
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Location = new System.Drawing.Point(232, 371);
            this.dtNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(296, 22);
            this.dtNgayTra.TabIndex = 19;
            // 
            // txtMaPM
            // 
            this.txtMaPM.Location = new System.Drawing.Point(239, 304);
            this.txtMaPM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPM.Multiline = true;
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(121, 34);
            this.txtMaPM.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(106, 420);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hạn trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(106, 373);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày trả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(106, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Độc giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(106, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã Phiếu mượn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 96);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(308, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 51);
            this.label3.TabIndex = 13;
            this.label3.Text = "LẬP PHIẾU TRẢ";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(207, 96);
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // txtTienPhat
            // 
            this.txtTienPhat.Location = new System.Drawing.Point(108, 143);
            this.txtTienPhat.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienPhat.Multiline = true;
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.ReadOnly = true;
            this.txtTienPhat.Size = new System.Drawing.Size(157, 34);
            this.txtTienPhat.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(149, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tiền phạt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(467, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Số tiền đã đóng";
            // 
            // txtTienDaDong
            // 
            this.txtTienDaDong.Location = new System.Drawing.Point(443, 143);
            this.txtTienDaDong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienDaDong.Multiline = true;
            this.txtTienDaDong.Name = "txtTienDaDong";
            this.txtTienDaDong.Size = new System.Drawing.Size(160, 34);
            this.txtTienDaDong.TabIndex = 25;
            // 
            // btnXemTP
            // 
            this.btnXemTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXemTP.Location = new System.Drawing.Point(285, 145);
            this.btnXemTP.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemTP.Name = "btnXemTP";
            this.btnXemTP.Size = new System.Drawing.Size(129, 32);
            this.btnXemTP.TabIndex = 26;
            this.btnXemTP.Text = "Xem tiền phạt";
            this.btnXemTP.UseVisualStyleBackColor = true;
            this.btnXemTP.Click += new System.EventHandler(this.btnXemTP_Click);
            // 
            // cboDG
            // 
            this.cboDG.FormattingEnabled = true;
            this.cboDG.Location = new System.Drawing.Point(239, 245);
            this.cboDG.Name = "cboDG";
            this.cboDG.Size = new System.Drawing.Size(289, 24);
            this.cboDG.TabIndex = 27;
            // 
            // FrmLapPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 578);
            this.Controls.Add(this.cboDG);
            this.Controls.Add(this.btnXemTP);
            this.Controls.Add(this.txtTienDaDong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTienPhat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLapPT);
            this.Controls.Add(this.dtHanTra);
            this.Controls.Add(this.dtNgayTra);
            this.Controls.Add(this.txtMaPM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(688, 572);
            this.Name = "FrmLapPhieuTra";
            this.Text = "FrmLapPhieuTra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLapPT;
        private System.Windows.Forms.DateTimePicker dtHanTra;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTienDaDong;
        private System.Windows.Forms.Button btnXemTP;
        private System.Windows.Forms.ComboBox cboDG;
    }
}