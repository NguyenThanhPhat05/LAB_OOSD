namespace QuanLyNuocGiaiKhat
{
    partial class FrmPhieuNo
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
            this.lblSoPN = new System.Windows.Forms.Label();
            this.txtSoPhieuNo = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.cboKhachQuen = new System.Windows.Forms.ComboBox();
            this.lblNVL = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblTienNo = new System.Windows.Forms.Label();
            this.numSoTienNo = new System.Windows.Forms.NumericUpDown();
            this.lblHen = new System.Windows.Forms.Label();
            this.dtNgayHenTra = new System.Windows.Forms.DateTimePicker();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.btnLapPhieuNo = new System.Windows.Forms.Button();
            this.lblDS = new System.Windows.Forms.Label();
            this.dgvDanhSachNo = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();
            this.lblSoPN.Name = "lblSoPN";
            this.lblSoPN.Location = new System.Drawing.Point(20, 23);
            this.lblSoPN.AutoSize = true;
            this.lblSoPN.Text = "Số phiếu nợ";
            this.txtSoPhieuNo.Name = "txtSoPhieuNo";
            this.txtSoPhieuNo.Location = new System.Drawing.Point(130, 20);
            this.txtSoPhieuNo.Size = new System.Drawing.Size(220, 23);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Location = new System.Drawing.Point(20, 63);
            this.lblKQ.AutoSize = true;
            this.lblKQ.Text = "Khách quen";
            this.cboKhachQuen.Name = "cboKhachQuen";
            this.cboKhachQuen.Location = new System.Drawing.Point(130, 60);
            this.cboKhachQuen.Size = new System.Drawing.Size(220, 23);
            this.cboKhachQuen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachQuen.FormattingEnabled = true;
            this.lblNVL.Name = "lblNVL";
            this.lblNVL.Location = new System.Drawing.Point(20, 103);
            this.lblNVL.AutoSize = true;
            this.lblNVL.Text = "Nhân viên lập";
            this.cboNV.Name = "cboNV";
            this.cboNV.Location = new System.Drawing.Point(130, 100);
            this.cboNV.Size = new System.Drawing.Size(220, 23);
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.lblTienNo.Name = "lblTienNo";
            this.lblTienNo.Location = new System.Drawing.Point(400, 23);
            this.lblTienNo.AutoSize = true;
            this.lblTienNo.Text = "Số tiền nợ";
            this.numSoTienNo.Name = "numSoTienNo";
            this.numSoTienNo.Location = new System.Drawing.Point(500, 20);
            this.numSoTienNo.Size = new System.Drawing.Size(220, 23);
            this.numSoTienNo.Maximum = new decimal(new int[] {1000000000, 0, 0, 0});
            this.numSoTienNo.ThousandsSeparator = true;
            this.lblHen.Name = "lblHen";
            this.lblHen.Location = new System.Drawing.Point(400, 63);
            this.lblHen.AutoSize = true;
            this.lblHen.Text = "Ngày hẹn trả";
            this.dtNgayHenTra.Name = "dtNgayHenTra";
            this.dtNgayHenTra.Location = new System.Drawing.Point(500, 60);
            this.dtNgayHenTra.Size = new System.Drawing.Size(220, 23);
            this.dtNgayHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Location = new System.Drawing.Point(400, 103);
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Text = "Lý do nợ";
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Location = new System.Drawing.Point(500, 100);
            this.txtLyDo.Size = new System.Drawing.Size(300, 60);
            this.txtLyDo.Multiline = true;
            this.btnLapPhieuNo.Name = "btnLapPhieuNo";
            this.btnLapPhieuNo.Location = new System.Drawing.Point(830, 100);
            this.btnLapPhieuNo.Size = new System.Drawing.Size(140, 45);
            this.btnLapPhieuNo.Text = "Lập phiếu nợ";
            this.btnLapPhieuNo.UseVisualStyleBackColor = true;
            this.lblDS.Name = "lblDS";
            this.lblDS.Location = new System.Drawing.Point(20, 175);
            this.lblDS.AutoSize = true;
            this.lblDS.Text = "Danh sách phiếu nợ chưa trả";
            this.dgvDanhSachNo.Name = "dgvDanhSachNo";
            this.dgvDanhSachNo.Location = new System.Drawing.Point(20, 200);
            this.dgvDanhSachNo.Size = new System.Drawing.Size(950, 400);
            this.dgvDanhSachNo.AllowUserToAddRows = false;
            this.dgvDanhSachNo.AllowUserToDeleteRows = false;
            this.dgvDanhSachNo.ReadOnly = true;
            this.dgvDanhSachNo.MultiSelect = false;
            this.dgvDanhSachNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNo.RowHeadersVisible = false;
            this.btnLapPhieuNo.Click += new System.EventHandler(this.btnLapPhieuNo_Click);
            this.Controls.Add(this.lblSoPN);
            this.Controls.Add(this.txtSoPhieuNo);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.cboKhachQuen);
            this.Controls.Add(this.lblNVL);
            this.Controls.Add(this.cboNV);
            this.Controls.Add(this.lblTienNo);
            this.Controls.Add(this.numSoTienNo);
            this.Controls.Add(this.lblHen);
            this.Controls.Add(this.dtNgayHenTra);
            this.Controls.Add(this.lblLyDo);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.btnLapPhieuNo);
            this.Controls.Add(this.lblDS);
            this.Controls.Add(this.dgvDanhSachNo);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 620);
            this.Name = "FrmPhieuNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phiếu ghi nợ trả chậm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblSoPN;
        private System.Windows.Forms.TextBox txtSoPhieuNo;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.ComboBox cboKhachQuen;
        private System.Windows.Forms.Label lblNVL;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblTienNo;
        private System.Windows.Forms.NumericUpDown numSoTienNo;
        private System.Windows.Forms.Label lblHen;
        private System.Windows.Forms.DateTimePicker dtNgayHenTra;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Button btnLapPhieuNo;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.DataGridView dgvDanhSachNo;
    }
}
