using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QLKhoaHocONL.Helpers;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL.GUI
{
    public class frmRegister : Form
    {
        private readonly Guna2TextBox _txtUser = new Guna2TextBox();
        private readonly Guna2TextBox _txtPass = new Guna2TextBox();
        private readonly Guna2TextBox _txtConfirm = new Guna2TextBox();
        private readonly Guna2TextBox _txtFullname = new Guna2TextBox();
        private readonly Guna2HtmlLabel _lblStatus = new Guna2HtmlLabel();

        public frmRegister()
        {
            Text = "Đăng ký";
            Width = 560;
            Height = 660;
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
                Text = "Tạo tài khoản mới",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 4)
            };

            var lblSubtitle = new Guna2HtmlLabel
            {
                Text = "Nhập thông tin để đăng ký",
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
            _txtUser.BorderRadius = 10;
            _txtUser.PlaceholderText = "Nhập email hoặc username";
            _txtUser.Font = new Font("Segoe UI", 11);
            _txtUser.Size = new Size(inputWidth, 44);
            _txtUser.Margin = new Padding(0, 0, 0, 14);
            _txtUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            var lblPass = new Guna2HtmlLabel
            {
                Text = "Mật khẩu",
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Margin = new Padding(0, 0, 0, 6)
            };
            _txtPass.Size = new Size(inputWidth, 44);
            _txtPass.BorderRadius = 10;
            _txtPass.PlaceholderText = "Nhập mật khẩu";
            _txtPass.PasswordChar = '*';
            _txtPass.Font = new Font("Segoe UI", 11);
            _txtPass.Margin = new Padding(0, 0, 0, 14);
            _txtPass.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            var lblConfirm = new Guna2HtmlLabel
            {
                Text = "Nhập lại mật khẩu",
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Margin = new Padding(0, 0, 0, 6)
            };
            _txtConfirm.Size = new Size(inputWidth, 44);
            _txtConfirm.BorderRadius = 10;
            _txtConfirm.PlaceholderText = "Nhập lại mật khẩu";
            _txtConfirm.PasswordChar = '*';
            _txtConfirm.Font = new Font("Segoe UI", 11);
            _txtConfirm.Margin = new Padding(0, 0, 0, 14);
            _txtConfirm.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            var lblFull = new Guna2HtmlLabel
            {
                Text = "Họ tên (tùy chọn)",
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Margin = new Padding(0, 0, 0, 6)
            };
            _txtFullname.Size = new Size(inputWidth, 44);
            _txtFullname.BorderRadius = 10;
            _txtFullname.PlaceholderText = "Nhập họ tên";
            _txtFullname.Font = new Font("Segoe UI", 11);
            _txtFullname.Margin = new Padding(0, 0, 0, 16);
            _txtFullname.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            _lblStatus.ForeColor = Color.Firebrick;
            _lblStatus.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            _lblStatus.AutoSize = true;
            _lblStatus.Margin = new Padding(0, 0, 0, 10);

            var btnRegister = new Guna2Button
            {
                Text = "Đăng ký",
                Size = new Size(inputWidth, 48),
                BorderRadius = 12,
                FillColor = Color.FromArgb(255, 102, 0),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Margin = new Padding(0, 4, 0, 10),
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };
            btnRegister.Click += BtnRegister_Click;

            layout.Controls.AddRange(new Control[]
            {
                lblTitle, lblSubtitle,
                lblUser, _txtUser,
                lblPass, _txtPass,
                lblConfirm, _txtConfirm,
                lblFull, _txtFullname,
                _lblStatus,
                btnRegister
            });

            card.Controls.Add(layout);
            Controls.Add(card);
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
