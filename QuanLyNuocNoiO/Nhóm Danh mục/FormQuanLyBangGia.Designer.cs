namespace QuanLyNuocNoiO.Nhóm_Danh_mục
{
    partial class FormQuanLyBangGia
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgayApDung = new System.Windows.Forms.DateTimePicker();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtBacDen = new System.Windows.Forms.TextBox();
            this.txtBacTu = new System.Windows.Forms.TextBox();
            this.txtTenBangGia = new System.Windows.Forms.TextBox();
            this.txtMaBangGia = new System.Windows.Forms.TextBox();
            this.lblNgayApDung = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblBacDen = new System.Windows.Forms.Label();
            this.lblTenBangGia = new System.Windows.Forms.Label();
            this.lblMaBangGia = new System.Windows.Forms.Label();
            this.dgvBangGia = new System.Windows.Forms.DataGridView();
            this.lblBacTu = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.pnlChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangGia)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(198, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(13, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // dtpNgayApDung
            // 
            this.dtpNgayApDung.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayApDung.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpNgayApDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayApDung.Location = new System.Drawing.Point(135, 285);
            this.dtpNgayApDung.Name = "dtpNgayApDung";
            this.dtpNgayApDung.Size = new System.Drawing.Size(230, 25);
            this.dtpNgayApDung.TabIndex = 5;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDonGia.Location = new System.Drawing.Point(135, 238);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(230, 25);
            this.txtDonGia.TabIndex = 4;
            // 
            // txtBacDen
            // 
            this.txtBacDen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtBacDen.Location = new System.Drawing.Point(135, 191);
            this.txtBacDen.Name = "txtBacDen";
            this.txtBacDen.Size = new System.Drawing.Size(230, 25);
            this.txtBacDen.TabIndex = 3;
            // 
            // txtBacTu
            // 
            this.txtBacTu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtBacTu.Location = new System.Drawing.Point(135, 144);
            this.txtBacTu.Name = "txtBacTu";
            this.txtBacTu.Size = new System.Drawing.Size(230, 25);
            this.txtBacTu.TabIndex = 2;
            // 
            // txtTenBangGia
            // 
            this.txtTenBangGia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTenBangGia.Location = new System.Drawing.Point(135, 97);
            this.txtTenBangGia.Name = "txtTenBangGia";
            this.txtTenBangGia.Size = new System.Drawing.Size(230, 25);
            this.txtTenBangGia.TabIndex = 1;
            // 
            // txtMaBangGia
            // 
            this.txtMaBangGia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMaBangGia.Location = new System.Drawing.Point(135, 50);
            this.txtMaBangGia.Name = "txtMaBangGia";
            this.txtMaBangGia.Size = new System.Drawing.Size(230, 25);
            this.txtMaBangGia.TabIndex = 0;
            // 
            // lblNgayApDung
            // 
            this.lblNgayApDung.AutoSize = true;
            this.lblNgayApDung.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNgayApDung.Location = new System.Drawing.Point(20, 290);
            this.lblNgayApDung.Name = "lblNgayApDung";
            this.lblNgayApDung.Size = new System.Drawing.Size(95, 17);
            this.lblNgayApDung.TabIndex = 5;
            this.lblNgayApDung.Text = "Ngày áp dụng:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(298, 10);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 40);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChucNang.Controls.Add(this.btnLuu);
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.btnSua);
            this.pnlChucNang.Controls.Add(this.btnThem);
            this.pnlChucNang.Location = new System.Drawing.Point(588, 370);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(384, 60);
            this.pnlChucNang.TabIndex = 5;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(108, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDonGia.Location = new System.Drawing.Point(20, 241);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(57, 17);
            this.lblDonGia.TabIndex = 4;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblBacDen
            // 
            this.lblBacDen.AutoSize = true;
            this.lblBacDen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBacDen.Location = new System.Drawing.Point(20, 194);
            this.lblBacDen.Name = "lblBacDen";
            this.lblBacDen.Size = new System.Drawing.Size(57, 17);
            this.lblBacDen.TabIndex = 3;
            this.lblBacDen.Text = "Bậc đến:";
            // 
            // lblTenBangGia
            // 
            this.lblTenBangGia.AutoSize = true;
            this.lblTenBangGia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTenBangGia.Location = new System.Drawing.Point(20, 100);
            this.lblTenBangGia.Name = "lblTenBangGia";
            this.lblTenBangGia.Size = new System.Drawing.Size(87, 17);
            this.lblTenBangGia.TabIndex = 1;
            this.lblTenBangGia.Text = "Tên bảng giá:";
            // 
            // lblMaBangGia
            // 
            this.lblMaBangGia.AutoSize = true;
            this.lblMaBangGia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMaBangGia.Location = new System.Drawing.Point(20, 53);
            this.lblMaBangGia.Name = "lblMaBangGia";
            this.lblMaBangGia.Size = new System.Drawing.Size(86, 17);
            this.lblMaBangGia.TabIndex = 0;
            this.lblMaBangGia.Text = "Mã bảng giá:";
            // 
            // dgvBangGia
            // 
            this.dgvBangGia.AllowUserToAddRows = false;
            this.dgvBangGia.AllowUserToDeleteRows = false;
            this.dgvBangGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangGia.Location = new System.Drawing.Point(12, 12);
            this.dgvBangGia.MultiSelect = false;
            this.dgvBangGia.Name = "dgvBangGia";
            this.dgvBangGia.ReadOnly = true;
            this.dgvBangGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangGia.Size = new System.Drawing.Size(560, 526);
            this.dgvBangGia.TabIndex = 3;
            this.dgvBangGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGia_CellClick);
            // 
            // lblBacTu
            // 
            this.lblBacTu.AutoSize = true;
            this.lblBacTu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBacTu.Location = new System.Drawing.Point(20, 147);
            this.lblBacTu.Name = "lblBacTu";
            this.lblBacTu.Size = new System.Drawing.Size(47, 17);
            this.lblBacTu.TabIndex = 2;
            this.lblBacTu.Text = "Bậc từ:";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.dtpNgayApDung);
            this.grpThongTin.Controls.Add(this.txtDonGia);
            this.grpThongTin.Controls.Add(this.txtBacDen);
            this.grpThongTin.Controls.Add(this.txtBacTu);
            this.grpThongTin.Controls.Add(this.txtTenBangGia);
            this.grpThongTin.Controls.Add(this.txtMaBangGia);
            this.grpThongTin.Controls.Add(this.lblNgayApDung);
            this.grpThongTin.Controls.Add(this.lblDonGia);
            this.grpThongTin.Controls.Add(this.lblBacDen);
            this.grpThongTin.Controls.Add(this.lblBacTu);
            this.grpThongTin.Controls.Add(this.lblTenBangGia);
            this.grpThongTin.Controls.Add(this.lblMaBangGia);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTin.Location = new System.Drawing.Point(588, 12);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(384, 340);
            this.grpThongTin.TabIndex = 4;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin Bảng giá";
            // 
            // FormQuanLyBangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 550);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.dgvBangGia);
            this.Controls.Add(this.grpThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyBangGia";
            this.Text = "Quản Lý Bảng Giá";
            this.Load += new System.EventHandler(this.FormQuanLyBangGia_Load);
            this.pnlChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangGia)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayApDung;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtBacDen;
        private System.Windows.Forms.TextBox txtBacTu;
        private System.Windows.Forms.TextBox txtTenBangGia;
        private System.Windows.Forms.TextBox txtMaBangGia;
        private System.Windows.Forms.Label lblNgayApDung;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblBacDen;
        private System.Windows.Forms.Label lblTenBangGia;
        private System.Windows.Forms.Label lblMaBangGia;
        private System.Windows.Forms.DataGridView dgvBangGia;
        private System.Windows.Forms.Label lblBacTu;
        private System.Windows.Forms.GroupBox grpThongTin;
    }
}