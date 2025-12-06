using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhoaHocONL.Models
{
    internal class AccountCourse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CourseId { get; set; }
        public DateTime PurchasedAt { get; set; }
    }
}
