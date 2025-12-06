using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QLKhoaHocONL
{
    public partial class UcBlog : UserControl
    {
        private class Post
        {
            public string Author { get; set; }
            public string Title { get; set; }
            public string Excerpt { get; set; }
            public string Tag { get; set; }
            public string TimeAgo { get; set; }
            public string ReadTime { get; set; }
            public Color Accent { get; set; }
        }

        public UcBlog()
        {
            InitializeComponent();
            BuildTopics();
            BuildPosts();
            postsPanel.SizeChanged += (_, __) => BuildPosts();
        }

        private void BuildTopics()
        {
            flowTopics.Controls.Clear();
            flowTopics.Controls.AddRange(new Control[] { btnTopic1, btnTopic2, btnTopic3, btnTopic4 });
        }

        private void BuildPosts()
        {
            postsPanel.Controls.Clear();
            var list = new List<Post>
            {
                new Post
                {
                    Author = "Huyền Lê Ngọc",
                    Title = "Trải nghiệm học thử React Native, DevOps, C++ vô cùng chất lượng cùng F8",
                    Excerpt = "Giúp học viên cảm nhận chất lượng giảng dạy với 3 lớp thử: C++, React Native và DevOps với lộ trình rõ ràng.",
                    Tag = "React Native",
                    TimeAgo = "3 tháng trước",
                    ReadTime = "2 phút đọc",
                },
                new Post
                {
                    Author = "Hoàng Tuấn 12A1 40.Võ",
                    Title = "Giới thiệu về ngành Công Nghệ Thông Tin và những kiến thức cơ bản bắt buộc phải học",
                    Excerpt = "Ngành CNTT đóng vai trò quan trọng trong hầu hết mọi lĩnh vực; đây là những kỹ năng cốt lõi bạn nên nắm.",
                    Tag = "Học-lập-trình",
                    TimeAgo = "3 tháng trước",
                    ReadTime = "4 phút đọc",
                }
            };

            foreach (var p in list)
            {
                postsPanel.Controls.Add(CreatePostCard(p));
            }
        }

        private Control CreatePostCard(Post p)
        {
            int cardWidth = Math.Max(600, postsPanel.ClientSize.Width - 30);
            var card = new Panel
            {
                Width = cardWidth,
                Height = 190,
                Padding = new Padding(16),
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 12)
            };
            card.Paint += (s, e) =>
            {
                var rect = card.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;
                using (var pen = new Pen(Color.Gainsboro))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            };

            var lblAuthor = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Text = p.Author,
                ForeColor = Color.DimGray,
                Location = new Point(16, 16)
            };

            var lblTitle = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Text = p.Title,
                Location = new Point(16, 42),
                Size = new Size(card.Width - 220, 50)
            };

            var lblExcerpt = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Color.FromArgb(60, 60, 60),
                Text = p.Excerpt,
                Location = new Point(16, 92),
                Size = new Size(card.Width - 220, 45)
            };

            var lblMeta = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Gray,
                Text = $"{p.TimeAgo}  ·  {p.ReadTime}",
                Location = new Point(16, 150)
            };

            var tag = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(255, 115, 29),
                Location = new Point(16, 168),
                Text = p.Tag
            };

            var thumb = new Panel
            {
                BackColor = p.Accent,
                Size = new Size(170, 120),
                Location = new Point(card.Width - 200, 35),
                Margin = new Padding(0)
            };
            thumb.Paint += (s, e) =>
            {
                using (var brush = new SolidBrush(Color.FromArgb(200, Color.Black)))
                {
                    e.Graphics.FillRectangle(brush, thumb.ClientRectangle);
                }
                TextRenderer.DrawText(e.Graphics, p.Title.Split(' ')[0], new Font("Segoe UI", 10F, FontStyle.Bold),
                    new Rectangle(8, 8, thumb.Width - 16, thumb.Height - 16), Color.White);
            };

            card.Controls.Add(lblAuthor);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblExcerpt);
            card.Controls.Add(lblMeta);
            card.Controls.Add(tag);
            card.Controls.Add(thumb);
            return card;
        }
    }
}