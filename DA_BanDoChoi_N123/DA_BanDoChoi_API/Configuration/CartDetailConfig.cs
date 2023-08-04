using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class CartDetailConfig : IEntityTypeConfiguration<CartDetail>
    {
        public void Configure(EntityTypeBuilder<CartDetail> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Status).HasColumnType("int");
            builder.Property(x => x.Quantity).HasColumnType("int");
            builder.Property(x => x.Total).HasColumnType("int");

        }
    }
}
