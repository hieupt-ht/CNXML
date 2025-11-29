namespace QLKhoaHocONL.vwUC
{
    partial class UcDetail
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.lblTenKhoaHoc = new System.Windows.Forms.Label();
            this.picAnhLon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.btnMuaNgay = new Guna.UI2.WinForms.Guna2Button();
            this.btnDemo = new Guna.UI2.WinForms.Guna2Button();
            this.lblDemo = new System.Windows.Forms.Label();
            this.lblVideoTitle = new System.Windows.Forms.Label();
            this.flowVideos = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhLon)).BeginInit();
            this.SuspendLayout();

            // btnBack
            this.btnBack.BorderRadius = 10;
            this.btnBack.FillColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(20, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 35);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "< Quay lại";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // picAnhLon
            this.picAnhLon.BorderRadius = 20;
            this.picAnhLon.Location = new System.Drawing.Point(20, 80);
            this.picAnhLon.Name = "picAnhLon";
            this.picAnhLon.Size = new System.Drawing.Size(420, 270);
            this.picAnhLon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhLon.TabIndex = 1;
            this.picAnhLon.TabStop = false;

            // lblTenKhoaHoc
            this.lblTenKhoaHoc.AutoSize = true;
            this.lblTenKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTenKhoaHoc.Location = new System.Drawing.Point(460, 80);
            this.lblTenKhoaHoc.Name = "lblTenKhoaHoc";
            this.lblTenKhoaHoc.Size = new System.Drawing.Size(246, 50);
            this.lblTenKhoaHoc.TabIndex = 2;
            this.lblTenKhoaHoc.Text = "Tên Khóa Học";

            // lblGia
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblGia.ForeColor = System.Drawing.Color.Red;
            this.lblGia.Location = new System.Drawing.Point(462, 143);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(152, 41);
            this.lblGia.TabIndex = 3;
            this.lblGia.Text = "1.299.000";

            // lblThongTin
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblThongTin.Location = new System.Drawing.Point(465, 196);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(292, 25);
            this.lblThongTin.TabIndex = 4;
            this.lblThongTin.Text = "Giá gốc | Thời lượng | Học viên";

            // btnMuaNgay
            this.btnMuaNgay.BorderRadius = 20;
            this.btnMuaNgay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnMuaNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMuaNgay.ForeColor = System.Drawing.Color.White;
            this.btnMuaNgay.Location = new System.Drawing.Point(470, 240);
            this.btnMuaNgay.Name = "btnMuaNgay";
            this.btnMuaNgay.Size = new System.Drawing.Size(180, 45);
            this.btnMuaNgay.TabIndex = 5;
            this.btnMuaNgay.Text = "MUA KHÓA HỌC";
            this.btnMuaNgay.Click += new System.EventHandler(this.btnMuaNgay_Click);

            // btnDemo
            this.btnDemo.BorderRadius = 20;
            this.btnDemo.FillColor = System.Drawing.Color.White;
            this.btnDemo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDemo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnDemo.Location = new System.Drawing.Point(670, 240);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(160, 45);
            this.btnDemo.TabIndex = 6;
            this.btnDemo.Text = "Xem demo";
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);

            // lblDemo
            this.lblDemo.AutoSize = true;
            this.lblDemo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDemo.ForeColor = System.Drawing.Color.DimGray;
            this.lblDemo.Location = new System.Drawing.Point(466, 300);
            this.lblDemo.Name = "lblDemo";
            this.lblDemo.Size = new System.Drawing.Size(128, 23);
            this.lblDemo.TabIndex = 7;
            this.lblDemo.Text = "Link video demo";

            // lblVideoTitle
            this.lblVideoTitle.AutoSize = true;
            this.lblVideoTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblVideoTitle.Location = new System.Drawing.Point(20, 360);
            this.lblVideoTitle.Name = "lblVideoTitle";
            this.lblVideoTitle.Size = new System.Drawing.Size(200, 28);
            this.lblVideoTitle.TabIndex = 8;
            this.lblVideoTitle.Text = "Danh sách bài học";

            // flowVideos
            this.flowVideos.AutoScroll = true;
            this.flowVideos.Location = new System.Drawing.Point(20, 395);
            this.flowVideos.Name = "flowVideos";
            this.flowVideos.Size = new System.Drawing.Size(1080, 220);
            this.flowVideos.TabIndex = 9;

            // UcDetail
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowVideos);
            this.Controls.Add(this.lblVideoTitle);
            this.Controls.Add(this.lblDemo);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.btnMuaNgay);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTenKhoaHoc);
            this.Controls.Add(this.picAnhLon);
            this.Controls.Add(this.btnBack);
            this.Name = "UcDetail";
            this.Size = new System.Drawing.Size(1120, 630);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhLon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label lblTenKhoaHoc;
        private Guna.UI2.WinForms.Guna2PictureBox picAnhLon;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblThongTin;
        private Guna.UI2.WinForms.Guna2Button btnMuaNgay;
        private Guna.UI2.WinForms.Guna2Button btnDemo;
        private System.Windows.Forms.Label lblDemo;
        private System.Windows.Forms.Label lblVideoTitle;
        private System.Windows.Forms.FlowLayoutPanel flowVideos;
    }
}
