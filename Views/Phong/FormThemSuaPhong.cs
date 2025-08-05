using System;
using System.Linq;
using System.Windows.Forms;
using HeThongQuanLyKTX.Models;

namespace HeThongQuanLyKTX.Views
{
    public partial class FormThemSuaPhong : Form
    {
        private Phong phong { get; set; }

        public FormThemSuaPhong()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Thiết lập giá trị mặc định cho ComboBox Tình trạng
            cmbTinhTrang.Items.AddRange(new object[] { "Còn trống", "Đầy" });
            //cmbTinhTrang.SelectedIndex = 0;

            // Thiết lập giá trị mặc định cho ComboBox Khu vực
            cmbKhuVuc.Items.AddRange(Enumerable.Range(1, 10).Select(x => x.ToString()).ToArray());
            //cmbKhuVuc.SelectedIndex = 0;

        }

        private void FormThemSuaPhong_Load(object sender, EventArgs e)
        {
            
        }

        internal FormThemSuaPhong(Phong phong) : this()
        {
            
            txtMaPhong.Text = phong.MaPhong.ToString();
            cmbTinhTrang.SelectedItem = phong.TinhTrangPhong.ToString();
            txtSoSinhVienHienTai.Text = phong.SoSVHienTai.ToString();
            txtLoaiPhong.Text = phong.MaLP.ToString();
            cmbKhuVuc.SelectedItem = phong.MaKV.ToString();
        }

        internal Phong GetPhong()
        {
            return phong;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhong = int.Parse(txtMaPhong.Text);
                string tinhTrang = cmbTinhTrang.SelectedItem.ToString();
                int soSinhVienHienTai = int.Parse(txtSoSinhVienHienTai.Text);
                int loaiPhong = int.Parse(txtLoaiPhong.Text);
                int khuVuc = int.Parse(cmbKhuVuc.SelectedItem.ToString());

                phong = new Phong(maPhong, soSinhVienHienTai, tinhTrang, loaiPhong, khuVuc);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
