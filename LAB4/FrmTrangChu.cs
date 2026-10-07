using System;
using System.Windows.Forms;

namespace QuanLyEShopping.From
{
    public partial class FrmTrangChu : Form
    {
        public FrmTrangChu()
        {
            InitializeComponent();
        }

        private void btnDangNhapDangKy_Click(object sender, EventArgs e)
        {
            FrmDangNhapDangKy frm = new FrmDangNhapDangKy();
            frm.ShowDialog();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            FrmDanhMuc frm = new FrmDanhMuc();
            frm.Show();
        }

        private void btnChiTietSanPham_Click(object sender, EventArgs e)
        {
            FrmChiTietSanPham frm = new FrmChiTietSanPham();
            frm.Show();
        }

        private void btnQuanLyGioHang_Click(object sender, EventArgs e)
        {
            FrmQuanLyGioHang frm = new FrmQuanLyGioHang();
            frm.Show();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            FrmDatHang frm = new FrmDatHang();
            frm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}