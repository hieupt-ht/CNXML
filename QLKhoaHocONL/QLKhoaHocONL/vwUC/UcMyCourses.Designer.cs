namespace QLKhoaHocONL.vwUC
{
    partial class UcMyCourses
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
            this.flowOwned = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(22, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Khoá học của tôi";
            // 
            // flowOwned
            // 
            this.flowOwned.AutoScroll = true;
            this.flowOwned.Location = new System.Drawing.Point(29, 78);
            this.flowOwned.Name = "flowOwned";
            this.flowOwned.Size = new System.Drawing.Size(1300, 690);
            this.flowOwned.TabIndex = 1;
            // 
            // UcMyCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowOwned);
            this.Controls.Add(this.lblTitle);
            this.Name = "UcMyCourses";
            this.Size = new System.Drawing.Size(1350, 790);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowOwned;
    }
}
