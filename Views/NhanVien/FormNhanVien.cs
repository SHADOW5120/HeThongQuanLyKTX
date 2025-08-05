using HeThongQuanLyKTX.Models;
using HeThongQuanLyKTX.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HeThongQuanLyKTX.Views
{
    public partial class FormNhanVien : Form
    {

        private NhanVien nhanVien = new NhanVien();
        private NhanVienViewModel nhanVienViewModel = new NhanVienViewModel();
        private int maNV;


        public FormNhanVien()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        internal FormNhanVien(int maNV) :this()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.maNV = maNV;
            InitNhanVien();
        }

        private void InitNhanVien()
        {
            // Tạm thời thêm một số dữ liệu mẫu
            nhanVien = nhanVienViewModel.GetNhanVienByMaNV(maNV);

            txtEmployeeName.Text = nhanVien.TenNV;
            txtPhone.Text = nhanVien.SdtNV;
            txtEmail.Text = nhanVien.EmailNV;
            cboGender.SelectedItem = nhanVien.GioiTinhNV;
            txtAddress.Text = nhanVien.QueQuanNV;
            dtpBirthDate.Value = nhanVien.NgaySinhNV;
        }


        private void LoadNhanVien()
        {
            txtEmployeeName.Text = nhanVien.TenNV;
            txtPhone.Text = nhanVien.SdtNV;
            txtEmail.Text = nhanVien.EmailNV;
            cboGender.SelectedItem = nhanVien.GioiTinhNV;
            txtAddress.Text = nhanVien.QueQuanNV;
            dtpBirthDate.Value = nhanVien.NgaySinhNV;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
             NhanVien selectedNhanVien = nhanVien;

             using (FormSuaNhanVien formDetails = new FormSuaNhanVien(selectedNhanVien))
             {
                if (formDetails.ShowDialog() == DialogResult.OK)

                nhanVien = formDetails.GetNhanVien();
                LoadNhanVien();
             }
        }
    }
}