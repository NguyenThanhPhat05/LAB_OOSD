using System;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FrmQuyetDinh : Form
    {
        public FrmQuyetDinh()
        {
            InitializeComponent();
        }

        private void btnLapQDCV_Click(object sender, EventArgs e)
        {
            // TODO: luu quyet dinh chuc vu
        }

        private void btnLamMoiCV_Click(object sender, EventArgs e)
        {
            txtSoQDCV.Clear();
            txtChucVu.Clear();
            numPhuCapCV.Value = 0;
            dtNgayHLCV.Value = DateTime.Today;
        }

        private void btnLapQDL_Click(object sender, EventArgs e)
        {
            // TODO: luu quyet dinh luong
        }

        private void btnLamMoiL_Click(object sender, EventArgs e)
        {
            txtSoQDL.Clear();
            numLuongCB.Value = 0;
            numPhuCapLuong.Value = 0;
            numPhuCapDocHai.Value = 0;
            dtNgayHLL.Value = DateTime.Today;
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }

    }
}
