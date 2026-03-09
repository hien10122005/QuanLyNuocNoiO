using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyNuocNoiO.Nhóm_Tra_cứu___Báo_cáo;
using QuanLyNuocNoiO.Nhóm_Hệ_thống;

namespace QuanLyNuocNoiO.Nhóm_Danh_mục
{
    public partial class FormQuanLyNhanVien : Form
    {
        string connectionString = KetNoi.KetNoi.ChuoiKetNoi;
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder bd;

        public FormQuanLyNhanVien()
        {
            InitializeComponent();
            
        }
        public void LoadTrangThai()
        {
            cboTrangThai.Items.Add("Hoạt động");
            cboTrangThai.Items.Add("Khóa");
            
        }
        void LoadKhuVuc()
        {
            string sql = "SELECT MaKhuVuc FROM KhuVuc";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboKhuVuc.DataSource = dt;
            cboKhuVuc.DisplayMember = "MaKhuVuc";
        }
        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadTrangThai();
            LoadVaiTro();
            LoadKhuVuc();
        }

        void LoadVaiTro()
        {
            cboVaiTro.Items.Add("Admin");
            cboVaiTro.Items.Add("Nhan Vien");

        }
        void ClearFields()
        {
            //txtMaTK.Text = "";
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSDT.Text = "";
            cboKhuVuc.Text = null;
            cboTrangThai.Text = null;
            cboVaiTro.Text = null;
            //txtTrangThai.Text = "";
            //txtMaTK.Focus(); // Đưa con trỏ chuột về ô đầu tiên
        }
        private string TaoMaTK(SqlConnection connection)
        {
            string maMoi = "TK01";
            string sql = "SELECT MAX(CAST(SUBSTRING(MaTK, 3, LEN(MaTK)) AS INT)) FROM TaiKhoan";
            SqlCommand cmd = new SqlCommand(sql, connection);
            object ketQua = cmd.ExecuteScalar();

            if (ketQua != DBNull.Value && ketQua != null)
            {
                int soHienTai = Convert.ToInt32(ketQua);
                int soTiepTheo = soHienTai + 1;
                maMoi = "TK" + soTiepTheo.ToString("00");
            }

            return maMoi;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try 
            {
                con.Open();
                if (con == null) 
                    con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed) 
                con.Open();
                //  Kiểm tra số điện thoại đã tồn tại chưa
                string sqlCheckSDT = "SELECT COUNT(*) FROM NhanVien WHERE SoDienThoai = @sdt";
                SqlCommand cmdSDT = new SqlCommand(sqlCheckSDT, con);
                cmdSDT.Parameters.AddWithValue("@sdt", txtSDT.Text);

                int count = (int)cmdSDT.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số khác.",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Kiểm tra mã nhân viên đã tồn tại chưa
                string sqlCheckMaNV = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @maNV";
                SqlCommand cmdMaNV = new SqlCommand(sqlCheckMaNV, con);
                cmdMaNV.Parameters.AddWithValue("@maNV", txtMaNV.Text);
                int countMaNV = (int)cmdMaNV.ExecuteScalar();
                if (countMaNV > 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập mã khác.",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string sqlInsert = "INSERT INTO NhanVien (MaNV, HoTen, SoDienThoai, ChucVu, MaKhuVuc, TrangThai) " +
                                   "VALUES (@maNV, @hoten, @sdt, @chucvu, @makv, @status)";

                SqlCommand cmd = new SqlCommand(sqlInsert, con);

               cmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@hoten", txtTenNV.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                cmd.Parameters.AddWithValue("@chucvu", cboVaiTro.Text);
                cmd.Parameters.AddWithValue("@makv", cboKhuVuc.Text);
                cmd.Parameters.AddWithValue("@status", cboTrangThai.Text);
                int r = (int)cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                    // Tạo tài khoản cho nhân viên mới
                    string sqlInsertTK = "INSERT INTO TaiKhoan (MaTK,MaNV, TenDangNhap, MatKhau,VaiTro,NgayTao, TrangThai) " +
                                         "VALUES (@matk,@maNV, @tenDN, @matKhau,@vaitro, @ngaytao,@trangthai)";
                    SqlCommand cmdTK = new SqlCommand(sqlInsertTK, con);
                    string maTK = TaoMaTK(con);
                    cmdTK.Parameters.AddWithValue("@matk", maTK);
                    cmdTK.Parameters.AddWithValue("@maNV", txtMaNV.Text);
                    cmdTK.Parameters.AddWithValue("@tenDN", txtTenNV.Text);
                    cmdTK.Parameters.AddWithValue("@matKhau", "123"); // Mật khẩu mặc định
                    cmdTK.Parameters.AddWithValue("@vaitro", cboVaiTro.Text);
                    cmdTK.Parameters.AddWithValue("@ngaytao", DateTime.Now);
                    cmdTK.Parameters.AddWithValue("@trangthai", cboTrangThai.Text);
                    cmdTK.ExecuteNonQuery();


                }
                FormQuanLyNhanVien_Load(sender, e);

                ClearFields(); // Gọi hàm xóa trắng textbox sau khi thêm
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        // Hàm này giúp xử lý lỗi dòng 107
        void OpenConnection()
        {
            if (con == null) con = new SqlConnection(connectionString);
            if (con.State == ConnectionState.Closed) con.Open();
        }
        void LoadData()
        {
            try
            {
                // Kiểm tra và mở kết nối
                if (con == null) con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed) con.Open();

                // Câu lệnh SQL lấy dữ liệu (đảm bảo có dấu * )
                string sql = "select * from NhanVien";

                da = new SqlDataAdapter(sql, con);
                ds = new DataSet();
                da.Fill(ds);

                // Đổ dữ liệu vào DataGridView
                dataGridQLNV.DataSource = ds.Tables[0];

                // Tự động căn chỉnh độ rộng cột cho đẹp
                dataGridQLNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Thông báo");
            }
            finally
            {
                // Đóng kết nối sau khi tải xong để tiết kiệm tài nguyên
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            OpenConnection();

            string sql = "UPDATE NhanVien SET MaNV=@maNV, HoTen=@tenDN, SoDienThoai=@sdt, ChucVu = @ChucVu, MaKhuvuc=@Makv, TrangThai=@status WHERE MaNV=@maNV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);
            cmd.Parameters.AddWithValue("@tenDN", txtTenNV.Text);
            cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
            cmd.Parameters.AddWithValue("@ChucVu", cboVaiTro.Text);
            cmd.Parameters.AddWithValue("@Makv", cboKhuVuc.Text);
            cmd.Parameters.AddWithValue("@status", cboTrangThai.Text);
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            MessageBox.Show("Cập nhật thành công!");

            string sqlTK = "UPDATE TaiKhoan SET TrangThai=@status WHERE MaNV=@maNV";
            SqlCommand cmdtk = new SqlCommand(sqlTK, con);
            cmdtk.Parameters.AddWithValue("@maNV", txtMaNV.Text);
            cmdtk.Parameters.AddWithValue("@status", cboTrangThai.Text);
            cmdtk.ExecuteNonQuery();

            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
              using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string sql = "DELETE FROM NhanVien WHERE MaNV=@maNV";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        string sqlTK = "DELETE FROM TaiKhoan WHERE MaNV=@maNV";
                        SqlCommand cmdtk = new SqlCommand(sqlTK, con);
                        cmdtk.Parameters.AddWithValue("@maNV", txtMaNV.Text);
                        cmdtk.ExecuteNonQuery();
                        LoadData();
                        ClearFields();
                    }
                    else
                        MessageBox.Show("Không tìm thấy nhân viên để xóa.");
                }
            }
        }

        private void dataGridQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo người dùng không click vào header
            {
                DataGridViewRow row = dataGridQLNV.Rows[e.RowIndex];
               // txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = row.Cells["HoTen"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                cboVaiTro.Text = row.Cells["ChucVu"].Value.ToString();
                cboKhuVuc.Text = row.Cells["MaKhuVuc"].Value.ToString();
                cboTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
            }
        }
    }
    
}
