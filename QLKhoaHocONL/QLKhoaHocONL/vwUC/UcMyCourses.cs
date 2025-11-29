using System;
using System.Linq;
using System.Windows.Forms;
using QLKhoaHocONL.Helpers;

namespace QLKhoaHocONL.vwUC
{
    /// <summary>
    /// Hiển thị danh sách khóa học đã mua của người dùng.
    /// </summary>
    public partial class UcMyCourses : UserControl
    {
        public UcMyCourses()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
        }

        private void LoadData()
        {
            flowOwned.Controls.Clear();

            if (!AppState.IsLoggedIn)
            {
                lblTitle.Text = "Bạn cần đăng nhập để xem khóa học đã mua";
                return;
            }

            var ids = XMLHelper.LoadUserCourses(AppState.CurrentUser.Username);
            var courses = XMLHelper.LoadCourses().Where(c => ids.Contains(c.Id)).ToList();

            lblTitle.Text = $"Khóa học của {AppState.CurrentUser.FullName ?? AppState.CurrentUser.Username}";

            if (!courses.Any())
            {
                flowOwned.Controls.Add(new Label
                {
                    AutoSize = true,
                    Text = "Chưa có khóa học nào. Thử mua một khóa học ở trang Lộ trình nhé!",
                    Font = new System.Drawing.Font("Segoe UI", 11F)
                });
                return;
            }

            foreach (var c in courses)
            {
                var card = new UC_ItemKhoaHoc();
                card.NapDuLieu(c);
                flowOwned.Controls.Add(card);
            }
        }
    }
}
