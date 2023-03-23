using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;

namespace R7_ZOZI
{
    public partial class FrmQuảnLýSảnPhẩm : Form
    {
        public FrmQuảnLýSảnPhẩm()
        {
            InitializeComponent();
        }
        SqlConnection con;

        #region trolai
        private void Btn_TrởLại_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTrangChủQuảnLý FrmTrangChủQuảnLý = new FrmTrangChủQuảnLý();
            FrmTrangChủQuảnLý.ShowDialog();
        }
        #endregion

        private void FrmQuảnLýSảnPhẩm_FormClosing(object sender, FormClosingEventArgs e)
        {
 
            con.Close();
        }


        private void DataHH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmQuảnLýSảnPhẩm_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["R7_ZOZI"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
            HienThi();
        }

        #region HienHH
        public void HienThi()
        {
            string sqlSELECT = "select * from HangHoa";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DataHH.DataSource = dt;
        }

        #endregion

        #region empty
        public bool KTThongTin()
        {
            if (Tb_MãHH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tb_MãHH.Focus();
                return false;
            }
            if (Tb_TênHH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tb_TênHH.Focus();
                return false;
            }
            if (Tb_DVT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tb_DVT.Focus();
                return false;
            }
            if (Tb_DonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tb_DonGia.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region Reset
        private void Reset()
        {
            Tb_MãHH.Text = "";
            Tb_TênHH.Text = "";
            Tb_DVT.Text = "";
            Tb_DonGia.Text = "";
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        #endregion

        #region Thêm
        private void Thêm_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {
                    string sqlINSET = "INSERT INTO HangHoa VALUES (@MaHH,@TenHH,@DVT,@DonGia)";
                    SqlCommand cmd = new SqlCommand(sqlINSET, con);
                    cmd.Parameters.AddWithValue("MaHH", Tb_MãHH.Text);
                    cmd.Parameters.AddWithValue("TenHH", Tb_TênHH.Text);
                    cmd.Parameters.AddWithValue("DVT", Tb_DVT.Text);
                    cmd.Parameters.AddWithValue("DonGia", Tb_DonGia.Text);
                    cmd.ExecuteNonQuery();
                    HienThi();
                    Reset();
                    MessageBox.Show("Đã thêm mới hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion


        #region Sửa
        private void Btn_Sửa_Click(object sender, EventArgs e)
        {
            if (Tb_MãHH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hàng hóa cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tb_MãHH.Focus();
            }
            else if (KTThongTin())
            {
                try
                {
                    string sqlEDIT = "UPDATE HangHoa SET MaHH = @MaHH ,TenHH = @TenHH , DVT = @DVT , DonGia = @DonGia where MaHH = @MaHH";
                    SqlCommand cmd = new SqlCommand(sqlEDIT, con);
                    cmd.Parameters.AddWithValue("MaHH", Tb_MãHH.Text);
                    cmd.Parameters.AddWithValue("TenHH", Tb_TênHH.Text);
                    cmd.Parameters.AddWithValue("DVT", Tb_DVT.Text);
                    cmd.Parameters.AddWithValue("DonGia", Tb_DonGia.Text);
                    cmd.ExecuteNonQuery();
                    HienThi();
                    Reset();
                    MessageBox.Show("Đã sửa hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Xóa
        private void Btn_Xóa_Click(object sender, EventArgs e)
        {
            if (Tb_MãHH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hàng hóa cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tb_MãHH.Focus();
            }
            else
            {
                try
                {
                    string sqlDELETE = "DELETE FROM HangHoa where MaHH = @MaHH";
                    SqlCommand cmd = new SqlCommand(sqlDELETE, con);
                    cmd.Parameters.AddWithValue("MaKH", Tb_MãHH.Text);
                    cmd.Parameters.AddWithValue("TenKH", Tb_TênHH.Text);
                    cmd.Parameters.AddWithValue("DVT", Tb_DVT.Text);
                    cmd.Parameters.AddWithValue("DonGia", Tb_DonGia.Text);
                    cmd.ExecuteNonQuery();
                    HienThi();
                    Reset();
                    MessageBox.Show("Đã xóa hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
