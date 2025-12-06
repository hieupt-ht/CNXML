using System;

namespace QLKhoaHocONL.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int? AccountId { get; set; }
    }
}
