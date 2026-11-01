using System;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FrmChamCong : Form
    {
        public FrmChamCong()
        {
            InitializeComponent();
        }

        private void btnLuuCC_Click(object sender, EventArgs e)
        {
            // TODO: luu cham cong vao CSDL
        }

        private void btnLamMoiCC_Click(object sender, EventArgs e)
        {
            txtMaCC.Clear();
            txtGhiChuCC.Clear();
            dtNgayCC.Value = DateTime.Today;
            cboTrangThai.SelectedIndex = 0;
        }

        private void btnLuuPT_Click(object sender, EventArgs e)
        {
            // TODO: luu phu troi vao CSDL
        }

        private void btnLamMoiPT_Click(object sender, EventArgs e)
        {
            txtMaPT.Clear();
            txtLyDoPT.Clear();
            numSoGio.Value = 0;
            numTienPT.Value = 0;
            dtNgayPT.Value = DateTime.Today;
            cboHeSo.SelectedIndex = 0;
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }

    }
}
