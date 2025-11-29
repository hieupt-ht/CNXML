using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QLKhoaHocONL
{
    public partial class UcRoadmap : UserControl
    {
        public UcRoadmap()
        {
            InitializeComponent();
            BuildCards();
        }

        private void BuildCards()
        {
            AddCard("Lộ trình học Front-end",
                "Lập trình viên Front-end là người xây dựng ra giao diện websites. Phần này giúp bạn trở thành lập trình viên Front-end.",
                "https://fullstack.edu.vn/learning-paths/front-end-development",
                Properties.Resources.html_css_pro);

            AddCard("Lộ trình học Back-end",
                "Back-end là người làm việc với dữ liệu, logic và hệ thống. Cùng tìm hiểu lộ trình trở thành lập trình viên Back-end.",
                "https://fullstack.edu.vn/learning-paths/back-end-development",
                Properties.Resources.nodejs);
        }

        private void AddCard(string title, string desc, string link, Image icon)
        {
            var card = new Guna.UI2.WinForms.Guna2Panel
            {
                Width = 520,
                Height = 180,
                BorderRadius = 16,
                FillColor = Color.White,
                Margin = new Padding(16),
                BorderThickness = 1,
                BorderColor = Color.Gainsboro,
                ShadowDecoration = { Enabled = true, Depth = 4, Shadow = new Padding(0, 0, 5, 5) }
            };

            var lblT = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Location = new Point(20, 20),
                AutoSize = true
            };
            var lblD = new Label
            {
                Text = desc,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                Location = new Point(20, 60),
                Size = new Size(320, 80)
            };
            var btn = new Guna.UI2.WinForms.Guna2Button
            {
                Text = "XEM CHI TIẾT",
                BorderRadius = 10,
                FillColor = Color.FromArgb(0, 132, 255),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                Size = new Size(140, 38),
                Location = new Point(20, 130),
                Tag = link
            };
            btn.Click += (s, e) => OpenLink(link);

            var pic = new PictureBox
            {
                Image = icon,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(140, 140),
                Location = new Point(360, 20)
            };

            card.Controls.Add(lblT);
            card.Controls.Add(lblD);
            card.Controls.Add(btn);
            card.Controls.Add(pic);
            flowCards.Controls.Add(card);
        }

        private void OpenLink(string link)
        {
            try
            {
                Process.Start(new ProcessStartInfo { FileName = link, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không mở được link: " + ex.Message);
            }
        }
    }
}
