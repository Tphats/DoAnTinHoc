namespace QuanLyThuVien
{
    partial class FrmChiTietPhieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietPhieu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.dgvChiTietP = new System.Windows.Forms.DataGridView();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnl_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.txtMaPM);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTenDG);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.txtMaDG);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 124);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Calibri", 35F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(551, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 58);
            this.label3.TabIndex = 13;
            this.label3.Text = "CHI TIẾT PHIẾU";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(275, 124);
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // pnl_Content
            // 
            this.pnl_Content.Controls.Add(this.dgvChiTietP);
            this.pnl_Content.Location = new System.Drawing.Point(0, 124);
            this.pnl_Content.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(1067, 430);
            this.pnl_Content.TabIndex = 2;
            // 
            // dgvChiTietP
            // 
            this.dgvChiTietP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietP.Location = new System.Drawing.Point(4, 0);
            this.dgvChiTietP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvChiTietP.Name = "dgvChiTietP";
            this.dgvChiTietP.Size = new System.Drawing.Size(1059, 426);
            this.dgvChiTietP.TabIndex = 0;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(439, 52);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.ReadOnly = true;
            this.txtMaDG.Size = new System.Drawing.Size(104, 22);
            this.txtMaDG.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(325, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã Độc giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(325, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên Độc giả";
            // 
            // txtTenDG
            // 
            this.txtTenDG.Location = new System.Drawing.Point(439, 82);
            this.txtTenDG.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.ReadOnly = true;
            this.txtTenDG.Size = new System.Drawing.Size(416, 22);
            this.txtTenDG.TabIndex = 24;
            // 
            // txtMaPM
            // 
            this.txtMaPM.Location = new System.Drawing.Point(439, 19);
            this.txtMaPM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.ReadOnly = true;
            this.txtMaPM.Size = new System.Drawing.Size(104, 22);
            this.txtMaPM.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(325, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mã Phiếu mượn";
            // 
            // FrmChiTietPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnl_Content);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1083, 593);
            this.Name = "FrmChiTietPhieu";
            this.Text = "FrmChiTietPM";
            this.Load += new System.EventHandler(this.FrmChiTietPhieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnl_Content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.DataGridView dgvChiTietP;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}