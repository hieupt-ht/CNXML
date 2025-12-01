using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QLKhoaHocONL.Helpers;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL.GUI
{
    public class frmLogin : Form
    {
        private readonly Guna2TextBox _txtUser = new Guna2TextBox();
        private readonly Guna2TextBox _txtPass = new Guna2TextBox();
        private readonly Guna2HtmlLabel _lblStatus = new Guna2HtmlLabel();

        public frmLogin()
        {
            Text = "Đăng nhập / Đăng ký";
            Width = 560;
            Height = 520;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            BuildUI();
        }

        private void BuildUI()
        {
            BackColor = Color.WhiteSmoke;
            Font = new Font("Segoe UI", 10, FontStyle.Regular);

            var card = new Guna2Panel
            {
                BorderRadius = 16,
                FillColor = Color.White,
                Dock = DockStyle.Fill,
                Padding = new Padding(20),
                AutoScroll = true
            };

            var layout = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(0)
            };

            int inputWidth = 480;

            var lblTitle = new Guna2HtmlLabel
            {
                Text = "Chào mừng bạn đến F8",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 4)
            };

            var lblSubtitle = new Guna2HtmlLabel
            {
                Text = "Đăng nhập hoặc tạo tài khoản mới",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                AutoSize = true,
                ForeColor = Color.DimGray,
                Margin = new Padding(0, 0, 0, 16)
            };

            var lblUser = new Guna2HtmlLabel
            {
                Text = "Tài khoản",
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Margin = new Padding(0, 0, 0, 6)
            };
            _txtUser.Size = new Size(inputWidth, 48);
            _txtUser.BorderRadius = 10;
            _txtUser.PlaceholderText = "Nhập email hoặc username";
            _txtUser.Font = new Font("Segoe UI", 11);
            _txtUser.Margin = new Padding(0, 0, 0, 14);
            _txtUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            var lblPass = new Guna2HtmlLabel
            {
                Text = "Mật khẩu",
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Margin = new Padding(0, 0, 0, 6)
            };
            _txtPass.Size = new Size(inputWidth, 48);
            _txtPass.BorderRadius = 10;
            _txtPass.PlaceholderText = "Nhập mật khẩu";
            _txtPass.PasswordChar = '*';
            _txtPass.Font = new Font("Segoe UI", 11);
            _txtPass.Margin = new Padding(0, 0, 0, 16);
            _txtPass.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            var btnLogin = new Guna2Button
            {
                Text = "Đăng nhập",
                Size = new Size(inputWidth, 48),
                BorderRadius = 12,
                FillColor = Color.FromArgb(255, 102, 0),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Margin = new Padding(0, 0, 0, 10),
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };
            btnLogin.Click += BtnLogin_Click;

            var btnRegister = new Guna2Button
            {
                Text = "Đăng ký",
                Size = new Size(inputWidth, 48),
                BorderRadius = 12,
                FillColor = Color.White,
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                BorderThickness = 1,
                BorderColor = Color.LightGray,
                Margin = new Padding(0, 0, 0, 10),
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };
            btnRegister.Click += BtnRegister_Click;

            _lblStatus.ForeColor = Color.Firebrick;
            _lblStatus.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            _lblStatus.AutoSize = true;
            _lblStatus.Margin = new Padding(0, 0, 0, 6);

            layout.Controls.AddRange(new Control[]
            {
                lblTitle, lblSubtitle,
                lblUser, _txtUser,
                lblPass, _txtPass,
                btnLogin, btnRegister,
                _lblStatus
            });

            card.Controls.Add(layout);
            Controls.Add(card);
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
            var user = _txtUser.Text.Trim();
            var pass = _txtPass.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                _lblStatus.Text = "Tài khoản và mật khẩu không được trống.";
                return;
            }

            var account = new Account
            {
                Username = user,
                Password = pass,
                FullName = user,
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
