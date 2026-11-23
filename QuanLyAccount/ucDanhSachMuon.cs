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
    public partial class ucDanhSachMuon : UserControl
    {
        public ucDanhSachMuon()
        {
            InitializeComponent();
        }

        public string MaDocGia { get; internal set; }

        private void dgvDangMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
