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
    public partial class FrmTrangChủQuảnLý : Form
    {
        public FrmTrangChủQuảnLý()
        {
            InitializeComponent();
        }
        private void Btn_ĐăngXuất_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmĐăngNhập FrmĐăngNhập = new FrmĐăngNhập();
            FrmĐăngNhập.ShowDialog();
        }

        private void Btn_QL_NV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuảnLýNhânViên FrmQuảnLýNhânViên = new FrmQuảnLýNhânViên();
            FrmQuảnLýNhânViên.ShowDialog();
        }
        private void Btn_QL_KH_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuảnLýKháchHàng FrmQuảnLýKháchHàng = new FrmQuảnLýKháchHàng();
            FrmQuảnLýKháchHàng.ShowDialog();
        }

        private void Btn_QL_SP_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuảnLýSảnPhẩm FrmQuảnLýSảnPhẩm = new FrmQuảnLýSảnPhẩm();
            FrmQuảnLýSảnPhẩm.ShowDialog();
        }

        private void Btn_QL_NCC_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuảnLýNhàCungCấp FrmQuảnLýHàngHóa = new FrmQuảnLýNhàCungCấp();
            FrmQuảnLýHàngHóa.ShowDialog();
        }

        private void FrmTrangChủQuảnLý_Load(object sender, EventArgs e)
        {

        }

        private void Btn_ĐăngXuất_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmĐăngNhập FrmĐăngNhập = new FrmĐăngNhập();
            FrmĐăngNhập.ShowDialog();
        }
    }
}
