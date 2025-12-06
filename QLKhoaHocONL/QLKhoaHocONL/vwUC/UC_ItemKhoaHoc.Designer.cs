// QUAN TRỌNG: Namespace phải giống hệt file .cs ở trên
namespace QLKhoaHocONL.vwUC
{
    partial class UC_ItemKhoaHoc
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
            this.guna2PanelNen = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblGiaGiam = new System.Windows.Forms.Label();
            this.lblGiaGoc = new System.Windows.Forms.Label();
            this.lblTenKhoaHoc = new System.Windows.Forms.Label();
            this.picAnhBia = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PanelNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhBia)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PanelNen
            // 
            this.guna2PanelNen.BorderRadius = 20;
            this.guna2PanelNen.Controls.Add(this.lblGiaGiam);
            this.guna2PanelNen.Controls.Add(this.lblGiaGoc);
            this.guna2PanelNen.Controls.Add(this.lblTenKhoaHoc);
            this.guna2PanelNen.Controls.Add(this.picAnhBia);
            this.guna2PanelNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelNen.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelNen.Name = "guna2PanelNen";
            this.guna2PanelNen.Size = new System.Drawing.Size(300, 380);
            this.guna2PanelNen.TabIndex = 0;
            // 
            // lblGiaGiam
            // 
            this.lblGiaGiam.AutoSize = true;
            this.lblGiaGiam.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaGiam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGiaGiam.ForeColor = System.Drawing.Color.White;
            this.lblGiaGiam.Location = new System.Drawing.Point(15, 312);
            this.lblGiaGiam.Name = "lblGiaGiam";
            this.lblGiaGiam.Size = new System.Drawing.Size(118, 28);
            this.lblGiaGiam.TabIndex = 3;
            this.lblGiaGiam.Text = "1.299.000d";
            // 
            // lblGiaGoc
            // 
            this.lblGiaGoc.AutoSize = true;
            this.lblGiaGoc.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaGoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Strikeout);
            this.lblGiaGoc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGiaGoc.Location = new System.Drawing.Point(16, 282);
            this.lblGiaGoc.Name = "lblGiaGoc";
            this.lblGiaGoc.Size = new System.Drawing.Size(91, 23);
            this.lblGiaGoc.TabIndex = 2;
            this.lblGiaGoc.Text = "2.500.000d";
            // 
            // lblTenKhoaHoc
            // 
            this.lblTenKhoaHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblTenKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTenKhoaHoc.ForeColor = System.Drawing.Color.Black;
            this.lblTenKhoaHoc.Location = new System.Drawing.Point(14, 226);
            this.lblTenKhoaHoc.Name = "lblTenKhoaHoc";
            this.lblTenKhoaHoc.Size = new System.Drawing.Size(270, 42);
            this.lblTenKhoaHoc.TabIndex = 1;
            this.lblTenKhoaHoc.Text = "Tên Khóa Học";
            // 
            // picAnhBia
            // 
            this.picAnhBia.BackColor = System.Drawing.Color.Transparent;
            this.picAnhBia.ErrorImage = null;
            this.picAnhBia.ImageRotate = 0F;
            this.picAnhBia.Location = new System.Drawing.Point(20, 20);
            this.picAnhBia.Name = "picAnhBia";
            this.picAnhBia.Size = new System.Drawing.Size(260, 180);
            this.picAnhBia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhBia.TabIndex = 0;
            this.picAnhBia.TabStop = false;
            // 
            // UC_ItemKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2PanelNen);
            this.Name = "UC_ItemKhoaHoc";
            this.Size = new System.Drawing.Size(300, 380);
            this.guna2PanelNen.ResumeLayout(false);
            this.guna2PanelNen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhBia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2GradientPanel guna2PanelNen;
        public System.Windows.Forms.Label lblGiaGiam;
        public System.Windows.Forms.Label lblGiaGoc;
        public System.Windows.Forms.Label lblTenKhoaHoc;
        public Guna.UI2.WinForms.Guna2PictureBox picAnhBia;
    }
}
