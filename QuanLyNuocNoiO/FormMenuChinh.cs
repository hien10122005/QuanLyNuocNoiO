using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNuocNoiO
{
    public partial class FormMenuChinh : Form
    {
        // ========== THÔNG TIN ĐĂNG NHẬP ==========
        private string _tenNhanVien;
        private string _vaiTro;
        private string _maNV;

        // ========== ROLE CONSTANT ==========
        private const string ROLE_ADMIN = "Admin";
        private const string ROLE_GHICHISO = "Ghi chỉ số";
        private const string ROLE_THUNGAN = "Thu ngân";

        // ========== NÚT ĐANG ACTIVE ==========
        private Button _btnDangActive = null;

        // ========== CONSTRUCTOR ==========
        public FormMenuChinh(string maNV, string tenNhanVien, string vaiTro)
        {
            InitializeComponent();

            _maNV = maNV;
            _tenNhanVien = tenNhanVien;
            _vaiTro = vaiTro;

            PhanQuyenMenu(); // ⭐ rất quan trọng
        }

        // ========================================
        // SET ACTIVE BUTTON (UI đẹp)
        // ========================================
        private void SetActiveButton(Button btn)
        {
            if (_btnDangActive != null)
                _btnDangActive.BackColor = Color.Transparent;

            _btnDangActive = btn;
            _btnDangActive.BackColor = Color.LightSkyBlue;
        }

        // ========================================
        // LOAD USERCONTROL VÀO PANEL
        // ========================================
        private void LoadUserControl(UserControl uc)
        {
            // cập nhật tiêu đề an toàn
            if (_btnDangActive != null)
                lblTieuDeContentDesign.Text = "  " + _btnDangActive.Text.Trim();

            pnlContentDesign.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContentDesign.Controls.Add(uc);
            uc.BringToFront();
        }

        // ========================================
        // PHÂN QUYỀN MENU
        // ========================================
        private void PhanQuyenMenu()
        {
            switch (_vaiTro)
            {
                case ROLE_GHICHISO:
                    // Chỉ thấy: Trang Chủ, Ghi Chỉ Số, Lập Hóa Đơn
                    btnKhuVuc.Visible = false;
                    btnKhachHang.Visible = false;
                    btnNhanVien.Visible = false;
                    btnDongHoNuoc.Visible = false;
                    btnBangGia.Visible = false;
                    btnThanhToan.Visible = false;
                    btnBaoCaoDoanhThu.Visible = false;
                    btnDanhSachNo.Visible = false;
                    btnTaiKhoan.Visible = false;
                    lblDanhMuc.Visible = false;
                    lblBaoCao.Visible = false;
                    break;

                case ROLE_THUNGAN:
                    // Chỉ thấy: Trang Chủ, Thanh Toán, Danh Sách Nợ, Báo Cáo
                    btnKhuVuc.Visible = false;
                    btnKhachHang.Visible = false;
                    btnNhanVien.Visible = false;
                    btnDongHoNuoc.Visible = false;
                    btnBangGia.Visible = false;
                    btnGhiChiSo.Visible = false;
                    btnLapHoaDon.Visible = false;
                    btnTaiKhoan.Visible = false;
                    lblDanhMuc.Visible = false;
                    break;

                case ROLE_ADMIN:
                default:
                    // Admin thấy tất cả
                    break;
            }
        }

        // ========================================
        // ĐĂNG XUẤT
        // ========================================
        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất không?",
                "Xác Nhận Đăng Xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                this.Hide(); // ⭐ tránh thoát app

                FormDangNhap frmDangNhap = new FormDangNhap();
                frmDangNhap.Show();
            }
        }

        // ========================================
        // ====== VÍ DỤ CLICK MENU (BẠN COPY MẪU)
        // ========================================

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnKhachHang);
            LoadUserControl(new UC_KhachHang());
        }

        private void btnKhuVuc_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnKhuVuc);
            LoadUserControl(new UC_KhuVuc());
        }

        private void btnGhiChiSo_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnGhiChiSo);
            LoadUserControl(new UC_GhiChiSo());
        }
    }
}