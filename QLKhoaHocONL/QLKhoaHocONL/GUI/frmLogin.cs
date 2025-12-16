using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QLKhoaHocONL.Helpers;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL.GUI
{
    public partial class frmLogin : Form
    {
        private bool _isPassVisible = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var user = _txtUser.Text.Trim();
            var pass = _txtPass.Text.Trim();
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                _lblStatus.Text = "Nhập tài khoản và mật khẩu.";
                return;
            }

            var acc = DbHelper.Authenticate(user, pass);
            if (acc == null)
            {
                _lblStatus.Text = "Sai tài khoản hoặc mật khẩu.";
                return;
            }

            AppState.SetUser(acc);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            using (var frm = new frmRegister())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Đăng ký thành công, hiển thị lại form đăng nhập
                    this.Show();
                    this.BringToFront();
                    this.Activate();
                }
            }
        }

        private void _txtPass_Enter(object sender, EventArgs e)
        {
            picEyePass.Visible = true;
        }

        private void _txtPass_Leave(object sender, EventArgs e)
        {
            picEyePass.Visible = false;
        }

        private void picEyePass_Click(object sender, EventArgs e)
        {
            _isPassVisible = !_isPassVisible;
            _txtPass.PasswordChar = _isPassVisible ? '\0' : '•';
            picEyePass.Image = _isPassVisible 
                ? Properties.Resources.ic_hienMK 
                : Properties.Resources.ic_anMK;
        }
    }
}