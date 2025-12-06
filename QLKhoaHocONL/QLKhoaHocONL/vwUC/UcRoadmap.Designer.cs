namespace QLKhoaHocONL
{
    partial class UcRoadmap
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.flowCards = new System.Windows.Forms.FlowLayoutPanel();
            this.cardFrontend = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFrontendTitle = new System.Windows.Forms.Label();
            this.lblFrontendDesc = new System.Windows.Forms.Label();
            this.lblFrontendItem1 = new System.Windows.Forms.Label();
            this.lblFrontendItem2 = new System.Windows.Forms.Label();
            this.lblFrontendItem3 = new System.Windows.Forms.Label();
            this.lblFrontendItem4 = new System.Windows.Forms.Label();
            this.btnFrontend = new Guna.UI2.WinForms.Guna2Button();
            this.cardBackend = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBackendTitle = new System.Windows.Forms.Label();
            this.lblBackendDesc = new System.Windows.Forms.Label();
            this.lblBackendItem1 = new System.Windows.Forms.Label();
            this.lblBackendItem2 = new System.Windows.Forms.Label();
            this.lblBackendItem3 = new System.Windows.Forms.Label();
            this.lblBackendItem4 = new System.Windows.Forms.Label();
            this.btnBackend = new Guna.UI2.WinForms.Guna2Button();
            this.picFrontend = new System.Windows.Forms.PictureBox();
            this.picBackend = new System.Windows.Forms.PictureBox();
            this.flowCards.SuspendLayout();
            this.cardFrontend.SuspendLayout();
            this.cardBackend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFrontend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackend)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Lộ trình học";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDesc.Location = new System.Drawing.Point(32, 75);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(880, 25);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Để bắt đầu thuận lợi, hãy chọn lộ trình phù hợp. Ví dụ: muốn đi làm Front-end hãy" +
    " tập trung Front-end.";
            // 
            // flowCards
            // 
            this.flowCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowCards.Controls.Add(this.cardFrontend);
            this.flowCards.Controls.Add(this.cardBackend);
            this.flowCards.Location = new System.Drawing.Point(36, 120);
            this.flowCards.Name = "flowCards";
            this.flowCards.Size = new System.Drawing.Size(1050, 480);
            this.flowCards.TabIndex = 2;
            // 
            // cardFrontend
            // 
            this.cardFrontend.BackColor = System.Drawing.Color.Transparent;
            this.cardFrontend.BorderColor = System.Drawing.Color.Gainsboro;
            this.cardFrontend.BorderRadius = 16;
            this.cardFrontend.BorderThickness = 1;
            this.cardFrontend.Controls.Add(this.lblFrontendTitle);
            this.cardFrontend.Controls.Add(this.lblFrontendDesc);
            this.cardFrontend.Controls.Add(this.lblFrontendItem1);
            this.cardFrontend.Controls.Add(this.lblFrontendItem2);
            this.cardFrontend.Controls.Add(this.lblFrontendItem3);
            this.cardFrontend.Controls.Add(this.lblFrontendItem4);
            this.cardFrontend.Controls.Add(this.btnFrontend);
            this.cardFrontend.Controls.Add(this.picFrontend);
            this.cardFrontend.FillColor = System.Drawing.Color.White;
            this.cardFrontend.Location = new System.Drawing.Point(16, 16);
            this.cardFrontend.Margin = new System.Windows.Forms.Padding(16);
            this.cardFrontend.Name = "cardFrontend";
            this.cardFrontend.ShadowDecoration.Depth = 4;
            this.cardFrontend.ShadowDecoration.Enabled = true;
            this.cardFrontend.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.cardFrontend.Size = new System.Drawing.Size(630, 320);
            this.cardFrontend.TabIndex = 0;
            // 
            // lblFrontendTitle
            // 
            this.lblFrontendTitle.AutoSize = true;
            this.lblFrontendTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFrontendTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFrontendTitle.Location = new System.Drawing.Point(20, 20);
            this.lblFrontendTitle.Name = "lblFrontendTitle";
            this.lblFrontendTitle.Size = new System.Drawing.Size(224, 28);
            this.lblFrontendTitle.TabIndex = 0;
            this.lblFrontendTitle.Text = "Lộ trình học Front-end";
            // 
            // lblFrontendDesc
            // 
            this.lblFrontendDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblFrontendDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFrontendDesc.Location = new System.Drawing.Point(20, 60);
            this.lblFrontendDesc.Name = "lblFrontendDesc";
            this.lblFrontendDesc.Size = new System.Drawing.Size(480, 60);
            this.lblFrontendDesc.TabIndex = 1;
            this.lblFrontendDesc.Text = "Lập trình viên Front-end là người xây dựng ra giao diện websites. Phần này giúp b" +
    "ạn trở thành lập trình viên Front-end.";
            // 
            // lblFrontendItem1
            // 
            this.lblFrontendItem1.AutoSize = true;
            this.lblFrontendItem1.BackColor = System.Drawing.Color.Transparent;
            this.lblFrontendItem1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFrontendItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblFrontendItem1.Location = new System.Drawing.Point(20, 130);
            this.lblFrontendItem1.Name = "lblFrontendItem1";
            this.lblFrontendItem1.Size = new System.Drawing.Size(153, 21);
            this.lblFrontendItem1.TabIndex = 2;
            this.lblFrontendItem1.Text = "✓ HTML, CSS cơ bản";
            // 
            // lblFrontendItem2
            // 
            this.lblFrontendItem2.AutoSize = true;
            this.lblFrontendItem2.BackColor = System.Drawing.Color.Transparent;
            this.lblFrontendItem2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFrontendItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblFrontendItem2.Location = new System.Drawing.Point(20, 158);
            this.lblFrontendItem2.Name = "lblFrontendItem2";
            this.lblFrontendItem2.Size = new System.Drawing.Size(147, 21);
            this.lblFrontendItem2.TabIndex = 3;
            this.lblFrontendItem2.Text = "✓ JavaScript cơ bản";
            // 
            // lblFrontendItem3
            // 
            this.lblFrontendItem3.AutoSize = true;
            this.lblFrontendItem3.BackColor = System.Drawing.Color.Transparent;
            this.lblFrontendItem3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFrontendItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblFrontendItem3.Location = new System.Drawing.Point(20, 186);
            this.lblFrontendItem3.Name = "lblFrontendItem3";
            this.lblFrontendItem3.Size = new System.Drawing.Size(83, 21);
            this.lblFrontendItem3.TabIndex = 4;
            this.lblFrontendItem3.Text = "✓ React JS";
            // 
            // lblFrontendItem4
            // 
            this.lblFrontendItem4.AutoSize = true;
            this.lblFrontendItem4.BackColor = System.Drawing.Color.Transparent;
            this.lblFrontendItem4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFrontendItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblFrontendItem4.Location = new System.Drawing.Point(20, 214);
            this.lblFrontendItem4.Name = "lblFrontendItem4";
            this.lblFrontendItem4.Size = new System.Drawing.Size(98, 21);
            this.lblFrontendItem4.TabIndex = 5;
            this.lblFrontendItem4.Text = "✓ TypeScript";
            // 
            // btnFrontend
            // 
            this.btnFrontend.BackColor = System.Drawing.Color.Transparent;
            this.btnFrontend.BorderRadius = 10;
            this.btnFrontend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFrontend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFrontend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFrontend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFrontend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnFrontend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFrontend.ForeColor = System.Drawing.Color.White;
            this.btnFrontend.Location = new System.Drawing.Point(20, 260);
            this.btnFrontend.Name = "btnFrontend";
            this.btnFrontend.Size = new System.Drawing.Size(202, 45);
            this.btnFrontend.TabIndex = 6;
            this.btnFrontend.Text = "XEM CHI TIẾT";
            // 
            // cardBackend
            // 
            this.cardBackend.BackColor = System.Drawing.Color.Transparent;
            this.cardBackend.BorderColor = System.Drawing.Color.Gainsboro;
            this.cardBackend.BorderRadius = 16;
            this.cardBackend.BorderThickness = 1;
            this.cardBackend.Controls.Add(this.lblBackendTitle);
            this.cardBackend.Controls.Add(this.lblBackendDesc);
            this.cardBackend.Controls.Add(this.lblBackendItem1);
            this.cardBackend.Controls.Add(this.lblBackendItem2);
            this.cardBackend.Controls.Add(this.lblBackendItem3);
            this.cardBackend.Controls.Add(this.lblBackendItem4);
            this.cardBackend.Controls.Add(this.btnBackend);
            this.cardBackend.Controls.Add(this.picBackend);
            this.cardBackend.FillColor = System.Drawing.Color.White;
            this.cardBackend.Location = new System.Drawing.Point(16, 368);
            this.cardBackend.Margin = new System.Windows.Forms.Padding(16);
            this.cardBackend.Name = "cardBackend";
            this.cardBackend.ShadowDecoration.Depth = 4;
            this.cardBackend.ShadowDecoration.Enabled = true;
            this.cardBackend.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.cardBackend.Size = new System.Drawing.Size(630, 320);
            this.cardBackend.TabIndex = 1;
            // 
            // lblBackendTitle
            // 
            this.lblBackendTitle.AutoSize = true;
            this.lblBackendTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBackendTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBackendTitle.Location = new System.Drawing.Point(20, 20);
            this.lblBackendTitle.Name = "lblBackendTitle";
            this.lblBackendTitle.Size = new System.Drawing.Size(219, 28);
            this.lblBackendTitle.TabIndex = 0;
            this.lblBackendTitle.Text = "Lộ trình học Back-end";
            // 
            // lblBackendDesc
            // 
            this.lblBackendDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblBackendDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBackendDesc.Location = new System.Drawing.Point(20, 60);
            this.lblBackendDesc.Name = "lblBackendDesc";
            this.lblBackendDesc.Size = new System.Drawing.Size(480, 60);
            this.lblBackendDesc.TabIndex = 1;
            this.lblBackendDesc.Text = "Back-end là người làm việc với dữ liệu, logic và hệ thống. Cùng tìm hiểu lộ trình" +
    " trở thành lập trình viên Back-end.";
            // 
            // lblBackendItem1
            // 
            this.lblBackendItem1.AutoSize = true;
            this.lblBackendItem1.BackColor = System.Drawing.Color.Transparent;
            this.lblBackendItem1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBackendItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblBackendItem1.Location = new System.Drawing.Point(20, 130);
            this.lblBackendItem1.Name = "lblBackendItem1";
            this.lblBackendItem1.Size = new System.Drawing.Size(129, 21);
            this.lblBackendItem1.TabIndex = 2;
            this.lblBackendItem1.Text = "✓ Node.js cơ bản";
            // 
            // lblBackendItem2
            // 
            this.lblBackendItem2.AutoSize = true;
            this.lblBackendItem2.BackColor = System.Drawing.Color.Transparent;
            this.lblBackendItem2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBackendItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblBackendItem2.Location = new System.Drawing.Point(20, 158);
            this.lblBackendItem2.Name = "lblBackendItem2";
            this.lblBackendItem2.Size = new System.Drawing.Size(92, 21);
            this.lblBackendItem2.TabIndex = 3;
            this.lblBackendItem2.Text = "✓ Express.js";
            // 
            // lblBackendItem3
            // 
            this.lblBackendItem3.AutoSize = true;
            this.lblBackendItem3.BackColor = System.Drawing.Color.Transparent;
            this.lblBackendItem3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBackendItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblBackendItem3.Location = new System.Drawing.Point(20, 186);
            this.lblBackendItem3.Name = "lblBackendItem3";
            this.lblBackendItem3.Size = new System.Drawing.Size(189, 21);
            this.lblBackendItem3.TabIndex = 4;
            this.lblBackendItem3.Text = "✓ Database (SQL/NoSQL)";
            // 
            // lblBackendItem4
            // 
            this.lblBackendItem4.AutoSize = true;
            this.lblBackendItem4.BackColor = System.Drawing.Color.Transparent;
            this.lblBackendItem4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBackendItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblBackendItem4.Location = new System.Drawing.Point(20, 214);
            this.lblBackendItem4.Name = "lblBackendItem4";
            this.lblBackendItem4.Size = new System.Drawing.Size(105, 21);
            this.lblBackendItem4.TabIndex = 5;
            this.lblBackendItem4.Text = "✓ RESTful API";
            // 
            // btnBackend
            // 
            this.btnBackend.BackColor = System.Drawing.Color.Transparent;
            this.btnBackend.BorderRadius = 10;
            this.btnBackend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnBackend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackend.ForeColor = System.Drawing.Color.White;
            this.btnBackend.Location = new System.Drawing.Point(20, 260);
            this.btnBackend.Name = "btnBackend";
            this.btnBackend.Size = new System.Drawing.Size(202, 45);
            this.btnBackend.TabIndex = 6;
            this.btnBackend.Text = "XEM CHI TIẾT";
            // 
            // picFrontend
            // 
            this.picFrontend.BackColor = System.Drawing.Color.Transparent;
            this.picFrontend.Image = global::QLKhoaHocONL.Properties.Resources.html_css_pro;
            this.picFrontend.Location = new System.Drawing.Point(380, 110);
            this.picFrontend.Name = "picFrontend";
            this.picFrontend.Size = new System.Drawing.Size(222, 171);
            this.picFrontend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFrontend.TabIndex = 7;
            this.picFrontend.TabStop = false;
            // 
            // picBackend
            // 
            this.picBackend.BackColor = System.Drawing.Color.Transparent;
            this.picBackend.Image = global::QLKhoaHocONL.Properties.Resources.nodejs;
            this.picBackend.Location = new System.Drawing.Point(380, 123);
            this.picBackend.Name = "picBackend";
            this.picBackend.Size = new System.Drawing.Size(222, 140);
            this.picBackend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBackend.TabIndex = 7;
            this.picBackend.TabStop = false;
            // 
            // UcRoadmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowCards);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Name = "UcRoadmap";
            this.Size = new System.Drawing.Size(1120, 623);
            this.flowCards.ResumeLayout(false);
            this.cardFrontend.ResumeLayout(false);
            this.cardFrontend.PerformLayout();
            this.cardBackend.ResumeLayout(false);
            this.cardBackend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFrontend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.FlowLayoutPanel flowCards;
        private Guna.UI2.WinForms.Guna2Panel cardFrontend;
        private System.Windows.Forms.Label lblFrontendTitle;
        private System.Windows.Forms.Label lblFrontendDesc;
        private System.Windows.Forms.Label lblFrontendItem1;
        private System.Windows.Forms.Label lblFrontendItem2;
        private System.Windows.Forms.Label lblFrontendItem3;
        private System.Windows.Forms.Label lblFrontendItem4;
        private Guna.UI2.WinForms.Guna2Button btnFrontend;
        private Guna.UI2.WinForms.Guna2Panel cardBackend;
        private System.Windows.Forms.Label lblBackendTitle;
        private System.Windows.Forms.Label lblBackendDesc;
        private System.Windows.Forms.Label lblBackendItem1;
        private System.Windows.Forms.Label lblBackendItem2;
        private System.Windows.Forms.Label lblBackendItem3;
        private System.Windows.Forms.Label lblBackendItem4;
        private Guna.UI2.WinForms.Guna2Button btnBackend;
        private System.Windows.Forms.PictureBox picFrontend;
        private System.Windows.Forms.PictureBox picBackend;
    }
}