namespace QuanLyNuocNoiO.Nhóm_Danh_mục
{
    partial class FormQuanLyDongHoNuoc
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
            this.dgvDongHo = new System.Windows.Forms.DataGridView();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.dtpNgayKiemDinh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayLapDat = new System.Windows.Forms.DateTimePicker();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.txtSoSeri = new System.Windows.Forms.TextBox();
            this.txtMaDongHo = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblNgayKiemDinh = new System.Windows.Forms.Label();
            this.lblNgayLapDat = new System.Windows.Forms.Label();
            this.lblViTri = new System.Windows.Forms.Label();
            this.lblSoSeri = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.lblMaDongHo = new System.Windows.Forms.Label();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDongHo)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDongHo
            // 
            this.dgvDongHo.AllowUserToAddRows = false;
            this.dgvDongHo.AllowUserToDeleteRows = false;
            this.dgvDongHo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDongHo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDongHo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDongHo.Location = new System.Drawing.Point(12, 12);
            this.dgvDongHo.MultiSelect = false;
            this.dgvDongHo.Name = "dgvDongHo";
            this.dgvDongHo.ReadOnly = true;
            this.dgvDongHo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDongHo.Size = new System.Drawing.Size(645, 539);
            this.dgvDongHo.TabIndex = 9;
            this.dgvDongHo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDongHo_CellClick);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.cboTrangThai);
            this.grpThongTin.Controls.Add(this.dtpNgayKiemDinh);
            this.grpThongTin.Controls.Add(this.dtpNgayLapDat);
            this.grpThongTin.Controls.Add(this.cboKhachHang);
            this.grpThongTin.Controls.Add(this.txtViTri);
            this.grpThongTin.Controls.Add(this.txtSoSeri);
            this.grpThongTin.Controls.Add(this.txtMaDongHo);
            this.grpThongTin.Controls.Add(this.lblTrangThai);
            this.grpThongTin.Controls.Add(this.lblNgayKiemDinh);
            this.grpThongTin.Controls.Add(this.lblNgayLapDat);
            this.grpThongTin.Controls.Add(this.lblViTri);
            this.grpThongTin.Controls.Add(this.lblSoSeri);
            this.grpThongTin.Controls.Add(this.lblKhachHang);
            this.grpThongTin.Controls.Add(this.lblMaDongHo);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grpThongTin.Location = new System.Drawing.Point(673, 12);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(384, 340);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin Đồng hồ";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(135, 280);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(230, 25);
            this.cboTrangThai.TabIndex = 6;
            // 
            // dtpNgayKiemDinh
            // 
            this.dtpNgayKiemDinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKiemDinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpNgayKiemDinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKiemDinh.Location = new System.Drawing.Point(135, 240);
            this.dtpNgayKiemDinh.Name = "dtpNgayKiemDinh";
            this.dtpNgayKiemDinh.Size = new System.Drawing.Size(230, 25);
            this.dtpNgayKiemDinh.TabIndex = 5;
            // 
            // dtpNgayLapDat
            // 
            this.dtpNgayLapDat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLapDat.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpNgayLapDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapDat.Location = new System.Drawing.Point(135, 200);
            this.dtpNgayLapDat.Name = "dtpNgayLapDat";
            this.dtpNgayLapDat.Size = new System.Drawing.Size(230, 25);
            this.dtpNgayLapDat.TabIndex = 4;
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(135, 80);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(230, 25);
            this.cboKhachHang.TabIndex = 1;
            // 
            // txtViTri
            // 
            this.txtViTri.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtViTri.Location = new System.Drawing.Point(135, 160);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(230, 25);
            this.txtViTri.TabIndex = 3;
            // 
            // txtSoSeri
            // 
            this.txtSoSeri.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSoSeri.Location = new System.Drawing.Point(135, 120);
            this.txtSoSeri.Name = "txtSoSeri";
            this.txtSoSeri.Size = new System.Drawing.Size(230, 25);
            this.txtSoSeri.TabIndex = 2;
            // 
            // txtMaDongHo
            // 
            this.txtMaDongHo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMaDongHo.Location = new System.Drawing.Point(135, 40);
            this.txtMaDongHo.Name = "txtMaDongHo";
            this.txtMaDongHo.Size = new System.Drawing.Size(230, 25);
            this.txtMaDongHo.TabIndex = 0;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTrangThai.Location = new System.Drawing.Point(20, 283);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(69, 17);
            this.lblTrangThai.TabIndex = 6;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // lblNgayKiemDinh
            // 
            this.lblNgayKiemDinh.AutoSize = true;
            this.lblNgayKiemDinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNgayKiemDinh.Location = new System.Drawing.Point(20, 243);
            this.lblNgayKiemDinh.Name = "lblNgayKiemDinh";
            this.lblNgayKiemDinh.Size = new System.Drawing.Size(102, 17);
            this.lblNgayKiemDinh.TabIndex = 5;
            this.lblNgayKiemDinh.Text = "Ngày kiểm định:";
            // 
            // lblNgayLapDat
            // 
            this.lblNgayLapDat.AutoSize = true;
            this.lblNgayLapDat.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNgayLapDat.Location = new System.Drawing.Point(20, 203);
            this.lblNgayLapDat.Name = "lblNgayLapDat";
            this.lblNgayLapDat.Size = new System.Drawing.Size(87, 17);
            this.lblNgayLapDat.TabIndex = 4;
            this.lblNgayLapDat.Text = "Ngày lắp đặt:";
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblViTri.Location = new System.Drawing.Point(20, 163);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(83, 17);
            this.lblViTri.TabIndex = 3;
            this.lblViTri.Text = "Vị trí lắp đặt:";
            // 
            // lblSoSeri
            // 
            this.lblSoSeri.AutoSize = true;
            this.lblSoSeri.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSoSeri.Location = new System.Drawing.Point(20, 123);
            this.lblSoSeri.Name = "lblSoSeri";
            this.lblSoSeri.Size = new System.Drawing.Size(51, 17);
            this.lblSoSeri.TabIndex = 2;
            this.lblSoSeri.Text = "Số seri:";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblKhachHang.Location = new System.Drawing.Point(20, 83);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(79, 17);
            this.lblKhachHang.TabIndex = 1;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // lblMaDongHo
            // 
            this.lblMaDongHo.AutoSize = true;
            this.lblMaDongHo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMaDongHo.Location = new System.Drawing.Point(20, 43);
            this.lblMaDongHo.Name = "lblMaDongHo";
            this.lblMaDongHo.Size = new System.Drawing.Size(84, 17);
            this.lblMaDongHo.TabIndex = 0;
            this.lblMaDongHo.Text = "Mã đồng hồ:";
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChucNang.Controls.Add(this.btnLuu);
            this.pnlChucNang.Controls.Add(this.btnLamMoi);
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.btnSua);
            this.pnlChucNang.Controls.Add(this.btnThem);
            this.pnlChucNang.Location = new System.Drawing.Point(673, 410);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(384, 60);
            this.pnlChucNang.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(304, 10);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 40);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(156, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(4, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(80, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(231, 10);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(70, 40);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // FormQuanLyDongHoNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 563);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.dgvDongHo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyDongHoNuoc";
            this.Text = "Quản Lý Đồng Hồ Nước";
            this.Load += new System.EventHandler(this.FormQuanLyDongHoNuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDongHo)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.pnlChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.DataGridView dgvDongHo;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Label lblMaDongHo;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblSoSeri;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.Label lblNgayLapDat;
        private System.Windows.Forms.Label lblNgayKiemDinh;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtMaDongHo;
        private System.Windows.Forms.TextBox txtSoSeri;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.DateTimePicker dtpNgayLapDat;
        private System.Windows.Forms.DateTimePicker dtpNgayKiemDinh;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
    }
}