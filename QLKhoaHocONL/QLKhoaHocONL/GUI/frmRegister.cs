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
        private bool _isPassVisible = false;
        private bool _isConfirmVisible = false;

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
            var email = _txtEmail.Text.Trim();
            var phone = _txtPhone.Text.Trim();
            var address = _txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(confirm))
            {
                _lblStatus.Text = "Tài khoản và mật khẩu không được trống.";
                return;
            }
            // Email và số điện thoại bắt buộc
            if (string.IsNullOrEmpty(email))
            {
                _lblStatus.Text = "Email không được để trống.";
                return;
            }
            if (string.IsNullOrEmpty(phone))
            {
                _lblStatus.Text = "Số điện thoại không được để trống.";
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
            // Tạo học viên với thông tin bắt buộc
            var student = new Student
            {
                FullName = string.IsNullOrEmpty(full) ? user : full,
                Email = email,
                Phone = phone,
                Address = address,
                AccountId = account.AccountId,
                EnrollmentDate = DateTime.Now
            };
            DbHelper.AddStudent(student);
            // Hiển thị thông báo
            MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập để tiếp tục.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Đóng form đăng ký và trả về OK để form gọi nó biết cần mở form đăng nhập
            DialogResult = DialogResult.OK;
            Close();
        }
        private void _txtPass_Enter(object sender, EventArgs e)
        {
            picEyePass.Visible = true;
        }
        private void _txtPass_Leave(object sender, EventArgs e)
        {
            picEyePass.Visible = false;
        }
        private void _txtConfirm_Enter(object sender, EventArgs e)
        {
            picEyeConfirm.Visible = true;
        }
        private void _txtConfirm_Leave(object sender, EventArgs e)
        {
            picEyeConfirm.Visible = false;
        }
        private void picEyePass_Click(object sender, EventArgs e)
        {
            _isPassVisible = !_isPassVisible;
            _txtPass.PasswordChar = _isPassVisible ? '\0' : '•';
            picEyePass.Image = _isPassVisible 
                ? Properties.Resources.ic_hienMK 
                : Properties.Resources.ic_anMK;
        }
        private void picEyeConfirm_Click(object sender, EventArgs e)
        {
            _isConfirmVisible = !_isConfirmVisible;
            _txtConfirm.PasswordChar = _isConfirmVisible ? '\0' : '•';
            picEyeConfirm.Image = _isConfirmVisible 
                ? Properties.Resources.ic_hienMK 
                : Properties.Resources.ic_anMK;
        }
    }
}