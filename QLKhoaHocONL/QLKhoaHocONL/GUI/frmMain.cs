using System;

using System.Drawing;

using System.Drawing.Drawing2D;

using System.Windows.Forms;

using QLKhoaHocONL.GUI;

using QLKhoaHocONL.Helpers;

using QLKhoaHocONL.vwUC;



namespace QLKhoaHocONL

{
    public partial class frmMain : Form

    {
        private readonly ContextMenuStrip _adminMenu = new ContextMenuStrip();

        private readonly UcCourses _homeCourses = new UcCourses();

        private readonly UcBlog _blog = new UcBlog();



        public frmMain()

        {

            InitializeComponent();

            picAdminAvatar.Image = SystemIcons.Shield.ToBitmap();

            picLogo.Image = CreateAvatarCircle("F8", Color.FromArgb(255, 117, 24), Color.White);

            ApplyButtonIcons();

            AppState.UserChanged += AppState_UserChanged;

            UpdateUserStateUI();

            BuildAdminMenu();

            ChuyenManHinh(_homeCourses);

        }

        private void AppState_UserChanged()
        {
            UpdateUserStateUI();
        }

        public void ChuyenManHinh(UserControl uc)

        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void btnCourses_Click(object sender, EventArgs e)

        {

            ResetMauNut();

            btnCourses.BackColor = Color.White;

            ChuyenManHinh(new UcRoadmap());

        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            ResetMauNut();
            btnHome.BackColor = Color.White;
            txtSearch.Text = string.Empty;
            _homeCourses.SetSearch(null);
            _homeCourses.RefreshData();
            ChuyenManHinh(_homeCourses);
        }



        private void btnRoadmap_Click(object sender, EventArgs e)

        {

            ResetMauNut();

            btnRoadmap.BackColor = Color.White;

            ChuyenManHinh(_blog);

        }



        private void ResetMauNut()

        {

            btnHome.BackColor = Color.Transparent;

            btnCourses.BackColor = Color.Transparent;

            btnRoadmap.BackColor = Color.Transparent;

            btnNotifications.BackColor = Color.Transparent;
            btnSyncData.BackColor = Color.Transparent;

        }



        private void btnLogin_Click(object sender, EventArgs e)

        {

            using (var frm = new frmLogin())

            {

                frm.ShowDialog();

            }

        }



        private void btnSignup_Click(object sender, EventArgs e)

        {

            using (var frm = new frmRegister())

            {

                frm.ShowDialog();

            }

        }



        private void btnLogout_Click(object sender, EventArgs e)

        {

            AppState.Logout();

            ResetMauNut();

            ChuyenManHinh(_homeCourses);

        }



        private void btnMyCourses_Click(object sender, EventArgs e)

        {

            if (!EnsureLogin()) return;

            ResetMauNut();

            ChuyenManHinh(new UcMyCourses());

        }



        private void btnAdmin_Click(object sender, EventArgs e)

        {
            if (!EnsureLogin()) return;

            if (!AppState.IsAdmin)

            {

                MessageBox.Show("Chỉ admin mới truy cập được màn hình này.");

                return;

            }
            _adminMenu.Show(btnAdmin, 0, btnAdmin.Height);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            if (!AppState.IsAdmin)
            {
                MessageBox.Show("Chỉ admin mới xem thông báo.");
                return;
            }

            ResetMauNut();
            btnNotifications.BackColor = Color.White;

            using (var frm = new frmNotifications())
            {
                frm.ShowDialog();
            }

            btnNotifications.BackColor = Color.Transparent;
            btnSyncData.BackColor = Color.Transparent;
            RefreshNotificationBadge();
        }

        private void btnSyncData_Click(object sender, EventArgs e)
        {
            if (!AppState.IsAdmin)
            {
                MessageBox.Show("Chỉ admin mới dùng chức năng này.");
                return;
            }

            ResetMauNut();
            btnSyncData.BackColor = Color.White;

            using (var f = new frmXMLData())
            {
                f.ShowDialog();
            }

            btnSyncData.BackColor = Color.Transparent;
            RefreshNotificationBadge();
        }

        private bool EnsureLogin()

        {

            if (AppState.IsLoggedIn) return true;

            using (var frm = new frmLogin())

            {
                return frm.ShowDialog() == DialogResult.OK;
            }

        }



        private void UpdateUserStateUI()

        {

            bool logged = AppState.IsLoggedIn;

            bool isAdmin = AppState.IsAdmin;



            btnLogin.Visible = btnSignup.Visible = !logged;

            btnCloseFrm.Visible = !logged;

            btnLogout.Visible = logged;

            btnAdmin.Visible = isAdmin;

            lblUser.Visible = logged && !isAdmin;

            btnMyCourses.Visible = logged && !isAdmin;

            picAdminAvatar.Visible = logged && isAdmin;



            btnNotifications.Visible = isAdmin;
            btnSyncData.Visible = isAdmin;

            if (isAdmin) RefreshNotificationBadge();

            else { btnNotifications.Text = "Thông báo"; btnSyncData.Visible = false; }



            if (logged && !isAdmin)

                lblUser.Text = $"Xin chào, {AppState.CurrentUser.FullName ?? AppState.CurrentUser.Username}";

        }



        private void ApplyButtonIcons()

        {

            btnHome.Image = CreateGlyphIcon("\uE80F", Color.FromArgb(64, 64, 64));       

            btnCourses.Image = CreateGlyphIcon("\uE816", Color.FromArgb(64, 64, 64));        

            btnRoadmap.Image = CreateGlyphIcon("\uE8A5", Color.FromArgb(64, 64, 64));

            btnSyncData.Image = CreateGlyphIcon("\uE895", Color.FromArgb(64, 64, 64));

            btnNotifications.Image = CreateGlyphIcon("\uEA8F", Color.FromArgb(64, 64, 64));  



            btnHome.TextImageRelation = TextImageRelation.ImageAboveText;

            btnCourses.TextImageRelation = TextImageRelation.ImageAboveText;

            btnRoadmap.TextImageRelation = TextImageRelation.ImageAboveText;

            btnSyncData.TextImageRelation = TextImageRelation.ImageAboveText;

            btnNotifications.TextImageRelation = TextImageRelation.ImageAboveText;

        }



        private static Bitmap CreateAvatarCircle(string text, Color background, Color foreground)

        {

            var size = 36;

            var bmp = new Bitmap(size, size);

            using (var g = Graphics.FromImage(bmp))

            {

                g.SmoothingMode = SmoothingMode.AntiAlias;

                using (var brush = new SolidBrush(background))

                {

                    g.FillEllipse(brush, 0, 0, size - 1, size - 1);

                }



                using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })

                using (var font = new Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Pixel))

                using (var brush = new SolidBrush(foreground))

                {

                    g.DrawString(text, font, brush, new RectangleF(0, 0, size, size), sf);

                }

            }



            return bmp;

        }



        private static Bitmap CreateGlyphIcon(string glyph, Color color)

        {

            var size = 36;

            var bmp = new Bitmap(size, size);

            using (var g = Graphics.FromImage(bmp))

            {

                g.SmoothingMode = SmoothingMode.AntiAlias;

                g.Clear(Color.Transparent);

                using (var font = new Font("Segoe MDL2 Assets", 20, FontStyle.Regular, GraphicsUnit.Pixel))

                using (var brush = new SolidBrush(color))

                using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })

                {

                    g.DrawString(glyph, font, brush, new RectangleF(0, 0, size, size), sf);

                }

            }



            return bmp;

        }



        private void BuildAdminMenu()

        {

            _adminMenu.Items.Clear();

            _adminMenu.Items.Add("Quản lý khóa học", null, (_, __) => { using (var f = new frmKhoaHoc()) f.ShowDialog(); });

            _adminMenu.Items.Add("Quản lý giảng viên", null, (_, __) => { using (var f = new frmInstructor()) f.ShowDialog(); });

            _adminMenu.Items.Add("Quản lý học viên", null, (_, __) => { using (var f = new frmStudent()) f.ShowDialog(); });

        }




        private void RefreshNotificationBadge()
        {
            try
            {
                int unread = DbHelper.CountUnreadNotifications();
                btnNotifications.Text = unread > 0 ? $"Thông báo ({unread})" : "Thông báo";
            }
            catch
            {
                btnNotifications.Text = "Thông báo";
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)

        {

            if (e.KeyCode != Keys.Enter) return;

            e.SuppressKeyPress = true;

            var keyword = txtSearch.Text;

            _homeCourses.SetSearch(keyword);

            ResetMauNut();

            btnHome.BackColor = Color.White;

            ChuyenManHinh(_homeCourses);

        }



        private void lblTitle_Click(object sender, EventArgs e)

        {



        }

        private void btnCloseFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
