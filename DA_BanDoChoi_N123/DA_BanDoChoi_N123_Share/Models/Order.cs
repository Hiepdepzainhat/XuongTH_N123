using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_BanDoChoi_N123_Share.Models
{
    public class Order
    {
        [Key]
        public Guid ID { get; set; }
        public Guid? CustomerID { get; set; }
        public Guid? EmployeeID { get; set; }
        public Guid? TransportID { get; set; }
        public Guid? PaymentID { get; set; }
        public Guid? VoucherID { get; set; }
        public DateTime? DateOrder { get; set; }
        public DateTime? DateShip { get; set; }
        public string? Address { get; set; }
        public string? DeliveryPhoneNumber { get; set; }
        public DateTime? DateOfPayment { get; set; }
        public int? Status { get; set; }
        public virtual Transport? Transport { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual VoucherDetail? VoucherDetail { get; set; }
        public virtual List<PointHistory>? PointHistory { get; set; }
        public virtual Payments? Payment { get; set; }
        public virtual List<OrderDetail>? OrderDetail { get; set; }
    }
}
