using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_BanDoChoi_N123_Share.Models
{
    public class Customer
    {
        [Key]
        public Guid ID { get; set; }
        public Guid? MemberID { get; set; }
        public string? FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Gender { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public int? Point { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Image { get; set; }
        public int? Status { get; set; }
        public virtual List<Address>? Addresses { get; set; }
        public virtual MemberType? MemberType { get; set; }
        public virtual List<PointHistory>? PointHistory { get; set; }
        public virtual List<FavoritesListDetail>? FavoritesListDetail { get; set;}
        public virtual List<Rating>? Rating { get; set; }
        public virtual List<Order>? Order { get; set; }
        public virtual Cart Cart { get; set; }


    }
}
