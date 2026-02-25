using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace QuanLyNuocNoiO.Nhóm_Tra_cứu___Báo_cáo
{
    public partial class FormDanhSachNo : Form
    {
        string strCon = KetNoi.KetNoi.ChuoiKetNoi;

        public FormDanhSachNo()
        {
            InitializeComponent();
        }

        private void FormDanhSachNo_Load(object sender, EventArgs e)
        {
            LoadKhuVuc();
            LoadDanhSachNo();
        }

        private void LoadKhuVuc()
        {
            string sqlkv = "SELECT MaKhuVuc, TenKhuVuc FROM KhuVuc ";
            SqlDataAdapter da = new SqlDataAdapter(sqlkv,strCon);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cboKhuVuc.DataSource = ds.Tables[0];
            cboKhuVuc.DisplayMember = "TenKhuVuc";
            cboKhuVuc.ValueMember = "MaKhuVuc";
        }

        private void LoadDanhSachNo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(KetNoi.KetNoi.ChuoiKetNoi))
                {
                    // Truy vấn đếm số tháng nợ và tổng tiền nợ
                    string sql = @"
                        SELECT k.MaKH, k.HoTen, k.SoDienThoai, 
                               COUNT(h.MaHD) as SoThangNo, 
                               SUM(h.TongTien) as TongTienNo,
                               CASE 
                                  WHEN COUNT(h.MaHD) = 1 THEN N'Nhắc nhở'
                                  WHEN COUNT(h.MaHD) >= 2 THEN N'Cần khóa'
                                  ELSE N'Bình thường'
                               END as TrangThaiXuLy
                        FROM KhachHang k
                        JOIN HoaDon h ON k.MaKH = h.MaKH
                        WHERE h.TrangThai = N'Chưa thanh toán' 
                        AND k.TrangThai = N'Hoạt động'
                        GROUP BY k.MaKH, k.HoTen, k.SoDienThoai
                        HAVING COUNT(h.MaHD) >= 1";

                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDanhSachNo.DataSource = dt;

                    FormatGrid();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FormatGrid()
        {
            // Tô màu dòng dựa trên số tháng nợ để dễ quan sát
            foreach (DataGridViewRow row in dgvDanhSachNo.Rows)
            {
                if (row.Cells["SoThangNo"].Value != null)
                {
                    int soThang = Convert.ToInt32(row.Cells["SoThangNo"].Value);
                    if (soThang >= 2)
                        row.DefaultCellStyle.BackColor = Color.MistyRose; // Màu đỏ nhạt cho nợ >= 2 tháng
                    else
                        row.DefaultCellStyle.BackColor = Color.LightYellow; // Màu vàng cho nợ 1 tháng
                }
            }
        }

        private void btnKhoaKhachHang_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachNo.CurrentRow == null) return;

            string maKH = dgvDanhSachNo.CurrentRow.Cells["MaKH"].Value.ToString();
            int soThangNo = Convert.ToInt32(dgvDanhSachNo.CurrentRow.Cells["SoThangNo"].Value);

            if (soThangNo < 2)
            {
                MessageBox.Show("Khách hàng này chỉ nợ 1 tháng, chỉ thực hiện nhắc nhở!", "Thông báo");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn KHÓA khách hàng " + maKH + " không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                // Thực hiện câu lệnh Update trạng thái khách hàng trong DB thành 'Bị khóa'
                UpdateTrangThaiKhachHang(maKH, "Khóa");
                LoadDanhSachNo(); // Load lại bảng
            }
        }

        private void UpdateTrangThaiKhachHang(string maKH, string trangThaiMoi)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string sql = "UPDATE KhachHang SET TrangThai = @trangthai WHERE MaKH = @ma";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@trangthai", trangThaiMoi);
                cmd.Parameters.AddWithValue("@ma", maKH);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã cập nhật trạng thái khách hàng thành công!");
            }
        }

        private void cboKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhuVuc.SelectedValue == null) return;

            string maKV = cboKhuVuc.SelectedValue.ToString();

            string sql = @"
                        SELECT k.MaKH, k.HoTen, k.SoDienThoai, 
                               COUNT(h.MaHD) as SoThangNo, 
                               SUM(h.TongTien) as TongTienNo,
                               CASE 
                                  WHEN COUNT(h.MaHD) = 1 THEN N'Nhắc nhở'
                                  WHEN COUNT(h.MaHD) >= 2 THEN N'Cần khóa'
                                  ELSE N'Bình thường'
                               END as TrangThaiXuLy
                        FROM KhachHang k
                        JOIN HoaDon h ON k.MaKH = h.MaKH
                        WHERE h.TrangThai = N'Chưa thanh toán' 
                        AND k.TrangThai = N'Hoạt động' AND k.MaKhuVuc = @MaKV
                        GROUP BY k.MaKH, k.HoTen, k.SoDienThoai
                        HAVING COUNT(h.MaHD) >= 1";

            using (SqlConnection conn = new SqlConnection(strCon))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaKV", maKV);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDanhSachNo.DataSource = dt; 
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            LoadKhuVuc();
            LoadDanhSachNo();
        }
    }
}