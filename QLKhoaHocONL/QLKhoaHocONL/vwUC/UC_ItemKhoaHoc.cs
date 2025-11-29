using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLKhoaHocONL.vwUC
{
    public partial class UC_ItemKhoaHoc : UserControl
    {
        public UC_ItemKhoaHoc()
        {
            InitializeComponent();

            // Gán sự kiện Click cho tất cả thành phần con
            // Để bấm vào hình, chữ hay nền đều ăn sự kiện Click
            this.Click += UC_ItemKhoaHoc_Click;
            guna2PanelNen.Click += UC_ItemKhoaHoc_Click;
            picAnhBia.Click += UC_ItemKhoaHoc_Click;
            lblTenKhoaHoc.Click += UC_ItemKhoaHoc_Click;
            lblGiaGiam.Click += UC_ItemKhoaHoc_Click;
        }

        // Biến lưu dữ liệu riêng của thẻ này
        public string TenKhoa { get; set; }
        public string GiaMoi { get; set; }
        public string DuongDanAnh { get; set; }

        public void NapDuLieu(string ten, string giaCu, string giaMoi, string tenAnhTrongXML, string mauDau, string mauCuoi)
        {
            // 1. Lưu dữ liệu (để dùng khi click)
            this.TenKhoa = ten;
            this.GiaMoi = giaMoi;

            // 2. Hiển thị chữ
            lblTenKhoaHoc.Text = ten;
            lblGiaGoc.Text = giaCu;
            lblGiaGiam.Text = giaMoi;

            // 3. XỬ LÝ ẢNH TỪ RESOURCE (Phần quan trọng)
            try
            {
                // Trong XML tên là "html_css_pro.png", nhưng trong Resource tên chỉ là "html_css_pro"
                // Nên ta phải xóa đuôi ".png" đi
                string tenResource = System.IO.Path.GetFileNameWithoutExtension(tenAnhTrongXML);

                // Lấy ảnh từ Resource theo tên
                object obj = Properties.Resources.ResourceManager.GetObject(tenResource);

                if (obj != null) // Nếu tìm thấy ảnh
                {
                    picAnhBia.Image = (Image)obj;
                    this.DuongDanAnh = tenResource; // Lưu lại tên resource để truyền đi nếu cần
                }
            }
            catch { } // Nếu lỗi thì thôi, để ảnh trống

            // 4. Xử lý màu nền
            try
            {
                guna2PanelNen.FillColor = ColorTranslator.FromHtml(mauDau);
                guna2PanelNen.FillColor2 = ColorTranslator.FromHtml(mauCuoi);
            }
            catch { }
        }

        // Sự kiện khi Click vào thẻ bài
        private void UC_ItemKhoaHoc_Click(object sender, EventArgs e)
        {
            // 1. Tìm về Form Cha (frmMain)
            frmMain mainForm = (frmMain)this.ParentForm;

            // 2. Tạo màn hình chi tiết
            UcDetail manHinhChiTiet = new UcDetail();

            // 3. Đổ dữ liệu của thẻ này sang màn hình chi tiết
            manHinhChiTiet.LoadChiTiet(this.TenKhoa, this.GiaMoi, this.DuongDanAnh);

            // 4. Bảo Form Cha hiển thị màn hình chi tiết lên
            mainForm.ChuyenManHinh(manHinhChiTiet);
        }
    }
}