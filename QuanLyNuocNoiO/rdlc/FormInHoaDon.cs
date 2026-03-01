// DÁN TOÀN BỘ CODE NÀY ĐỂ THAY THẾ FILE FormInHoaDon.cs

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

// Đảm bảo namespace này đúng với project của bạn
namespace QuanLyNuocNoiO.rdlc
{
    public partial class FormInHoaDon : Form
    {
        // Sử dụng lớp KetNoi của bạn
        private string connectionString = KetNoi.KetNoi.ChuoiKetNoi;

        private string maHD;

        public FormInHoaDon(string maHoaDonCanIn)
        {
            InitializeComponent();
            this.maHD = maHoaDonCanIn;
        }

        private void FormInHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            hd.MaHD, k.HoTen, k.DiaChi, k.SoDienThoai, kv.TenKhuVuc,
                            hd.Thang, hd.Nam, cs.ChiSoCu, cs.ChiSoMoi, hd.SanLuong,
                            hd.TongTien, hd.NgayLapHD, hd.HanThanhToan
                        FROM HoaDon hd
                        JOIN KhachHang k ON hd.MaKH = k.MaKH
                        JOIN ChiSo cs ON hd.MaChiSo = cs.MaChiSo
                        JOIN KhuVuc kv ON k.MaKhuVuc = kv.MaKhuVuc
                        WHERE hd.MaHD = @MaHD";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@MaHD", this.maHD);

                    // Tạo DataSet dựa trên file .xsd
                    dsHoaDon dataSet = new dsHoaDon();

                    // Đổ dữ liệu vào DataTable có tên "dtHoaDonChiTiet"
                    adapter.Fill(dataSet, "dtHoaDonChiTiet");

                    if (dataSet.Tables["dtHoaDonChiTiet"].Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin cho hóa đơn này.");
                        this.Close();
                        return;
                    }

                    this.reportViewer1.LocalReport.DataSources.Clear();

                    // === SỬA LỖI ĐƯỜNG DẪN Ở ĐÂY ===
                    // Chỉ định báo cáo bằng cách đọc từ resource đã được nhúng
                    // Cấu trúc tên: [Tên Namespace Gốc].[Tên Thư Mục].[Tên File.rdlc]
                    this.reportViewer1.LocalReport.ReportPath = null; // Xóa path cũ
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNuocNoiO.rdlc.rpinHoaDon.rdlc";

                    // Tên của ReportDataSource ("DataSet1") phải khớp với tên trong thiết kế báo cáo
                    ReportDataSource rds = new ReportDataSource("DataSet1", dataSet.Tables["dtHoaDonChiTiet"]);

                    this.reportViewer1.LocalReport.DataSources.Add(rds);
                    this.reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}