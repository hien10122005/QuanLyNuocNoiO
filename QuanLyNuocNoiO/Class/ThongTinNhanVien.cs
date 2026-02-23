using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNuocNoiO.Class
{
    internal static class ThongTinNhanVien
    {
        // ====== Thông tin nhân viên đang đăng nhập ======
        public static string MaNhanVien { get; set; }
        public static string TenNhanVien { get; set; }
        public static string TenDangNhap { get; set; }
        public static string VaiTro { get; set; } // Admin / NhanVien
        public static string Email { get; set; }
        public static string DienThoai { get; set; }

        // ====== Kiểm tra đã đăng nhập chưa ======
        public static bool DaDangNhap
        {
            get { return !string.IsNullOrEmpty(MaNhanVien); }
        }

        // ====== Xóa session khi đăng xuất ======
        public static void DangXuat()
        {
            MaNhanVien = null;
            TenNhanVien = null;
            TenDangNhap = null;
            VaiTro = null;
            Email = null;
            DienThoai = null;
        }
    }
}

