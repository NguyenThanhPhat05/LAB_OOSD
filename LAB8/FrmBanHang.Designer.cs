namespace QuanLyNuocGiaiKhat
{
    partial class FrmBanHang
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
            this.lblSoHD = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.lblKH = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblNVB = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblNL = new System.Windows.Forms.Label();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblKho = new System.Windows.Forms.Label();
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.lblSL = new System.Windows.Forms.Label();
            this.numSLMua = new System.Windows.Forms.NumericUpDown();
            this.btnThemGH = new System.Windows.Forms.Button();
            this.lblGio = new System.Windows.Forms.Label();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.lblTongTienCap = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Location = new System.Drawing.Point(10, 18);
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Text = "Số HD";
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Location = new System.Drawing.Point(70, 15);
            this.txtSoHD.Size = new System.Drawing.Size(110, 23);
            this.lblKH.Name = "lblKH";
            this.lblKH.Location = new System.Drawing.Point(200, 18);
            this.lblKH.AutoSize = true;
            this.lblKH.Text = "Khách hàng";
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Location = new System.Drawing.Point(285, 15);
            this.cboKhachHang.Size = new System.Drawing.Size(200, 23);
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FormattingEnabled = true;
            this.lblNVB.Name = "lblNVB";
            this.lblNVB.Location = new System.Drawing.Point(510, 18);
            this.lblNVB.AutoSize = true;
            this.lblNVB.Text = "Nhân viên bán";
            this.cboNV.Name = "cboNV";
            this.cboNV.Location = new System.Drawing.Point(610, 15);
            this.cboNV.Size = new System.Drawing.Size(180, 23);
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.lblNL.Name = "lblNL";
            this.lblNL.Location = new System.Drawing.Point(810, 18);
            this.lblNL.AutoSize = true;
            this.lblNL.Text = "Ngày lập";
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Location = new System.Drawing.Point(875, 15);
            this.dtNgayLap.Size = new System.Drawing.Size(200, 23);
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lblKho.Name = "lblKho";
            this.lblKho.Location = new System.Drawing.Point(10, 55);
            this.lblKho.AutoSize = true;
            this.lblKho.Text = "Kho hàng hiện tại";
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.Location = new System.Drawing.Point(10, 80);
            this.dgvKho.Size = new System.Drawing.Size(520, 470);
            this.dgvKho.AllowUserToAddRows = false;
            this.dgvKho.AllowUserToDeleteRows = false;
            this.dgvKho.ReadOnly = true;
            this.dgvKho.MultiSelect = false;
            this.dgvKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKho.RowHeadersVisible = false;
            this.lblSL.Name = "lblSL";
            this.lblSL.Location = new System.Drawing.Point(10, 573);
            this.lblSL.AutoSize = true;
            this.lblSL.Text = "Số lượng mua";
            this.numSLMua.Name = "numSLMua";
            this.numSLMua.Location = new System.Drawing.Point(110, 570);
            this.numSLMua.Size = new System.Drawing.Size(100, 23);
            this.numSLMua.Maximum = new decimal(new int[] {1000000000, 0, 0, 0});
            this.numSLMua.ThousandsSeparator = true;
            this.btnThemGH.Name = "btnThemGH";
            this.btnThemGH.Location = new System.Drawing.Point(230, 563);
            this.btnThemGH.Size = new System.Drawing.Size(180, 38);
            this.btnThemGH.Text = "Thêm vào giỏ hàng";
            this.btnThemGH.UseVisualStyleBackColor = true;
            this.lblGio.Name = "lblGio";
            this.lblGio.Location = new System.Drawing.Point(550, 55);
            this.lblGio.AutoSize = true;
            this.lblGio.Text = "Giỏ hàng (chi tiết hóa đơn)";
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.Location = new System.Drawing.Point(550, 80);
            this.dgvGioHang.Size = new System.Drawing.Size(530, 400);
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AllowUserToDeleteRows = false;
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.MultiSelect = false;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.RowHeadersVisible = false;
            this.lblTongTienCap.Name = "lblTongTienCap";
            this.lblTongTienCap.Location = new System.Drawing.Point(550, 505);
            this.lblTongTienCap.AutoSize = true;
            this.lblTongTienCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongTienCap.Text = "Tổng tiền:";
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Location = new System.Drawing.Point(650, 505);
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTongTien.Text = "0";
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Location = new System.Drawing.Point(800, 555);
            this.btnThanhToan.Size = new System.Drawing.Size(280, 50);
            this.btnThanhToan.Text = "Thanh toán / Lập hóa đơn";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThemGH.Click += new System.EventHandler(this.btnThemGH_Click);
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            this.Controls.Add(this.lblSoHD);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.lblKH);
            this.Controls.Add(this.cboKhachHang);
            this.Controls.Add(this.lblNVB);
            this.Controls.Add(this.cboNV);
            this.Controls.Add(this.lblNL);
            this.Controls.Add(this.dtNgayLap);
            this.Controls.Add(this.lblKho);
            this.Controls.Add(this.dgvKho);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.numSLMua);
            this.Controls.Add(this.btnThemGH);
            this.Controls.Add(this.lblGio);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.lblTongTienCap);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnThanhToan);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 620);
            this.Name = "FrmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng & Lập hóa đơn";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblNVB;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblNL;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.Label lblKho;
        private System.Windows.Forms.DataGridView dgvKho;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.NumericUpDown numSLMua;
        private System.Windows.Forms.Button btnThemGH;
        private System.Windows.Forms.Label lblGio;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Label lblTongTienCap;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnThanhToan;
    }
}
