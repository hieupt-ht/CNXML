using System;
using System.Drawing;
using System.Windows.Forms;

// QUAN TRỌNG: Phải có dòng này để nhận diện được UcCourses
using QLKhoaHocONL.vwUC;

namespace QLKhoaHocONL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            // Khi mở app lên thì hiện luôn UcCourses
            ChuyenManHinh(new UcCourses());
        }

        // HÀM DÙNG CHUNG (Public để các form con gọi được)
        public void ChuyenManHinh(UserControl uc)
        {
            // 1. Xóa hết các cái cũ đang hiện trong pnlContent
            pnlContent.Controls.Clear();

            // 2. Chỉnh cho cái mới tràn đầy màn hình
            uc.Dock = DockStyle.Fill;

            // 3. Thêm cái mới vào
            pnlContent.Controls.Add(uc);
        }

        // Sự kiện khi bấm nút "Lộ trình" (Courses)
        private void btnCourses_Click(object sender, EventArgs e)
        {
            // Bước 1: Đổi màu nút cho đẹp (Highlight)
            ResetMauNut();
            btnCourses.BackColor = Color.White;

            // Bước 2: Gọi màn hình UcCourses ra
            // Code trong UcCourses.cs (OnLoad) sẽ tự động chạy để đọc XML
            ChuyenManHinh(new UcCourses());
        }

        // Sự kiện khi bấm nút Trang chủ
        private void btnHome_Click(object sender, EventArgs e)
        {
            ResetMauNut();
            btnHome.BackColor = Color.White;

            // Nếu bạn chưa tạo UcHome thì tạm thời load UcCourses hoặc hiện thông báo
            // ChuyenManHinh(new UcHome()); 
            MessageBox.Show("Chức năng trang chủ đang phát triển");
        }

        // Sự kiện khi bấm nút Bài viết
        private void btnRoadmap_Click(object sender, EventArgs e)
        {
            ResetMauNut();
            btnRoadmap.BackColor = Color.White;
            MessageBox.Show("Chức năng bài viết đang phát triển");
        }

        // Hàm reset màu các nút về trong suốt
        private void ResetMauNut()
        {
            btnHome.BackColor = Color.Transparent;
            btnCourses.BackColor = Color.Transparent;
            btnRoadmap.BackColor = Color.Transparent;
        }

        private void txbF8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}