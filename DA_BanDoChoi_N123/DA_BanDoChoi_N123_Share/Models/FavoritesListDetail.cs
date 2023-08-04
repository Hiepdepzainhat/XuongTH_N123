using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_BanDoChoi_N123_Share.Models
{
    public class FavoritesListDetail
    {
        [Key]
        public Guid ID { get; set; }
        public Guid? CustomerID { get; set; }
        public Guid? ProductID { get; set; }
        public string? Name { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual ProductDetail? ProductDetail { get; set; }
    }
}
