using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyNuocNoiO.Nhóm_Hệ_thống
{
    public partial class FormTaiKhoan : Form
    {
        string connectionString = KetNoi.KetNoi.ChuoiKetNoi;
        public FormTaiKhoan()
        {
            InitializeComponent();
        }
        void LoadDataTaiKhoan()
        {
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "SELECT * FROM TaiKhoan";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTaiKhoan.DataSource = dt;
        }
        void LoadNhanVien()
        {
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "SELECT MaNV FROM NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboNhanVien.DataSource = dt;
            cboNhanVien.DisplayMember = "MaNV";
        }
       public void LoadTrangThai()
        {
            cboTrangThai.Items.Add("Hoạt động");
           cboTrangThai.Items.Add("Khóa");

        }
        void LoadVaiTro()
        {
            cboVaiTro.Items.Add("Admin");
            cboVaiTro.Items.Add("Nhan Vien");

        }
        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadDataTaiKhoan();
            LoadVaiTro();
            LoadTrangThai();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                { 
                    con.Open();
                    string sql = "INSERT INTO TaiKhoan (MaTK, TenDangNhap, MatKhau, MaNV, VaiTro,TrangThai,NgayTao) " +
                        "VALUES (@MaTK, @TenDangNhap, @MatKhau, @MaNV, @VaiTro,@TrangThai,@NgayTao)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@MaTK", txtMaTK.Text);
                    cmd.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                    cmd.Parameters.AddWithValue("@MaNV", cboNhanVien.Text);
                    cmd.Parameters.AddWithValue("@VaiTro", cboVaiTro.Text);
                    cmd.Parameters.AddWithValue("@TrangThai", cboTrangThai.Text);
                    cmd.Parameters.AddWithValue("@NgayTao", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm tài khoản thành công!");
                    LoadDataTaiKhoan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string sql = "Update TaiKhoan Set TenDangNhap =@TenDangNhap , MatKhau= @MatKhau ,VaiTro =@VaiTro ,TrangThai =@TrangThai Where MaTK = @MaTK  ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@MaTK", txtMaTK.Text);
                    cmd.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                    cmd.Parameters.AddWithValue("@MaNV", cboNhanVien.Text);
                    cmd.Parameters.AddWithValue("@VaiTro", cboVaiTro.Text);
                    cmd.Parameters.AddWithValue("@TrangThai", cboTrangThai.Text);
                    cmd.Parameters.AddWithValue("@NgayTao", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm tài khoản thành công!");
                    LoadDataTaiKhoan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string sql = "DELETE From TaiKhoan Where MaTK = @MaTK  ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@MaTK", txtMaTK.Text);             
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoa tài khoản thành công!");
                    LoadDataTaiKhoan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTK.Text = "";
            txtMatKhau.Text = "";
            txtTenDangNhap.Text = "";
            cboNhanVien.Text = null;
            cboVaiTro.Text = null;
            cboTrangThai.Text = null;
        }

       

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                txtMaTK.Text = row.Cells["MaTK"].Value.ToString();
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                cboNhanVien.Text = row.Cells["MaNV"].Value.ToString();
                cboVaiTro.Text = row.Cells["VaiTro"].Value.ToString();
                cboTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
            }
        }
    }
}
