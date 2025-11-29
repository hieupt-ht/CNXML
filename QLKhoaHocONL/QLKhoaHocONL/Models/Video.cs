namespace QLKhoaHocONL.Models
{
    /// <summary>
    /// Video của khóa học.
    /// </summary>
    internal class Video
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int Order { get; set; }
    }
}
