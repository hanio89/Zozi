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
    public partial class FrmQuảnLýKháchHàng : Form
    {
        public FrmQuảnLýKháchHàng()
        {
            InitializeComponent();
        }
        SqlConnection con;
        #region TroLai
        private void Btn_TrởLại_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTrangChủQuảnLý FrmTrangChủQuảnLý = new FrmTrangChủQuảnLý();
            FrmTrangChủQuảnLý.ShowDialog();
        }
        #endregion


        private void FrmQuảnLýKháchHàng_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["R7_ZOZI"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }
        #region HienKH
        public void HienThi()
        {
            string sqlSELECT = "select * from KhachHang";
            SqlCommand cmd= new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DataKhachHang.DataSource= dt;
        }

        #endregion

        #region
        public bool KTThongTin()
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return false;
            }
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKH.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region Thêm
        private void BtnThem_Click(object sender, EventArgs e)
        {
            string sqlINSET = "INSERT INTO KhachHang VALUES (@MaKH,@TenKH)";
            SqlCommand cmd = new SqlCommand(sqlINSET, con);
            cmd.Parameters.AddWithValue("MaKH", txtMaKH.Text);
            cmd.Parameters.AddWithValue("TenKH", txtTenKH.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }
        #endregion

        #region Sửa
        private void BtnSua_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE KhachHang SET TenKH = @TenKH where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("MaKH", txtMaKH.Text);
            cmd.Parameters.AddWithValue("TenKH", txtTenKH.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }
        #endregion

        #region Xóa
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM KhachHang where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("MaKH", txtMaKH.Text);
            cmd.Parameters.AddWithValue("TenKH", txtTenKH.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }
        #endregion


        private void FrmQuảnLýKháchHàng_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        #region Tìm Kiếm

        private void Button1_Click(object sender, EventArgs e)
        {
            string sqlTimKiem = "SELECT * FROM KhachHang where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("MaKH", TxtTimKiem.Text);
            cmd.Parameters.AddWithValue("TenKH", txtTenKH.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DataKhachHang.DataSource = dt;
        }
        #endregion

        #region Reset
        private void Reset()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnReset_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
        #endregion
    }
}
