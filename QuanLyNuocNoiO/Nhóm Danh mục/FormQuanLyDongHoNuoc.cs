// DÁN TOÀN BỘ CODE NÀY VÀO FILE FormQuanLyDongHoNuoc.cs

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNuocNoiO.Nhóm_Danh_mục
{
    public partial class FormQuanLyDongHoNuoc : Form
    {
        // !!! THAY THẾ CHUỖI KẾT NỐI BẰNG CỦA BẠN !!!
        private string connectionString = KetNoi.KetNoi.ChuoiKetNoi;

        private bool isAdding = false;

        public FormQuanLyDongHoNuoc()
        {
            InitializeComponent();
        }

        private void FormQuanLyDongHoNuoc_Load(object sender, EventArgs e)
        {
            LoadKhachHangComboBox();
            SetupTrangThaiComboBox();
            LoadData();
            SetButtonStates(true);
        }

        #region CÁC HÀM TIỆN ÍCH VÀ TẢI DỮ LIỆU
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"SELECT 
                                     dh.MaDongHo, kh.HoTen, dh.MaKH, dh.SoSeri, 
                                     dh.ViTriLapDat, dh.NgayLapDat, dh.NgayKiemDinh, dh.TrangThai 
                                 FROM DongHoNuoc dh
                                 JOIN KhachHang kh ON dh.MaKH = kh.MaKH";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDongHo.DataSource = dt;
                    FormatGrid(); // Gọi hàm định dạng cột
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
        }

        // Hàm định dạng tên cột cho DataGridView
        private void FormatGrid()
        {
            if (dgvDongHo.Columns.Count > 0)
            {
                dgvDongHo.Columns["MaDongHo"].HeaderText = "Mã Đồng Hồ";
                dgvDongHo.Columns["HoTen"].HeaderText = "Tên Khách Hàng";
                dgvDongHo.Columns["MaKH"].Visible = false; // Ẩn cột mã khách hàng đi
                dgvDongHo.Columns["SoSeri"].HeaderText = "Số Seri";
                dgvDongHo.Columns["ViTriLapDat"].HeaderText = "Vị Trí";
                dgvDongHo.Columns["NgayLapDat"].HeaderText = "Ngày Lắp Đặt";
                dgvDongHo.Columns["NgayKiemDinh"].HeaderText = "Ngày Kiểm Định";
                dgvDongHo.Columns["TrangThai"].HeaderText = "Trạng Thái";
            }
        }

        private void LoadKhachHangComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT MaKH, HoTen FROM KhachHang", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cboKhachHang.DataSource = dt;
                    cboKhachHang.DisplayMember = "HoTen";
                    cboKhachHang.ValueMember = "MaKH";
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải danh sách khách hàng: " + ex.Message); }
        }

        private void SetupTrangThaiComboBox()
        {
            cboTrangThai.Items.Add("Hoạt động");
            cboTrangThai.Items.Add("Hỏng");
            cboTrangThai.Items.Add("Ngừng sử dụng");
            cboTrangThai.SelectedIndex = 0;
        }

         void XoaThongTin()
        {
            txtMaDongHo.Text = "";
            txtSoSeri.Text = "";
            txtViTri.Text = "";
            if (cboKhachHang.Items.Count > 0) cboKhachHang.SelectedIndex = 0;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;
            dtpNgayLapDat.Value = DateTime.Now;
            dtpNgayKiemDinh.Value = DateTime.Now;
        }

         void SetButtonStates(bool isInitialState)
        {
            btnThem.Enabled = isInitialState;
            btnSua.Enabled = isInitialState;
            btnXoa.Enabled = isInitialState;
            dgvDongHo.Enabled = isInitialState;

            btnLuu.Enabled = !isInitialState;// Chỉ cho phép lưu khi đang ở trạng thái thêm/sửa
            btnLamMoi.Text = isInitialState ? "Làm mới" : "Hủy"; // Đổi tên nút làm mới thành hủy khi đang ở trạng thái thêm/sửa
            grpThongTin.Enabled = !isInitialState;
        }
        #endregion

        #region CÁC SỰ KIỆN
        private void DgvDongHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDongHo.Rows[e.RowIndex];
                txtMaDongHo.Text = row.Cells["MaDongHo"].Value.ToString();
                txtSoSeri.Text = row.Cells["SoSeri"].Value.ToString();
                txtViTri.Text = row.Cells["ViTriLapDat"].Value.ToString();
                cboKhachHang.SelectedValue = row.Cells["MaKH"].Value;
                cboTrangThai.SelectedItem = row.Cells["TrangThai"].Value.ToString();
                dtpNgayLapDat.Value = Convert.ToDateTime(row.Cells["NgayLapDat"].Value);
                if (row.Cells["NgayKiemDinh"].Value != DBNull.Value)
                    dtpNgayKiemDinh.Value = Convert.ToDateTime(row.Cells["NgayKiemDinh"].Value);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;// Đang ở trạng thái thêm mới
            XoaThongTin();// Xóa hết thông tin cũ trên form để nhập thông tin mới
            SetButtonStates(false);// Cho phép nhập thông tin đồng hồ mới
            txtMaDongHo.Enabled = true;// Mã đồng hồ được phép nhập khi thêm mới
            txtMaDongHo.Focus();// Cho phép nhập mã đồng hồ khi thêm mới
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvDongHo.SelectedRows.Count == 0) // Nếu chưa chọn dòng nào thì không làm gì cả
                return;
            isAdding = false;// Đang ở trạng thái chỉnh sửa
            SetButtonStates(false);// Cho phép chỉnh sửa thông tin đồng hồ
            txtMaDongHo.Enabled = false;// Mã đồng hồ không được sửa khi chỉnh sửa
            cboKhachHang.Focus();// Cho phép chọn khách hàng khi sửa đồng hồ
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDongHo.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Bạn có chắc muốn xóa đồng hồ này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM DongHoNuoc WHERE MaDongHo = @MaDH", conn);
                        cmd.Parameters.AddWithValue("@MaDH", txtMaDongHo.Text);
                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                    XoaThongTin ();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi khi xóa: " + ex.Message); }
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDongHo.Text) || string.IsNullOrWhiteSpace(txtSoSeri.Text) || cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Mã đồng hồ, số seri và khách hàng không được để trống.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = isAdding
                        ? "INSERT INTO DongHoNuoc(MaDongHo, MaKH, SoSeri, ViTriLapDat, NgayLapDat, NgayKiemDinh, TrangThai) VALUES(@MaDH, @MaKH, @SoSeri, @ViTri, @NgayLD, @NgayKD, @TrangThai)"
                        : "UPDATE DongHoNuoc SET MaKH = @MaKH, SoSeri = @SoSeri, ViTriLapDat = @ViTri, NgayLapDat = @NgayLD, NgayKiemDinh = @NgayKD, TrangThai = @TrangThai WHERE MaDongHo = @MaDH";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDH", txtMaDongHo.Text);
                        cmd.Parameters.AddWithValue("@MaKH", cboKhachHang.SelectedValue);
                        cmd.Parameters.AddWithValue("@SoSeri", txtSoSeri.Text);
                        cmd.Parameters.AddWithValue("@ViTri", txtViTri.Text);
                        cmd.Parameters.AddWithValue("@NgayLD", dtpNgayLapDat.Value);
                        cmd.Parameters.AddWithValue("@NgayKD", dtpNgayKiemDinh.Value);
                        cmd.Parameters.AddWithValue("@TrangThai", cboTrangThai.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Lưu thành công!", "Thông báo");
                LoadData();
                SetButtonStates(true);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi khi lưu: " + ex.Message); }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            if (btnLamMoi.Text == "Hủy")
            {
                SetButtonStates(true);
                if (dgvDongHo.SelectedRows.Count > 0)
                    DgvDongHo_CellClick(null, new DataGridViewCellEventArgs(0, dgvDongHo.CurrentRow.Index));
            }
            else
            {
                LoadData();
                XoaThongTin();
            }
        }
        #endregion
    }
}