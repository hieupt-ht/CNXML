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

        private readonly (string title, string desc, string action, string link, Color c1, Color c2)[] _banners =
        {
            ("F8 trên Youtube", "F8 được nhắc tới ở mọi nơi, cơ hội việc làm cho người yêu thích lập trình.", "Đăng ký kênh", "https://www.youtube.com/c/F8VNOfficial",
                Color.FromArgb(255,94,0), Color.FromArgb(255,166,0)),
            ("Học React nhanh", "Lộ trình ReactJS Master dành cho frontender muốn lên tầm cao mới.", "Xem lộ trình", "https://fullstack.edu.vn/learning/reactjs",
                Color.FromArgb(0,198,255), Color.FromArgb(0,114,255)),
            ("Việc làm IT", "Học xong là thực chiến – chuẩn bị hồ sơ, phỏng vấn và nhận offer.", "Xem khoá", "https://fullstack.edu.vn/learning/html-css",
                Color.FromArgb(17,153,142), Color.FromArgb(56,239,125))
        };

        public UcCourses(bool onlyOwned = false)
        {
            _onlyOwned = onlyOwned;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lblTitle.Text = _onlyOwned ? "Khoá học của tôi" : "Khóa học nổi bật";
            UpdateBanner();
            DocXML();
        }

        private void DocXML()
        {
            try
            {
                flowLayoutPanelKhoaHoc.Controls.Clear();

                var list = XMLHelper.LoadCourses();
                if (_onlyOwned && AppState.IsLoggedIn)
                {
                    var ownedIds = XMLHelper.LoadUserCourses(AppState.CurrentUser.Username);
                    list = list.Where(c => ownedIds.Contains(c.Id)).ToList();
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
                            ? "Bạn chưa mua khóa học nào, quay lại Trang chủ để đăng ký nhé!"
                            : "Chưa có dữ liệu khóa học."
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
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
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _bannerIndex--;
            if (_bannerIndex < 0) _bannerIndex = _banners.Length - 1;
            UpdateBanner();
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
                    MessageBox.Show("Không mở được link: " + ex.Message);
                }
            }
        }
    }
}
