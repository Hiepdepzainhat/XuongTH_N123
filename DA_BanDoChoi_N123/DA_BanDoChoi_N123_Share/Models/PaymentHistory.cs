using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_BanDoChoi_N123_Share.Models
{
    public class PaymentHistory
    {
        [Key]
        public Guid ID { get; set; }
        public Guid? PaymentID { get; set; }
        public Guid? OrderID { get; set; }
        public int? PaymentAmount { get; set; }
        public string? Note { get; set; }
        public int? Status { get; set; }
        
    }
}
