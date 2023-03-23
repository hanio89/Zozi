using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R7_ZOZI
{
    public partial class FrmQuảnLýNhânViên : Form
    {
        public FrmQuảnLýNhânViên()
        {
            InitializeComponent();
        }

        private void Btn_TrởLại_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTrangChủQuảnLý FrmTrangChủQuảnLý = new FrmTrangChủQuảnLý();
            FrmTrangChủQuảnLý.ShowDialog();
        }


    }
}
