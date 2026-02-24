using QuanLyNuocNoiO.Main;
using QuanLyNuocNoiO.Nhóm_Danh_mục;
using QuanLyNuocNoiO.Nhóm_Hệ_thống;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNuocNoiO
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormMenu());
            Application.Run(new FormQuanLyNhanVien());

        }
    }
}
