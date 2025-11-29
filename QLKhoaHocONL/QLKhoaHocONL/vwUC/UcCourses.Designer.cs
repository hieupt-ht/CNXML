// QUAN TRỌNG: Namespace phải giống file .cs
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
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(149, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Lộ Trình";
            // 
            // flowLayoutPanelKhoaHoc
            // 
            this.flowLayoutPanelKhoaHoc.AutoScroll = true;
            this.flowLayoutPanelKhoaHoc.Location = new System.Drawing.Point(23, 74);
            this.flowLayoutPanelKhoaHoc.Name = "flowLayoutPanelKhoaHoc";
            this.flowLayoutPanelKhoaHoc.Size = new System.Drawing.Size(1308, 716);
            this.flowLayoutPanelKhoaHoc.TabIndex = 1;
            // 
            // UcCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanelKhoaHoc);
            this.Controls.Add(this.lblTitle);
            this.Name = "UcCourses";
            this.Size = new System.Drawing.Size(1341, 799);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKhoaHoc;
    }
}