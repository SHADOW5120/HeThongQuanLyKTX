using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HeThongQuanLyKTX.Models;

namespace HeThongQuanLyKTX.Views
{
    public partial class FormThemSuaLoaiPhong : Form
    {
        private LoaiPhong loaiPhong { get; set; }

        public FormThemSuaLoaiPhong()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        internal FormThemSuaLoaiPhong(LoaiPhong loaiPhong) : this()
        {
            txtMaLoaiPhong.Text = loaiPhong.MaLP.ToString();
            txtSoSVToiDa.Text = loaiPhong.SoSVToiDa.ToString();
            txtDienTich.Text = loaiPhong.DienTichLP.ToString();
            txtTienLP.Text = loaiPhong.TienLP.ToString();
        }

        internal LoaiPhong GetLoaiPhong()
        {
            return loaiPhong;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int maLoaiPhong = int.Parse(txtMaLoaiPhong.Text);
                int soSV = int.Parse(txtSoSVToiDa.Text);
                int dienTich = int.Parse(txtDienTich.Text);
                int TienLP = int.Parse(txtTienLP.Text);

                loaiPhong = new LoaiPhong
                {
                    MaLP = maLoaiPhong,
                    SoSVToiDa = soSV,
                    DienTichLP = dienTich,
                    TienLP = TienLP
                };

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaLoaiPhong_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
