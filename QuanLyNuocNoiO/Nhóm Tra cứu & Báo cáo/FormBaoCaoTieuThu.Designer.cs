namespace QuanLyNuocNoiO.Nhóm_Tra_cứu___Báo_cáo
{
    partial class FormBaoCaoTieuThu
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
            this.lblTongTieuThu = new System.Windows.Forms.Label();
            this.lblTongTieuThuValue = new System.Windows.Forms.Label();
            this.pnlTongCong = new System.Windows.Forms.Panel();
            this.lblThang = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTieuThu = new System.Windows.Forms.DataGridView();
            this.pnlTongCong.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTieuThu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTongTieuThu
            // 
            this.lblTongTieuThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTieuThu.AutoSize = true;
            this.lblTongTieuThu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTongTieuThu.Location = new System.Drawing.Point(525, 7);
            this.lblTongTieuThu.Name = "lblTongTieuThu";
            this.lblTongTieuThu.Size = new System.Drawing.Size(248, 25);
            this.lblTongTieuThu.TabIndex = 0;
            this.lblTongTieuThu.Text = "Tổng Sản Lượng Tiêu Thụ:";
            // 
            // lblTongTieuThuValue
            // 
            this.lblTongTieuThuValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTieuThuValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTongTieuThuValue.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTongTieuThuValue.Location = new System.Drawing.Point(747, 7);
            this.lblTongTieuThuValue.Name = "lblTongTieuThuValue";
            this.lblTongTieuThuValue.Size = new System.Drawing.Size(225, 25);
            this.lblTongTieuThuValue.TabIndex = 1;
            this.lblTongTieuThuValue.Text = "0 m³";
            this.lblTongTieuThuValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTongCong
            // 
            this.pnlTongCong.Controls.Add(this.lblTongTieuThuValue);
            this.pnlTongCong.Controls.Add(this.lblTongTieuThu);
            this.pnlTongCong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTongCong.Location = new System.Drawing.Point(0, 510);
            this.pnlTongCong.Name = "pnlTongCong";
            this.pnlTongCong.Size = new System.Drawing.Size(984, 40);
            this.pnlTongCong.TabIndex = 4;
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
            // cboThang
            // 
            this.cboThang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(70, 17);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(80, 25);
            this.cboThang.TabIndex = 1;
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
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNam.Location = new System.Drawing.Point(220, 17);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 25);
            this.txtNam.TabIndex = 2;
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
            // cboKhuVuc
            // 
            this.cboKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Location = new System.Drawing.Point(420, 17);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(220, 25);
            this.cboKhuVuc.TabIndex = 3;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnThongKe);
            this.pnlControls.Controls.Add(this.cboKhuVuc);
            this.pnlControls.Controls.Add(this.lblKhuVuc);
            this.pnlControls.Controls.Add(this.txtNam);
            this.pnlControls.Controls.Add(this.lblNam);
            this.pnlControls.Controls.Add(this.cboThang);
            this.pnlControls.Controls.Add(this.lblThang);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(984, 60);
            this.pnlControls.TabIndex = 3;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(680, 14);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(120, 30);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.BtnThongKe_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTieuThu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 450);
            this.panel1.TabIndex = 5;
            // 
            // dgvTieuThu
            // 
            this.dgvTieuThu.AllowUserToAddRows = false;
            this.dgvTieuThu.AllowUserToDeleteRows = false;
            this.dgvTieuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTieuThu.Location = new System.Drawing.Point(0, 0);
            this.dgvTieuThu.Name = "dgvTieuThu";
            this.dgvTieuThu.ReadOnly = true;
            this.dgvTieuThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTieuThu.Size = new System.Drawing.Size(984, 450);
            this.dgvTieuThu.TabIndex = 6;
            // 
            // FormBaoCaoTieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlTongCong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaoCaoTieuThu";
            this.Text = "Báo Cáo Sản Lượng Tiêu Thụ";
            this.Load += new System.EventHandler(this.FormBaoCaoTieuThu_Load);
            this.pnlTongCong.ResumeLayout(false);
            this.pnlTongCong.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTieuThu)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label lblTongTieuThu;
        private System.Windows.Forms.Label lblTongTieuThuValue;
        private System.Windows.Forms.Panel pnlTongCong;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTieuThu;
    }
}