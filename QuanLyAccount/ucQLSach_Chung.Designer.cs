namespace QuanLyThuVien
{
    partial class ucQLSach_Chung
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
            this.pnl_sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnTheLoai = new System.Windows.Forms.Button();
            this.btnTG = new System.Windows.Forms.Button();
            this.btnNXB = new System.Windows.Forms.Button();
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_sidebar.SuspendLayout();
            this.pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_sidebar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnl_sidebar.Controls.Add(this.btnSach);
            this.pnl_sidebar.Controls.Add(this.btnTheLoai);
            this.pnl_sidebar.Controls.Add(this.btnTG);
            this.pnl_sidebar.Controls.Add(this.btnNXB);
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 63);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(800, 38);
            this.pnl_sidebar.TabIndex = 5;
            // 
            // btnSach
            // 
            this.btnSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSach.Location = new System.Drawing.Point(3, 3);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(189, 35);
            this.btnSach.TabIndex = 0;
            this.btnSach.Text = "Sách";
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTheLoai.Location = new System.Drawing.Point(198, 3);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(198, 35);
            this.btnTheLoai.TabIndex = 3;
            this.btnTheLoai.Text = "Thể loại";
            this.btnTheLoai.UseVisualStyleBackColor = true;
            this.btnTheLoai.Click += new System.EventHandler(this.btnTheLoai_Click);
            // 
            // btnTG
            // 
            this.btnTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTG.Location = new System.Drawing.Point(402, 3);
            this.btnTG.Name = "btnTG";
            this.btnTG.Size = new System.Drawing.Size(196, 35);
            this.btnTG.TabIndex = 1;
            this.btnTG.Text = "Tác giả";
            this.btnTG.UseVisualStyleBackColor = true;
            this.btnTG.Click += new System.EventHandler(this.btnTG_Click);
            // 
            // btnNXB
            // 
            this.btnNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNXB.Location = new System.Drawing.Point(604, 3);
            this.btnNXB.Name = "btnNXB";
            this.btnNXB.Size = new System.Drawing.Size(183, 35);
            this.btnNXB.TabIndex = 2;
            this.btnNXB.Text = "Nhà xuất bản";
            this.btnNXB.UseVisualStyleBackColor = true;
            this.btnNXB.Click += new System.EventHandler(this.btnNXB_Click);
            // 
            // pnl_Content
            // 
            this.pnl_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Content.Location = new System.Drawing.Point(0, 100);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(792, 346);
            this.pnl_Content.TabIndex = 4;
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.label5);
            this.pnl_Top.Controls.Add(this.panel3);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(792, 57);
            this.pnl_Top.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(275, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 41);
            this.label5.TabIndex = 3;
            this.label5.Text = "QUẢN LÝ SÁCH";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 21);
            this.panel3.TabIndex = 2;
            // 
            // ucQLSach_Chung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_sidebar);
            this.Controls.Add(this.pnl_Content);
            this.Controls.Add(this.pnl_Top);
            this.Name = "ucQLSach_Chung";
            this.Size = new System.Drawing.Size(792, 446);
            this.pnl_sidebar.ResumeLayout(false);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl_sidebar;
        private System.Windows.Forms.Button btnTheLoai;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnTG;
        private System.Windows.Forms.Button btnNXB;
        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
    }
}
