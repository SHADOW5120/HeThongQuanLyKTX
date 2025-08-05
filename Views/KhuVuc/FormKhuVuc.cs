using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HeThongQuanLyKTX.Models;
using HeThongQuanLyKTX.ViewModels;

namespace HeThongQuanLyKTX.Views
{
    public partial class FormKhuVuc : Form
    {

        private List<KhuVuc> danhKhuVuc = new List<KhuVuc>();
        private KhuVucViewModel khuVucViewModel = new KhuVucViewModel();

        public FormKhuVuc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitDanhKhuVuc();
        }

        private void InitDanhKhuVuc()
        {
            // Tạm thời thêm một số dữ liệu mẫu
            danhKhuVuc = khuVucViewModel.GetAllKhuVuc();

            // Thêm các khu vực vào flowLayoutPanel
            foreach (var khuVuc in danhKhuVuc)
            {
                AddItem("bk", khuVuc.TenKV, khuVuc.MaKV);
            }
        }


        private void AddItem(string imageName, string text, int maKV)
        {
            try
            {
                // Tải hình ảnh từ tài nguyên
                var image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);

                if (image == null)
                {
                    MessageBox.Show($"Không tìm thấy ảnh: {imageName}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var panel = new Panel
                {
                    Size = new Size(150, 200),
                    Margin = new Padding(10)
                };

                var pictureBox = new PictureBox
                {
                    Image = image,
                    Size = new Size(150, 150),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Cursor = Cursors.Hand
                };

                var label = new Label
                {
                    Text = text,
                    Font = new Font("Segoe UI", 10),
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                pictureBox.MouseEnter += (s, e) =>
                {
                    pictureBox.Size = new Size(180, 180);
                    label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                };

                pictureBox.MouseLeave += (s, e) =>
                {
                    pictureBox.Size = new Size(150, 150);
                    label.Font = new Font("Segoe UI", 10);
                };

                pictureBox.Click += (s, e) =>
                {
                    FormPhong formPhong = new FormPhong(maKV);
                    formPhong.Show();
                };

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);

                flowLayoutPanel.Controls.Add(panel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            // Tuỳ chỉnh giao diện nếu cần
        }
    }
}
