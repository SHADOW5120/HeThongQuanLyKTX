using HeThongQuanLyKTX.ViewModels;
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
    public partial class FormDatLaiMatKhau : Form
    {
        private string matKhaurMoi;

        public FormDatLaiMatKhau()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Length == 0 || txtConfirmPassword.Text.Length == 0) 
            {
                MessageBox.Show("Chưa nhập mật khẩu mới.");
            }
            else if (txtConfirmPassword.Text !=  txtNewPassword.Text)
            {
                MessageBox.Show("Có vẻ như bạn đã xác nhận sai mật khẩu mới.");
            }
            else
            {
                matKhaurMoi = txtNewPassword.Text;
                MessageBox.Show("Đổi mật khẩu thành công.");
                DialogResult = DialogResult.OK;
            }
        }

        public string GetMK()
        {
            return this.matKhaurMoi;
        }
    }
}
