using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNuocNoiO.Nhóm_Nghiệp_vụ
{
    public partial class FormLapHoaDon : Form
    {
        string strCon = KetNoi.KetNoi.ChuoiKetNoi;

        public FormLapHoaDon()
        {
            InitializeComponent();
        }

        private void FormLapHoaDon_Load(object sender, EventArgs e)
        {
            LoadComboBoxKhuVuc();
            LoadComboBoxThang();
            txtNam.Text = DateTime.Now.Year.ToString();
        }

        private void LoadComboBoxThang()
        {
            for (int i = 1; i <= 12; i++) cboThang.Items.Add(i);
            cboThang.SelectedItem = DateTime.Now.Month;
        }

        private void LoadComboBoxKhuVuc()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    string query = "SELECT MaKhuVuc, TenKhuVuc FROM KhuVuc";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cboKhuVuc.DataSource = dt;
                    cboKhuVuc.DisplayMember = "TenKhuVuc";
                    cboKhuVuc.ValueMember = "MaKhuVuc";
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Lỗi tải khu vực: " + ex.Message); }
        }

        // NÚT HIỂN THỊ: Lấy danh sách những người đã có chỉ số nhưng chưa lập hóa đơn
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    // SỬA LỖI MaKH: Phải Join qua bảng DongHo để lấy thông tin Khách hàng
                    string query = @"SELECT cs.MaChiSo, kh.MaKH, kh.HoTen, cs.ChiSoCu, cs.ChiSoMoi, cs.SanLuong
                             FROM ChiSo cs
                             JOIN DongHoNuoc dh ON cs.MaDongHo = dh.MaDongHo
                             JOIN KhachHang kh ON dh.MaKH = kh.MaKH
                             WHERE cs.Thang = @Thang AND cs.Nam = @Nam 
                             AND kh.MaKhuVuc = @MaKV
                             AND cs.MaChiSo NOT IN (SELECT MaChiSo FROM HoaDon)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Thang", cboThang.Text);
                    cmd.Parameters.AddWithValue("@Nam", txtNam.Text);
                    cmd.Parameters.AddWithValue("@MaKV", cboKhuVuc.SelectedValue);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDanhSachCho.DataSource = dt;

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("Không có khách hàng nào chờ lập hóa đơn trong kỳ này.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị: " + ex.Message);
            }
        }

        // HÀM TÍNH TIỀN THEO BẬC THANG (Logic chính từ DB BangGia)
        public decimal TinhTien(double sanLuong)
        {
            decimal tongTien = 0;
            double slConLai = sanLuong;

            using (SqlConnection conn = new SqlConnection(strCon))
            {
                DataTable dtGia = new DataTable();
                new SqlDataAdapter("SELECT * FROM BangGia ORDER BY BacTu ASC", conn).Fill(dtGia);

                foreach (DataRow row in dtGia.Rows)
                {
                    if (slConLai <= 0) break;
                    double tu = Convert.ToDouble(row["BacTu"]);
                    double den = Convert.ToDouble(row["BacDen"]);
                    decimal gia = Convert.ToDecimal(row["DonGia"]);

                    double gioiHan = den - tu + 1;
                    double soKhoi = (slConLai > gioiHan && den < 9999) ? gioiHan : slConLai;

                    tongTien += (decimal)soKhoi * gia;
                    slConLai -= soKhoi;
                }
            }
            return tongTien;
        }

        // NÚT LẬP HÓA ĐƠN CHO CÁC MỤC ĐÃ CHỌN
        private void btnLapHoaDonChon_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dgvDanhSachCho.Rows)
            {
                // Kiểm tra nếu ô CheckBox được tích
                bool isSelected = Convert.ToBoolean(row.Cells["colChon"].Value);
                if (isSelected)
                {
                    LuuHoaDon(row);
                    count++;
                }
            }

            if (count > 0)
            {
                MessageBox.Show($"Đã lập thành công {count} hóa đơn!");
                btnHienThi_Click(null, null); // Load lại danh sách
            }
            else MessageBox.Show("Vui lòng chọn ít nhất một dòng!");
        }

        // NÚT LẬP HÓA ĐƠN TẤT CẢ
        private void btnLapHoaDonTatCa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachCho.Rows.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn lập hóa đơn cho toàn bộ danh sách này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                int thanhCong = 0;
                foreach (DataGridViewRow row in dgvDanhSachCho.Rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua dòng trống cuối cùng nếu có

                    if (LuuHoaDonTuRow(row))
                    {
                        thanhCong++;
                    }
                }

                MessageBox.Show($"Đã hoàn thành! Lập thành công {thanhCong} hóa đơn.");
                btnHienThi_Click(null, null); // Load lại để xóa những người đã lập xong khỏi danh sách chờ
            }
        }

        // Hàm phụ để lưu từng dòng
        private bool LuuHoaDonTuRow(DataGridViewRow row)
        {
            try
            {
                string maCS = row.Cells["MaChiSo"].Value.ToString();
                string maKH = row.Cells["MaKH"].Value.ToString();
                double sl = Convert.ToDouble(row.Cells["SanLuong"].Value);
                decimal tien = TinhTien(sl); // Hàm TinhTien bạn đã có ở bước trước
                string maHD = "HD" + DateTime.Now.Ticks.ToString().Substring(10);

                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    string sql = @"INSERT INTO HoaDon (MaHD, MaChiSo, MaKH, Thang, Nam, SanLuong, TongTien, NgayLapHD, HanThanhToan, TrangThai)
                           VALUES (@MaHD, @MaCS, @MaKH, @Thang, @Nam, @SL, @Tien, @NgayLap, @HanTT, N'Chưa thanh toán')";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.Parameters.AddWithValue("@MaCS", maCS);
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@Thang", cboThang.Text);
                    cmd.Parameters.AddWithValue("@Nam", txtNam.Text);
                    cmd.Parameters.AddWithValue("@SL", sl);
                    cmd.Parameters.AddWithValue("@Tien", tien);
                    cmd.Parameters.AddWithValue("@NgayLap", DateTime.Now);
                    cmd.Parameters.AddWithValue("@HanTT", DateTime.Now.AddDays(7));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch { return false; }
        }

        // Hàm phụ thực hiện lệnh INSERT vào SQL
        private void LuuHoaDon(DataGridViewRow row)
        {
            try
            {
                string maCS = row.Cells["MaChiSo"].Value.ToString();
                string maKH = row.Cells["MaKH"].Value.ToString();
                double sl = Convert.ToDouble(row.Cells["SanLuong"].Value);
                decimal tien = TinhTien(sl);
                string maHD = "HD" + DateTime.Now.Ticks.ToString().Substring(10);

                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    string sql = @"INSERT INTO HoaDon (MaHD, MaChiSo, MaKH, Thang, Nam, SanLuong, TongTien, NgayLapHD, HanThanhToan, TrangThai)
                                   VALUES (@MaHD, @MaCS, @MaKH, @Thang, @Nam, @SL, @Tien, @NgayLap, @HanTT, N'Chưa thanh toán')";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.Parameters.AddWithValue("@MaCS", maCS);
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@Thang", cboThang.Text);
                    cmd.Parameters.AddWithValue("@Nam", txtNam.Text);
                    cmd.Parameters.AddWithValue("@SL", sl);
                    cmd.Parameters.AddWithValue("@Tien", tien);
                    cmd.Parameters.AddWithValue("@NgayLap", DateTime.Now);
                    cmd.Parameters.AddWithValue("@HanTT", DateTime.Now.AddDays(7)); // Hạn nộp 7 ngày

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { Console.WriteLine("Lỗi dòng: " + ex.Message); }
        }
    }
}