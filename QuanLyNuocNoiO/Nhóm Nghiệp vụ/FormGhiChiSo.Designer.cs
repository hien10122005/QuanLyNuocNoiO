namespace QuanLyNuocNoiO.Nhóm_Nghiệp_vụ
{
    partial class FormGhiChiSo
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDanhSachGhi = new System.Windows.Forms.DataGridView();
            this.lblChiSoSu = new System.Windows.Forms.Label();
            this.lblKhachHangValue = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.lblDongHoValue = new System.Windows.Forms.Label();
            this.lblDongHo = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtChiSoMoi = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblChiSoMoi = new System.Windows.Forms.Label();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.grpNhapChiSo = new System.Windows.Forms.GroupBox();
            this.pnlChonKy = new System.Windows.Forms.Panel();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.txtNam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGhi)).BeginInit();
            this.grpNhapChiSo.SuspendLayout();
            this.pnlChonKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chỉ Số Cũ :";
            // 
            // dgvDanhSachGhi
            // 
            this.dgvDanhSachGhi.AllowUserToAddRows = false;
            this.dgvDanhSachGhi.AllowUserToDeleteRows = false;
            this.dgvDanhSachGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachGhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachGhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachGhi.Location = new System.Drawing.Point(12, 77);
            this.dgvDanhSachGhi.MultiSelect = false;
            this.dgvDanhSachGhi.Name = "dgvDanhSachGhi";
            this.dgvDanhSachGhi.ReadOnly = true;
            this.dgvDanhSachGhi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachGhi.Size = new System.Drawing.Size(628, 472);
            this.dgvDanhSachGhi.TabIndex = 10;
            this.dgvDanhSachGhi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachGhi_CellClick);
            // 
            // lblChiSoSu
            // 
            this.lblChiSoSu.AutoSize = true;
            this.lblChiSoSu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiSoSu.ForeColor = System.Drawing.Color.Blue;
            this.lblChiSoSu.Location = new System.Drawing.Point(115, 109);
            this.lblChiSoSu.Name = "lblChiSoSu";
            this.lblChiSoSu.Size = new System.Drawing.Size(33, 17);
            this.lblChiSoSu.TabIndex = 12;
            this.lblChiSoSu.Text = "N/A";
            // 
            // lblKhachHangValue
            // 
            this.lblKhachHangValue.AutoSize = true;
            this.lblKhachHangValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHangValue.ForeColor = System.Drawing.Color.Blue;
            this.lblKhachHangValue.Location = new System.Drawing.Point(115, 70);
            this.lblKhachHangValue.Name = "lblKhachHangValue";
            this.lblKhachHangValue.Size = new System.Drawing.Size(33, 17);
            this.lblKhachHangValue.TabIndex = 10;
            this.lblKhachHangValue.Text = "N/A";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblKhachHang.Location = new System.Drawing.Point(20, 70);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(79, 17);
            this.lblKhachHang.TabIndex = 9;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // lblDongHoValue
            // 
            this.lblDongHoValue.AutoSize = true;
            this.lblDongHoValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDongHoValue.ForeColor = System.Drawing.Color.Blue;
            this.lblDongHoValue.Location = new System.Drawing.Point(115, 32);
            this.lblDongHoValue.Name = "lblDongHoValue";
            this.lblDongHoValue.Size = new System.Drawing.Size(33, 17);
            this.lblDongHoValue.TabIndex = 8;
            this.lblDongHoValue.Text = "N/A";
            // 
            // lblDongHo
            // 
            this.lblDongHo.AutoSize = true;
            this.lblDongHo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDongHo.Location = new System.Drawing.Point(20, 32);
            this.lblDongHo.Name = "lblDongHo";
            this.lblDongHo.Size = new System.Drawing.Size(84, 17);
            this.lblDongHo.TabIndex = 7;
            this.lblDongHo.Text = "Mã đồng hồ:";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(23, 341);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(280, 50);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu và Ghi tiếp";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtGhiChu.Location = new System.Drawing.Point(23, 241);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(280, 80);
            this.txtGhiChu.TabIndex = 6;
            // 
            // txtChiSoMoi
            // 
            this.txtChiSoMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiSoMoi.Location = new System.Drawing.Point(120, 168);
            this.txtChiSoMoi.Name = "txtChiSoMoi";
            this.txtChiSoMoi.Size = new System.Drawing.Size(183, 29);
            this.txtChiSoMoi.TabIndex = 5;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblGhiChu.Location = new System.Drawing.Point(20, 221);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(54, 17);
            this.lblGhiChu.TabIndex = 2;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNam.Location = new System.Drawing.Point(175, 20);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(39, 17);
            this.lblNam.TabIndex = 2;
            this.lblNam.Text = "Năm:";
            // 
            // cboThang
            // 
            this.cboThang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(70, 17);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(80, 25);
            this.cboThang.TabIndex = 1;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblThang.Location = new System.Drawing.Point(12, 20);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(47, 17);
            this.lblThang.TabIndex = 0;
            this.lblThang.Text = "Tháng:";
            // 
            // lblChiSoMoi
            // 
            this.lblChiSoMoi.AutoSize = true;
            this.lblChiSoMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiSoMoi.Location = new System.Drawing.Point(19, 171);
            this.lblChiSoMoi.Name = "lblChiSoMoi";
            this.lblChiSoMoi.Size = new System.Drawing.Size(94, 21);
            this.lblChiSoMoi.TabIndex = 1;
            this.lblChiSoMoi.Text = "Chỉ số mới:";
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Location = new System.Drawing.Point(420, 17);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(220, 25);
            this.cboKhuVuc.TabIndex = 3;
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblKhuVuc.Location = new System.Drawing.Point(350, 20);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(57, 17);
            this.lblKhuVuc.TabIndex = 4;
            this.lblKhuVuc.Text = "Khu vực:";
            // 
            // grpNhapChiSo
            // 
            this.grpNhapChiSo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNhapChiSo.Controls.Add(this.lblChiSoSu);
            this.grpNhapChiSo.Controls.Add(this.label2);
            this.grpNhapChiSo.Controls.Add(this.lblKhachHangValue);
            this.grpNhapChiSo.Controls.Add(this.lblKhachHang);
            this.grpNhapChiSo.Controls.Add(this.lblDongHoValue);
            this.grpNhapChiSo.Controls.Add(this.lblDongHo);
            this.grpNhapChiSo.Controls.Add(this.btnLuu);
            this.grpNhapChiSo.Controls.Add(this.txtGhiChu);
            this.grpNhapChiSo.Controls.Add(this.txtChiSoMoi);
            this.grpNhapChiSo.Controls.Add(this.lblGhiChu);
            this.grpNhapChiSo.Controls.Add(this.lblChiSoMoi);
            this.grpNhapChiSo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNhapChiSo.Location = new System.Drawing.Point(646, 77);
            this.grpNhapChiSo.Name = "grpNhapChiSo";
            this.grpNhapChiSo.Size = new System.Drawing.Size(326, 472);
            this.grpNhapChiSo.TabIndex = 11;
            this.grpNhapChiSo.TabStop = false;
            this.grpNhapChiSo.Text = "Nhập Chỉ Số";
            // 
            // pnlChonKy
            // 
            this.pnlChonKy.Controls.Add(this.btnHienThi);
            this.pnlChonKy.Controls.Add(this.cboKhuVuc);
            this.pnlChonKy.Controls.Add(this.lblKhuVuc);
            this.pnlChonKy.Controls.Add(this.txtNam);
            this.pnlChonKy.Controls.Add(this.lblNam);
            this.pnlChonKy.Controls.Add(this.cboThang);
            this.pnlChonKy.Controls.Add(this.lblThang);
            this.pnlChonKy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChonKy.Location = new System.Drawing.Point(0, 0);
            this.pnlChonKy.Name = "pnlChonKy";
            this.pnlChonKy.Size = new System.Drawing.Size(984, 60);
            this.pnlChonKy.TabIndex = 9;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(680, 14);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(180, 30);
            this.btnHienThi.TabIndex = 4;
            this.btnHienThi.Text = "Hiển thị danh sách cần ghi";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNam.Location = new System.Drawing.Point(220, 17);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 25);
            this.txtNam.TabIndex = 2;
            // 
            // FormGhiChiSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 550);
            this.Controls.Add(this.dgvDanhSachGhi);
            this.Controls.Add(this.grpNhapChiSo);
            this.Controls.Add(this.pnlChonKy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGhiChiSo";
            this.Text = "Ghi Chỉ Số Nước Hàng Tháng";
            this.Load += new System.EventHandler(this.FormGhiChiSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGhi)).EndInit();
            this.grpNhapChiSo.ResumeLayout(false);
            this.grpNhapChiSo.PerformLayout();
            this.pnlChonKy.ResumeLayout(false);
            this.pnlChonKy.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDanhSachGhi;
        private System.Windows.Forms.Label lblChiSoSu;
        private System.Windows.Forms.Label lblKhachHangValue;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblDongHoValue;
        private System.Windows.Forms.Label lblDongHo;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtChiSoMoi;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblChiSoMoi;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.GroupBox grpNhapChiSo;
        private System.Windows.Forms.Panel pnlChonKy;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.TextBox txtNam;
    }
}