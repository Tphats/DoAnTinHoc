namespace QuanLyAccount
{
    partial class FrmQLSach_Chung
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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnTG = new System.Windows.Forms.Button();
            this.btnNXB = new System.Windows.Forms.Button();
            this.pnl_Top.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.label5);
            this.pnl_Top.Controls.Add(this.panel3);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(800, 57);
            this.pnl_Top.TabIndex = 0;
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
            // pnl_Content
            // 
            this.pnl_Content.Location = new System.Drawing.Point(0, 100);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(800, 351);
            this.pnl_Content.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSach);
            this.flowLayoutPanel1.Controls.Add(this.btnTG);
            this.flowLayoutPanel1.Controls.Add(this.btnNXB);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 31);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnSach
            // 
            this.btnSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSach.Location = new System.Drawing.Point(3, 3);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(212, 28);
            this.btnSach.TabIndex = 0;
            this.btnSach.Text = "Sách";
            this.btnSach.UseVisualStyleBackColor = true;
            // 
            // btnTG
            // 
            this.btnTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTG.Location = new System.Drawing.Point(221, 3);
            this.btnTG.Name = "btnTG";
            this.btnTG.Size = new System.Drawing.Size(187, 28);
            this.btnTG.TabIndex = 1;
            this.btnTG.Text = "Tác giả";
            this.btnTG.UseVisualStyleBackColor = true;
            // 
            // btnNXB
            // 
            this.btnNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNXB.Location = new System.Drawing.Point(414, 3);
            this.btnNXB.Name = "btnNXB";
            this.btnNXB.Size = new System.Drawing.Size(150, 28);
            this.btnNXB.TabIndex = 2;
            this.btnNXB.Text = "Nhà xuất bản";
            this.btnNXB.UseVisualStyleBackColor = true;
            // 
            // FrmQLSach_Chung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnl_Content);
            this.Controls.Add(this.pnl_Top);
            this.Name = "FrmQLSach_Chung";
            this.Text = "FrmQLSach_Chung";
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnTG;
        private System.Windows.Forms.Button btnNXB;
    }
}