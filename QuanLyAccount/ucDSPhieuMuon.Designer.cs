namespace QuanLyAccount
{
    partial class ucDSPhieuMuon
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
            this.dgv_dsphieumuon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsphieumuon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_dsphieumuon
            // 
            this.dgv_dsphieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsphieumuon.Location = new System.Drawing.Point(0, 0);
            this.dgv_dsphieumuon.Name = "dgv_dsphieumuon";
            this.dgv_dsphieumuon.Size = new System.Drawing.Size(792, 446);
            this.dgv_dsphieumuon.TabIndex = 0;
            // 
            // ucDSPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_dsphieumuon);
            this.Name = "ucDSPhieuMuon";
            this.Size = new System.Drawing.Size(792, 446);
            this.Load += new System.EventHandler(this.ucDSPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsphieumuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dsphieumuon;
    }
}
