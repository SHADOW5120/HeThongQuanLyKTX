using System;
using System.Windows.Forms;
using HeThongQuanLyKTX.Database;
using MySql.Data.MySqlClient;

namespace HeThongQuanLyKTX.Views
{
    public partial class FormTestDB : Form
    {
        private DatabaseHelper dbHelper;

        public FormTestDB()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper(); // Khởi tạo đối tượng DatabaseHelper
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            // Thực hiện kết nối và kiểm tra
            if (CheckConnection())
            {
                lblConnectionStatus.Text = "Kết nối thành công!";
                lblConnectionStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblConnectionStatus.Text = "Kết nối thất bại!";
                lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        // Kiểm tra kết nối với cơ sở dữ liệu
        private bool CheckConnection()
        {
            try
            {
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open(); // Mở kết nối
                    return conn.State == System.Data.ConnectionState.Open; // Kiểm tra trạng thái kết nối
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Nếu có lỗi, kết nối không thành công
            }
        }
    }
}
