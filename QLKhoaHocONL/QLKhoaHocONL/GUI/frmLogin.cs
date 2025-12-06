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
                frm.ShowDialog();
                this.Hide();
            }
        }
    }
}