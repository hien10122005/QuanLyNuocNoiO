
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyNuocNoiO.Nhóm_Tra_cứu___Báo_cáo
{
    public partial class FormBaoCaoTieuThu : Form
    {
        // !!! THAY THẾ CHUỖI KẾT NỐI NÀY BẰNG CỦA BẠN !!!
        private string connectionString = KetNoi.KetNoi.ChuoiKetNoi;

        public FormBaoCaoTieuThu()
        {
            InitializeComponent();
        }
        void LoadDuLieu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // lấy tháng năm hiện tại
                    int thang = DateTime.Now.Month;
                    int nam = DateTime.Now.Year;

                    string query = @"
                SELECT 
                    kv.MaKhuVuc,
                    kv.TenKhuVuc,
                    SUM(c.SanLuong) AS TongSanLuong
                FROM ChiSo c
                JOIN DongHoNuoc dh ON c.MaDongHo = dh.MaDongHo
                JOIN KhachHang kh ON dh.MaKH = kh.MaKH
                JOIN KhuVuc kv ON kh.MaKhuVuc = kv.MaKhuVuc             
                GROUP BY kv.MaKhuVuc, kv.TenKhuVuc
                ORDER BY TongSanLuong DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvTieuThu.DataSource = dt;

                        FormatGrid();
                        CalculateAndDisplayTotal(dt);

                        // ⭐ UX tốt hơn
                        if (dt.Rows.Count == 0)
                        {
                            lblTongTieuThuValue.Text = "0 m³";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void FormBaoCaoTieuThu_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            SetupThangComboBox();
            LoadKhuVucComboBox();
           // BtnThongKe_Click(null, null);
            txtNam.Text = DateTime.Now.Year.ToString();
        }

        // Tạo danh sách tháng từ 1 đến 12 cho ComboBox
        private void SetupThangComboBox()
        {
            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add(i);
            }
            cboThang.SelectedItem = DateTime.Now.Month;
        }

        // Tải danh sách khu vực vào ComboBox
        private void LoadKhuVucComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT MaKhuVuc, TenKhuVuc FROM KhuVuc", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DataRow dr = dt.NewRow();
                    dr["MaKhuVuc"] = "ALL";
                    dr["TenKhuVuc"] = "--- Tất cả khu vực ---";
                    dt.Rows.InsertAt(dr, 0);

                    cboKhuVuc.DataSource = dt;
                    cboKhuVuc.DisplayMember = "TenKhuVuc";
                    cboKhuVuc.ValueMember = "MaKhuVuc";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách khu vực: " + ex.Message);
            }
        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {

            if (cboThang.SelectedItem == null || string.IsNullOrWhiteSpace(txtNam.Text) || !int.TryParse(txtNam.Text, out _))
            {
                MessageBox.Show("Vui lòng chọn tháng và nhập năm hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int thang = Convert.ToInt32(cboThang.SelectedItem);
                int nam = Convert.ToInt32(txtNam.Text);
                string maKhuVuc = cboKhuVuc.SelectedValue.ToString();

                // Câu truy vấn để tổng hợp sản lượng tiêu thụ theo từng khu vực
                string query = @"SELECT 
                                    kv.MaKhuVuc,
                                    kv.TenKhuVuc,
                                    SUM(c.SanLuong) AS TongSanLuong
                                FROM ChiSo c
                                JOIN DongHoNuoc dh ON c.MaDongHo = dh.MaDongHo
                                JOIN KhachHang kh ON dh.MaKH = kh.MaKH
                                JOIN KhuVuc kv ON kh.MaKhuVuc = kv.MaKhuVuc
                                WHERE c.Thang = @Thang AND c.Nam = @Nam ";

                // Nếu người dùng chọn một khu vực cụ thể, thêm điều kiện lọc
                if (maKhuVuc != "ALL")
                {
                    query += " AND kh.MaKhuVuc = @MaKhuVuc ";
                }

                query += "GROUP BY kv.MaKhuVuc, kv.TenKhuVuc ORDER BY TongSanLuong DESC";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Thang", thang);
                        cmd.Parameters.AddWithValue("@Nam", nam);
                        if (maKhuVuc != "ALL")
                        {
                            cmd.Parameters.AddWithValue("@MaKhuVuc", maKhuVuc);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvTieuThu.DataSource = dt;
                        FormatGrid();
                        CalculateAndDisplayTotal(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thống kê: " + ex.Message);
            }
        }

        // Định dạng các cột trong bảng
        private void FormatGrid()
        {
            if (dgvTieuThu.Columns.Count > 0)
            {
                dgvTieuThu.Columns["MaKhuVuc"].HeaderText = "Mã Khu Vực";
                dgvTieuThu.Columns["TenKhuVuc"].HeaderText = "Tên Khu Vực";
            //    dgvTieuThu.Columns["TenKhuVuc"].HeaderText = "Tên Khu Vực";
                dgvTieuThu.Columns["TongSanLuong"].HeaderText = "Tổng Sản Lượng (m³)";

                dgvTieuThu.Columns["TongSanLuong"].DefaultCellStyle.Format = "N0";
                dgvTieuThu.Columns["TongSanLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        // Tính và hiển thị tổng sản lượng
        private void CalculateAndDisplayTotal(DataTable dt)
        {
            decimal tongTieuThu = 0;
            foreach (DataRow row in dt.Rows)
            {
                tongTieuThu += Convert.ToDecimal(row["TongSanLuong"]);
            }
            lblTongTieuThuValue.Text = string.Format("{0:N0} m³", tongTieuThu);
        }
    }
}