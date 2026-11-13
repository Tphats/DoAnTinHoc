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
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
            ucQLAccount uc = new ucQLAccount();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
    }
}
