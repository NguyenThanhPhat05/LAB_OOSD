namespace QuanLyNuocGiaiKhat
{
    partial class FrmThongKe
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
            this.lblTu = new System.Windows.Forms.Label();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.tabKQ = new System.Windows.Forms.TabControl();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.tabTonKho = new System.Windows.Forms.TabPage();
            this.tabCongNo = new System.Windows.Forms.TabPage();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.dgvTonKho = new System.Windows.Forms.DataGridView();
            this.dgvCongNo = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();
            this.lblTu.Name = "lblTu";
            this.lblTu.Location = new System.Drawing.Point(20, 23);
            this.lblTu.AutoSize = true;
            this.lblTu.Text = "Từ ngày";
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Location = new System.Drawing.Point(80, 20);
            this.dtTuNgay.Size = new System.Drawing.Size(160, 23);
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lblDen.Name = "lblDen";
            this.lblDen.Location = new System.Drawing.Point(270, 23);
            this.lblDen.AutoSize = true;
            this.lblDen.Text = "Đến ngày";
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Location = new System.Drawing.Point(340, 20);
            this.dtDenNgay.Size = new System.Drawing.Size(160, 23);
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Location = new System.Drawing.Point(530, 15);
            this.btnThongKe.Size = new System.Drawing.Size(120, 35);
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.tabKQ.Name = "tabKQ";
            this.tabKQ.Location = new System.Drawing.Point(10, 65);
            this.tabKQ.Size = new System.Drawing.Size(960, 480);
            this.tabDoanhThu.Text = "Doanh thu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanhThu.UseVisualStyleBackColor = true;
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabTonKho.Text = "Tồn kho";
            this.tabTonKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabTonKho.UseVisualStyleBackColor = true;
            this.tabTonKho.Name = "tabTonKho";
            this.tabCongNo.Text = "Công nợ khách quen";
            this.tabCongNo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCongNo.UseVisualStyleBackColor = true;
            this.tabCongNo.Name = "tabCongNo";
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AllowUserToDeleteRows = false;
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.MultiSelect = false;
            this.dgvDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.RowHeadersVisible = false;
            this.dgvTonKho.Name = "dgvTonKho";
            this.dgvTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTonKho.AllowUserToAddRows = false;
            this.dgvTonKho.AllowUserToDeleteRows = false;
            this.dgvTonKho.ReadOnly = true;
            this.dgvTonKho.MultiSelect = false;
            this.dgvTonKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTonKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTonKho.RowHeadersVisible = false;
            this.dgvCongNo.Name = "dgvCongNo";
            this.dgvCongNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCongNo.AllowUserToAddRows = false;
            this.dgvCongNo.AllowUserToDeleteRows = false;
            this.dgvCongNo.ReadOnly = true;
            this.dgvCongNo.MultiSelect = false;
            this.dgvCongNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongNo.RowHeadersVisible = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.dtTuNgay);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.dtDenNgay);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.tabKQ);
            this.tabKQ.Controls.Add(this.tabDoanhThu);
            this.tabKQ.Controls.Add(this.tabTonKho);
            this.tabKQ.Controls.Add(this.tabCongNo);
            this.tabDoanhThu.Controls.Add(this.dgvDoanhThu);
            this.tabTonKho.Controls.Add(this.dgvTonKho);
            this.tabCongNo.Controls.Add(this.dgvCongNo);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 560);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê báo cáo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.TabControl tabKQ;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.TabPage tabTonKho;
        private System.Windows.Forms.TabPage tabCongNo;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DataGridView dgvTonKho;
        private System.Windows.Forms.DataGridView dgvCongNo;
    }
}
