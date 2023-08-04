using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_BanDoChoi_N123_Share.Models
{
    public class OrderDetail
    {
        public Guid OrderID { get; set; }       
        public Guid ProductID { get; set; }
        public int? Price { get; set; }
        public int? Quantity { get; set; }
        public virtual List<Rating>? Ratings { get; set; }
        public virtual ProductDetail? ProductDetail { get; set; }
        public virtual Order? Order { get; set; }

    }
}
