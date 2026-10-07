using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net;
using QuanLyEShopping;

namespace QuanLyEShopping.From
{
    public partial class FrmDangNhapDangKy : Form
    {
        public FrmDangNhapDangKy()
        {
            InitializeComponent();
        }

        // ==========================================
        // HÀM HỖ TRỢ TÌM VÀ LẤY GIÁ TRỊ CONTROL
        // ==========================================
        private TabControl GetTabControl()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TabControl tc) return tc;
            }
            return null;
        }

        private string GetControlText(string controlName)
        {
            Control[] list = this.Controls.Find(controlName, true);
            if (list.Length > 0)
            {
                return list[0].Text.Trim();
            }
            return "";
        }

        private void SetControlText(string controlName, string text)
        {
            Control[] list = this.Controls.Find(controlName, true);
            if (list.Length > 0)
            {
                list[0].Text = text;
            }
        }

        // ==========================================
        // 1. CHUYỂN TAB VÀ ĐÓNG FORM
        // ==========================================

        // Link "Đăng ký tài khoản" -> Chuyển sang Tab Đăng ký (Index 1)
        private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TabControl tc = GetTabControl();
            if (tc != null && tc.TabPages.Count > 1)
            {
                tc.SelectedIndex = 1;
            }
        }

        // Link "Đăng nhập" -> Chuyển về Tab Đăng nhập (Index 0)
        private void lnkDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TabControl tc = GetTabControl();
            if (tc != null && tc.TabPages.Count > 0)
            {
                tc.SelectedIndex = 0;
            }
        }

        // Nút Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ==========================================
        // 2. XỬ LÝ ĐĂNG NHẬP
        // ==========================================
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = GetControlText("txtTenDangNhap_DN");
            if (string.IsNullOrEmpty(username)) username = GetControlText("txtUsername");

            string password = GetControlText("txtMatKhau_DN");
            if (string.IsNullOrEmpty(password)) password = GetControlText("txtPassword");

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "SELECT account_id, customer_id, password_hash FROM ACCOUNT WHERE username = @Username";
                SqlParameter[] parameters = { new SqlParameter("@Username", username) };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt != null && dt.Rows.Count > 0)
                {
                    string storedHash = dt.Rows[0]["password_hash"].ToString();

                    if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                    {
                        UserSession.CurrentAccountId = dt.Rows[0]["account_id"].ToString();
                        UserSession.CurrentCustomerId = dt.Rows[0]["customer_id"].ToString();

                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 3. XỬ LÝ ĐĂNG KÝ HOÀN CHỈNH
        // ==========================================
        private void btnDangKy_Click(object sender, EventArgs e)
        {

        }

        // ==========================================
        // LINK HOẶC SỰ KIỆN PHỤ KHÁC
        // ==========================================
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkDangKy_LinkClicked(sender, e);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}