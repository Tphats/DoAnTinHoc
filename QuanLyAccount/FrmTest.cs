using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
            //ucDangkyTK uc = new ucDangkyTK();
            //ucQLAccount uc = new ucQLAccount();
            ucQLUser uc = new ucQLUser();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
    }
}
