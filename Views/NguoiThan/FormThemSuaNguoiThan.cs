using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HeThongQuanLyKTX.Models;

namespace HeThongQuanLyKTX.Views
{
    public partial class FormThemSuaNguoiThan : Form
    {
        private NguoiThan nguoiThan { get; set; }

        public FormThemSuaNguoiThan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        internal FormThemSuaNguoiThan(NguoiThan nguoiThan) : this()
        {
            txtMaNT.Text = nguoiThan.MaNT.ToString();
            txtTenNT.Text = nguoiThan.TenNT.ToString();
            txtSdtNT.Text = nguoiThan.SdtNT;
            txtDiaChiNT.Text = nguoiThan.DiaChiNT.ToString();
            txtMaSV.Text = nguoiThan.MaSV.ToString();
        }

        internal NguoiThan GetNguoiThan()
        {
            return nguoiThan;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int maNguoiThan = int.Parse(txtMaNT.Text);
                string tenNguoiThan = txtTenNT.Text;
                string sdtNguoiThan = txtSdtNT.Text;
                string diaChiNguoiThan = txtDiaChiNT.Text.ToString();
                int maSV = int.Parse(txtMaSV.Text);

                nguoiThan = new NguoiThan(maNguoiThan, tenNguoiThan, sdtNguoiThan, diaChiNguoiThan, maSV);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
