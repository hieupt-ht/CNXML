using System;

namespace QLKhoaHocONL.Models
{
    /// <summary>
    /// Buyer information for a course (used by admin view).
    /// </summary>
    internal class CourseBuyer
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime PurchasedAt { get; set; }
    }
}
