namespace QuanLyNuocGiaiKhat
{
    partial class FrmNuocGiaiKhat
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
            this.dgvNGK = new System.Windows.Forms.DataGridView();
            this.lbl_txtMaNGK = new System.Windows.Forms.Label();
            this.txtMaNGK = new System.Windows.Forms.TextBox();
            this.lbl_txtTenNGK = new System.Windows.Forms.Label();
            this.txtTenNGK = new System.Windows.Forms.TextBox();
            this.lbl_txtDVT = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.lbl_numDonGia = new System.Windows.Forms.Label();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.lbl_numTonKho = new System.Windows.Forms.Label();
            this.numTonKho = new System.Windows.Forms.NumericUpDown();
            this.lbl_cboLoai = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.lbl_cboNCU = new System.Windows.Forms.Label();
            this.cboNCU = new System.Windows.Forms.ComboBox();
            this.btnThemNGK = new System.Windows.Forms.Button();
            this.btnSuaNGK = new System.Windows.Forms.Button();
            this.btnXoaNGK = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.dgvNGK.Name = "dgvNGK";
            this.dgvNGK.Location = new System.Drawing.Point(10, 10);
            this.dgvNGK.Size = new System.Drawing.Size(960, 300);
            this.dgvNGK.AllowUserToAddRows = false;
            this.dgvNGK.AllowUserToDeleteRows = false;
            this.dgvNGK.ReadOnly = true;
            this.dgvNGK.MultiSelect = false;
            this.dgvNGK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNGK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNGK.RowHeadersVisible = false;
            this.lbl_txtMaNGK.Name = "lbl_txtMaNGK";
            this.lbl_txtMaNGK.Location = new System.Drawing.Point(20, 333);
            this.lbl_txtMaNGK.AutoSize = true;
            this.lbl_txtMaNGK.Text = "Mã NGK";
            this.txtMaNGK.Name = "txtMaNGK";
            this.txtMaNGK.Location = new System.Drawing.Point(140, 330);
            this.txtMaNGK.Size = new System.Drawing.Size(260, 23);
            this.lbl_txtTenNGK.Name = "lbl_txtTenNGK";
            this.lbl_txtTenNGK.Location = new System.Drawing.Point(500, 333);
            this.lbl_txtTenNGK.AutoSize = true;
            this.lbl_txtTenNGK.Text = "Tên NGK";
            this.txtTenNGK.Name = "txtTenNGK";
            this.txtTenNGK.Location = new System.Drawing.Point(620, 330);
            this.txtTenNGK.Size = new System.Drawing.Size(260, 23);
            this.lbl_txtDVT.Name = "lbl_txtDVT";
            this.lbl_txtDVT.Location = new System.Drawing.Point(20, 373);
            this.lbl_txtDVT.AutoSize = true;
            this.lbl_txtDVT.Text = "Đơn vị tính";
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Location = new System.Drawing.Point(140, 370);
            this.txtDVT.Size = new System.Drawing.Size(260, 23);
            this.lbl_numDonGia.Name = "lbl_numDonGia";
            this.lbl_numDonGia.Location = new System.Drawing.Point(500, 373);
            this.lbl_numDonGia.AutoSize = true;
            this.lbl_numDonGia.Text = "Đơn giá";
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Location = new System.Drawing.Point(620, 370);
            this.numDonGia.Size = new System.Drawing.Size(260, 23);
            this.numDonGia.Maximum = new decimal(new int[] {1000000000, 0, 0, 0});
            this.numDonGia.ThousandsSeparator = true;
            this.lbl_numTonKho.Name = "lbl_numTonKho";
            this.lbl_numTonKho.Location = new System.Drawing.Point(20, 413);
            this.lbl_numTonKho.AutoSize = true;
            this.lbl_numTonKho.Text = "Số lượng tồn";
            this.numTonKho.Name = "numTonKho";
            this.numTonKho.Location = new System.Drawing.Point(140, 410);
            this.numTonKho.Size = new System.Drawing.Size(260, 23);
            this.numTonKho.Maximum = new decimal(new int[] {1000000000, 0, 0, 0});
            this.numTonKho.ThousandsSeparator = true;
            this.lbl_cboLoai.Name = "lbl_cboLoai";
            this.lbl_cboLoai.Location = new System.Drawing.Point(500, 413);
            this.lbl_cboLoai.AutoSize = true;
            this.lbl_cboLoai.Text = "Loại (nhãn hiệu)";
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Location = new System.Drawing.Point(620, 410);
            this.cboLoai.Size = new System.Drawing.Size(260, 23);
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FormattingEnabled = true;
            this.lbl_cboNCU.Name = "lbl_cboNCU";
            this.lbl_cboNCU.Location = new System.Drawing.Point(20, 453);
            this.lbl_cboNCU.AutoSize = true;
            this.lbl_cboNCU.Text = "Nhà cung ứng";
            this.cboNCU.Name = "cboNCU";
            this.cboNCU.Location = new System.Drawing.Point(140, 450);
            this.cboNCU.Size = new System.Drawing.Size(260, 23);
            this.cboNCU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCU.FormattingEnabled = true;
            this.btnThemNGK.Name = "btnThemNGK";
            this.btnThemNGK.Location = new System.Drawing.Point(20, 500);
            this.btnThemNGK.Size = new System.Drawing.Size(110, 38);
            this.btnThemNGK.Text = "Thêm";
            this.btnThemNGK.UseVisualStyleBackColor = true;
            this.btnSuaNGK.Name = "btnSuaNGK";
            this.btnSuaNGK.Location = new System.Drawing.Point(150, 500);
            this.btnSuaNGK.Size = new System.Drawing.Size(110, 38);
            this.btnSuaNGK.Text = "Sửa";
            this.btnSuaNGK.UseVisualStyleBackColor = true;
            this.btnXoaNGK.Name = "btnXoaNGK";
            this.btnXoaNGK.Location = new System.Drawing.Point(280, 500);
            this.btnXoaNGK.Size = new System.Drawing.Size(110, 38);
            this.btnXoaNGK.Text = "Xóa";
            this.btnXoaNGK.UseVisualStyleBackColor = true;
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Location = new System.Drawing.Point(410, 500);
            this.btnLamMoi.Size = new System.Drawing.Size(110, 38);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnThemNGK.Click += new System.EventHandler(this.btnThemNGK_Click);
            this.btnSuaNGK.Click += new System.EventHandler(this.btnSuaNGK_Click);
            this.btnXoaNGK.Click += new System.EventHandler(this.btnXoaNGK_Click);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            this.Controls.Add(this.dgvNGK);
            this.Controls.Add(this.lbl_txtMaNGK);
            this.Controls.Add(this.txtMaNGK);
            this.Controls.Add(this.lbl_txtTenNGK);
            this.Controls.Add(this.txtTenNGK);
            this.Controls.Add(this.lbl_txtDVT);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.lbl_numDonGia);
            this.Controls.Add(this.numDonGia);
            this.Controls.Add(this.lbl_numTonKho);
            this.Controls.Add(this.numTonKho);
            this.Controls.Add(this.lbl_cboLoai);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.lbl_cboNCU);
            this.Controls.Add(this.cboNCU);
            this.Controls.Add(this.btnThemNGK);
            this.Controls.Add(this.btnSuaNGK);
            this.Controls.Add(this.btnXoaNGK);
            this.Controls.Add(this.btnLamMoi);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 560);
            this.Name = "FrmNuocGiaiKhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nước giải khát & tồn kho";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.DataGridView dgvNGK;
        private System.Windows.Forms.Label lbl_txtMaNGK;
        private System.Windows.Forms.TextBox txtMaNGK;
        private System.Windows.Forms.Label lbl_txtTenNGK;
        private System.Windows.Forms.TextBox txtTenNGK;
        private System.Windows.Forms.Label lbl_txtDVT;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label lbl_numDonGia;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.Label lbl_numTonKho;
        private System.Windows.Forms.NumericUpDown numTonKho;
        private System.Windows.Forms.Label lbl_cboLoai;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label lbl_cboNCU;
        private System.Windows.Forms.ComboBox cboNCU;
        private System.Windows.Forms.Button btnThemNGK;
        private System.Windows.Forms.Button btnSuaNGK;
        private System.Windows.Forms.Button btnXoaNGK;
        private System.Windows.Forms.Button btnLamMoi;
    }
}
