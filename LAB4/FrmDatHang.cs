using System;
using System.Windows.Forms;

namespace QuanLyEShopping.From
{
    public partial class FrmDatHang : Form
    {
        public FrmDatHang()
        {
            InitializeComponent();
        }

        private void FrmDatHang_Load(object sender, EventArgs e)
        {
            // Auto fill Tab 1: Đặt hàng
            SetControlText("txtHoTenNguoiNhan", "Nguyễn Thành Phát");
            SetControlText("txtLoaiTheThanhToan", "VISA / Mastercard");
            SetControlText("txtPhuongThucGiao", "Giao hàng nhanh");
            SetControlText("txtDiaChiGiaoHang", "123 Đường Nguyễn Văn Bảo, Gò Vấp, TP.HCM");
            SetControlText("txtSoDienThoai", "0901234567");
            SetControlText("txtKhuVucGiaoHang", "TP. Hồ Chí Minh");

            // Auto fill Tab 2: Thanh toán
            SetControlText("txtLoaiThe", "VISA");
            SetControlText("txtTenChuThe", "NGUYEN THANH PHAT");
            SetControlText("txtMaCVC", "777");
            SetControlText("lblTongTienSP", "1,250,000 VNĐ");
            SetControlText("lblPhiGiaoDich", "0 VNĐ");
            SetControlText("lblCuocPhiGiaoHang", "30,000 VNĐ");
            SetControlText("lblTongThanhToan", "1,280,000 VNĐ");
        }

        private TabControl GetTabControl()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TabControl tc) return tc;
            }
            return null;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            TabControl tc = GetTabControl();
            if (tc != null && tc.TabPages.Count > 1)
            {
                tc.SelectedIndex = 1; // Nhảy sang Tab Thanh Toán
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công! Đơn hàng của bạn đang được xử lý.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void SetControlText(string controlName, string text)
        {
            Control[] list = this.Controls.Find(controlName, true);
            if (list.Length > 0) list[0].Text = text;
        }
    }
}