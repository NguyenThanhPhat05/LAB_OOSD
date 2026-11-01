using System;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FrmThongKeNS : Form
    {
        public FrmThongKeNS()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (dtTuNgay.Value.Date > dtDenNgay.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // TODO: truy van CSDL roi do du lieu vao dgvLuongThang, dgvPhongBan va cac label tong hop
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }

    }
}
