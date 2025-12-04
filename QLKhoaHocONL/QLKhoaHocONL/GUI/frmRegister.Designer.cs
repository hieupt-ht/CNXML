namespace QLKhoaHocONL.GUI
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblConfirm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._txtConfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFullname = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._txtFullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this._lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(40, 30);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4);
            this.lblTitle.MinimumSize = new System.Drawing.Size(270, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tạo tài khoản mới";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(40, 83);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4);
            this.lblSubtitle.MinimumSize = new System.Drawing.Size(220, 30);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(220, 30);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Nhập thông tin để đăng ký";
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUser.Location = new System.Drawing.Point(40, 120);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4);
            this.lblUser.MinimumSize = new System.Drawing.Size(80, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(80, 25);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Tài khoản";
            // 
            // _txtUser
            // 
            this._txtUser.BorderRadius = 10;
            this._txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtUser.DefaultText = "";
            this._txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this._txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtUser.Location = new System.Drawing.Point(40, 150);
            this._txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtUser.Name = "_txtUser";
            this._txtUser.PlaceholderText = "Nhập email hoặc username";
            this._txtUser.SelectedText = "";
            this._txtUser.Size = new System.Drawing.Size(480, 44);
            this._txtUser.TabIndex = 3;
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPass.Location = new System.Drawing.Point(40, 210);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4);
            this.lblPass.MinimumSize = new System.Drawing.Size(80, 25);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(80, 25);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Mật khẩu";
            // 
            // _txtPass
            // 
            this._txtPass.BorderRadius = 10;
            this._txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtPass.DefaultText = "";
            this._txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this._txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtPass.Location = new System.Drawing.Point(40, 240);
            this._txtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtPass.Name = "_txtPass";
            this._txtPass.PasswordChar = '•';
            this._txtPass.PlaceholderText = "Nhập mật khẩu";
            this._txtPass.SelectedText = "";
            this._txtPass.Size = new System.Drawing.Size(480, 44);
            this._txtPass.TabIndex = 5;
            // 
            // lblConfirm
            // 
            this.lblConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConfirm.Location = new System.Drawing.Point(40, 300);
            this.lblConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.lblConfirm.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(150, 25);
            this.lblConfirm.TabIndex = 6;
            this.lblConfirm.Text = "Nhập lại mật khẩu";
            // 
            // _txtConfirm
            // 
            this._txtConfirm.BorderRadius = 10;
            this._txtConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtConfirm.DefaultText = "";
            this._txtConfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtConfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtConfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtConfirm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this._txtConfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtConfirm.Location = new System.Drawing.Point(40, 330);
            this._txtConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtConfirm.Name = "_txtConfirm";
            this._txtConfirm.PasswordChar = '•';
            this._txtConfirm.PlaceholderText = "Nhập lại mật khẩu";
            this._txtConfirm.SelectedText = "";
            this._txtConfirm.Size = new System.Drawing.Size(480, 44);
            this._txtConfirm.TabIndex = 7;
            // 
            // lblFullname
            // 
            this.lblFullname.BackColor = System.Drawing.Color.Transparent;
            this.lblFullname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFullname.Location = new System.Drawing.Point(40, 390);
            this.lblFullname.Margin = new System.Windows.Forms.Padding(4);
            this.lblFullname.MinimumSize = new System.Drawing.Size(140, 25);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(140, 25);
            this.lblFullname.TabIndex = 8;
            this.lblFullname.Text = "Họ tên (tùy chọn)";
            // 
            // _txtFullname
            // 
            this._txtFullname.BorderRadius = 10;
            this._txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtFullname.DefaultText = "";
            this._txtFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtFullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtFullname.Font = new System.Drawing.Font("Segoe UI", 11F);
            this._txtFullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtFullname.Location = new System.Drawing.Point(40, 420);
            this._txtFullname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtFullname.Name = "_txtFullname";
            this._txtFullname.PlaceholderText = "Nhập họ tên";
            this._txtFullname.SelectedText = "";
            this._txtFullname.Size = new System.Drawing.Size(480, 44);
            this._txtFullname.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.BorderRadius = 12;
            this.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(40, 520);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(480, 48);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // _lblStatus
            // 
            this._lblStatus.BackColor = System.Drawing.Color.Transparent;
            this._lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._lblStatus.ForeColor = System.Drawing.Color.Firebrick;
            this._lblStatus.Location = new System.Drawing.Point(40, 480);
            this._lblStatus.Margin = new System.Windows.Forms.Padding(4);
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(3, 2);
            this._lblStatus.TabIndex = 11;
            this._lblStatus.Text = null;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 600);
            this.Controls.Add(this._lblStatus);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this._txtFullname);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this._txtConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this._txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this._txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng ký";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUser;
        private Guna.UI2.WinForms.Guna2TextBox _txtUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPass;
        private Guna.UI2.WinForms.Guna2TextBox _txtPass;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblConfirm;
        private Guna.UI2.WinForms.Guna2TextBox _txtConfirm;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFullname;
        private Guna.UI2.WinForms.Guna2TextBox _txtFullname;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private Guna.UI2.WinForms.Guna2HtmlLabel _lblStatus;
    }
}