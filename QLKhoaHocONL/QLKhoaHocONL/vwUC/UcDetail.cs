using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QLKhoaHocONL.Helpers;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL.vwUC
{
    public partial class UcDetail : UserControl
    {
        private Course _course;

        public UcDetail()
        {
            InitializeComponent();
        }

        public void LoadChiTiet(Course course)
        {
            _course = course;
            lblTenKhoaHoc.Text = course.TenKhoaHoc;
            lblGia.Text = course.GiaGiam;
            var giangVien = string.IsNullOrWhiteSpace(course.InstructorName)
                ? "Chưa rõ giảng viên"
                : $"Giảng viên: {course.InstructorName}";
            lblThongTin.Text = $"{giangVien} | Giá gốc: {course.GiaGoc} | Giá giảm: {course.GiaGiam} | {course.ThoiLuong} | {course.SoHocVien} học viên";
            lblDemo.Text = string.IsNullOrWhiteSpace(course.DemoLink) ? "Chưa có link demo" : course.DemoLink;

            try
            {
                string tenResource = System.IO.Path.GetFileNameWithoutExtension(course.TenAnh);
                object obj = Properties.Resources.ResourceManager.GetObject(tenResource);
                if (obj != null) picAnhLon.Image = (Image)obj;
            }
            catch
            {
                // ignore load failures
            }

            LoadVideos();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var main = (frmMain)this.ParentForm;
            main.ChuyenManHinh(new UcCourses());
        }

        private void btnMuaNgay_Click(object sender, EventArgs e)
        {
            if (_course == null) return;

            if (!AppState.IsLoggedIn)
            {
                using (var frm = new GUI.frmLogin())
                {
                    if (frm.ShowDialog() != DialogResult.OK) return;
                }
            }

            DbHelper.AddUserCourse(AppState.CurrentUser.Username, _course.Id);
            MessageBox.Show("Đã thêm khóa học vào tài khoản của bạn!");
            UpdateOwnershipUI(true);
            LoadVideos();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            if (_course == null || string.IsNullOrWhiteSpace(_course.DemoLink))
            {
                MessageBox.Show("Chưa có video demo cho khóa học này.");
                return;
            }

            OpenUrl(_course.DemoLink);
        }

        private void LoadVideos()
        {
            flowVideos.Controls.Clear();

            if (_course == null) return;

            bool owned = UserOwnsCourse();
            UpdateOwnershipUI(owned);
            lblVideoTitle.Text = owned ? "Danh sách bài học" : "Bạn cần mua để xem danh sách bài học";

            if (!owned)
            {
                flowVideos.Controls.Add(new Label
                {
                    AutoSize = true,
                    Text = "Hãy mua khóa học để xem toàn bộ video.",
                    Font = new Font("Segoe UI", 10F)
                });
                return;
            }

            var videos = DbHelper.LoadVideos(_course.Id);
            if (!videos.Any())
            {
                flowVideos.Controls.Add(new Label
                {
                    AutoSize = true,
                    Text = "Chưa có video cho khóa học này.",
                    Font = new Font("Segoe UI", 10F)
                });
                return;
            }

            foreach (var v in videos)
            {
                var btn = new Guna.UI2.WinForms.Guna2Button
                {
                    Width = 320,
                    Height = 50,
                    Margin = new Padding(6),
                    BorderRadius = 8,
                    TextAlign = HorizontalAlignment.Left,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    Text = $"{v.Order}. {v.Title}",
                    Tag = v.Url,
                    FillColor = Color.White,
                    ForeColor = Color.Black,
                    BorderThickness = 1,
                    BorderColor = Color.LightGray
                };
                btn.Click += (s, e) => OpenUrl(v.Url);
                flowVideos.Controls.Add(btn);
            }
        }

        private void OpenUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url)) return;
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không mở được video: " + ex.Message);
            }
        }

        private bool UserOwnsCourse()
        {
            if (_course == null || !AppState.IsLoggedIn || AppState.CurrentUser == null) return false;
            return DbHelper.LoadUserCourseIds(AppState.CurrentUser.Username).Contains(_course.Id);
        }

        private void UpdateOwnershipUI(bool owned)
        {
            btnMuaNgay.Visible = !owned;
            btnDemo.Enabled = owned || !string.IsNullOrWhiteSpace(_course?.DemoLink);
        }
    }
}
