using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_BanDoChoi_N123_Share.Models
{
    public class Employee
    {
        [Key]
        public Guid ID { get; set; }
        public Guid? ROleID { get; set; }
        public string? FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Gender { get; set; }
        public string? Email { get; set; }
        public string? PassWord { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Image { get; set; }
        public int? Status { get; set; }
        public virtual Role? Role { get; set; }
        public virtual List<Order>? Order { get; set; }
    }
}
