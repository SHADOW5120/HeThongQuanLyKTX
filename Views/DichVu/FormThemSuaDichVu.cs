using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongQuanLyKTX.Models;
using HeThongQuanLyKTX.ViewModels;

namespace HeThongQuanLyKTX.Views
{
    public partial class FormThemSuaDichVu : Form
    {
        private DichVu dichVu { get; set; }

        public FormThemSuaDichVu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        internal FormThemSuaDichVu(DichVu dichVu) : this()
        {
            // Gán thông tin từ đối tượng DichVu vào các điều khiển trên form
            txtMaDV.Text = dichVu.MaDV.ToString();
            txtTenDV.Text = dichVu.TenDV;
            txtDonViDV.Text = dichVu.DonViDV;
            txtGiaDV.Text = dichVu.GiaDV.ToString("F2");
        }

        internal DichVu GetDichVu()
        {
            return dichVu;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ form
                int maDV = int.Parse(txtMaDV.Text);
                string tenDV = txtTenDV.Text;
                string donViDV = txtDonViDV.Text;
                decimal giaDV = decimal.Parse(txtGiaDV.Text);

                // Tạo mới đối tượng DichVu hoặc cập nhật giá trị
                dichVu = new DichVu(maDV, tenDV, donViDV, giaDV);

                // Đặt kết quả của form là OK để xử lý sau
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaDV_TextChanged(object sender, EventArgs e)
        {
            // Optional: Xử lý sự kiện khi text trong txtMaDV thay đổi
        }
    }
}
