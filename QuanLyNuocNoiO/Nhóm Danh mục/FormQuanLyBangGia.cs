using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNuocNoiO.Nhóm_Danh_mục
{
    public partial class FormQuanLyBangGia : Form
    {
        string connectionString = KetNoi.KetNoi.ChuoiKetNoi;

        public FormQuanLyBangGia()
        {
            InitializeComponent();
        }

        // ================= LOAD FORM =================
        private void FormQuanLyBangGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // ================= LOAD DATA (DÙNG ADAPTER) =================
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM BangGia";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvBangGia.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // ================= CLICK GRID =================
        private void dgvBangGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvBangGia.Rows[e.RowIndex];

            txtMaBangGia.Text = row.Cells["MaBangGia"].Value?.ToString();
            txtTenBangGia.Text = row.Cells["TenBangGia"].Value?.ToString();
            txtBacTu.Text = row.Cells["BacTu"].Value?.ToString();
            txtBacDen.Text = row.Cells["BacDen"].Value?.ToString();
            txtDonGia.Text = row.Cells["DonGia"].Value?.ToString();

            if (row.Cells["NgayApDung"].Value != null)
                dtpNgayApDung.Value = Convert.ToDateTime(row.Cells["NgayApDung"].Value);
        }

        // ================= THÊM (DÙNG COMMAND) =================
        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"INSERT INTO BangGia
                                   (MaBangGia, TenBangGia, BacTu, BacDen, DonGia, NgayApDung)
                                   VALUES (@Ma, @Ten, @BacTu, @BacDen, @DonGia, @Ngay)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@Ma", txtMaBangGia.Text);
                    cmd.Parameters.AddWithValue("@Ten", txtTenBangGia.Text);
                    cmd.Parameters.AddWithValue("@BacTu", Convert.ToDecimal(txtBacTu.Text));

                    if (string.IsNullOrWhiteSpace(txtBacDen.Text))
                        cmd.Parameters.AddWithValue("@BacDen", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@BacDen", Convert.ToDecimal(txtBacDen.Text));

                    cmd.Parameters.AddWithValue("@DonGia", Convert.ToDecimal(txtDonGia.Text));
                    cmd.Parameters.AddWithValue("@Ngay", dtpNgayApDung.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm thành công!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        // ================= SỬA =================
        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"UPDATE BangGia SET
                                   TenBangGia = @Ten,
                                   BacTu = @BacTu,
                                   BacDen = @BacDen,
                                   DonGia = @DonGia,
                                   NgayApDung = @Ngay
                                   WHERE MaBangGia = @Ma";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@Ma", txtMaBangGia.Text);
                    cmd.Parameters.AddWithValue("@Ten", txtTenBangGia.Text);
                    cmd.Parameters.AddWithValue("@BacTu", Convert.ToDecimal(txtBacTu.Text));

                    if (string.IsNullOrWhiteSpace(txtBacDen.Text))
                        cmd.Parameters.AddWithValue("@BacDen", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@BacDen", Convert.ToDecimal(txtBacDen.Text));

                    cmd.Parameters.AddWithValue("@DonGia", Convert.ToDecimal(txtDonGia.Text));
                    cmd.Parameters.AddWithValue("@Ngay", dtpNgayApDung.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sửa thành công!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        // ================= XÓA =================
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBangGia.Text))
            {
                MessageBox.Show("Chọn dòng cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa?",
                "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "DELETE FROM BangGia WHERE MaBangGia = @Ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Ma", txtMaBangGia.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

        // ================= LƯU (KHÔNG CẦN NỮA) =================
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu trực tiếp vào CSDL, không cần nút Lưu nữa.");
        }
    }
}