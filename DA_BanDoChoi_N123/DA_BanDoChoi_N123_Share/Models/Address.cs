using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_BanDoChoi_N123_Share.Models
{
    public class Address
    {
        [Key]
        public Guid ID { get; set; }
        public Guid? CustomerID { get; set; }
        public string? NameCustomer { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
        public string? AddressDetail { get; set; }
        public int? Status { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
