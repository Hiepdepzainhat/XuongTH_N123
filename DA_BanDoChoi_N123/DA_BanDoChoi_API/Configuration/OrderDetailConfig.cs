using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class OrderDetailConfig : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {

            builder.HasKey(x => new { x.OrderID, x.ProductID });
            builder.Property(x => x.Price).HasColumnType("int");
            builder.Property(x => x.Quantity).HasColumnType("int");
            builder.HasOne(x => x.Order).WithMany(x => x.OrderDetail).HasForeignKey(x => x.OrderID);
            builder.HasOne(x => x.ProductDetail).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductID);

        }
    }
}
