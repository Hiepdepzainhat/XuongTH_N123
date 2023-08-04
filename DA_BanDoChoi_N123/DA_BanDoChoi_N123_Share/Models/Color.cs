using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_BanDoChoi_N123_Share.Models
{
    public class Color
    {
        [Key]
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int? Status { get; set; }
        public string? Description { get; set; }
        public virtual IEnumerable<ProductDetail>? ProductDetail { get; set; }
    }
}
