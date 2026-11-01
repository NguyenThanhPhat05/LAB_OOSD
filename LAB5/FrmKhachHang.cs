using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public partial class FrmKhachHang : Form
{
    public FrmKhachHang()
    {
        InitializeComponent();
        LoadData();
    }

    private void LoadData()
    {
        string query = "SELECT maKH AS [Mã KH], tenKhachHang AS [Tên Khách], soDienThoai AS [SĐT], kieuKhach AS [Loại Khách], nguoiDaiDien AS [Đại Diện], soCMND AS [CCCD] FROM KHACH_HANG";
        dgvKhachHang.DataSource = DatabaseHelper.ExecuteQuery(query);
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        string query = "INSERT INTO KHACH_HANG VALUES (@maKH, @ten, @sdt, @kieu, @daiDien, @cccd)";
        SqlParameter[] p = {
            new SqlParameter("@maKH", txtMaKH.Text),
            new SqlParameter("@ten", txtTenKH.Text),
            new SqlParameter("@sdt", txtSDT.Text),
            new SqlParameter("@kieu", cboKieuKhach.SelectedItem.ToString()),
            new SqlParameter("@daiDien", (object)txtNguoiDaiDien.Text ?? DBNull.Value),
            new SqlParameter("@cccd", (object)txtCCCD.Text ?? DBNull.Value)
        };

        DatabaseHelper.ExecuteNonQuery(query, p);
        MessageBox.Show("Thêm khách hàng thành công!");
        LoadData();
    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }
}