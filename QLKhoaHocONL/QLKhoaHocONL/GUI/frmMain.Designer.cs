namespace QLKhoaHocONL
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnRoadmap = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.topbar = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnMyCourses = new Guna.UI2.WinForms.Guna2Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txbF8 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSignup = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sidebar.Controls.Add(this.btnRoadmap);
            this.sidebar.Controls.Add(this.btnCourses);
            this.sidebar.Controls.Add(this.btnHome);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 19, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(70, 635);
            this.sidebar.TabIndex = 0;
            // 
            // btnRoadmap
            // 
            this.btnRoadmap.BackColor = System.Drawing.Color.Transparent;
            this.btnRoadmap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoadmap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoadmap.FlatAppearance.BorderSize = 0;
            this.btnRoadmap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoadmap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRoadmap.Location = new System.Drawing.Point(0, 169);
            this.btnRoadmap.Name = "btnRoadmap";
            this.btnRoadmap.Size = new System.Drawing.Size(70, 75);
            this.btnRoadmap.TabIndex = 2;
            this.btnRoadmap.Text = "Bài viết";
            this.btnRoadmap.UseVisualStyleBackColor = false;
            this.btnRoadmap.Click += new System.EventHandler(this.btnRoadmap_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.Transparent;
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCourses.Location = new System.Drawing.Point(0, 94);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(70, 75);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "Lộ trình";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.Location = new System.Drawing.Point(0, 19);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(70, 75);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.White;
            this.topbar.Controls.Add(this.btnLogout);
            this.topbar.Controls.Add(this.btnAdmin);
            this.topbar.Controls.Add(this.btnMyCourses);
            this.topbar.Controls.Add(this.lblUser);
            this.topbar.Controls.Add(this.lblTitle);
            this.topbar.Controls.Add(this.txbF8);
            this.topbar.Controls.Add(this.txtSearch);
            this.topbar.Controls.Add(this.btnSignup);
            this.topbar.Controls.Add(this.btnLogin);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(70, 0);
            this.topbar.Name = "topbar";
            this.topbar.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.topbar.Size = new System.Drawing.Size(1120, 66);
            this.topbar.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.AutoRoundedCorners = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderRadius = 15;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Location = new System.Drawing.Point(1000, 17);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(104, 33);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdmin.AutoRoundedCorners = true;
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.BorderRadius = 15;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdmin.FillColor = System.Drawing.Color.White;
            this.btnAdmin.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.btnAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmin.Location = new System.Drawing.Point(880, 17);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(114, 33);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnMyCourses
            // 
            this.btnMyCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMyCourses.AutoRoundedCorners = true;
            this.btnMyCourses.BackColor = System.Drawing.Color.Transparent;
            this.btnMyCourses.BorderRadius = 15;
            this.btnMyCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyCourses.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMyCourses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMyCourses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMyCourses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMyCourses.FillColor = System.Drawing.Color.White;
            this.btnMyCourses.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.btnMyCourses.ForeColor = System.Drawing.Color.Black;
            this.btnMyCourses.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnMyCourses.Location = new System.Drawing.Point(630, 17);
            this.btnMyCourses.Name = "btnMyCourses";
            this.btnMyCourses.Size = new System.Drawing.Size(124, 33);
            this.btnMyCourses.TabIndex = 5;
            this.btnMyCourses.Text = "Khoá của tôi";
            this.btnMyCourses.Visible = false;
            this.btnMyCourses.Click += new System.EventHandler(this.btnMyCourses_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(775, 23);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(116, 23);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Xin chào F8";
            this.lblUser.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(89, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Học Lập Trình Để Đi Làm";
            // 
            // txbF8
            // 
            this.txbF8.AutoRoundedCorners = true;
            this.txbF8.BorderColor = System.Drawing.Color.LightGray;
            this.txbF8.BorderRadius = 20;
            this.txbF8.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txbF8.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbF8.DefaultText = "F8";
            this.txbF8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbF8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbF8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbF8.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbF8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.txbF8.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbF8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.txbF8.ForeColor = System.Drawing.Color.White;
            this.txbF8.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbF8.Location = new System.Drawing.Point(22, 15);
            this.txbF8.Margin = new System.Windows.Forms.Padding(4);
            this.txbF8.Name = "txbF8";
            this.txbF8.PlaceholderText = "";
            this.txbF8.ReadOnly = true;
            this.txbF8.SelectedText = "";
            this.txbF8.Size = new System.Drawing.Size(60, 42);
            this.txbF8.TabIndex = 1;
            this.txbF8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::QLKhoaHocONL.Properties.Resources.ic_search;
            this.txtSearch.Location = new System.Drawing.Point(230, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Tìm kiếm khóa học, bài viết, video, ...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(380, 33);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSignup
            // 
            this.btnSignup.AutoRoundedCorners = true;
            this.btnSignup.BackColor = System.Drawing.Color.Transparent;
            this.btnSignup.BorderRadius = 15;
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignup.FillColor = System.Drawing.Color.White;
            this.btnSignup.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.Black;
            this.btnSignup.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSignup.HoverState.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(163)))), ((int)(((byte)(238)))));
            this.btnSignup.Location = new System.Drawing.Point(808, 17);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(114, 33);
            this.btnSignup.TabIndex = 6;
            this.btnSignup.Text = "Đăng ký";
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(928, 17);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 33);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(70, 66);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1120, 569);
            this.pnlContent.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 635);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.sidebar);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F8 - Học Lập Trình Để Đi Làm";
            this.sidebar.ResumeLayout(false);
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnRoadmap;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Panel pnlContent;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnSignup;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2TextBox txbF8;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnMyCourses;
        private Guna.UI2.WinForms.Guna2Button btnAdmin;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private System.Windows.Forms.Label lblUser;
    }
}
