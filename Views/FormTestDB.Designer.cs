namespace HeThongQuanLyKTX.Views
{
    partial class FormTestDB
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCheckConnection;
        private System.Windows.Forms.Label lblConnectionStatus;

        // Form1's designer code
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnCheckConnection = new System.Windows.Forms.Button();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckConnection
            // 
            this.btnCheckConnection.Location = new System.Drawing.Point(100, 100);
            this.btnCheckConnection.Name = "btnCheckConnection";
            this.btnCheckConnection.Size = new System.Drawing.Size(150, 40);
            this.btnCheckConnection.TabIndex = 0;
            this.btnCheckConnection.Text = "Kiểm tra kết nối";
            this.btnCheckConnection.UseVisualStyleBackColor = true;
            this.btnCheckConnection.Click += new System.EventHandler(this.btnCheckConnection_Click);
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(100, 160);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(0, 17);
            this.lblConnectionStatus.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.btnCheckConnection);
            this.Name = "Form1";
            this.Text = "Kiểm Tra Kết Nối MySQL";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
