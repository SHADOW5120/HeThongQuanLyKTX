using System;
using System.Drawing;
using System.Windows.Forms;

namespace HeThongQuanLyKTX.Views
{
    public partial class FormChiTiet : Form
    {
        private string khuVuc;

        public FormChiTiet(string khuVuc)
        {
            InitializeComponent();
            this.khuVuc = khuVuc;
            lblTitle.Text = $"Chi Tiết {khuVuc}";
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormChiTiet";
            this.Text = "Chi Tiết";
            this.Load += new System.EventHandler(this.FormChiTiet_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
    }
}
