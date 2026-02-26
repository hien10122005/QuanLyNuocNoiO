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

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select from NhanVien";
                da = new SqlDataAdapter(sql, con);
                ds = new DataSet();
                da.Fill(ds);
                bd = new SqlCommandBuilder(da);
                dataGridQLNV.DataSource = ds.Tables[0];
                dataGridQLNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridQLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void ClearFields()
        {
            txtMaTK.Text = "";
            txtMaNV.Text = "";
            txtTenDN.Text = "";
            txtMatKhau.Text = "";
            txtVaiTro.Text = "";
            txtNgayTao.Text = "";
            txtTrangThai.Text = "";
            txtMaTK.Focus(); // Đưa con trỏ chuột về ô đầu tiên
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try 
            {
                if (con == null) con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed) con.Open();

                // 2. Viết câu lệnh SQL Insert
                string sqlInsert = "INSERT INTO NhanVien (MaTK, MaNV, TenDN, MatKhau, VaiTro, NgayTao, TrangThai) " +
                                   "VALUES (@maTK, @maNV, @tenDN, @pass, @role, @date, @status)";

                SqlCommand cmd = new SqlCommand(sqlInsert, con);

                // 3. Gán tham số từ các Textbox (Hãy kiểm tra lại ID của Textbox trong Form của bạn)
                cmd.Parameters.AddWithValue("@maTK", txtMaTK.Text);
                cmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@tenDN", txtTenDN.Text);
                cmd.Parameters.AddWithValue("@pass", txtMatKhau.Text);
                cmd.Parameters.AddWithValue("@role", txtVaiTro.Text);
                cmd.Parameters.AddWithValue("@date", txtNgayTao.Text);
                cmd.Parameters.AddWithValue("@status", txtTrangThai.Text);

                // 4. Thực thi
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");

                // 5. Tải lại lưới dữ liệu để cập nhật hiển thị
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
<<<<<<< HEAD
            OpenConnection();
=======
           
        
               //OpenConnection();
>>>>>>> a6e4157f51de8ede83d33455c61bb349c19c1e1a
            string sql = "UPDATE NhanVien SET MaNV=@maNV, TenDN=@tenDN, MatKhau=@pass, VaiTro=@role, NgayTao=@date, TrangThai=@status WHERE MaTK=@maTK";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@maTK", txtMaTK.Text); // Khóa chính để tìm dòng cần sửa
            cmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);
            cmd.Parameters.AddWithValue("@tenDN", txtTenDN.Text);
            cmd.Parameters.AddWithValue("@pass", txtMatKhau.Text);
            cmd.Parameters.AddWithValue("@role", txtVaiTro.Text);
            cmd.Parameters.AddWithValue("@date", txtNgayTao.Text);
            cmd.Parameters.AddWithValue("@status", txtTrangThai.Text);

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0) MessageBox.Show("Cập nhật thành công!");
            //LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
               // OpenConnection();
               SqlDataAdapter con = new SqlDataAdapter();
                string sql = "DELETE FROM NhanVien WHERE MaTK=@maTK";
<<<<<<< HEAD
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maTK", txtMaTK.Text);
=======
               // SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("@maTK", txtMaTaiKhoan.Text);
>>>>>>> a6e4157f51de8ede83d33455c61bb349c19c1e1a

                //cmd.ExecuteNonQuery();
             //   LoadData();
                ClearFields();
            }
        }
    }
    
}
