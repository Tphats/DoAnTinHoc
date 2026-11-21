namespace QuanLyAccount
{
    partial class ucDSDocGia
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
            this.dgv_dsdocgia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsdocgia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_dsdocgia
            // 
            this.dgv_dsdocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsdocgia.Location = new System.Drawing.Point(0, 0);
            this.dgv_dsdocgia.Name = "dgv_dsdocgia";
            this.dgv_dsdocgia.Size = new System.Drawing.Size(792, 446);
            this.dgv_dsdocgia.TabIndex = 1;
            // 
            // ucDSDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_dsdocgia);
            this.Name = "ucDSDocGia";
            this.Size = new System.Drawing.Size(792, 446);
            this.Load += new System.EventHandler(this.ucDSDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsdocgia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dsdocgia;
    }
}
