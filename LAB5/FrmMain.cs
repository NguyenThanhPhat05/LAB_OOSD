using System;
using System.Windows.Forms;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
    }

    private void btnDangKy_Click(object sender, EventArgs e)
    {
        FrmDangKy frm = new FrmDangKy();
        frm.ShowDialog();
    }

    private void btnKhachHang_Click(object sender, EventArgs e)
    {
        FrmKhachHang frm = new FrmKhachHang();
        frm.ShowDialog();
    }
}