using System;
using System.Windows.Forms;

namespace QuanLyEShopping.From
{
    public partial class FrmQuanLyGioHang : Form
    {
        public FrmQuanLyGioHang()
        {
            InitializeComponent();
        }

        private void FrmQuanLyGioHang_Load(object sender, EventArgs e)
        {
            LoadDataMatDinh();
        }

        private void LoadDataMatDinh()
        {
            DataGridView dgv = FindDgv(this);
            if (dgv != null)
            {
                // Tắt tự động tạo cột mới
                dgv.AutoGenerateColumns = false;
                dgv.Rows.Clear();

                // Thêm trực tiếp 3 dòng dữ liệu mẫu khớp đúng 5 cột trên giao diện của bạn:
                // Cột 0: Mã SP | Cột 1: Tên SP | Cột 2: Nhà SX | Cột 3: Đơn giá | Cột 4: Trạng thái
                dgv.Rows.Add("SP001", "Quần Tây Nam Form Tay Đo", "Phát Tailor", "350.000 VNĐ", "Còn hàng");
                dgv.Rows.Add("SP002", "Áo Blazer Nam Oversize", "Fashion Store", "550.000 VNĐ", "Còn hàng");
                dgv.Rows.Add("SP003", "Áo Hoodie Nike Tech", "Nike Official", "420.000 VNĐ", "Còn hàng");
            }

            // Cập nhật nhãn tổng tiền
            UpdateTongTienLabel(this, "1.320.000 VNĐ");
        }

        // --- CHỨC NĂNG 1: XÓA SẢN PHẨM ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridView dgv = FindDgv(this);
            if (dgv != null && dgv.CurrentRow != null && !dgv.CurrentRow.IsNewRow)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này khỏi giỏ hàng?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
                    TinhLaiTongTien();
                    MessageBox.Show("Đã xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // --- CHỨC NĂNG 2: CẬP NHẬT GIỎ HÀNG ---
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            TinhLaiTongTien();
            MessageBox.Show("Đã cập nhật lại danh sách giỏ hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- CÁC HÀM BỔ TRỢ ---
        private void TinhLaiTongTien()
        {
            decimal tongTien = 0;
            DataGridView dgv = FindDgv(this);

            if (dgv != null)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        // Cột 3 là Đơn giá
                        var val = row.Cells[3].Value;
                        if (val != null)
                        {
                            string strVal = val.ToString().Replace(" VNĐ", "").Replace(".", "").Replace(",", "");
                            if (decimal.TryParse(strVal, out decimal tien))
                            {
                                tongTien += tien;
                            }
                        }
                    }
                }
            }

            UpdateTongTienLabel(this, string.Format("{0:#,##0} VNĐ", tongTien));
        }

        private DataGridView FindDgv(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is DataGridView dgv) return dgv;
                if (c.HasChildren)
                {
                    DataGridView subDgv = FindDgv(c);
                    if (subDgv != null) return subDgv;
                }
            }
            return null;
        }

        private void UpdateTongTienLabel(Control parent, string tongTien)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Label lbl)
                {
                    string txt = lbl.Text.ToLower().Trim();
                    string name = lbl.Name.ToLower();

                    if (txt.Contains("tổng") || txt.Contains("0 vnđ") || name.Contains("tongtien") || name.Contains("tong"))
                    {
                        lbl.Text = "Tổng tiền hàng: " + tongTien;
                    }
                }
                if (c.HasChildren)
                {
                    UpdateTongTienLabel(c, tongTien);
                }
            }
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            FrmDatHang frm = new FrmDatHang();
            frm.ShowDialog();
        }

        private void btnTiepTucMuaHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}