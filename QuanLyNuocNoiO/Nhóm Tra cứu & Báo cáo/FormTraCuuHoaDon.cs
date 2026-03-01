
using QuanLyNuocNoiO.rdlc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Thêm thư viện này
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNuocNoiO.Nhóm_Tra_cứu___Báo_cáo
{
    public partial class FormTraCuuHoaDon : Form
    {
        // Chuỗi kết nối (Thay đổi "TEN_SERVER" bằng tên SQL Server của bạn)
        string strCon =KetNoi.KetNoi.ChuoiKetNoi;
        SqlConnection sqlCon = null;

        public FormTraCuuHoaDon()
        {
            InitializeComponent();
        }

        private void FormTraCuuHoaDon_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị mặc định cho ComboBox khi load form
            cboThang.SelectedIndex = -1; // Chưa chọn tháng
            cboTrangThai.SelectedIndex = 0; // Mặc định chọn "Tất cả"

            LoadData(); // Hiển thị tất cả hóa đơn khi mở form
        }

        // Hàm tải dữ liệu lên DataGridView
        private void LoadData()
        {
            try
            {
                if (sqlCon == null) sqlCon = new SqlConnection(strCon);

                // Câu lệnh SQL JOIN giữa HoaDon và KhachHang để lấy Tên khách hàng
                string query = @"SELECT h.MaHD, k.HoTen as [Tên Khách Hàng], h.Thang, h.Nam, 
                                 h.SanLuong as [Sản Lượng], h.TongTien as [Tổng Tiền], 
                                 h.NgayLapHD as [Ngày Lập], h.TrangThai as [Trạng Thái]
                                 FROM HoaDon h
                                 INNER JOIN KhachHang k ON h.MaKH = k.MaKH";

                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvHoaDon.DataSource = dt;

                // Tùy chỉnh độ rộng cột nếu cần
                dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý nút Tìm Kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null) sqlCon = new SqlConnection(strCon);

                // Gốc của câu truy vấn
                string query = @"SELECT h.MaHD, k.HoTen as [Tên Khách Hàng], h.Thang, h.Nam, 
                                 h.SanLuong as [Sản Lượng], h.TongTien as [Tổng Tiền], 
                                 h.NgayLapHD as [Ngày Lập], h.TrangThai as [Trạng Thái]
                                 FROM HoaDon h
                                 INNER JOIN KhachHang k ON h.MaKH = k.MaKH
                                 WHERE 1=1"; // Thủ thuật để nối chuỗi AND phía sau dễ dàng

                // Kiểm tra từng điều kiện lọc
                if (!string.IsNullOrEmpty(txtMaHD.Text))
                    query += " AND h.MaHD LIKE '%" + txtMaHD.Text.Trim() + "%'";

                if (!string.IsNullOrEmpty(txtTenKH.Text))
                    query += " AND k.HoTen LIKE N'%" + txtTenKH.Text.Trim() + "%'";

                if (cboThang.SelectedIndex != -1)
                    query += " AND h.Thang = " + cboThang.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(txtNam.Text))
                    query += " AND h.Nam = " + txtNam.Text.Trim();

                if (cboTrangThai.SelectedIndex == 1) // Đã thanh toán
                    query += " AND h.TrangThai = N'Đã thanh toán'";
                else if (cboTrangThai.SelectedIndex == 2) // Chưa thanh toán
                    query += " AND h.TrangThai = N'Chưa thanh toán'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvHoaDon.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        // Xử lý nút Làm Mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            txtTenKH.Clear();
            txtNam.Clear();
            cboThang.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = 0;
            LoadData(); // Load lại toàn bộ
        }

        // Xử lý nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Xử lý nút In Hóa Đơn (Placeholder)
        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Lấy mã hóa đơn từ dòng đang được chọn trong bảng
                string maHD = dgvHoaDon.CurrentRow.Cells["MaHD"].Value.ToString();

                // 3. Tạo một thể hiện (instance) của FormInHoaDon và truyền mã hóa đơn vào
                // Đảm bảo bạn đã có using cho namespace chứa FormInHoaDon
                // Ví dụ: using QuanLyNuocNoiO.Nhóm_Nghiệp_vụ;
                FormInHoaDon formIn = new FormInHoaDon(maHD);

                // 4. Hiển thị form in hóa đơn
                // ShowDialog() sẽ làm cho form này nổi lên trên và người dùng phải đóng nó mới thao tác được form cũ
                formIn.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi chuẩn bị in hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTraCuuHoaDon_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * h.MaHD, k.HoTen as [Tên Khách Hàng], h.Thang, h.Nam, 
                                 h.SanLuong as [Sản Lượng], h.TongTien as [Tổng Tiền], 
                                 h.NgayLapHD as [Ngày Lập], h.TrangThai as [Trạng Thái]
             */
            if (e.RowIndex < 0)
                {
                return; // Nếu click vào header hoặc ngoài vùng dữ liệu, không làm gì
            }
            DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
            txtMaHD.Text = row.Cells["MaHD"].Value.ToString();
           txtTenKH.Text = row.Cells["Tên Khách Hàng"].Value.ToString();
            cboThang.SelectedItem = row.Cells["Thang"].Value.ToString();
            txtNam.Text = row.Cells["Nam"].Value.ToString();
            cboTrangThai.SelectedItem = row.Cells["Trạng Thái"].Value.ToString();




        }
    }
}
