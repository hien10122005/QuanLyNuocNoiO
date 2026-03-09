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

namespace QuanLyNuocNoiO.Nhóm_Hệ_thống
{
    public partial class FormTaiKhoan : Form
    {
        string connectionString = KetNoi.KetNoi.ChuoiKetNoi;
        public FormTaiKhoan()
        {
            InitializeComponent();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    String sql = "@Insert into TaiKhoan (MaTK, MaNV, TenDangNhap, MatKhau, Vai Tro) values (@TK, @NV, @TenDN, @MK, @Vaitro)";
                    SqlCommand cmd = new SqlCommand(sql, conn);


                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
        private void LamMoi()
        {
           
        }
        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM TaiKhoan";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvTaiKhoan.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];

            txtMaTK.Text = row.Cells["MaTK"].Value.ToString();
            cboNhanVien.Text = row.Cells["MaNV"].Value.ToString();
            txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
            txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            cboVaiTro.Text = row.Cells["VaiTro"].Value.ToString();
        }
    }
}

