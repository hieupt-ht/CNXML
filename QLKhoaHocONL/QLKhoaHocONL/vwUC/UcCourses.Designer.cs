namespace QLKhoaHocONL.vwUC
{
    partial class UcCourses
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanelKhoaHoc = new System.Windows.Forms.FlowLayoutPanel();
            this.bannerPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnBannerAction = new Guna.UI2.WinForms.Guna2Button();
            this.lblBannerDesc = new System.Windows.Forms.Label();
            this.lblBannerTitle = new System.Windows.Forms.Label();
            this.btnPrev = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2CircleButton();
            this.bannerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 250);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Khóa học nổi bật";
            // 
            // flowLayoutPanelKhoaHoc
            // 
            this.flowLayoutPanelKhoaHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelKhoaHoc.AutoScroll = true;
            this.flowLayoutPanelKhoaHoc.Location = new System.Drawing.Point(23, 300);
            this.flowLayoutPanelKhoaHoc.Name = "flowLayoutPanelKhoaHoc";
            this.flowLayoutPanelKhoaHoc.Size = new System.Drawing.Size(1308, 480);
            this.flowLayoutPanelKhoaHoc.TabIndex = 1;
            // 
            // bannerPanel
            // 
            this.bannerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bannerPanel.BorderRadius = 20;
            this.bannerPanel.Controls.Add(this.btnBannerAction);
            this.bannerPanel.Controls.Add(this.lblBannerDesc);
            this.bannerPanel.Controls.Add(this.lblBannerTitle);
            this.bannerPanel.Controls.Add(this.btnPrev);
            this.bannerPanel.Controls.Add(this.btnNext);
            this.bannerPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.bannerPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.bannerPanel.Location = new System.Drawing.Point(23, 18);
            this.bannerPanel.Name = "bannerPanel";
            this.bannerPanel.Size = new System.Drawing.Size(1308, 220);
            this.bannerPanel.TabIndex = 2;
            // 
            // btnBannerAction
            // 
            this.btnBannerAction.BorderRadius = 12;
            this.btnBannerAction.FillColor = System.Drawing.Color.White;
            this.btnBannerAction.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBannerAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.btnBannerAction.Location = new System.Drawing.Point(42, 148);
            this.btnBannerAction.Name = "btnBannerAction";
            this.btnBannerAction.Size = new System.Drawing.Size(160, 40);
            this.btnBannerAction.TabIndex = 4;
            this.btnBannerAction.Text = "Đăng ký kênh";
            this.btnBannerAction.Click += new System.EventHandler(this.btnBannerAction_Click);
            // 
            // lblBannerDesc
            // 
            this.lblBannerDesc.AutoSize = true;
            this.lblBannerDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBannerDesc.ForeColor = System.Drawing.Color.White;
            this.lblBannerDesc.Location = new System.Drawing.Point(38, 82);
            this.lblBannerDesc.Name = "lblBannerDesc";
            this.lblBannerDesc.Size = new System.Drawing.Size(328, 25);
            this.lblBannerDesc.TabIndex = 3;
            this.lblBannerDesc.Text = "Nội dung sẽ được cập nhật qua banner";
            // 
            // lblBannerTitle
            // 
            this.lblBannerTitle.AutoSize = true;
            this.lblBannerTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBannerTitle.ForeColor = System.Drawing.Color.White;
            this.lblBannerTitle.Location = new System.Drawing.Point(36, 28);
            this.lblBannerTitle.Name = "lblBannerTitle";
            this.lblBannerTitle.Size = new System.Drawing.Size(253, 46);
            this.lblBannerTitle.TabIndex = 2;
            this.lblBannerTitle.Text = "F8 trên Youtube";
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.Animated = true;
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrev.FillColor = System.Drawing.Color.White;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.Gray;
            this.btnPrev.Location = new System.Drawing.Point(8, 88);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPrev.Size = new System.Drawing.Size(36, 36);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Animated = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColor = System.Drawing.Color.Transparent;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.Gray;
            this.btnNext.Location = new System.Drawing.Point(1264, 88);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNext.Size = new System.Drawing.Size(36, 36);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = ">";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // UcCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bannerPanel);
            this.Controls.Add(this.flowLayoutPanelKhoaHoc);
            this.Controls.Add(this.lblTitle);
            this.Name = "UcCourses";
            this.Size = new System.Drawing.Size(1341, 799);
            this.bannerPanel.ResumeLayout(false);
            this.bannerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKhoaHoc;
        private Guna.UI2.WinForms.Guna2GradientPanel bannerPanel;
        private System.Windows.Forms.Label lblBannerTitle;
        private System.Windows.Forms.Label lblBannerDesc;
        private Guna.UI2.WinForms.Guna2Button btnBannerAction;
        private Guna.UI2.WinForms.Guna2CircleButton btnPrev;
        private Guna.UI2.WinForms.Guna2CircleButton btnNext;
    }
}
