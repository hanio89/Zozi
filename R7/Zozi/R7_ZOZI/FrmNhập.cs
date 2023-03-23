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
    public partial class FrmNhập : Form
    {
        public FrmNhập()
        {
            InitializeComponent();
        }

        private void Btn_TrởLại_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuảnLýNhânViên FrmQuảnLýNhânViên = new FrmQuảnLýNhânViên();
            FrmQuảnLýNhânViên.ShowDialog();
        }
    }
}
