namespace QLKhoaHocONL.Models
{
    /// <summary>
    /// Khóa học hiển thị ở trang chủ, chi tiết và quản trị.
    /// </summary>
    public class Course
    {
        public int Id { get; set; }
        public string TenKhoaHoc { get; set; }
        public string GiaGoc { get; set; }
        public string GiaGiam { get; set; }
        public int SoHocVien { get; set; }
        public string ThoiLuong { get; set; }
        public string TenAnh { get; set; }
        public string MauBatDau { get; set; }
        public string MauKetThuc { get; set; }
        public string DemoLink { get; set; }
    }
}
