namespace QLKhoaHocONL
{
    partial class UcBlog
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.postsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.flowTopics = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTopic1 = new System.Windows.Forms.Button();
            this.btnTopic2 = new System.Windows.Forms.Button();
            this.btnTopic3 = new System.Windows.Forms.Button();
            this.btnTopic4 = new System.Windows.Forms.Button();
            this.promoPanel = new System.Windows.Forms.Panel();
            this.lblPromoTitle = new System.Windows.Forms.Label();
            this.lblPromoList = new System.Windows.Forms.Label();
            this.btnPromo = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.promoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.mainLayout.Controls.Add(this.lblSubtitle, 0, 1);
            this.mainLayout.Controls.Add(this.lblTitle, 0, 0);
            this.mainLayout.Controls.Add(this.postsPanel, 0, 2);
            this.mainLayout.Controls.Add(this.sidebar, 1, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(1120, 630);
            this.mainLayout.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(15, 60);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(741, 40);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Tổng hợp các bài viết chia sẻ kinh nghiệm tự học lập trình online và các kỹ năng" +
    " nghề nghiệp.";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(15, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(741, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Bài viết nổi bật";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // postsPanel
            // 
            this.postsPanel.AutoScroll = true;
            this.postsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postsPanel.Location = new System.Drawing.Point(10, 103);
            this.postsPanel.Margin = new System.Windows.Forms.Padding(10, 3, 5, 3);
            this.postsPanel.Name = "postsPanel";
            this.postsPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.postsPanel.Size = new System.Drawing.Size(746, 524);
            this.postsPanel.TabIndex = 3;
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.lblSidebarTitle);
            this.sidebar.Controls.Add(this.flowTopics);
            this.sidebar.Controls.Add(this.promoPanel);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar.Location = new System.Drawing.Point(761, 103);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(10);
            this.sidebar.Size = new System.Drawing.Size(349, 524);
            this.sidebar.TabIndex = 4;
            // 
            // lblSidebarTitle
            // 
            this.lblSidebarTitle.AutoSize = true;
            this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTitle.Location = new System.Drawing.Point(13, 10);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.Size = new System.Drawing.Size(193, 23);
            this.lblSidebarTitle.TabIndex = 0;
            this.lblSidebarTitle.Text = "Xem bài viết theo chủ đề";
            // 
            // flowTopics
            // 
            this.flowTopics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowTopics.AutoSize = true;
            this.flowTopics.Location = new System.Drawing.Point(10, 40);
            this.flowTopics.Name = "flowTopics";
            this.flowTopics.Size = new System.Drawing.Size(327, 0);
            this.flowTopics.TabIndex = 1;
            // 
            // btnTopic1
            // 
            this.btnTopic1.AutoSize = true;
            this.btnTopic1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTopic1.FlatAppearance.BorderSize = 0;
            this.btnTopic1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopic1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTopic1.Location = new System.Drawing.Point(0, 0);
            this.btnTopic1.Margin = new System.Windows.Forms.Padding(5);
            this.btnTopic1.Name = "btnTopic1";
            this.btnTopic1.Size = new System.Drawing.Size(156, 32);
            this.btnTopic1.TabIndex = 0;
            this.btnTopic1.Text = "Front-end / Mobile";
            this.btnTopic1.UseVisualStyleBackColor = false;
            // 
            // btnTopic2
            // 
            this.btnTopic2.AutoSize = true;
            this.btnTopic2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTopic2.FlatAppearance.BorderSize = 0;
            this.btnTopic2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopic2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTopic2.Location = new System.Drawing.Point(0, 0);
            this.btnTopic2.Margin = new System.Windows.Forms.Padding(5);
            this.btnTopic2.Name = "btnTopic2";
            this.btnTopic2.Size = new System.Drawing.Size(135, 32);
            this.btnTopic2.TabIndex = 1;
            this.btnTopic2.Text = "Back-end / Devops";
            this.btnTopic2.UseVisualStyleBackColor = false;
            // 
            // btnTopic3
            // 
            this.btnTopic3.AutoSize = true;
            this.btnTopic3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTopic3.FlatAppearance.BorderSize = 0;
            this.btnTopic3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopic3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTopic3.Location = new System.Drawing.Point(0, 0);
            this.btnTopic3.Margin = new System.Windows.Forms.Padding(5);
            this.btnTopic3.Name = "btnTopic3";
            this.btnTopic3.Size = new System.Drawing.Size(121, 32);
            this.btnTopic3.TabIndex = 2;
            this.btnTopic3.Text = "UI / UX / Design";
            this.btnTopic3.UseVisualStyleBackColor = false;
            // 
            // btnTopic4
            // 
            this.btnTopic4.AutoSize = true;
            this.btnTopic4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTopic4.FlatAppearance.BorderSize = 0;
            this.btnTopic4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopic4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTopic4.Location = new System.Drawing.Point(0, 0);
            this.btnTopic4.Margin = new System.Windows.Forms.Padding(5);
            this.btnTopic4.Name = "btnTopic4";
            this.btnTopic4.Size = new System.Drawing.Size(65, 32);
            this.btnTopic4.TabIndex = 3;
            this.btnTopic4.Text = "Others";
            this.btnTopic4.UseVisualStyleBackColor = false;
            // 
            // promoPanel
            // 
            this.promoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(234)))));
            this.promoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.promoPanel.Controls.Add(this.lblPromoTitle);
            this.promoPanel.Controls.Add(this.lblPromoList);
            this.promoPanel.Controls.Add(this.btnPromo);
            this.promoPanel.Location = new System.Drawing.Point(10, 320);
            this.promoPanel.Name = "promoPanel";
            this.promoPanel.Padding = new System.Windows.Forms.Padding(12);
            this.promoPanel.Size = new System.Drawing.Size(327, 194);
            this.promoPanel.TabIndex = 2;
            // 
            // lblPromoTitle
            // 
            this.lblPromoTitle.AutoSize = true;
            this.lblPromoTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPromoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(29)))));
            this.lblPromoTitle.Location = new System.Drawing.Point(12, 12);
            this.lblPromoTitle.Name = "lblPromoTitle";
            this.lblPromoTitle.Size = new System.Drawing.Size(172, 28);
            this.lblPromoTitle.TabIndex = 0;
            this.lblPromoTitle.Text = "HTML CSS Pro ✨";
            // 
            // lblPromoList
            // 
            this.lblPromoList.AutoSize = true;
            this.lblPromoList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPromoList.Location = new System.Drawing.Point(14, 50);
            this.lblPromoList.Name = "lblPromoList";
            this.lblPromoList.Size = new System.Drawing.Size(256, 75);
            this.lblPromoList.TabIndex = 1;
            this.lblPromoList.Text = "✔ Thực hành 8 dự án\r\n✔ Hơn 300 bài tập thử thách\r\n✔ Flashcards và checklist UI\r\n✔" +
    " Games luyện HTML/CSS\r\n✔ Thiết kế sẵn trên Figma";
            // 
            // btnPromo
            // 
            this.btnPromo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(29)))));
            this.btnPromo.FlatAppearance.BorderSize = 0;
            this.btnPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPromo.ForeColor = System.Drawing.Color.White;
            this.btnPromo.Location = new System.Drawing.Point(17, 142);
            this.btnPromo.Name = "btnPromo";
            this.btnPromo.Size = new System.Drawing.Size(140, 32);
            this.btnPromo.TabIndex = 2;
            this.btnPromo.Text = "Tìm hiểu thêm";
            this.btnPromo.UseVisualStyleBackColor = false;
            // 
            // UcBlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainLayout);
            this.Name = "UcBlog";
            this.Size = new System.Drawing.Size(1120, 630);
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.promoPanel.ResumeLayout(false);
            this.promoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel postsPanel;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.FlowLayoutPanel flowTopics;
        private System.Windows.Forms.Button btnTopic1;
        private System.Windows.Forms.Button btnTopic2;
        private System.Windows.Forms.Button btnTopic3;
        private System.Windows.Forms.Button btnTopic4;
        private System.Windows.Forms.Panel promoPanel;
        private System.Windows.Forms.Label lblPromoTitle;
        private System.Windows.Forms.Label lblPromoList;
        private System.Windows.Forms.Button btnPromo;
    }
}
