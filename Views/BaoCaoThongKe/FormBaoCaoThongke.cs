using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKTX.Views.BaoCaoThongKe
{
    public partial class FormBaoCaoThongke : Form
    {
        public FormBaoCaoThongke()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void tabPageSLPD_Click(object sender, EventArgs e)
        {

        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra tab nào đang được chọn và mở form tương ứng
            switch (guna2TabControl1.SelectedIndex)
            {
                case 0: // Nếu chọn tab 0
                    OpenForm(new FormDoanhThuThang());
                    break;
                case 1: // Nếu chọn tab 1
                    OpenForm(new FormSoLuongDVSuDung());
                    break;
                case 2: // Nếu chọn tab 2
                    OpenForm(new FormSoLuongSVDangKy());
                    break;
                case 3: // Nếu chọn tab 2
                    OpenForm(new FormSoluongSVTheoKV());
                    break;
                case 4: // Nếu chọn tab 2
                    OpenForm(new FormSoPhongTrongTheoKV());
                    break;
                case 5: // Nếu chọn tab 2
                    OpenForm(new FormSoPhongDayTheoKV());
                    break;
                default:
                    break;
            }
        }

        // Hàm mở form
        private void OpenForm(Form form)
        {
            // Đóng form hiện tại nếu có
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == form.GetType())
                {
                    f.Activate();
                    return;
                }
            }

            // Mở form mới
            form.TopLevel = false;  // Đặt form con không phải là top-level form
            form.FormBorderStyle = FormBorderStyle.None; // Bỏ border
            form.Dock = DockStyle.Fill; // Để form chiếm toàn bộ không gian trong tab
            guna2TabControl1.TabPages[guna2TabControl1.SelectedIndex].Controls.Add(form); // Thêm form vào tab
            form.Show();  // Hiển thị form
        }

        private void tabPageDTT_Click(object sender, EventArgs e)
        {

        }
    }
}
