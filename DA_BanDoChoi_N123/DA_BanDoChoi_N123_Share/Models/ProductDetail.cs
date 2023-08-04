using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_BanDoChoi_N123_Share.Models
{
    public class ProductDetail
    {
        [Key]
        public Guid ID { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? ColorID { get; set; }
        public Guid? AgeID { get; set; }
        public Guid? MaterialID { get; set; }
        public Guid? CategoryID { get; set; }
        public Guid? SoundID { get; set; }
        public Guid? ProducerID { get; set; }
        public string? CodeProduct { get; set; }
        public int? ImportPrice { get; set; }
        public int? Price { get; set; }
        public int? StockQuantity { get; set; }
        public int? Status { get; set;}
        public virtual Product? Product { get; set; }
        public virtual Color? Color { get; set; }
        public virtual Age? Age { get; set; }
        public virtual Material? Material { get; set; }
        public virtual ProductCategory? ProductCategory { get; set; }
        public virtual Sound? Sound { get; set; }
        public virtual Producer? Producer { get; set; }
        public virtual List<OrderDetail>? OrderDetails { get; set; }
        public virtual List<VoucherDetail>? VoucherDetails { get; set; }
        public virtual List<CartDetail>? CartDetails { get; set; }
        public virtual List<FavoritesListDetail>? FavoritesListDetails { get; set; }
        public virtual List<ProductImage>? ProductImages { get; set; }

    }
}
