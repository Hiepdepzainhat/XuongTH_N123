using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_BanDoChoi_N123_Share.Models
{
    public class ProductImage
    {
        [Key]
        public Guid ID { get; set; }
        public Guid? ProductDetailID { get; set; }
        public string? Name { get; set; }
        public string? ImagePath { get; set; }
        public virtual ProductDetail? ProductDetail { get; set; }
    }
}
