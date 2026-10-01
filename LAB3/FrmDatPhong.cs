using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDatPhong : Form
    {
        public FrmDatPhong()
        {
            InitializeComponent();
        }

        private void FrmDatPhong_Load(object sender, EventArgs e)
        {
            LoadPhongTroNg();
        }

        // Tải danh sách phòng trống lên DataGridView (giả sử tên là dataGridView5)
        private void LoadPhongTroNg()
        {
            try
            {
                // Sử dụng đúng tên các cột từ cơ sở dữ liệu của bạn
                string query = "SELECT SoPhong, MaKhuVuc, SoNguoiToiDa, DonGiaNgay FROM Phong WHERE TrangThai = N'Trống'";
                DataTable dt = QuanLyKhachSan.Data.Db.ExecuteQuery(query);
                dataGridView5.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải phòng trống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Lập phiếu đặt phòng (bấm để lưu vào CSDL)
        private void button1_Click(object sender, EventArgs e)
        {
            string soPhieu = txtSoPhieu.Text.Trim();
            string tenKhach = txtKhach.Text.Trim();

            if (string.IsNullOrEmpty(soPhieu) || string.IsNullOrEmpty(tenKhach))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Số phiếu và Tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "INSERT INTO PhieuDat (SoPhieu, TenKhach, NgayLap) VALUES (@SoPhieu, @TenKhach, GETDATE())";
                SqlParameter[] parameters = {
                    new SqlParameter("@SoPhieu", soPhieu),
                    new SqlParameter("@TenKhach", tenKhach)
                };

                QuanLyKhachSan.Data.Db.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Lập phiếu đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPhongTroNg();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lập phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void textBox11_TextChanged(object sender, EventArgs e) { }
    }
}