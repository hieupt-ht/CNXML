using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QLKhoaHocONL.Helpers;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL.vwUC
{
    public partial class UcCourses : UserControl
    {
        private readonly bool _onlyOwned;
        private int _bannerIndex;
        private string _searchQuery = string.Empty;
        private readonly Timer _bannerTimer = new Timer { Interval = 3000 };

        private readonly (string title, string desc, string action, string link, Color c1, Color c2)[] _banners =
        {
            ("F8 trên Youtube", "F8 được nhắc tới ở mọi nơi, mở rộng cơ hội việc làm cho người yêu lập trình.", "Đăng ký kênh", "https://www.youtube.com/c/F8VNOfficial",
                Color.FromArgb(255, 94, 0), Color.FromArgb(255, 166, 0)),
            ("Học React nhanh", "Lộ trình ReactJS Master cho frontend developer muốn lên tầm cao mới.", "Xem lộ trình", "https://fullstack.edu.vn/learning/reactjs",
                Color.FromArgb(0, 198, 255), Color.FromArgb(0, 114, 255)),
            ("Việc làm IT", "Học xong là thực chiến - chuẩn bị hồ sơ, phỏng vấn và nhận offer.", "Xem khóa", "https://fullstack.edu.vn/learning/html-css",
                Color.FromArgb(17, 153, 142), Color.FromArgb(56, 239, 125))
        };

        public UcCourses(bool onlyOwned = false)
        {
            _onlyOwned = onlyOwned;
            InitializeComponent();
            _bannerTimer.Tick += (s, e) => btnNext_Click(s, e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lblTitle.Text = _onlyOwned ? "Khoa hoc cua toi" : "Khoa hoc noi bat";
            UpdateBanner();
            _bannerTimer.Start();
            DocXML();
        }

        public void SetSearch(string query)
        {
            _searchQuery = (query ?? string.Empty).Trim();
            DocXML();
        }

        private void DocXML()
        {
            try
            {
                flowLayoutPanelKhoaHoc.Controls.Clear();

                var list = DbHelper.LoadCourses();
                if (_onlyOwned && AppState.IsLoggedIn)
                {
                    var ownedIds = DbHelper.LoadUserCourseIds(AppState.CurrentUser.Username);
                    list = list.Where(c => ownedIds.Contains(c.Id)).ToList();
                }

                if (!string.IsNullOrWhiteSpace(_searchQuery))
                {
                    var key = _searchQuery.ToLowerInvariant();
                    list = list.Where(c => (c.TenKhoaHoc ?? string.Empty).ToLowerInvariant().Contains(key)).ToList();
                }

                foreach (var item in list)
                {
                    var uc = new UC_ItemKhoaHoc();
                    uc.NapDuLieu(item);
                    flowLayoutPanelKhoaHoc.Controls.Add(uc);
                }

                if (!list.Any())
                {
                    flowLayoutPanelKhoaHoc.Controls.Add(new Label
                    {
                        AutoSize = true,
                        Font = new System.Drawing.Font("Segoe UI", 11F),
                        Text = _onlyOwned
                            ? "Ban chua mua khoa hoc nao, quay lai Trang chu de dang ky nhe!"
                            : "Chua co du lieu khoa hoc."
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        public void RefreshData(bool resetSearch = false)
        {
            if (resetSearch) _searchQuery = string.Empty;
            DocXML();
        }

        private void UpdateBanner()
        {
            var b = _banners[_bannerIndex];
            lblBannerTitle.Text = b.title;
            lblBannerDesc.Text = b.desc;
            btnBannerAction.Text = b.action;
            btnBannerAction.Tag = b.link;
            bannerPanel.FillColor = b.c1;
            bannerPanel.FillColor2 = b.c2;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _bannerIndex = (_bannerIndex + 1) % _banners.Length;
            UpdateBanner();
            _bannerTimer.Stop();
            _bannerTimer.Start();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _bannerIndex--;
            if (_bannerIndex < 0) _bannerIndex = _banners.Length - 1;
            UpdateBanner();
            _bannerTimer.Stop();
            _bannerTimer.Start();
        }

        private void btnBannerAction_Click(object sender, EventArgs e)
        {
            if (btnBannerAction.Tag is string link && !string.IsNullOrWhiteSpace(link))
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = link,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Khong mo duoc link: " + ex.Message);
                }
            }
        }
    }
}
