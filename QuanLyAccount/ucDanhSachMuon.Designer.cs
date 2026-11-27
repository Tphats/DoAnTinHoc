namespace QuanLyAccount
{
    partial class ucDanhSachMuon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDanhSachMuon));
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTongKet = new System.Windows.Forms.Label();
            this.dgvDanhSachMuon = new System.Windows.Forms.DataGridView();
            this.colMaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSachMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.lblHanTra = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTT = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtpHanTra = new System.Windows.Forms.DateTimePicker();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMuon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(190)))));
            this.lblTieuDe.Location = new System.Drawing.Point(129, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(284, 38);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "DANH SÁCH MƯỢN";
            this.lblTieuDe.Click += new System.EventHandler(this.lblTieuDe_Click);
            // 
            // lblTongKet
            // 
            this.lblTongKet.AutoSize = true;
            this.lblTongKet.Location = new System.Drawing.Point(14, 42);
            this.lblTongKet.Name = "lblTongKet";
            this.lblTongKet.Size = new System.Drawing.Size(0, 23);
            this.lblTongKet.TabIndex = 1;
            // 
            // dgvDanhSachMuon
            // 
            this.dgvDanhSachMuon.AllowUserToAddRows = false;
            this.dgvDanhSachMuon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvDanhSachMuon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSachMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachMuon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDanhSachMuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachMuon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPM,
            this.colSachMuon,
            this.colNgayMuon,
            this.colHanTra,
            this.colConLai,
            this.colTrangThai});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(215)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachMuon.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDanhSachMuon.EnableHeadersVisualStyles = false;
            this.dgvDanhSachMuon.Location = new System.Drawing.Point(0, 99);
            this.dgvDanhSachMuon.MultiSelect = false;
            this.dgvDanhSachMuon.Name = "dgvDanhSachMuon";
            this.dgvDanhSachMuon.ReadOnly = true;
            this.dgvDanhSachMuon.RowHeadersVisible = false;
            this.dgvDanhSachMuon.RowHeadersWidth = 51;
            this.dgvDanhSachMuon.RowTemplate.Height = 24;
            this.dgvDanhSachMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachMuon.Size = new System.Drawing.Size(792, 132);
            this.dgvDanhSachMuon.TabIndex = 2;
            this.dgvDanhSachMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDangMuon_CellContentClick);
            // 
            // colMaPM
            // 
            this.colMaPM.DataPropertyName = "MaPM";
            this.colMaPM.FillWeight = 55F;
            this.colMaPM.HeaderText = "Mã Phiếu";
            this.colMaPM.MinimumWidth = 6;
            this.colMaPM.Name = "colMaPM";
            this.colMaPM.ReadOnly = true;
            // 
            // colSachMuon
            // 
            this.colSachMuon.DataPropertyName = "SachMuon";
            this.colSachMuon.FillWeight = 200F;
            this.colSachMuon.HeaderText = "Sách Mượn";
            this.colSachMuon.MinimumWidth = 6;
            this.colSachMuon.Name = "colSachMuon";
            this.colSachMuon.ReadOnly = true;
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.DataPropertyName = "NgayMuon";
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            this.colNgayMuon.DefaultCellStyle = dataGridViewCellStyle6;
            this.colNgayMuon.HeaderText = "Ngày Mượn";
            this.colNgayMuon.MinimumWidth = 6;
            this.colNgayMuon.Name = "colNgayMuon";
            this.colNgayMuon.ReadOnly = true;
            // 
            // colHanTra
            // 
            this.colHanTra.DataPropertyName = "HanTra";
            dataGridViewCellStyle7.Format = "dd/MM/yyyy";
            this.colHanTra.DefaultCellStyle = dataGridViewCellStyle7;
            this.colHanTra.HeaderText = "Hạn Trả";
            this.colHanTra.MinimumWidth = 6;
            this.colHanTra.Name = "colHanTra";
            this.colHanTra.ReadOnly = true;
            // 
            // colConLai
            // 
            this.colConLai.DataPropertyName = "SoNgayConLai";
            this.colConLai.FillWeight = 70F;
            this.colConLai.HeaderText = "Còn Lại";
            this.colConLai.MinimumWidth = 6;
            this.colConLai.Name = "colConLai";
            this.colConLai.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTieuDe);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 100);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpHanTra);
            this.panel2.Controls.Add(this.dtpNgayMuon);
            this.panel2.Controls.Add(this.lblTT);
            this.panel2.Controls.Add(this.lblMa);
            this.panel2.Controls.Add(this.lblTrangThai);
            this.panel2.Controls.Add(this.lblHanTra);
            this.panel2.Controls.Add(this.lblNgayMuon);
            this.panel2.Controls.Add(this.lblMaPhieu);
            this.panel2.Location = new System.Drawing.Point(6, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 206);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieu.Location = new System.Drawing.Point(3, 17);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(110, 28);
            this.lblMaPhieu.TabIndex = 0;
            this.lblMaPhieu.Text = "Mã Phiếu:";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayMuon.Location = new System.Drawing.Point(3, 56);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(135, 28);
            this.lblNgayMuon.TabIndex = 1;
            this.lblNgayMuon.Text = "Ngày Mượn:";
            // 
            // lblHanTra
            // 
            this.lblHanTra.AutoSize = true;
            this.lblHanTra.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHanTra.Location = new System.Drawing.Point(3, 97);
            this.lblHanTra.Name = "lblHanTra";
            this.lblHanTra.Size = new System.Drawing.Size(97, 28);
            this.lblHanTra.TabIndex = 2;
            this.lblHanTra.Text = "Hạn Trả:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(7, 152);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(125, 28);
            this.lblTrangThai.TabIndex = 3;
            this.lblTrangThai.Text = "Trạng Thái:";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(177, 22);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(43, 23);
            this.lblMa.TabIndex = 4;
            this.lblMa.Text = "Null";
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTT.Location = new System.Drawing.Point(177, 157);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(43, 23);
            this.lblTT.TabIndex = 5;
            this.lblTT.Text = "Null";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(181, 56);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(113, 30);
            this.dtpNgayMuon.TabIndex = 6;
            // 
            // dtpHanTra
            // 
            this.dtpHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHanTra.Location = new System.Drawing.Point(181, 97);
            this.dtpHanTra.Name = "dtpHanTra";
            this.dtpHanTra.Size = new System.Drawing.Size(113, 30);
            this.dtpHanTra.TabIndex = 7;
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.BackColor = System.Drawing.Color.Lavender;
            this.btnGiaHan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGiaHan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGiaHan.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaHan.Image")));
            this.btnGiaHan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaHan.Location = new System.Drawing.Point(396, 259);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(188, 47);
            this.btnGiaHan.TabIndex = 5;
            this.btnGiaHan.Text = "Gia Hạn";
            this.btnGiaHan.UseVisualStyleBackColor = false;
            // 
            // btnTraSach
            // 
            this.btnTraSach.BackColor = System.Drawing.Color.Lavender;
            this.btnTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTraSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTraSach.Image = ((System.Drawing.Image)(resources.GetObject("btnTraSach.Image")));
            this.btnTraSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraSach.Location = new System.Drawing.Point(396, 317);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(188, 47);
            this.btnTraSach.TabIndex = 6;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = false;
            // 
            // ucDanhSachMuon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDanhSachMuon);
            this.Controls.Add(this.lblTongKet);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "ucDanhSachMuon";
            this.Size = new System.Drawing.Size(792, 446);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMuon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTongKet;
        private System.Windows.Forms.DataGridView dgvDanhSachMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSachMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblHanTra;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnTraSach;
    }
}
