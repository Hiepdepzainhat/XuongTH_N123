using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_BanDoChoi_N123_Share.Models
{
    public class Rating
    {
        [Key]
        public Guid ID { get; set; }
        public Guid? CustomerID { get; set; }
        public Guid? ProductID { get; set; }
        public int? Star { get; set; }
        public string? Content { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual OrderDetail? OrderDetail { get; set; }

    }
}
