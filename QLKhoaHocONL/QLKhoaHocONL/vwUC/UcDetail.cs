using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLKhoaHocONL.vwUC
{
    public partial class UcDetail : UserControl
    {
        public UcDetail()
        {
            InitializeComponent();
        }

        // Hàm nhận dữ liệu chi tiết
        public void LoadChiTiet(string ten, string gia, string pathAnh)
        {
            lblTenKhoaHoc.Text = ten;
            lblGia.Text = gia;
            if (System.IO.File.Exists(pathAnh))
                picAnhLon.Image = Image.FromFile(pathAnh);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Khi bấm Quay lại -> Gọi frmMain load lại UcCourses
            frmMain main = (frmMain)this.ParentForm;
            main.ChuyenManHinh(new UcCourses());
        }
    }
}