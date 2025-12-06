using QLKhoaHocONL.Models;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
            lblGiaGoc.Text = FormatMoney(course.GiaGoc);
            lblGiaGiam.Text = FormatMoney(course.GiaGiam);


            string fallbackStart = "#7E57C2";
            string fallbackEnd = "#5C6BC0";

            try
            {
                string imagePath = System.IO.Path.Combine(Application.StartupPath, "Images", course.TenAnh);

                if (System.IO.File.Exists(imagePath))
                {
                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        picAnhBia.Image = Image.FromStream(fs);
                    }
                }
                else
                {
                    string tenResource = System.IO.Path.GetFileNameWithoutExtension(course.TenAnh);
                    object obj = Properties.Resources.ResourceManager.GetObject(tenResource);

                    if (obj != null)
                    {
                        picAnhBia.Image = (Image)obj;
                    }
                    else
                    {
                        picAnhBia.Image = null;
                        picAnhBia.FillColor = Color.WhiteSmoke;
                    }
                }
            }
            catch
            {
                picAnhBia.Image = null;
            }

            try
            {
                var c1 = string.IsNullOrWhiteSpace(course.MauBatDau) ? fallbackStart : course.MauBatDau;
                var c2 = string.IsNullOrWhiteSpace(course.MauKetThuc) ? fallbackEnd : course.MauKetThuc;
                guna2PanelNen.FillColor = ColorTranslator.FromHtml(c1);
                guna2PanelNen.FillColor2 = ColorTranslator.FromHtml(c2);
            }
            catch
            {
                guna2PanelNen.FillColor = ColorTranslator.FromHtml(fallbackStart);
                guna2PanelNen.FillColor2 = ColorTranslator.FromHtml(fallbackEnd);
            }
        }

        private string FormatMoney(string input)
        {
            if (string.IsNullOrEmpty(input)) return "0đ";

            // Lọc chỉ lấy các ký tự số
            string cleanNumber = new string(input.Where(char.IsDigit).ToArray());

            // Chuyển sang số và format lại theo chuẩn
            if (decimal.TryParse(cleanNumber, out decimal value))
            {
                // vi-VN sẽ dùng dấu chấm (.) phân cách hàng nghìn
                return string.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:N0}đ", value);
            }

            return input;
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
