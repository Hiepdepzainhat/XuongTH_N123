using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.DateOrder).HasColumnType("Date");
            builder.Property(x => x.DateShip).HasColumnType("Date");
            builder.Property(x => x.Address).HasColumnType("nvarchar(1000)");
            builder.Property(x => x.DeliveryPhoneNumber).HasColumnType("nvarchar(10)");
            builder.Property(x => x.DateOfPayment).HasColumnType("Date");
            builder.Property(x => x.Status).HasColumnType("int");
            builder.HasOne(x => x.Customer).WithMany(x => x.Order).HasForeignKey(x => x.CustomerID);
            builder.HasOne(x => x.Employee).WithMany(x => x.Order).HasForeignKey(x => x.EmployeeID);
            builder.HasOne(x => x.Transport).WithMany(x => x.Orders).HasForeignKey(x => x.TransportID);
            builder.HasOne(x => x.VoucherDetail).WithMany(x => x.Order).HasForeignKey(x => x.VoucherID);
            builder.HasOne(x => x.Payment).WithMany(x => x.Orders).HasForeignKey(x => x.PaymentID);
        }
    }
}
