using System;
using System.Drawing;
using System.Windows.Forms;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL.vwUC
{
    public partial class UC_ItemKhoaHoc : UserControl
    {
        public UC_ItemKhoaHoc()
        {
            InitializeComponent();

            // Gán sự kiện Click cho tất cả thẻ con để mở chi tiết.
            this.Click += UC_ItemKhoaHoc_Click;
            guna2PanelNen.Click += UC_ItemKhoaHoc_Click;
            picAnhBia.Click += UC_ItemKhoaHoc_Click;
            lblTenKhoaHoc.Click += UC_ItemKhoaHoc_Click;
            lblGiaGiam.Click += UC_ItemKhoaHoc_Click;
        }

        // Lưu dữ liệu khoá học cho click.
        public Course Data { get; private set; }

        public void NapDuLieu(Course course)
        {
            Data = course;
            lblTenKhoaHoc.Text = course.TenKhoaHoc;
            lblGiaGoc.Text = course.GiaGoc;
            lblGiaGiam.Text = course.GiaGiam;

            try
            {
                string tenResource = System.IO.Path.GetFileNameWithoutExtension(course.TenAnh);
                object obj = Properties.Resources.ResourceManager.GetObject(tenResource);

                if (obj != null)
                {
                    picAnhBia.Image = (Image)obj;
                }
            }
            catch
            {
                // ignore lỗi load ảnh để không chặn UI.
            }

            try
            {
                guna2PanelNen.FillColor = ColorTranslator.FromHtml(course.MauBatDau);
                guna2PanelNen.FillColor2 = ColorTranslator.FromHtml(course.MauKetThuc);
            }
            catch { }
        }

        private void UC_ItemKhoaHoc_Click(object sender, EventArgs e)
        {
            if (Data == null) return;
            frmMain mainForm = (frmMain)this.ParentForm;
            UcDetail detail = new UcDetail();
            detail.LoadChiTiet(Data);
            mainForm.ChuyenManHinh(detail);
        }
    }
}
