namespace QuanLyNuocNoiO.Main
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.palMain = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.palChaNghiepVu = new System.Windows.Forms.Panel();
            this.palListNghiepVu = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.btnGhiChiSo = new System.Windows.Forms.Button();
            this.btnNghiepVu = new System.Windows.Forms.Button();
            this.palChaTrCuuBaoCao = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pallistTraCuuBaoCao = new System.Windows.Forms.Panel();
            this.btnBaoCaoTieuThu = new System.Windows.Forms.Button();
            this.btnBaoCaoDoanhThu = new System.Windows.Forms.Button();
            this.btnDanhSachNo = new System.Windows.Forms.Button();
            this.btnTraCuuHoaDon = new System.Windows.Forms.Button();
            this.btnTraCuubaoCao = new System.Windows.Forms.Button();
            this.palChaDanhMuc = new System.Windows.Forms.Panel();
            this.palListDanhMuc = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBangGia = new System.Windows.Forms.Button();
            this.btnDongHoNuoc = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnKhuVuc = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.palChaNghiepVu.SuspendLayout();
            this.palListNghiepVu.SuspendLayout();
            this.panel6.SuspendLayout();
            this.palChaTrCuuBaoCao.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pallistTraCuuBaoCao.SuspendLayout();
            this.palChaDanhMuc.SuspendLayout();
            this.palListDanhMuc.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.labTieuDe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1429, 73);
            this.panel1.TabIndex = 0;
            // 
            // labTieuDe
            // 
            this.labTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labTieuDe.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(0, 0);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(1429, 73);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "Hệ Thống Quản Lý Đồng Hồ Nước Nội Ô";
            this.labTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // palMain
            // 
            this.palMain.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.palMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palMain.Location = new System.Drawing.Point(271, 73);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(1158, 786);
            this.palMain.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(0, 738);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(271, 48);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.palChaNghiepVu);
            this.panel2.Controls.Add(this.palChaTrCuuBaoCao);
            this.panel2.Controls.Add(this.palChaDanhMuc);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 786);
            this.panel2.TabIndex = 1;
            // 
            // palChaNghiepVu
            // 
            this.palChaNghiepVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.palChaNghiepVu.Controls.Add(this.palListNghiepVu);
            this.palChaNghiepVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.palChaNghiepVu.Location = new System.Drawing.Point(0, 470);
            this.palChaNghiepVu.Name = "palChaNghiepVu";
            this.palChaNghiepVu.Size = new System.Drawing.Size(271, 245);
            this.palChaNghiepVu.TabIndex = 12;
            // 
            // palListNghiepVu
            // 
            this.palListNghiepVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.palListNghiepVu.Controls.Add(this.panel6);
            this.palListNghiepVu.Controls.Add(this.btnNghiepVu);
            this.palListNghiepVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.palListNghiepVu.Location = new System.Drawing.Point(0, 0);
            this.palListNghiepVu.Name = "palListNghiepVu";
            this.palListNghiepVu.Size = new System.Drawing.Size(271, 217);
            this.palListNghiepVu.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel6.Controls.Add(this.btnTaiKhoan);
            this.panel6.Controls.Add(this.btnThanhToan);
            this.panel6.Controls.Add(this.btnLapHoaDon);
            this.panel6.Controls.Add(this.btnGhiChiSo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 50);
            this.panel6.Margin = new System.Windows.Forms.Padding(5);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(271, 153);
            this.panel6.TabIndex = 5;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.Location = new System.Drawing.Point(5, 110);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(261, 35);
            this.btnTaiKhoan.TabIndex = 3;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThanhToan.Location = new System.Drawing.Point(5, 75);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(261, 35);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLapHoaDon.Location = new System.Drawing.Point(5, 40);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(261, 35);
            this.btnLapHoaDon.TabIndex = 1;
            this.btnLapHoaDon.Text = " Lập hóa đơn";
            this.btnLapHoaDon.UseVisualStyleBackColor = true;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // btnGhiChiSo
            // 
            this.btnGhiChiSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGhiChiSo.Location = new System.Drawing.Point(5, 5);
            this.btnGhiChiSo.Name = "btnGhiChiSo";
            this.btnGhiChiSo.Size = new System.Drawing.Size(261, 35);
            this.btnGhiChiSo.TabIndex = 0;
            this.btnGhiChiSo.Text = "Ghi chỉ số";
            this.btnGhiChiSo.UseVisualStyleBackColor = true;
            this.btnGhiChiSo.Click += new System.EventHandler(this.btnGhiChiSo_Click);
            // 
            // btnNghiepVu
            // 
            this.btnNghiepVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNghiepVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNghiepVu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNghiepVu.Location = new System.Drawing.Point(0, 0);
            this.btnNghiepVu.Margin = new System.Windows.Forms.Padding(0);
            this.btnNghiepVu.Name = "btnNghiepVu";
            this.btnNghiepVu.Size = new System.Drawing.Size(271, 50);
            this.btnNghiepVu.TabIndex = 1;
            this.btnNghiepVu.Text = "Nghiệp vụ";
            this.btnNghiepVu.UseVisualStyleBackColor = true;
            this.btnNghiepVu.Click += new System.EventHandler(this.btnNghiepVu_Click);
            // 
            // palChaTrCuuBaoCao
            // 
            this.palChaTrCuuBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.palChaTrCuuBaoCao.Controls.Add(this.panel7);
            this.palChaTrCuuBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.palChaTrCuuBaoCao.Location = new System.Drawing.Point(0, 251);
            this.palChaTrCuuBaoCao.Name = "palChaTrCuuBaoCao";
            this.palChaTrCuuBaoCao.Size = new System.Drawing.Size(271, 219);
            this.palChaTrCuuBaoCao.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel7.Controls.Add(this.pallistTraCuuBaoCao);
            this.panel7.Controls.Add(this.btnTraCuubaoCao);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(271, 208);
            this.panel7.TabIndex = 6;
            // 
            // pallistTraCuuBaoCao
            // 
            this.pallistTraCuuBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pallistTraCuuBaoCao.Controls.Add(this.btnBaoCaoTieuThu);
            this.pallistTraCuuBaoCao.Controls.Add(this.btnBaoCaoDoanhThu);
            this.pallistTraCuuBaoCao.Controls.Add(this.btnDanhSachNo);
            this.pallistTraCuuBaoCao.Controls.Add(this.btnTraCuuHoaDon);
            this.pallistTraCuuBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pallistTraCuuBaoCao.Location = new System.Drawing.Point(0, 50);
            this.pallistTraCuuBaoCao.Margin = new System.Windows.Forms.Padding(5);
            this.pallistTraCuuBaoCao.Name = "pallistTraCuuBaoCao";
            this.pallistTraCuuBaoCao.Padding = new System.Windows.Forms.Padding(5);
            this.pallistTraCuuBaoCao.Size = new System.Drawing.Size(271, 153);
            this.pallistTraCuuBaoCao.TabIndex = 5;
            // 
            // btnBaoCaoTieuThu
            // 
            this.btnBaoCaoTieuThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCaoTieuThu.Location = new System.Drawing.Point(5, 110);
            this.btnBaoCaoTieuThu.Name = "btnBaoCaoTieuThu";
            this.btnBaoCaoTieuThu.Size = new System.Drawing.Size(261, 35);
            this.btnBaoCaoTieuThu.TabIndex = 3;
            this.btnBaoCaoTieuThu.Text = "Báo cáo tiêu thụ";
            this.btnBaoCaoTieuThu.UseVisualStyleBackColor = true;
            this.btnBaoCaoTieuThu.Click += new System.EventHandler(this.btnBaoCaoTieuThu_Click);
            // 
            // btnBaoCaoDoanhThu
            // 
            this.btnBaoCaoDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCaoDoanhThu.Location = new System.Drawing.Point(5, 75);
            this.btnBaoCaoDoanhThu.Name = "btnBaoCaoDoanhThu";
            this.btnBaoCaoDoanhThu.Size = new System.Drawing.Size(261, 35);
            this.btnBaoCaoDoanhThu.TabIndex = 2;
            this.btnBaoCaoDoanhThu.Text = "Báo cáo doanh thu";
            this.btnBaoCaoDoanhThu.UseVisualStyleBackColor = true;
            this.btnBaoCaoDoanhThu.Click += new System.EventHandler(this.btnBaoCaoDoanhThu_Click);
            // 
            // btnDanhSachNo
            // 
            this.btnDanhSachNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhSachNo.Location = new System.Drawing.Point(5, 40);
            this.btnDanhSachNo.Name = "btnDanhSachNo";
            this.btnDanhSachNo.Size = new System.Drawing.Size(261, 35);
            this.btnDanhSachNo.TabIndex = 1;
            this.btnDanhSachNo.Text = "Danh sách nợ";
            this.btnDanhSachNo.UseVisualStyleBackColor = true;
            this.btnDanhSachNo.Click += new System.EventHandler(this.btnDanhSachNo_Click);
            // 
            // btnTraCuuHoaDon
            // 
            this.btnTraCuuHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTraCuuHoaDon.Location = new System.Drawing.Point(5, 5);
            this.btnTraCuuHoaDon.Name = "btnTraCuuHoaDon";
            this.btnTraCuuHoaDon.Size = new System.Drawing.Size(261, 35);
            this.btnTraCuuHoaDon.TabIndex = 0;
            this.btnTraCuuHoaDon.Text = "Tra cứu hóa đơn";
            this.btnTraCuuHoaDon.UseVisualStyleBackColor = true;
            this.btnTraCuuHoaDon.Click += new System.EventHandler(this.btnTraCuuHoaDon_Click);
            // 
            // btnTraCuubaoCao
            // 
            this.btnTraCuubaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTraCuubaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuubaoCao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuubaoCao.Location = new System.Drawing.Point(0, 0);
            this.btnTraCuubaoCao.Margin = new System.Windows.Forms.Padding(0);
            this.btnTraCuubaoCao.Name = "btnTraCuubaoCao";
            this.btnTraCuubaoCao.Size = new System.Drawing.Size(271, 50);
            this.btnTraCuubaoCao.TabIndex = 1;
            this.btnTraCuubaoCao.Text = "Tra cứu & Báo cáo";
            this.btnTraCuubaoCao.UseVisualStyleBackColor = true;
            this.btnTraCuubaoCao.Click += new System.EventHandler(this.btnTraCuubaoCao_Click);
            // 
            // palChaDanhMuc
            // 
            this.palChaDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.palChaDanhMuc.Controls.Add(this.palListDanhMuc);
            this.palChaDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.palChaDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.palChaDanhMuc.Name = "palChaDanhMuc";
            this.palChaDanhMuc.Size = new System.Drawing.Size(271, 251);
            this.palChaDanhMuc.TabIndex = 10;
            // 
            // palListDanhMuc
            // 
            this.palListDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.palListDanhMuc.Controls.Add(this.panel5);
            this.palListDanhMuc.Controls.Add(this.btnDanhMuc);
            this.palListDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.palListDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.palListDanhMuc.Name = "palListDanhMuc";
            this.palListDanhMuc.Size = new System.Drawing.Size(271, 235);
            this.palListDanhMuc.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel5.Controls.Add(this.btnBangGia);
            this.panel5.Controls.Add(this.btnDongHoNuoc);
            this.panel5.Controls.Add(this.btnNhanVien);
            this.panel5.Controls.Add(this.btnKhachHang);
            this.panel5.Controls.Add(this.btnKhuVuc);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 50);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(271, 188);
            this.panel5.TabIndex = 5;
            // 
            // btnBangGia
            // 
            this.btnBangGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBangGia.Location = new System.Drawing.Point(5, 145);
            this.btnBangGia.Name = "btnBangGia";
            this.btnBangGia.Size = new System.Drawing.Size(261, 35);
            this.btnBangGia.TabIndex = 4;
            this.btnBangGia.Text = "Quản lý bảng giá";
            this.btnBangGia.UseVisualStyleBackColor = true;
            this.btnBangGia.Click += new System.EventHandler(this.btnBangGia_Click);
            // 
            // btnDongHoNuoc
            // 
            this.btnDongHoNuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDongHoNuoc.Location = new System.Drawing.Point(5, 110);
            this.btnDongHoNuoc.Name = "btnDongHoNuoc";
            this.btnDongHoNuoc.Size = new System.Drawing.Size(261, 35);
            this.btnDongHoNuoc.TabIndex = 3;
            this.btnDongHoNuoc.Text = "Quản lý đồng hồ nước";
            this.btnDongHoNuoc.UseVisualStyleBackColor = true;
            this.btnDongHoNuoc.Click += new System.EventHandler(this.btnDongHoNuoc_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.Location = new System.Drawing.Point(5, 75);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(261, 35);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "Quản lý nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.Location = new System.Drawing.Point(5, 40);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(261, 35);
            this.btnKhachHang.TabIndex = 1;
            this.btnKhachHang.Text = "Quản lý khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnKhuVuc
            // 
            this.btnKhuVuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhuVuc.Location = new System.Drawing.Point(5, 5);
            this.btnKhuVuc.Name = "btnKhuVuc";
            this.btnKhuVuc.Size = new System.Drawing.Size(261, 35);
            this.btnKhuVuc.TabIndex = 0;
            this.btnKhuVuc.Text = "Quản lý khu vực";
            this.btnKhuVuc.UseVisualStyleBackColor = true;
            this.btnKhuVuc.Click += new System.EventHandler(this.btnKhuVuc_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.btnDanhMuc.Margin = new System.Windows.Forms.Padding(0);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(271, 50);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 859);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.palChaNghiepVu.ResumeLayout(false);
            this.palListNghiepVu.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.palChaTrCuuBaoCao.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pallistTraCuuBaoCao.ResumeLayout(false);
            this.palChaDanhMuc.ResumeLayout(false);
            this.palListDanhMuc.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel palChaTrCuuBaoCao;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pallistTraCuuBaoCao;
        private System.Windows.Forms.Button btnBaoCaoTieuThu;
        private System.Windows.Forms.Button btnBaoCaoDoanhThu;
        private System.Windows.Forms.Button btnDanhSachNo;
        private System.Windows.Forms.Button btnTraCuuHoaDon;
        private System.Windows.Forms.Button btnTraCuubaoCao;
        private System.Windows.Forms.Panel palChaDanhMuc;
        private System.Windows.Forms.Panel palListDanhMuc;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBangGia;
        private System.Windows.Forms.Button btnDongHoNuoc;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnKhuVuc;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Panel palChaNghiepVu;
        private System.Windows.Forms.Panel palListNghiepVu;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Button btnGhiChiSo;
        private System.Windows.Forms.Button btnNghiepVu;
    }
}