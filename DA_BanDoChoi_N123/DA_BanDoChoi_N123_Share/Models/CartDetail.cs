using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_BanDoChoi_N123_Share.Models
{
    public class CartDetail
    {
        [Key]
        public Guid ID { get; set; }
        public Guid? CartID { get; set; }
        public Guid? ProductID { get; set; }
        public int? Quantity { get; set; }
        public int? Total { get; set; }
        public int? Status { get; set; }
        public virtual Cart? Cart { get; set; }
        public virtual ProductDetail? ProductDetail { get; set; }

    }
}
