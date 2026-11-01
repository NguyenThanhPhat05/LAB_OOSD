using System;
using System.Windows.Forms;

namespace QuanLyNuocGiaiKhat
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e) { new FrmDanhMuc().ShowDialog(); }
        private void btnNGK_Click(object sender, EventArgs e) { new FrmNuocGiaiKhat().ShowDialog(); }
        private void btnDatHang_Click(object sender, EventArgs e) { new FrmDatHang().ShowDialog(); }
        private void btnBanHang_Click(object sender, EventArgs e) { new FrmBanHang().ShowDialog(); }
        private void btnPhieuNo_Click(object sender, EventArgs e) { new FrmPhieuNo().ShowDialog(); }
        private void btnThongKe_Click(object sender, EventArgs e) { new FrmThongKe().ShowDialog(); }
        private void btnThoat_Click(object sender, EventArgs e) { Close(); }

    }
}
