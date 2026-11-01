using System;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ThongBao(string ten)
        {
            MessageBox.Show("Chức năng \"" + ten + "\" đang được phát triển.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e) { ThongBao("Danh mục"); }
        private void btnTuyenDung_Click(object sender, EventArgs e) { ThongBao("Tuyển dụng - Thử việc"); }
        private void btnHopDong_Click(object sender, EventArgs e) { ThongBao("Hợp đồng - Bảo hiểm"); }
        private void btnChucVuLuong_Click(object sender, EventArgs e) { new FrmQuyetDinh().ShowDialog(); }
        private void btnChamCong_Click(object sender, EventArgs e) { new FrmChamCong().ShowDialog(); }
        private void btnBangLuong_Click(object sender, EventArgs e) { ThongBao("Bảng lương"); }
        private void btnKhenThuong_Click(object sender, EventArgs e) { ThongBao("Khen thưởng - Kỷ luật"); }
        private void btnThongKe_Click(object sender, EventArgs e) { new FrmThongKeNS().ShowDialog(); }
        private void btnThoat_Click(object sender, EventArgs e) { Close(); }

    }
}
