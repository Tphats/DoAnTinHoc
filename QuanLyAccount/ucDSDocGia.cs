using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyAccount
{
    public partial class ucDSDocGia : UserControl
    {
        public ucDSDocGia()
        {
            InitializeComponent();
        }

        private void ucDSDocGia_Load(object sender, EventArgs e)
        {
            dgv_dsdocgia.DataSource = DuLieuDungChung.dsuser_info.ToList();
        }
        
    }
}
