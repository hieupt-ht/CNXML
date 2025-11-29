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
            this.lblMoTa = new System.Windows.Forms.Label();
            this.btnMuaNgay = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhLon)).BeginInit();
            this.SuspendLayout();

            // btnBack (Nút quay lại)
            this.btnBack.BorderRadius = 10;
            this.btnBack.FillColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(20, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "< Quay lại";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // picAnhLon (Ảnh khóa học)
            this.picAnhLon.BorderRadius = 20;
            this.picAnhLon.Location = new System.Drawing.Point(20, 80);
            this.picAnhLon.Name = "picAnhLon";
            this.picAnhLon.Size = new System.Drawing.Size(400, 250);
            this.picAnhLon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhLon.TabIndex = 1;
            this.picAnhLon.TabStop = false;

            // lblTenKhoaHoc
            this.lblTenKhoaHoc.AutoSize = true;
            this.lblTenKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTenKhoaHoc.Location = new System.Drawing.Point(450, 80);
            this.lblTenKhoaHoc.Name = "lblTenKhoaHoc";
            this.lblTenKhoaHoc.Size = new System.Drawing.Size(250, 50);
            this.lblTenKhoaHoc.TabIndex = 2;
            this.lblTenKhoaHoc.Text = "Tên Khóa Học";

            // lblGia
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblGia.ForeColor = System.Drawing.Color.Red;
            this.lblGia.Location = new System.Drawing.Point(455, 140);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(180, 41);
            this.lblGia.TabIndex = 3;
            this.lblGia.Text = "1.299.000đ";

            // btnMuaNgay
            this.btnMuaNgay.BorderRadius = 20;
            this.btnMuaNgay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnMuaNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMuaNgay.ForeColor = System.Drawing.Color.White;
            this.btnMuaNgay.Location = new System.Drawing.Point(460, 200);
            this.btnMuaNgay.Name = "btnMuaNgay";
            this.btnMuaNgay.Size = new System.Drawing.Size(180, 45);
            this.btnMuaNgay.TabIndex = 4;
            this.btnMuaNgay.Text = "ĐĂNG KÝ HỌC";

            // UcDetail
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnMuaNgay);
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
        private System.Windows.Forms.Label lblMoTa;
        private Guna.UI2.WinForms.Guna2Button btnMuaNgay;
    }
}