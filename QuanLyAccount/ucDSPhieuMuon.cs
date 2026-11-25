using QuanLyThuVien;
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
    public partial class ucDSPhieuMuon : UserControl
    {
        public ucDSPhieuMuon()
        {
            InitializeComponent();
        }

        private void ucDSPhieuMuon_Load(object sender, EventArgs e)
        {
            dgv_dsphieumuon.DataSource = DuLieuDungChung.dsphieumuon_info.ToList();
        }
    }
}
