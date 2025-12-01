using System;
using System.Drawing;
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

        public frmMain()
        {
            InitializeComponent();
            AppState.UserChanged += AppState_UserChanged;
            UpdateUserStateUI();
            BuildAdminMenu();
            ChuyenManHinh(_homeCourses);
        }

        private void AppState_UserChanged()
        {
            UpdateUserStateUI();
        }

        // HAM DUNG CHUNG (Public để các form con gọi được)
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
            ChuyenManHinh(_homeCourses);
        }

        private void btnRoadmap_Click(object sender, EventArgs e)
        {
            ResetMauNut();
            btnRoadmap.BackColor = Color.White;
            MessageBox.Show("Bài viết/lộ trình chi tiết sẽ cập nhật sau.");
        }

        private void ResetMauNut()
        {
            btnHome.BackColor = Color.Transparent;
            btnCourses.BackColor = Color.Transparent;
            btnRoadmap.BackColor = Color.Transparent;
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
            btnLogin.Visible = btnSignup.Visible = !logged;
            lblUser.Visible = btnLogout.Visible = btnMyCourses.Visible = logged;
            btnAdmin.Visible = AppState.IsAdmin;

            if (logged)
                lblUser.Text = $"Xin chào, {AppState.CurrentUser.FullName ?? AppState.CurrentUser.Username}";
        }

        private void BuildAdminMenu()
        {
            _adminMenu.Items.Clear();
            _adminMenu.Items.Add("Quản lý khóa học", null, (_, __) => { using (var f = new frmKhoaHoc()) f.ShowDialog(); });
            _adminMenu.Items.Add("Quản lý giảng viên", null, (_, __) => { using (var f = new frmInstructor()) f.ShowDialog(); });
            _adminMenu.Items.Add("Quản lý học viên", null, (_, __) => { using (var f = new frmStudent()) f.ShowDialog(); });
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
    }
}
