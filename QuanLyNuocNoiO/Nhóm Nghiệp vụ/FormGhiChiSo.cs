using QuanLyNuocNoiO.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNuocNoiO.Nhóm_Nghiệp_vụ
{
    public partial class FormGhiChiSo : Form
    {
        string strCon = KetNoi.KetNoi.ChuoiKetNoi;
        string maDongHoDangChon = "";
        int chiSoCu = 0;

        // Giả sử bạn có biến toàn cục lưu mã nhân viên đang đăng nhập
        // string maNhanVienDangNhap = "NV001"; 

        public FormGhiChiSo()
        {
            InitializeComponent();
        }

        private void FormGhiChiSo_Load(object sender, EventArgs e)
        {
            LoadThang();
            LoadNam();
            LoadKhuVuc();
        }

        void LoadThang()
        {
            cboThang.Items.Clear();
            for (int i = 1; i <= 12; i++) cboThang.Items.Add(i);
            cboThang.SelectedItem = DateTime.Now.Month;
        }

        void LoadNam()
        {
            txtNam.Text = DateTime.Now.Year.ToString();
        }

        void LoadKhuVuc()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    string sql = "SELECT MaKhuVuc, TenKhuVuc FROM KhuVuc";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboKhuVuc.DataSource = dt;
                    cboKhuVuc.DisplayMember = "TenKhuVuc";
                    cboKhuVuc.ValueMember = "MaKhuVuc";
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải khu vực: " + ex.Message); }
        }
        int LayChiSoCu(string maDongHo, int thang, int nam)
        {
            int chiSo = 0;
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                // Truy vấn tìm chỉ số mới của kỳ gần nhất (tháng trước hoặc năm trước)
                string sql = @"
            SELECT TOP 1 ChiSoMoi 
            FROM ChiSo 
            WHERE MaDongHo = @MaDongHo 
              AND (Nam < @Nam OR (Nam = @Nam AND Thang < @Thang))
            ORDER BY Nam DESC, Thang DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaDongHo", maDongHo);
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@Nam", nam);

                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    chiSo = Convert.ToInt32(result);
                }
            }
            return chiSo;
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (cboKhuVuc.SelectedValue == null) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    // Truy vấn lấy danh sách đồng hồ và chỉ số cũ nhất (chỉ số mới của kỳ gần nhất)
                    string sql = @"
                            SELECT 
                                dh.MaDongHo, 
                                kh.HoTen, 
                                kh.DiaChi,
                                -- Logic lấy chỉ số cũ chuẩn:
                                ISNULL(
                                    cs_hien_tai.ChiSoCu, 
                                    ISNULL((
                                        SELECT TOP 1 ChiSoMoi 
                                        FROM ChiSo 
                                        WHERE MaDongHo = dh.MaDongHo 
                                          AND (Nam < @Nam OR (Nam = @Nam AND Thang < @Thang))
                                        ORDER BY Nam DESC, Thang DESC
                                    ), 0)
                                ) AS ChiSoCu,
                                ISNULL(cs_hien_tai.ChiSoMoi, 0) AS ChiSoMoi
                            FROM DongHoNuoc dh
                            JOIN KhachHang kh ON dh.MaKH = kh.MaKH
                            LEFT JOIN ChiSo cs_hien_tai ON dh.MaDongHo = cs_hien_tai.MaDongHo 
                                                        AND cs_hien_tai.Thang = @Thang 
                                                        AND cs_hien_tai.Nam = @Nam
                            WHERE kh.MaKhuVuc = @MaKhuVuc
                              AND dh.TrangThai = N'Đang dùng'";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Thang", int.Parse(cboThang.Text));
                    cmd.Parameters.AddWithValue("@Nam", int.Parse(txtNam.Text));
                    cmd.Parameters.AddWithValue("@MaKhuVuc", cboKhuVuc.SelectedValue);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDanhSachGhi.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi hiển thị: " + ex.Message); }
        }

        private void dgvDanhSachGhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvDanhSachGhi.Rows[e.RowIndex];

            // 1. Gán thông tin cơ bản
            maDongHoDangChon = row.Cells["MaDongHo"].Value.ToString();
            lblDongHoValue.Text = maDongHoDangChon;
            lblKhachHangValue.Text = row.Cells["HoTen"].Value.ToString();

            // 2. Lấy chỉ số cũ (Lấy chính xác con số đang hiển thị trên Grid)
            // Giả sử cột trên Grid bạn đặt tên là "ChiSoCu"
            chiSoCu = Convert.ToInt32(row.Cells["ChiSoCu"].Value);
            lblChiSoSu.Text = chiSoCu.ToString(); // Gán lên nhãn bên phải

            // 3. (Tùy chọn) Nếu đã có chỉ số mới trong tháng này rồi, hiển thị lên để sửa
            // Nếu bạn muốn gõ mới hoàn toàn thì để trống txtChiSoMoi
            txtChiSoMoi.Clear();
        }

        string TaoMaChiSo(SqlConnection conn)
        {
            // Câu SQL: lấy số lớn nhất phía sau tiền tố CS
            string sql = @" SELECT MAX(CAST(SUBSTRING(MaChiSo, 3, 10) AS INT)) FROM ChiSo WHERE MaChiSo LIKE 'CS%'";

            SqlCommand cmd = new SqlCommand(sql, conn);

            object result = cmd.ExecuteScalar(); // Kết quả sẽ là số lớn nhất phía sau CS, hoặc null nếu chưa có dòng nào

            int so;

            // Nếu bảng chưa có dữ liệu
            if (result == null || result == DBNull.Value)
            {
                so = 1; // bắt đầu từ 1
            }
            else
            {
                so = Convert.ToInt32(result) + 1; // tăng lên 1
            }

            // Ghép lại thành mã dạng CS0001
            string maMoi = "CS" + so.ToString("D4");

            return maMoi;
        }
        // Hàm kiểm tra tính hợp lệ của chỉ số mới trước khi lưu
        bool KiemTraChiSoMoiHopLe()
        {
            if (string.IsNullOrWhiteSpace(txtChiSoMoi.Text)) // Kiểm tra nếu chưa nhập chỉ số mới
            {
                MessageBox.Show("Vui lòng nhập chỉ số mới!");
                txtChiSoMoi.Focus();
                return false;
            }

            if (!int.TryParse(txtChiSoMoi.Text, out int chiSoMoiNhap)) // Kiểm tra nếu chỉ số mới không phải là số
            {
                MessageBox.Show("Chỉ số mới phải là số!");
                txtChiSoMoi.Focus();
                return false;
            }

            if (chiSoMoiNhap <= chiSoCu) // Kiểm tra nếu chỉ số mới không lớn hơn chỉ số cũ
            {
                MessageBox.Show("Chỉ số mới phải lớn hơn chỉ số cũ!");
                txtChiSoMoi.Focus();
                return false;
            }

            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraChiSoMoiHopLe())
                return;

            int chiSoMoi = int.Parse(txtChiSoMoi.Text);
            int sanLuong = chiSoMoi - chiSoCu;


            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                // Kiểm tra xem tháng/năm này đã có dòng nào trong bảng ChiSo chưa
                string sqlCheck = "SELECT COUNT(*) FROM ChiSo WHERE MaDongHo=@MaDongHo AND Thang=@Thang AND Nam=@Nam";
                SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                cmdCheck.Parameters.AddWithValue("@MaDongHo", maDongHoDangChon);
                cmdCheck.Parameters.AddWithValue("@Thang", cboThang.Text);
                cmdCheck.Parameters.AddWithValue("@Nam", txtNam.Text);
                int exists = (int)cmdCheck.ExecuteScalar();

                string sql;
                if (exists == 0) // Nếu chưa có thì INSERT
                {
                    sql = @"INSERT INTO ChiSo 
                            (MaChiSo, MaDongHo, MaNV, Thang, Nam, ChiSoCu, ChiSoMoi, SanLuong, NgayGhi, GhiChu)
                            VALUES 
                            (@MaChiSo, @MaDongHo, @MaNV, @Thang, @Nam, @ChiSoCu, @ChiSoMoi, @SanLuong, GETDATE(), @GhiChu)";
                }
                else // Nếu có rồi thì UPDATE
                {
                    sql = @"UPDATE ChiSo SET ChiSoCu=@ChiSoCu, ChiSoMoi=@ChiSoMoi, SanLuong=@SanLuong, NgayGhi=GETDATE() 
                    WHERE MaDongHo=@MaDongHo AND Thang=@Thang AND Nam=@Nam";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                if (exists == 0) 
                cmd.Parameters.AddWithValue("@MaChiSo", TaoMaChiSo(conn));
                cmd.Parameters.AddWithValue("@MaDongHo", maDongHoDangChon);
                cmd.Parameters.AddWithValue("@MaNv", ThongTinNhanVien.MaNhanVien); // Thay bằng mã nhân viên thực tế đang đăng nhập
                cmd.Parameters.AddWithValue("@Thang", cboThang.Text);
                cmd.Parameters.AddWithValue("@Nam", txtNam.Text);
                cmd.Parameters.AddWithValue("@ChiSoCu", chiSoCu); // Giá trị 116 sẽ được lưu vào đây
                cmd.Parameters.AddWithValue("@ChiSoMoi", chiSoMoi);
                cmd.Parameters.AddWithValue("@SanLuong", sanLuong); // Giá trị hiệu số sẽ được lưu vào đây
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu dữ liệu thành công!");
                btnHienThi.PerformClick();
            }
        }
        // Chỉ cho phép nhập số vào txtChiSoMoi
        private void txtChiSoMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}