using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R7_ZOZI
{
    public partial class FrmQuảnLýNhàCungCấp : Form
    {
        public FrmQuảnLýNhàCungCấp()
        {
            InitializeComponent();
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTrangChủQuảnLý FrmTrangChủQuảnLý = new FrmTrangChủQuảnLý();
            FrmTrangChủQuảnLý.ShowDialog();
        }
    }
}
