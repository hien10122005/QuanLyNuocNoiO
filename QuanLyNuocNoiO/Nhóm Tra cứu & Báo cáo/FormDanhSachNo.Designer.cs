namespace QuanLyNuocNoiO.Nhóm_Tra_cứu___Báo_cáo
{
    partial class FormDanhSachNo
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnKhoaKhachHang = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDanhSachNo = new System.Windows.Forms.DataGridView();
            this.btnMoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Red;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(900, 50);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "DANH SÁCH KHÁCH HÀNG NỢ TIỀN NƯỚC";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKhoaKhachHang
            // 
            this.btnKhoaKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoaKhachHang.BackColor = System.Drawing.Color.OrangeRed;
            this.btnKhoaKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhoaKhachHang.Location = new System.Drawing.Point(738, 9);
            this.btnKhoaKhachHang.Name = "btnKhoaKhachHang";
            this.btnKhoaKhachHang.Size = new System.Drawing.Size(150, 40);
            this.btnKhoaKhachHang.TabIndex = 2;
            this.btnKhoaKhachHang.Text = "Khóa Khách Hàng";
            this.btnKhoaKhachHang.UseVisualStyleBackColor = false;
            this.btnKhoaKhachHang.Click += new System.EventHandler(this.btnKhoaKhachHang_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(0, 0);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Khu vực:";
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Location = new System.Drawing.Point(73, 6);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(200, 21);
            this.cboKhuVuc.TabIndex = 4;
            this.cboKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cboKhuVuc_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboKhuVuc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 46);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDanhSachNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 364);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMoi);
            this.panel3.Controls.Add(this.btnKhoaKhachHang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 61);
            this.panel3.TabIndex = 8;
            // 
            // dgvDanhSachNo
            // 
            this.dgvDanhSachNo.AllowUserToAddRows = false;
            this.dgvDanhSachNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachNo.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachNo.Name = "dgvDanhSachNo";
            this.dgvDanhSachNo.Size = new System.Drawing.Size(900, 364);
            this.dgvDanhSachNo.TabIndex = 0;
            // 
            // btnMoi
            // 
            this.btnMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMoi.BackColor = System.Drawing.Color.OrangeRed;
            this.btnMoi.ForeColor = System.Drawing.Color.White;
            this.btnMoi.Location = new System.Drawing.Point(12, 9);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(150, 40);
            this.btnMoi.TabIndex = 3;
            this.btnMoi.Text = "Làm Mới";
            this.btnMoi.UseVisualStyleBackColor = false;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // FormDanhSachNo
            // 
            this.ClientSize = new System.Drawing.Size(900, 460);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormDanhSachNo";
            this.Load += new System.EventHandler(this.FormDanhSachNo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNo)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnKhoaKhachHang;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDanhSachNo;
        private System.Windows.Forms.Button btnMoi;
    }
}