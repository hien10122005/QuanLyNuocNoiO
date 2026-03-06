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
         string connectionString = KetNoi.KetNoi.ChuoiKetNoi;

        public FormBaoCaoDoanhThu()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FormBaoCaoDoanhThu_Load);
        }
        public void SetupThangComboBox()
        {
            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add(i);
            }
            cboThang.SelectedIndex = DateTime.Now.Month - 1;
        }
        private void FormBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            LoadKhuVucComboBox();
            SetupThangComboBox();
            txtNam.Text = DateTime.Now.Year.ToString();
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
                string maKhuVuc = cboKhuVuc.SelectedValue?.ToString() ?? "ALL";

                string query = @"SELECT 
                            FORMAT(tt.NgayTT, 'dd/MM/yyyy') AS NgayThu,
                            kh.HoTen,
                            kv.TenKhuVuc,
                            tt.SoTienTT AS SoTien,
                            hd.MaHD
                         FROM ThanhToan tt
                         JOIN HoaDon hd ON tt.MaHD = hd.MaHD
                         JOIN KhachHang kh ON hd.MaKH = kh.MaKH
                         JOIN KhuVuc kv ON kh.MaKhuVuc = kv.MaKhuVuc
                         WHERE hd.Thang = @thang AND hd.Nam = @nam ";

                if (maKhuVuc != "ALL")
                {
                    query += " AND kh.MaKhuVuc = @MaKhuVuc ";
                }

                query += " ORDER BY tt.NgayTT";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@thang", SqlDbType.Int).Value = int.Parse(cboThang.Text);
                        cmd.Parameters.Add("@nam", SqlDbType.Int).Value = int.Parse(txtNam.Text);

                        if (maKhuVuc != "ALL")
                        {
                            cmd.Parameters.AddWithValue("@MaKhuVuc", maKhuVuc);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                    dgvDoanhThu.DataSource = null;
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
                dgvDoanhThu.Columns["MaHD"].HeaderText = "Hóa Đơn";
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

            foreach (DataRow row in dt.Rows)
            {
                tongDoanhThu += Convert.ToDecimal(row["SoTien"]);
            }

            CultureInfo viVn = new CultureInfo("vi-VN");
            lblTongDoanhThuValue.Text = tongDoanhThu.ToString("c0", viVn);
        }
    }
}