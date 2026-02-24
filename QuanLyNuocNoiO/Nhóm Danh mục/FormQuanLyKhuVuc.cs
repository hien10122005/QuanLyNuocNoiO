// DÁN TOÀN BỘ CODE NÀY VÀO FILE FormQuanLyKhuVuc.cs

using QuanLyNuocNoiO.KetNoi;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNuocNoiO.Nhóm_Danh_mục
{
    public partial class FormQuanLyKhuVuc : Form
    {
        // THAY THẾ CHUỖI KẾT NỐI NÀY BẰNG CỦA BẠN
        string connectionString = KetNoi.KetNoi.ChuoiKetNoi;

        // Cờ để xác định đang ở chế độ Thêm mới hay Sửa
        bool isAdding = false;

        public FormQuanLyKhuVuc()
        {
            InitializeComponent();
        }

        private void FormQuanLyKhuVuc_Load(object sender, EventArgs e)
        {
            LoadData();
            SetButtonStates(true); // Trạng thái ban đầu
        }

        // --- CÁC HÀM XỬ LÝ DỮ LIỆU ---

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(KetNoi.KetNoi.ChuoiKetNoi))
                {
                    conn.Open();
                    string query = "SELECT MaKhuVuc, TenKhuVuc, MoTa FROM KhuVuc";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvKhuVuc.DataSource = dt;

                    // Đặt lại tên cột cho dễ nhìn
                    dgvKhuVuc.Columns["MaKhuVuc"].HeaderText = "Mã Khu Vực";
                    dgvKhuVuc.Columns["TenKhuVuc"].HeaderText = "Tên Khu Vực";
                    dgvKhuVuc.Columns["MoTa"].HeaderText = "Mô Tả";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            txtMaKhuVuc.Text = "";
            txtTenKhuVuc.Text = "";
            txtMoTa.Text = "";
        }

        private void SetButtonStates(bool trangthai)
        {
            btnThem.Enabled = trangthai;
            btnSua.Enabled = trangthai;
            btnXoa.Enabled = trangthai;
            txtTimKiem.Enabled = trangthai;
            dgvKhuVuc.Enabled = trangthai;

            btnLuu.Enabled = !trangthai;
            btnLamMoi.Text = trangthai ? "Làm mới" : "Hủy";

            grpThongTin.Enabled = !trangthai;
        }

        // --- SỰ KIỆN CLICK VÀO LƯỚI ---

        private void DgvKhuVuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo người dùng click vào một dòng hợp lệ
            {
                DataGridViewRow row = dgvKhuVuc.Rows[e.RowIndex];
                txtMaKhuVuc.Text = row.Cells["MaKhuVuc"].Value.ToString();
                txtTenKhuVuc.Text = row.Cells["TenKhuVuc"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
            }
        }

        // --- SỰ KIỆN CỦA CÁC NÚT BẤM ---

        private void BtnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearTextBoxes();
            SetButtonStates(false);
            txtMaKhuVuc.Enabled = true;
            txtMaKhuVuc.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhuVuc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khu vực để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdding = false;
            SetButtonStates(false);
            txtMaKhuVuc.Enabled = false; // Không cho sửa khóa chính
            txtTenKhuVuc.Focus();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhuVuc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khu vực để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maKV = txtMaKhuVuc.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khu vực '" + maKV + "' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM KhuVuc WHERE MaKhuVuc = @MaKV";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaKV", maKV);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            string maKV = txtMaKhuVuc.Text.Trim();
            string tenKV = txtTenKhuVuc.Text.Trim();
            string moTa = txtMoTa.Text.Trim();

            if (string.IsNullOrEmpty(maKV) || string.IsNullOrEmpty(tenKV))
            {
                MessageBox.Show("Mã và Tên khu vực không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "";
                    if (isAdding)
                    {
                        // Thêm mới
                        query = "INSERT INTO KhuVuc (MaKhuVuc, TenKhuVuc, MoTa) VALUES (@MaKV, @TenKV, @MoTa)";
                    }
                    else
                    {
                        // Cập nhật
                        query = "UPDATE KhuVuc SET TenKhuVuc = @TenKV, MoTa = @MoTa WHERE MaKhuVuc = @MaKV";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKV", maKV);
                        cmd.Parameters.AddWithValue("@TenKV", tenKV);
                        cmd.Parameters.AddWithValue("@MoTa", moTa);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                SetButtonStates(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            if (btnLamMoi.Text == "Hủy")
            {
                // Nếu đang ở chế độ Thêm/Sửa, nút này sẽ là Hủy
                SetButtonStates(true);
                // Hiển thị lại dữ liệu của dòng đang chọn (nếu có)
                if (dgvKhuVuc.SelectedRows.Count > 0)
                {
                    DgvKhuVuc_CellClick(dgvKhuVuc, new DataGridViewCellEventArgs(0, dgvKhuVuc.CurrentRow.Index));
                }
                else
                {
                    ClearTextBoxes();
                }
            }
            else
            {
                // Nếu ở trạng thái bình thường, nút này là Làm mới
                LoadData();
                ClearTextBoxes();
                txtTimKiem.Text = "";
            }
        }

        // --- SỰ KIỆN TÌM KIẾM ---
        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Lấy nội dung mà người dùng đang gõ vào ô tìm kiếm
            string tuKhoa = txtTimKiem.Text.Trim();

            //Tạo câu lệnh SQL để tìm kiếm
            // Dấu '%' là ký tự đại diện, nghĩa là "bất kỳ chuỗi ký tự nào"
            // Ví dụ: Nếu bạn gõ "Tân", câu lệnh sẽ tìm tất cả các khu vực có tên chứa chữ "Tân"
            string query = "SELECT MaKhuVuc, TenKhuVuc, MoTa FROM KhuVuc " +
                           "WHERE TenKhuVuc LIKE '%' + @TuKhoa + '%' OR MaKhuVuc LIKE '%' + @TuKhoa + '%'";

            try
            {
                // Kết nối đến CSDL và thực thi câu lệnh
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Sử dụng SqlDataAdapter để lấy dữ liệu về
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        // Thêm tham số @TuKhoa để tránh lỗi SQL Injection (bảo mật)
                        adapter.SelectCommand.Parameters.AddWithValue("@TuKhoa", tuKhoa);

                        // Đổ dữ liệu tìm được vào một bảng tạm (DataTable)
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Hiển thị kết quả lên DataGridView
                        dgvKhuVuc.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}