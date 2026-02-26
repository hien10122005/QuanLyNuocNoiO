// DÁN VÀO FILE FormDangNhap.cs
using QuanLyNuocNoiO.Class;
using System;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Data.SqlClient;
using QuanLyNuocNoiO.KetNoi;
using QuanLyNuocNoiO.Main;

namespace QuanLyNuocNoiO.Nhóm_Hệ_thống
{
    public partial class FormDangNhap : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        
        public FormDangNhap()
        {
            InitializeComponent();
        }

        #region Di Chuyển Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PnlLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(KetNoi.KetNoi.ChuoiKetNoi))
            {
                try
                {
                    conn.Open();
                    string query = @"
                                SELECT tk.TenDangNhap, tk.VaiTro,
                                       nv.MaNV, nv.HoTen, nv.SoDienThoai
                                FROM TaiKhoan tk
                                JOIN NhanVien nv ON tk.MaNV = nv.MaNV
                                WHERE tk.TenDangNhap = @username
                                  AND tk.MatKhau = @password
                                  AND tk.TrangThai = N'Hoạt động'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", tenDangNhap);
                        cmd.Parameters.AddWithValue("@password", matKhau);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows) 
                            {
                                reader.Read(); 

                                ThongTinNhanVien.MaNhanVien = reader["MaNV"].ToString();
                                ThongTinNhanVien.TenNhanVien = reader["HoTen"].ToString();
                                ThongTinNhanVien.TenDangNhap = reader["TenDangNhap"].ToString();
                                ThongTinNhanVien.VaiTro = reader["VaiTro"].ToString();
                                ThongTinNhanVien.SoDienThoai = reader["SoDienThoai"].ToString();
                                MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                FormMenu f = new FormMenu();
                                f.Show();
                                this.Hide();
                            }
                            else 
                            {
                                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}