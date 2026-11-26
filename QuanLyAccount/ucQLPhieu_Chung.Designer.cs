namespace QuanLyThuVien
{
    partial class ucQLPhieu_Chung
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.pnl_sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnPT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 74);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(335, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(418, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "QUẢN LÝ PHIẾU MƯỢN/TRẢ";
            // 
            // pnl_Content
            // 
            this.pnl_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Content.Location = new System.Drawing.Point(0, 132);
            this.pnl_Content.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(1056, 490);
            this.pnl_Content.TabIndex = 5;
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_sidebar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnl_sidebar.Controls.Add(this.btnPM);
            this.pnl_sidebar.Controls.Add(this.btnPT);
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 78);
            this.pnl_sidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(1067, 47);
            this.pnl_sidebar.TabIndex = 6;
            // 
            // btnPM
            // 
            this.btnPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPM.Location = new System.Drawing.Point(4, 4);
            this.btnPM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(252, 43);
            this.btnPM.TabIndex = 0;
            this.btnPM.Text = "Phiếu mượn";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnPT
            // 
            this.btnPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPT.Location = new System.Drawing.Point(264, 4);
            this.btnPT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPT.Name = "btnPT";
            this.btnPT.Size = new System.Drawing.Size(264, 43);
            this.btnPT.TabIndex = 3;
            this.btnPT.Text = "Phiếu trả";
            this.btnPT.UseVisualStyleBackColor = true;
            this.btnPT.Click += new System.EventHandler(this.btnPT_Click);
            // 
            // ucQLPhieu_Chung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.pnl_sidebar);
            this.Controls.Add(this.pnl_Content);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1025, 622);
            this.Name = "ucQLPhieu_Chung";
            this.Size = new System.Drawing.Size(1056, 622);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.FlowLayoutPanel pnl_sidebar;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnPT;
    }
}
