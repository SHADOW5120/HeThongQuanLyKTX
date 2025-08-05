using HeThongQuanLyKTX.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKTX.Views
{
    public partial class FormSuaNhanVien : Form
    {
        private NhanVien nhanVien { get; set; }

        public FormSuaNhanVien()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Thiết lập giá trị mặc định cho ComboBox Tình trạng
            cmbGender.Items.AddRange(new object[] { "Nam", "Nữ" });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int maNV = 0;
                string tenNV = txtName.Text;
                string sdtNV = txtPhone.Text;
                string emailNV = txtEmail.Text;
                string gioiTinhNV = cmbGender.SelectedItem.ToString();
                string queQuanNV = txtAddress.Text;
                DateTime ngaySinhNV = dtpBirthDate.Value;
               

                nhanVien = new NhanVien(maNV, tenNV, sdtNV, emailNV, gioiTinhNV, queQuanNV, ngaySinhNV);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        internal FormSuaNhanVien(NhanVien nhanVien) : this()
        {
            // Hiển thị thông tin từ đối tượng nhanVien vào các điều khiển
            txtName.Text = nhanVien.TenNV;
            txtPhone.Text = nhanVien.SdtNV;
            txtEmail.Text = nhanVien.EmailNV;
            cmbGender.SelectedItem = nhanVien.GioiTinhNV;
            txtAddress.Text = nhanVien.QueQuanNV;
            dtpBirthDate.Value = nhanVien.NgaySinhNV;
        }

        internal NhanVien GetNhanVien()
        {
            return nhanVien;
        }



    }
}
