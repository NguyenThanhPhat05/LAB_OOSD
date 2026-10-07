using System;
using System.Windows.Forms;

namespace QuanLyEShopping.From
{
    public partial class FrmChiTietSanPham : Form
    {
        // Biến lưu trữ thông tin sản phẩm
        private string tenSP = "Quần Tây Nam Form Tay Đo";
        private string nhaSX = "Phát Tailor";
        private string giaSP = "350.000 VNĐ";

        public FrmChiTietSanPham()
        {
            InitializeComponent();
        }

        // Constructor nhận dữ liệu từ FrmDanhMuc
        public FrmChiTietSanPham(string ten, string hang, string gia)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(ten)) tenSP = ten;
            if (!string.IsNullOrEmpty(hang)) nhaSX = hang;
            if (!string.IsNullOrEmpty(gia)) giaSP = gia;
        }

        private void FrmChiTietSanPham_Load(object sender, EventArgs e)
        {
            FillDataToControls(this);
        }

        // Hàm đệ quy tự động quét và gán dữ liệu cho các Label, TextBox, RichTextBox
        private void FillDataToControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Label lbl)
                {
                    string txt = lbl.Text.ToLower().Trim();
                    string name = lbl.Name.ToLower();

                    // Gán Tên sản phẩm
                    if (txt.Contains("tên sản phẩm") || name.Contains("tensanpham") || name.Contains("ten"))
                        lbl.Text = tenSP;
                    // Gán Giá
                    else if (txt.Contains("0 vnđ") || txt.Contains("giá") || name.Contains("gia"))
                        lbl.Text = giaSP;
                    // Gán Hãng sản xuất
                    else if (txt.Contains("hãng sản xuất") || txt.Contains("nhà sản xuất") || name.Contains("hang") || name.Contains("nhasanxuat"))
                        lbl.Text = "Hãng sản xuất: " + nhaSX;
                    // Gán Danh mục
                    else if (txt.Contains("danh mục") || name.Contains("danhmuc"))
                        lbl.Text = "Danh mục: Thời trang Nam";
                    // Gán Trạng thái
                    else if (txt.Contains("trạng thái") || name.Contains("trangthai"))
                        lbl.Text = "Trạng thái: Còn hàng";
                }
                else if (c is TextBox txt)
                {
                    if (txt.Text.Contains("Mô tả") || txt.Name.ToLower().Contains("mota"))
                        txt.Text = "Chất liệu vải co giãn cao cấp, giữ phom chuẩn, đường may tỉ mỉ. Phù hợp mặc công sở, đi chơi hay tham gia sự kiện.";
                    else if (txt.Text.Contains("Thông số") || txt.Name.ToLower().Contains("thongso"))
                        txt.Text = "• Size: S, M, L, XL\n• Màu sắc: Đen, Ghi, Xanh đen\n• Phong cách: Lịch lãm, Hiện đại";
                }
                else if (c is RichTextBox rtb)
                {
                    if (rtb.Text.Contains("Mô tả") || rtb.Name.ToLower().Contains("mota"))
                        rtb.Text = "Chất liệu vải co giãn cao cấp, giữ phom chuẩn, đường may tỉ mỉ. Phù hợp mặc công sở, đi chơi hay tham gia sự kiện.";
                    else if (rtb.Text.Contains("Thông số") || rtb.Name.ToLower().Contains("thongso"))
                        rtb.Text = "• Size: S, M, L, XL\n• Màu sắc: Đen, Ghi, Xanh đen\n• Phong cách: Lịch lãm, Hiện đại";
                }

                if (c.HasChildren)
                {
                    FillDataToControls(c);
                }
            }
        }

        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã thêm sản phẩm vào giỏ hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}