namespace QuanLyNuocGiaiKhat
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnNGK = new System.Windows.Forms.Button();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnPhieuNo = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Location = new System.Drawing.Point(20, 20);
            this.lblTieuDe.Size = new System.Drawing.Size(560, 50);
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTieuDe.Text = "HỆ THỐNG QUẢN LÝ CỬA HÀNG NƯỚC GIẢI KHÁT";
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Location = new System.Drawing.Point(50, 100);
            this.btnDanhMuc.Size = new System.Drawing.Size(250, 70);
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDanhMuc.Text = "1. Danh mục nền";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnNGK.Name = "btnNGK";
            this.btnNGK.Location = new System.Drawing.Point(320, 100);
            this.btnNGK.Size = new System.Drawing.Size(250, 70);
            this.btnNGK.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNGK.Text = "2. Quản lý Nước giải khát";
            this.btnNGK.UseVisualStyleBackColor = true;
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Location = new System.Drawing.Point(50, 190);
            this.btnDatHang.Size = new System.Drawing.Size(250, 70);
            this.btnDatHang.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDatHang.Text = "3. Đặt hàng & Giao hàng (3 đợt)";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Location = new System.Drawing.Point(320, 190);
            this.btnBanHang.Size = new System.Drawing.Size(250, 70);
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBanHang.Text = "4. Bán hàng & Hóa đơn";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnPhieuNo.Name = "btnPhieuNo";
            this.btnPhieuNo.Location = new System.Drawing.Point(50, 280);
            this.btnPhieuNo.Size = new System.Drawing.Size(250, 70);
            this.btnPhieuNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPhieuNo.Text = "5. Quản lý Phiếu ghi nợ";
            this.btnPhieuNo.UseVisualStyleBackColor = true;
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Location = new System.Drawing.Point(320, 280);
            this.btnThongKe.Size = new System.Drawing.Size(250, 70);
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnThongKe.Text = "6. Thống kê báo cáo";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Location = new System.Drawing.Point(240, 400);
            this.btnThoat.Size = new System.Drawing.Size(120, 45);
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            this.btnNGK.Click += new System.EventHandler(this.btnNGK_Click);
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            this.btnPhieuNo.Click += new System.EventHandler(this.btnPhieuNo_Click);
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.btnNGK);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.btnPhieuNo);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnThoat);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý cửa hàng nước giải khát";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnNGK;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnPhieuNo;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
    }
}
