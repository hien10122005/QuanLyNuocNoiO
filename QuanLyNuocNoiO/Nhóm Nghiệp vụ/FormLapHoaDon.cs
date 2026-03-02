using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNuocNoiO.Nhóm_Nghiệp_vụ
{
    public partial class FormLapHoaDon : Form
    {
        string connectionString = KetNoi.KetNoi.ChuoiKetNoi;
        SqlConnection ketNoi;
        SqlDataAdapter da;
        DataSet ds;
        public FormLapHoaDon()
        {
            InitializeComponent();
        }

        private void FormLapHoaDon_Load(object sender, EventArgs e)
        {
            SetupThangComboBox();
            txtNam.Text = DateTime.Now.Year.ToString();
            LoadKhuVucComboBox();
            ketNoi = new SqlConnection(connectionString);
        }

        private void SetupThangComboBox()
        {
            cboThang.Items.Clear();
            for (int i = 1; i <= 12; i++)
                cboThang.Items.Add(i);
            cboThang.SelectedItem = DateTime.Now.Month;
        }

        private void LoadKhuVucComboBox()
        {
            try
            {
                string sql = "SELECT MaKhuVuc, TenKhuVuc FROM KhuVuc";
                da = new SqlDataAdapter(sql, connectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr["MaKhuVuc"] = "ALL";
                dr["TenKhuVuc"] = "--- Tất cả khu vực ---";
                dt.Rows.InsertAt(dr, 0);

                cboKhuVuc.DataSource = dt;
                cboKhuVuc.DisplayMember = "TenKhuVuc";
                cboKhuVuc.ValueMember = "MaKhuVuc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải khu vực: " + ex.Message);
            }
        }

        private void TaoCotCheckBox()
        {
            if (!dgvDanhSachCho.Columns.Contains("colChon"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.Name = "colChon";
                chk.HeaderText = "Chọn";
                chk.Width = 50;
                dgvDanhSachCho.Columns.Insert(0, chk);
            }
        }

        private void BtnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"
                    SELECT c.MaChiSo, dh.MaDongHo, kh.MaKH, kh.HoTen, 
                           c.ChiSoCu, c.ChiSoMoi, c.SanLuong
                    FROM ChiSo c
                    JOIN DongHoNuoc dh ON c.MaDongHo = dh.MaDongHo
                    JOIN KhachHang kh ON dh.MaKH = kh.MaKH
                    WHERE c.Thang = @Thang AND c.Nam = @Nam
                    AND NOT EXISTS (SELECT 1 FROM HoaDon hd WHERE hd.MaChiSo = c.MaChiSo)";

                if (cboKhuVuc.SelectedValue?.ToString() != "ALL")
                    sql += " AND kh.MaKhuVuc = @MaKhuVuc";

                SqlCommand cmd = new SqlCommand(sql, ketNoi);
                cmd.Parameters.AddWithValue("@Thang", cboThang.SelectedItem);
                cmd.Parameters.AddWithValue("@Nam", txtNam.Text);
                if (cboKhuVuc.SelectedValue?.ToString() != "ALL")
                    cmd.Parameters.AddWithValue("@MaKhuVuc", cboKhuVuc.SelectedValue);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "ChiSoCho");

                dgvDanhSachCho.Columns.Clear();
                dgvDanhSachCho.DataSource = ds.Tables["ChiSoCho"];

                TaoCotCheckBox();
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị: " + ex.Message);
            }
        }

        private string TaoMaHoaDonTuDong(SqlConnection connection)
        {
            string maMoi = "HD0001";
            string sql = "SELECT MAX(CAST(SUBSTRING(MaHD, 3, LEN(MaHD)) AS INT)) FROM HoaDon";
            SqlCommand cmd = new SqlCommand(sql, connection);
            object ketQua = cmd.ExecuteScalar();

            if (ketQua != DBNull.Value && ketQua != null)
            {
                int soHienTai = Convert.ToInt32(ketQua);
                int soTiepTheo = soHienTai + 1;
                maMoi = "HD" + soTiepTheo.ToString("0000");
            }

            return maMoi;
        }

        private void XuLyLapHoaDon(List<DataGridViewRow> danhSach)
        {
            int thanhCong = 0;
            ketNoi = new SqlConnection(connectionString);

            try
            {
                ketNoi.Open();
                DataTable dtBangGia = GetBangGia(ketNoi);
                string maBatDau = TaoMaHoaDonTuDong(ketNoi);
                int soThuTuHienTai = int.Parse(maBatDau.Substring(2));

                foreach (DataGridViewRow row in danhSach)
                {
                    string maHDMoi = "HD" + soThuTuHienTai.ToString("0000");

                    if (LapHoaDonChoMotDong(row, dtBangGia, ketNoi, maHDMoi))
                    {
                        thanhCong++;
                        soThuTuHienTai++;
                    }
                }

                MessageBox.Show("Đã lập thành công " + thanhCong + " hóa đơn.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
            finally
            {
                if (ketNoi.State == ConnectionState.Open) ketNoi.Close();
                BtnHienThi_Click(null, null);
            }
        }

        private bool LapHoaDonChoMotDong(DataGridViewRow row, DataTable dtBangGia, SqlConnection conn, string maHD)
        {
            try
            {
                if (row.Cells["MaChiSo"].Value == null || row.Cells["MaKH"].Value == null) return false;

                string maChiSo = row.Cells["MaChiSo"].Value.ToString();
                string maKH = row.Cells["MaKH"].Value.ToString();
                decimal sanLuong = Convert.ToDecimal(row.Cells["SanLuong"].Value);
                decimal tongTien = TinhTienNuoc(sanLuong, dtBangGia);

                string sql = @"INSERT INTO HoaDon (MaHD, MaChiSo, MaKH, Thang, Nam, SanLuong, TongTien, NgayLapHD, HanThanhToan, TrangThai)
                               VALUES (@MaHD, @MaChiSo, @MaKH, @Thang, @Nam, @SanLuong, @TongTien, GETDATE(), DATEADD(DAY,15,GETDATE()), N'Chưa thanh toán')";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.Parameters.AddWithValue("@MaChiSo", maChiSo);
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@Thang", cboThang.SelectedItem);
                    cmd.Parameters.AddWithValue("@Nam", txtNam.Text.Trim());
                    cmd.Parameters.AddWithValue("@SanLuong", sanLuong);
                    cmd.Parameters.AddWithValue("@TongTien", tongTien);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tại khách hàng " + row.Cells["HoTen"].Value + ":\n" + ex.Message);
                return false;
            }
        }

        private DataTable GetBangGia(SqlConnection conn)
        {
            SqlDataAdapter daBG = new SqlDataAdapter("SELECT BacTu, BacDen, DonGia FROM BangGia ORDER BY BacTu", conn);
            DataTable dt = new DataTable();
            daBG.Fill(dt);
            return dt;
        }

        private decimal TinhTienNuoc(decimal sanLuong, DataTable dtBangGia)
        {
            decimal tongTien = 0;
            foreach (DataRow row in dtBangGia.Rows)
            {
                decimal bacTu = Convert.ToDecimal(row["BacTu"]);
                decimal bacDen = row["BacDen"] == DBNull.Value ? decimal.MaxValue : Convert.ToDecimal(row["BacDen"]);
                decimal donGia = Convert.ToDecimal(row["DonGia"]);

                if (sanLuong <= bacTu) break;
                decimal mucTinh = Math.Min(sanLuong, bacDen) - bacTu;
                if (mucTinh > 0) tongTien += mucTinh * donGia;
            }
            return tongTien;
        }

        private void BtnLapHoaDonChon_Click(object sender, EventArgs e)
        {
            dgvDanhSachCho.EndEdit();
            List<DataGridViewRow> dsChon = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dgvDanhSachCho.Rows)
            {
                if (row.IsNewRow) continue;

                object val = row.Cells["colChon"].FormattedValue;

                if (val != null && (bool)val == true)
                {
                    dsChon.Add(row);
                }
            }

            if (dsChon.Count == 0)
            {
                MessageBox.Show("Vui lòng tích chọn vào cột 'Chọn' cho các khách hàng muốn lập hóa đơn!");
                return;
            }

            XuLyLapHoaDon(dsChon);
        }

        private void BtnLapHoaDonTatCa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachCho.Rows.Count == 0) return;
            if (MessageBox.Show("Lập hóa đơn cho tất cả?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<DataGridViewRow> tatCa = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dgvDanhSachCho.Rows)
                {
                    if (!row.IsNewRow) tatCa.Add(row);
                }
                XuLyLapHoaDon(tatCa);
            }
        }

        private void FormatGrid()
        {
            if (dgvDanhSachCho.Columns.Contains("MaChiSo")) dgvDanhSachCho.Columns["MaChiSo"].Visible = false;
            if (dgvDanhSachCho.Columns.Contains("MaKH")) dgvDanhSachCho.Columns["MaKH"].Visible = false;
            if (dgvDanhSachCho.Columns.Contains("MaDongHo")) dgvDanhSachCho.Columns["MaDongHo"].HeaderText = "Mã ĐH";
            if (dgvDanhSachCho.Columns.Contains("HoTen")) dgvDanhSachCho.Columns["HoTen"].HeaderText = "Khách Hàng";
        }

        private void dgvDanhSachCho_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDanhSachCho.IsCurrentCellDirty)
            {
                dgvDanhSachCho.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}