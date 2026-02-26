using QuanLyNuocNoiO.Class;
using QuanLyNuocNoiO.Nhóm_Danh_mục;
using QuanLyNuocNoiO.Nhóm_Hệ_thống;
using QuanLyNuocNoiO.Nhóm_Nghiệp_vụ;
using QuanLyNuocNoiO.Nhóm_Tra_cứu___Báo_cáo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNuocNoiO.Main
{
    public partial class FormMenu : Form
    {
        bool danhmuc = false;
        bool nghiepvu = false;
        bool tracuu = false;
        void loadHeightPalList()
        {
            palChaNghiepVu.Height = 52;
            palChaDanhMuc.Height = 52;
            palChaTrCuuBaoCao.Height = 52;
        }
       
        private void PhanQuyenMenu()
        {
            string vaiTro = ThongTinNhanVien.VaiTro;

            if (vaiTro == "Ghi chỉ số" || vaiTro == "Thu ngân")
            { 
                btnNhanVien.Visible = false;
                btnTaiKhoan.Visible = false; 
            }

        }
        public FormMenu()
        {
            InitializeComponent();
            loadHeightPalList();
            PhanQuyenMenu();
            
        }
        private Form currentFormChild = null;
        public void OpenChildForm(Form childForm)
        {
            // Nếu có form đang mở rồi thì đóng nó lại cho sạch
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;

            // Cấu hình quan trọng để form con nằm trong panel
            childForm.TopLevel = false;           // Không cho làm cửa sổ độc lập
            childForm.FormBorderStyle = FormBorderStyle.None; // Bỏ khung viền (nút X, thu nhỏ...)
            childForm.Dock = DockStyle.Fill;      // QUAN TRỌNG: Lấp đầy toàn bộ diện tích Panel

            // Giả sử cái Panel bên phải của bạn tên là 'panelContent' 
            // (Bạn hãy kiểm tra tên panel đó trong Properties rồi thay vào đây nhé)
            palMain.Controls.Add(childForm);
            palMain.Tag = childForm;
            childForm.BringToFront();             // Đưa form lên phía trước
            childForm.Show();                     // Hiển thị form
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
         
        }

        void DongMoList(ref bool bienco, Panel palCha, Panel list)
        {
            bienco = !bienco;

            if (bienco)
            {
                palCha.Height = 245;
                list.Height = 280;
            }
            else
            {
                palCha.Height = 52;
                list.Height = 52;
            }
        }
        void DongList(ref bool bienco, Panel palCha, Panel list)
        {
            bienco = false;
            palCha.Height = 52;
            list.Height = 52;
        }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            DongMoList(ref danhmuc, palChaDanhMuc, palListDanhMuc);
           DongList(ref nghiepvu, palChaNghiepVu, palListNghiepVu);
            DongList(ref tracuu, palChaTrCuuBaoCao, palChaTrCuuBaoCao);


        }

        private void btnNghiepVu_Click(object sender, EventArgs e)
        {
            DongMoList(ref nghiepvu, palChaNghiepVu, palListNghiepVu);
            DongList(ref danhmuc, palChaDanhMuc, palListDanhMuc);
             DongList(ref tracuu, palChaTrCuuBaoCao, palChaTrCuuBaoCao);
        }

        private void btnTraCuubaoCao_Click(object sender, EventArgs e)
        {
            DongMoList(ref tracuu, palChaTrCuuBaoCao, palChaTrCuuBaoCao);
               DongList(ref danhmuc, palChaDanhMuc, palListDanhMuc);
            DongList(ref nghiepvu, palChaNghiepVu, palListNghiepVu);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
         //   FormDang f = new FormDangNhap();
         FormDangNhap f = new FormDangNhap();
            DialogResult d = MessageBox.Show("Bạn chắc chắn muốn thoát không ","Thông Báo",MessageBoxButtons.OK);
            if (d == DialogResult.OK)
            {
                ThongTinNhanVien.DangXuat();
                f.Show();
                this.Hide();
            }
        }
        // Nhóm Danh mục
        private void btnKhuVuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyKhuVuc ());
            labTieuDe.Text = btnKhuVuc.Text;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyNhanVien());
            labTieuDe.Text = btnNhanVien.Text;

        }

        private void btnDongHoNuoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyDongHoNuoc());
            labTieuDe.Text = btnDongHoNuoc.Text;

        }

        private void btnBangGia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyBangGia());
            labTieuDe.Text = btnBangGia.Text;

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyKhachHang());
            labTieuDe.Text = btnKhachHang.Text;

        }

        //Nhóm Nghiệp vụ

        private void btnGhiChiSo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGhiChiSo());
            labTieuDe.Text = btnGhiChiSo.Text;

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThanhToan());
            labTieuDe.Text = btnThanhToan.Text;

        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLapHoaDon());
            labTieuDe.Text = btnLapHoaDon.Text;

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTaiKhoan());
            labTieuDe.Text = btnTaiKhoan.Text;

        }

        //Nhóm Tra cứu & Báo cáo

        private void btnTraCuuHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTraCuuHoaDon());
            labTieuDe.Text = btnTraCuuHoaDon.Text;

        }

        private void btnBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBaoCaoDoanhThu());
            labTieuDe.Text = btnBaoCaoDoanhThu.Text;

        }

        private void btnDanhSachNo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhSachNo());
            labTieuDe.Text = btnDanhSachNo.Text;

        }

        private void btnBaoCaoTieuThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBaoCaoTieuThu());
            labTieuDe.Text = btnBaoCaoTieuThu.Text;

        }

       
    }
}
