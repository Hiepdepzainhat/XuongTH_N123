using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class CartConfig : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(x => x.UserID);
            builder.Property(x => x.Description).HasColumnType("nvarchar(1000)");
            builder.HasOne(c => c.Customer).WithOne(c => c.Cart).HasForeignKey<Cart>(c => c.UserID);
        }
    }
}
