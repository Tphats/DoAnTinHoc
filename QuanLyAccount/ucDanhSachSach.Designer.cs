namespace QuanLyAccount
{
    partial class ucDanhSachSach
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDanhSachSach));
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.btnTIm = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.dgvDanhSachSach = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(190)))));
            this.lblTieuDe.Location = new System.Drawing.Point(270, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(265, 38);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "DANH SÁCH SÁCH";
            this.lblTieuDe.Click += new System.EventHandler(this.lblTieuDe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Kiếm :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(141, 52);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(197, 34);
            this.txtTimKiem.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thể Loại :";
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(438, 52);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(170, 31);
            this.cboTheLoai.TabIndex = 5;
            // 
            // btnTIm
            // 
            this.btnTIm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTIm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTIm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnTIm.Location = new System.Drawing.Point(614, 52);
            this.btnTIm.Name = "btnTIm";
            this.btnTIm.Size = new System.Drawing.Size(90, 34);
            this.btnTIm.TabIndex = 6;
            this.btnTIm.Text = "Tìm";
            this.btnTIm.UseVisualStyleBackColor = false;
            // 
            // btnTatCa
            // 
            this.btnTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCa.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnTatCa.Location = new System.Drawing.Point(702, 52);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(90, 34);
            this.btnTatCa.TabIndex = 7;
            this.btnTatCa.Text = "Tất Cả";
            this.btnTatCa.UseVisualStyleBackColor = false;
            // 
            // dgvDanhSachSach
            // 
            this.dgvDanhSachSach.AllowUserToAddRows = false;
            this.dgvDanhSachSach.AllowUserToDeleteRows = false;
            this.dgvDanhSachSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTenSach,
            this.colTacGia,
            this.colTheLoai,
            this.colNXB,
            this.colNamXB,
            this.colSoLuongCon});
            this.dgvDanhSachSach.EnableHeadersVisualStyles = false;
            this.dgvDanhSachSach.GridColor = System.Drawing.Color.Black;
            this.dgvDanhSachSach.Location = new System.Drawing.Point(0, 89);
            this.dgvDanhSachSach.MultiSelect = false;
            this.dgvDanhSachSach.Name = "dgvDanhSachSach";
            this.dgvDanhSachSach.ReadOnly = true;
            this.dgvDanhSachSach.RowHeadersVisible = false;
            this.dgvDanhSachSach.RowHeadersWidth = 51;
            this.dgvDanhSachSach.RowTemplate.Height = 24;
            this.dgvDanhSachSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachSach.Size = new System.Drawing.Size(792, 357);
            this.dgvDanhSachSach.TabIndex = 8;
            // 
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.FillWeight = 50F;
            this.colMaSach.HeaderText = "Mã Sách";
            this.colMaSach.MinimumWidth = 6;
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.ReadOnly = true;
            // 
            // colTenSach
            // 
            this.colTenSach.DataPropertyName = "TenSach";
            this.colTenSach.FillWeight = 160F;
            this.colTenSach.HeaderText = "Tên Sách";
            this.colTenSach.MinimumWidth = 6;
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.ReadOnly = true;
            // 
            // colTacGia
            // 
            this.colTacGia.DataPropertyName = "TenTacGia";
            this.colTacGia.HeaderText = "Tác Giả";
            this.colTacGia.MinimumWidth = 6;
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.ReadOnly = true;
            // 
            // colTheLoai
            // 
            this.colTheLoai.DataPropertyName = "TenTheLoai";
            this.colTheLoai.HeaderText = "Thể Loại";
            this.colTheLoai.MinimumWidth = 6;
            this.colTheLoai.Name = "colTheLoai";
            this.colTheLoai.ReadOnly = true;
            // 
            // colNXB
            // 
            this.colNXB.DataPropertyName = "TenNXB";
            this.colNXB.FillWeight = 110F;
            this.colNXB.HeaderText = "Nhà Xuất Bản";
            this.colNXB.MinimumWidth = 6;
            this.colNXB.Name = "colNXB";
            this.colNXB.ReadOnly = true;
            // 
            // colNamXB
            // 
            this.colNamXB.DataPropertyName = "NamXuatBan";
            this.colNamXB.FillWeight = 50F;
            this.colNamXB.HeaderText = "Năm Xuất Bản";
            this.colNamXB.MinimumWidth = 6;
            this.colNamXB.Name = "colNamXB";
            this.colNamXB.ReadOnly = true;
            // 
            // colSoLuongCon
            // 
            this.colSoLuongCon.DataPropertyName = "SoLuongCon";
            this.colSoLuongCon.FillWeight = 55F;
            this.colSoLuongCon.HeaderText = "Còn Lại";
            this.colSoLuongCon.MinimumWidth = 6;
            this.colSoLuongCon.Name = "colSoLuongCon";
            this.colSoLuongCon.ReadOnly = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(12, 423);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 23);
            this.lblKetQua.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(243, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 38);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 38);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // ucDanhSachSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.dgvDanhSachSach);
            this.Controls.Add(this.btnTatCa);
            this.Controls.Add(this.btnTIm);
            this.Controls.Add(this.cboTheLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "ucDanhSachSach";
            this.Size = new System.Drawing.Size(792, 446);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.Button btnTIm;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.DataGridView dgvDanhSachSach;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongCon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
