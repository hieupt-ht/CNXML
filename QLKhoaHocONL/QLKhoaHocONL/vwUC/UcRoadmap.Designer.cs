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
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Lộ trình học";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDesc.Location = new System.Drawing.Point(32, 75);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(704, 25);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Để bắt đầu thuận lợi, hãy chọn lộ trình phù hợp. Ví dụ: muốn đi làm Front-end hãy" +
    " tập trung Front-end.";
            // 
            // flowCards
            // 
            this.flowCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowCards.Location = new System.Drawing.Point(36, 120);
            this.flowCards.Name = "flowCards";
            this.flowCards.Size = new System.Drawing.Size(1050, 480);
            this.flowCards.TabIndex = 2;
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
            this.Size = new System.Drawing.Size(1120, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.FlowLayoutPanel flowCards;
    }
}
