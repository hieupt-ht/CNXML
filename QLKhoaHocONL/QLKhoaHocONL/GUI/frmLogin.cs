using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QLKhoaHocONL.Helpers;
using QLKhoaHocONL.Models;
//aaaa
namespace QLKhoaHocONL.GUI
{
    /// <summary>
    /// Form đăng nhập/đăng ký sử dụng Guna UI2.
    /// </summary>
    public class frmLogin : Form
    {
        private readonly Guna2TextBox _txtUser = new Guna2TextBox();
        private readonly Guna2TextBox _txtPass = new Guna2TextBox();
        private readonly Guna2TextBox _txtFullname = new Guna2TextBox();
        private readonly Guna2ComboBox _cboRole = new Guna2ComboBox();
        private readonly Guna2HtmlLabel _lblStatus = new Guna2HtmlLabel();

        public frmLogin()
        {
            Text = "Đăng nhập / Đăng ký";
            Width = 440;
            Height = 420;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            BuildUI();
        }

        private void BuildUI()
        {
            BackColor = Color.White;

            var lblTitle = new Guna2HtmlLabel
            {
                Text = "Chào mừng bạn đến F8",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Location = new Point(24, 18),
                AutoSize = true
            };

            var lblUser = new Guna2HtmlLabel
            {
                Text = "Tài khoản",
                Location = new Point(24, 66),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            _txtUser.Location = new Point(24, 90);
            _txtUser.Size = new Size(370, 40);
            _txtUser.BorderRadius = 8;
            _txtUser.PlaceholderText = "Nhập email hoặc username";

            var lblPass = new Guna2HtmlLabel
            {
                Text = "Mật khẩu",
                Location = new Point(24, 140),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            _txtPass.Location = new Point(24, 164);
            _txtPass.Size = new Size(370, 40);
            _txtPass.BorderRadius = 8;
            _txtPass.PlaceholderText = "Nhập mật khẩu";
            _txtPass.PasswordChar = '•';

            var lblFull = new Guna2HtmlLabel
            {
                Text = "Họ tên (dùng khi đăng ký)",
                Location = new Point(24, 214),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            _txtFullname.Location = new Point(24, 238);
            _txtFullname.Size = new Size(370, 40);
            _txtFullname.BorderRadius = 8;
            _txtFullname.PlaceholderText = "Nhập họ tên";

            var lblRole = new Guna2HtmlLabel
            {
                Text = "Vai trò",
                Location = new Point(24, 288),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            _cboRole.Location = new Point(24, 312);
            _cboRole.Size = new Size(180, 36);
            _cboRole.BorderRadius = 8;
            _cboRole.DrawMode = DrawMode.OwnerDrawFixed;
            _cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboRole.Items.AddRange(new object[] { "User", "Admin" });
            _cboRole.SelectedIndex = 0;

            var btnLogin = new Guna2Button
            {
                Text = "Đăng nhập",
                Size = new Size(150, 40),
                Location = new Point(244, 308),
                BorderRadius = 10,
                FillColor = Color.FromArgb(255, 102, 0),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnLogin.Click += BtnLogin_Click;

            var btnRegister = new Guna2Button
            {
                Text = "Đăng ký",
                Size = new Size(150, 40),
                Location = new Point(244, 352),
                BorderRadius = 10,
                FillColor = Color.White,
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BorderThickness = 1,
                BorderColor = Color.LightGray
            };
            btnRegister.Click += BtnRegister_Click;

            _lblStatus.Location = new Point(24, 360);
            _lblStatus.ForeColor = Color.Firebrick;
            _lblStatus.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            _lblStatus.AutoSize = true;

            Controls.AddRange(new Control[]
            {
                lblTitle,
                lblUser, _txtUser,
                lblPass, _txtPass,
                lblFull, _txtFullname,
                lblRole, _cboRole,
                btnLogin, btnRegister,
                _lblStatus
            });
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

            var acc = XMLHelper.Authenticate(user, pass);
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
            var full = _txtFullname.Text.Trim();
            var role = _cboRole.SelectedItem?.ToString() ?? "User";

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                _lblStatus.Text = "Tài khoản và mật khẩu không được trống.";
                return;
            }

            var account = new Account
            {
                Username = user,
                Password = pass,
                FullName = string.IsNullOrEmpty(full) ? user : full,
                Role = role
            };

            if (!XMLHelper.AddAccount(account, out var error))
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
