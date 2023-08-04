using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class PointHistoryConfig : IEntityTypeConfiguration<PointHistory>
    {
        public void Configure(EntityTypeBuilder<PointHistory> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.PointUsed).HasColumnType("int");
            builder.Property(X => X.Desciption).HasColumnType("nvarchar(1000)");
            builder.Property(x => x.Status).HasColumnType("int");
            builder.HasOne(x => x.Order).WithMany(x => x.PointHistory).HasForeignKey(x => x.OrderID);
            builder.HasOne(x => x.Customer).WithMany(x => x.PointHistory).HasForeignKey(x => x.CustomerID);

        }
    }
}
