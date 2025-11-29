using System;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL.Helpers
{
    /// <summary>
    /// Lưu phiên đăng nhập hiện tại và thông báo cho UI khi thay đổi.
    /// </summary>
    internal static class AppState
    {
        public static Account CurrentUser { get; private set; }

        public static bool IsLoggedIn => CurrentUser != null;
        public static bool IsAdmin => CurrentUser != null && CurrentUser.IsAdmin;

        public static event Action UserChanged;

        public static void SetUser(Account account)
        {
            CurrentUser = account;
            UserChanged?.Invoke();
        }

        public static void Logout()
        {
            CurrentUser = null;
            UserChanged?.Invoke();
        }
    }
}
