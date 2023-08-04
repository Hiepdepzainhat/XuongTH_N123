using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_BanDoChoi_N123_Share.Models
{
    public class Cart
    {
        [Key]
        public Guid UserID { get; set; }
        public string? Description { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<CartDetail>? CartDetails { get; set; }

    }
}
