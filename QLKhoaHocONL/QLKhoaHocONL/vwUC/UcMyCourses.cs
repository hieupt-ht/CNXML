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

            var ids = DbHelper.LoadUserCourseIds(AppState.CurrentUser.Username);
            
            // Load từ XML, nếu chưa có thì tự động load từ SQL (chỉ cho UcMyCourses)
            var courses = XMLHelper.LoadCourses();
            
            // Tự động fallback từ SQL nếu XML chưa có dữ liệu
            if (!courses.Any())
            {
                courses = DbHelper.LoadCourses();
                // Tự động đồng bộ SQL -> XML nếu có dữ liệu từ SQL
                if (courses.Any())
                {
                    XMLHelper.SaveCourses(courses);
                }
            }
            
            courses = courses.Where(c => ids.Contains(c.Id)).ToList();

            lblTitle.Text = $"Khóa học của {AppState.CurrentUser.FullName ?? AppState.CurrentUser.Username}";

            if (!courses.Any())
            {
                var message = ids.Any()
                    ? "Chưa có khóa học nào. Thử mua một khóa học ở trang Lộ trình nhé!"
                    : "Chưa có dữ liệu khóa học.";
                
                flowOwned.Controls.Add(new Label
                {
                    AutoSize = true,
                    Text = message,
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
