using HeThongQuanLyKTX.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKTX
{
    public partial class FormThemSuaSinhVien : Form
    {
        private SinhVien sinhVien {  get; set; }

        public FormThemSuaSinhVien()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        internal FormThemSuaSinhVien(SinhVien sinhVien) : this()
        {

            txtStudentID.Text = sinhVien.MaSV.ToString();
            txtName.Text = sinhVien.TenSV.ToString();
            dtpBirthDate.Value = sinhVien.NgaySinhSV;
            txtPhone.Text = sinhVien.SdtSV.ToString();
            cmbGender.SelectedItem = sinhVien.GioiTinhSV.ToString();
            txtHometown.Text = sinhVien.QueQuanSV.ToString();
            txtEmail.Text = sinhVien.EmailSV.ToString();
        }

        internal SinhVien GetSinhVien()
        {
            return sinhVien;
        }

        // Sự kiện khi click vào Label giả làm placeholder
        private void lblGenderPlaceholder_Click(object sender, EventArgs e)
        {
            this.cmbGender.Focus(); // Đặt focus vào ComboBox
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int maSV = int.Parse(txtStudentID.Text);
                string tenSV = txtName.Text;
                DateTime ngaySinhSV = dtpBirthDate.Value;
                string gioiTinhSV = cmbGender.SelectedItem.ToString();
                string sdtSV = txtPhone.Text;
                string queQuanSV = txtHometown.Text;
                string emailSV = txtEmail.Text;

                sinhVien = new SinhVien(maSV, tenSV, ngaySinhSV, gioiTinhSV, sdtSV, queQuanSV, emailSV);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
