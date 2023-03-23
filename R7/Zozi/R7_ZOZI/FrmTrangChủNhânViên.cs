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
    public partial class FrmTrangChủNhânViên : Form
    {
        public FrmTrangChủNhânViên()
        {
            InitializeComponent();
        }
        private void Btn_ĐăngXuất_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmĐăngNhập FrmĐăngNhập = new FrmĐăngNhập();
            FrmĐăngNhập.ShowDialog();
        }

        private void Btn_Bán_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBán FrmBán = new FrmBán();
            FrmBán.ShowDialog();
        }

        private void Btn_Nhập_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNhập FrmNhập = new FrmNhập();
            FrmNhập.ShowDialog();
        }
        private void Btn_HàngHóa_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHàngHóa FrmHàngHóa = new FrmHàngHóa();
            FrmHàngHóa.ShowDialog();
        }
        private void Btn_NhàCungCấp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNhàCungCấp FrmNhàCungCấp = new FrmNhàCungCấp();
            FrmNhàCungCấp.ShowDialog();
        }

        private void FrmTrangChủNhânViên_Load(object sender, EventArgs e)
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
