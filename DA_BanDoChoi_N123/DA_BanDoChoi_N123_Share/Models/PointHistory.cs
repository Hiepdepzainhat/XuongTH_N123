using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_BanDoChoi_N123_Share.Models
{
    public class PointHistory
    {
        [Key]
        public Guid ID { get; set; }
        public Guid? OrderID { get; set; }
        public Guid? CustomerID { get; set; }
        public int? PointUsed { get; set; }
        public string? Desciption { get; set; }
        public int? Status { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Order? Order { get; set; }

    }
}
