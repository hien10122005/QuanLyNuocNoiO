// DÁN TOÀN BỘ CODE NÀY VÀO FILE FormBaoCaoDoanhThu.cs

using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyNuocNoiO.Nhóm_Tra_cứu___Báo_cáo
{
    public partial class FormBaoCaoDoanhThu : Form
    {
        // !!! THAY THẾ CHUỖI KẾT NỐI NÀY BẰNG CỦA BẠN !!!
        private string connectionString = KetNoi.KetNoi.ChuoiKetNoi;

        public FormBaoCaoDoanhThu()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FormBaoCaoDoanhThu_Load);
        }

        private void FormBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            LoadKhuVucComboBox();
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;
        }

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
            try
            {
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);
                string maKhuVuc = cboKhuVuc.SelectedValue.ToString();

                string query = @"SELECT 
                                    FORMAT(tt.NgayTT, 'dd/MM/yyyy') AS NgayThu,
                                    kh.HoTen,
                                    kv.TenKhuVuc,
                                    tt.SoTienTT AS SoTien
                                FROM ThanhToan tt
                                JOIN HoaDon hd ON tt.MaHD = hd.MaHD
                                JOIN KhachHang kh ON hd.MaKH = kh.MaKH
                                JOIN KhuVuc kv ON kh.MaKhuVuc = kv.MaKhuVuc
                                WHERE tt.NgayTT BETWEEN @TuNgay AND @DenNgay ";

                if (maKhuVuc != "ALL")
                {
                    query += " AND kh.MaKhuVuc = @MaKhuVuc ";
                }
                query += "ORDER BY tt.NgayTT";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                        cmd.Parameters.AddWithValue("@DenNgay", denNgay);
                        if (maKhuVuc != "ALL")
                        {
                            cmd.Parameters.AddWithValue("@MaKhuVuc", maKhuVuc);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvDoanhThu.DataSource = dt;
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

        private void FormatGrid()
        {
            if (dgvDoanhThu.Columns.Count > 0)
            {
                dgvDoanhThu.Columns["NgayThu"].HeaderText = "Ngày Thu";
                dgvDoanhThu.Columns["HoTen"].HeaderText = "Tên Khách Hàng";
                dgvDoanhThu.Columns["TenKhuVuc"].HeaderText = "Khu Vực";
                dgvDoanhThu.Columns["SoTien"].HeaderText = "Số Tiền Thu (VNĐ)";
                dgvDoanhThu.Columns["SoTien"].DefaultCellStyle.Format = "N0";
            }
        }

        private void CalculateAndDisplayTotal(DataTable dt)
        {
            decimal tongDoanhThu = 0;
            // Tính tổng từ cột 'SoTien' trong DataTable
            foreach (DataRow row in dt.Rows)
            {
                tongDoanhThu += Convert.ToDecimal(row["SoTien"]);
            }

            CultureInfo viVn = new CultureInfo("vi-VN");
            lblTongDoanhThuValue.Text = tongDoanhThu.ToString("c0", viVn);
        }
    }
}