using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyEShopping.From
{
    public partial class FrmDanhMuc : Form
    {
        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            LoadDataSample();
        }

        private void LoadDataSample()
        {
            // 1. Tự động điền danh sách vào ComboBox Nhóm sản phẩm (nếu có)
            FillComboBox(this);

            // 2. Tìm DataGridView trên Form
            DataGridView dgv = FindDgv(this);
            if (dgv != null)
            {
                // Nếu DataGridView đã được tạo sẵn cột trên Designer
                if (dgv.Columns.Count >= 4)
                {
                    // Tắt tự động tạo cột thừa
                    dgv.AutoGenerateColumns = false;

                    // Xóa dòng cũ nếu có
                    dgv.Rows.Clear();

                    // Thêm trực tiếp dòng dữ liệu vào các cột thiết kế sẵn[cite: 15]
                    dgv.Rows.Add("SP001", "Quần Tây Nam Form Tay Đo", "Phát Tailor", "350.000 VNĐ");
                    dgv.Rows.Add("SP002", "Áo Blazer Nam Oversize", "Fashion Store", "550.000 VNĐ");
                    dgv.Rows.Add("SP003", "Áo Hoodie Nike Tech", "Nike Official", "420.000 VNĐ");
                    dgv.Rows.Add("SP004", "Giày Sneaker Streetwear", "Adidas", "890.000 VNĐ");
                }
                else
                {
                    // Trường hợp chưa có cột, gán DataTable bình thường
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Mã sản phẩm");
                    dt.Columns.Add("Tên sản phẩm");
                    dt.Columns.Add("Nhà sản xuất");
                    dt.Columns.Add("Giá hiện tại");

                    dt.Rows.Add("SP001", "Quần Tây Nam Form Tay Đo", "Phát Tailor", "350.000 VNĐ");
                    dt.Rows.Add("SP002", "Áo Blazer Nam Oversize", "Fashion Store", "550.000 VNĐ");
                    dt.Rows.Add("SP003", "Áo Hoodie Nike Tech", "Nike Official", "420.000 VNĐ");
                    dt.Rows.Add("SP004", "Giày Sneaker Streetwear", "Adidas", "890.000 VNĐ");

                    dgv.DataSource = dt;
                }
            }
        }

        // Hàm đệ quy tìm DataGridView trên Form
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

        // Hàm đệ quy nạp dữ liệu mẫu vào ComboBox Nhóm sản phẩm[cite: 15]
        private void FillComboBox(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is ComboBox cb)
                {
                    cb.Items.Clear();
                    cb.Items.Add("Tất cả nhóm sản phẩm");
                    cb.Items.Add("Thời trang Nam");
                    cb.Items.Add("Thời trang Nữ");
                    cb.Items.Add("Giày dép & Phụ kiện");
                    cb.SelectedIndex = 0;
                    return;
                }
                if (c.HasChildren)
                {
                    FillComboBox(c);
                }
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            FrmChiTietSanPham frm = new FrmChiTietSanPham();
            frm.Show();
        }

        private void btnThemVaoGioHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã thêm sản phẩm vào giỏ hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}