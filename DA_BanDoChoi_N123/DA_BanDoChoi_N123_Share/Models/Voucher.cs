using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_BanDoChoi_N123_Share.Models
{
    public class Voucher
    {
        [Key]
        public Guid ID { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Code { get; set; }
        public int? Status { get; set; }
        public virtual List<VoucherDetail>? VoucherDetails { get; set; }
    }
}
