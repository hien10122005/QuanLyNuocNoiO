namespace QuanLyNuocNoiO.Nhóm_Tra_cứu___Báo_cáo
{
    partial class FormBaoCaoDoanhThu
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
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.pnlTongCong = new System.Windows.Forms.Panel();
            this.lblTongDoanhThuValue = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            this.pnlTongCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.txtNam);
            this.pnlControls.Controls.Add(this.lblNam);
            this.pnlControls.Controls.Add(this.cboThang);
            this.pnlControls.Controls.Add(this.lblThang);
            this.pnlControls.Controls.Add(this.btnThongKe);
            this.pnlControls.Controls.Add(this.cboKhuVuc);
            this.pnlControls.Controls.Add(this.lblKhuVuc);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(984, 60);
            this.pnlControls.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.Location = new System.Drawing.Point(822, 20);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(120, 30);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.BtnThongKe_Click);
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Location = new System.Drawing.Point(580, 17);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(220, 25);
            this.cboKhuVuc.TabIndex = 5;
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblKhuVuc.Location = new System.Drawing.Point(510, 20);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(57, 17);
            this.lblKhuVuc.TabIndex = 2;
            this.lblKhuVuc.Text = "Khu vực:";
            // 
            // pnlTongCong
            // 
            this.pnlTongCong.Controls.Add(this.lblTongDoanhThuValue);
            this.pnlTongCong.Controls.Add(this.lblTongDoanhThu);
            this.pnlTongCong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTongCong.Location = new System.Drawing.Point(0, 510);
            this.pnlTongCong.Name = "pnlTongCong";
            this.pnlTongCong.Size = new System.Drawing.Size(984, 40);
            this.pnlTongCong.TabIndex = 1;
            // 
            // lblTongDoanhThuValue
            // 
            this.lblTongDoanhThuValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongDoanhThuValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThuValue.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTongDoanhThuValue.Location = new System.Drawing.Point(747, 7);
            this.lblTongDoanhThuValue.Name = "lblTongDoanhThuValue";
            this.lblTongDoanhThuValue.Size = new System.Drawing.Size(225, 25);
            this.lblTongDoanhThuValue.TabIndex = 1;
            this.lblTongDoanhThuValue.Text = "0 VNĐ";
            this.lblTongDoanhThuValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.Location = new System.Drawing.Point(569, 7);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(167, 25);
            this.lblTongDoanhThu.TabIndex = 0;
            this.lblTongDoanhThu.Text = "Tổng Doanh Thu:";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AllowUserToDeleteRows = false;
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThu.Location = new System.Drawing.Point(0, 60);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThu.Size = new System.Drawing.Size(984, 450);
            this.dgvDoanhThu.TabIndex = 2;
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNam.Location = new System.Drawing.Point(244, 17);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 25);
            this.txtNam.TabIndex = 9;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNam.Location = new System.Drawing.Point(199, 20);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(39, 17);
            this.lblNam.TabIndex = 10;
            this.lblNam.Text = "Năm:";
            // 
            // cboThang
            // 
            this.cboThang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(94, 17);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(80, 25);
            this.cboThang.TabIndex = 8;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblThang.Location = new System.Drawing.Point(36, 20);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(47, 17);
            this.lblThang.TabIndex = 7;
            this.lblThang.Text = "Tháng:";
            // 
            // FormBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 550);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.pnlTongCong);
            this.Controls.Add(this.pnlControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaoCaoDoanhThu";
            this.Text = "Báo Cáo Doanh Thu";
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlTongCong.ResumeLayout(false);
            this.pnlTongCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel pnlTongCong;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThuValue;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label lblThang;
    }
}