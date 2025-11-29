using System;

namespace QLKhoaHocONL.Models
{
    /// <summary>
    /// Thông tin tài khoản đăng nhập.
    /// </summary>
    internal class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; } = "User";

        public bool IsAdmin => string.Equals(Role, "Admin", StringComparison.OrdinalIgnoreCase);
    }
}
