
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace R7_ZOZI
{
    public partial class FrmĐăngNhập : Form
    {
        public FrmĐăngNhập()
        {
            InitializeComponent();
        }

        readonly SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-P0CJE6B4\SQLEXPRESS;Initial Catalog=QuanLyBanHangZoziCoffee;Integrated Security=True");

        private void FrmĐăngNhập_Load(object sender, EventArgs e)
        {
        }
        #region  ẩn mk
        private void Pb_Hide_Click(object sender, EventArgs e)
        {
            if (Tb_mk.PasswordChar == '*')
            {
                Pb_eye.BringToFront();
                Tb_mk.PasswordChar = '\0';
            }
        }

        private void Pb_eye_Click(object sender, EventArgs e)
        {
            if (Tb_mk.PasswordChar == '\0')
            {
                Pb_Hide.BringToFront();
                Tb_mk.PasswordChar = '*';
            }
        }
        #endregion
        private void Btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (Rbtn_QL.Checked == true)
            {
                conn.Open();
                try
                {

                    string taikhoan = Tb_tk.Text;
                    string matkhau = Tb_mk.Text;
                    string query = "Select * from TK_QL where TenDangNhap='" + taikhoan + "' and MatKhau='" + matkhau + "'";
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmTrangChủQuảnLý FrmTrangChủQuảnLý = new FrmTrangChủQuảnLý();
                        FrmTrangChủQuảnLý.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng Nhập Thất Bại. Vui Lòng Kiểm Tra Lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();

            }
            else if (Rbtn_NV.Checked == true)
            {
                conn.Open();
                try
                {
                    string taikhoan = Tb_tk.Text;
                    string matkhau = Tb_mk.Text;
                    string query = "Select * from TK_NV where TenDangNhap='" + taikhoan + "' and MatKhau='" + matkhau + "'";
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmTrangChủNhânViên FrmTrangChủNhânViên = new FrmTrangChủNhânViên();
                        FrmTrangChủNhânViên.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng Nhập Thất Bại. Vui Lòng Kiểm Tra Lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //conn.Close();
            }
            else
            {
                MessageBox.Show("Chưa Chọn Chức Vụ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }
    }
}
