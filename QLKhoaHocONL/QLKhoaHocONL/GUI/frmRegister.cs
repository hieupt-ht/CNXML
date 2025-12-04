using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QLKhoaHocONL.Helpers;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL.GUI
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var user = _txtUser.Text.Trim();
            var pass = _txtPass.Text.Trim();
            var confirm = _txtConfirm.Text.Trim();
            var full = _txtFullname.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(confirm))
            {
                _lblStatus.Text = "Tài khoản và mật khẩu không được trống.";
                return;
            }

            if (pass != confirm)
            {
                _lblStatus.Text = "Mật khẩu nhập lại không khớp.";
                return;
            }

            var account = new Account
            {
                Username = user,
                Password = pass,
                FullName = string.IsNullOrEmpty(full) ? user : full,
                Role = "User"
            };

            if (!DbHelper.AddAccount(account, out var error))
            {
                _lblStatus.Text = error;
                return;
            }

            AppState.SetUser(account);
            MessageBox.Show("Đăng ký thành công, bạn đã được đăng nhập.");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}