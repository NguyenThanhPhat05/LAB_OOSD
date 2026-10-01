using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            // Gọi kiểm tra kết nối ngay khi Form vừa khởi chạy
            KiemTraKetNoiSQL();
        }

        private void KiemTraKetNoiSQL()
        {
            try
            {
                // Thử truy vấn một bảng bất kỳ trong CSDL của bạn (ví dụ bảng DichVu)
                DataTable dt = QuanLyKhachSan.Data.Db.ExecuteQuery("SELECT * FROM DichVu");
                int soDong = dt.Rows.Count;

                MessageBox.Show("Kết nối SQL Server thành công! Lấy được " + soDong + " dòng từ bảng Dịch vụ.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại! Lỗi: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- DÁN CÁC HÀM SỰ KIỆN CLICK VÀO ĐÂY ---

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            FrmDanhMuc frm = new FrmDanhMuc();
            frm.ShowDialog();
        }

        private void btnPhongTienNghi_Click(object sender, EventArgs e)
        {
            FrmPhongTienNghi frm = new FrmPhongTienNghi();
            frm.ShowDialog();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            FrmDatPhong frm = new FrmDatPhong();
            frm.ShowDialog();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            FrmDichVu frm = new FrmDichVu();
            frm.ShowDialog();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            FrmTraPhong frm = new FrmTraPhong();
            frm.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FrmThongKe frm = new FrmThongKe();
            frm.ShowDialog();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit(); // Đóng toàn bộ ứng dụng
            }
        }
    }
}

