using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class RatingConfig : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Star).HasColumnType("int");
            builder.Property(x => x.Content).HasColumnType("nvarchar(1000)");
            builder.HasOne(x => x.OrderDetail).WithMany(x => x.Ratings).HasForeignKey(x => x.ID);
            builder.HasOne(x => x.Customer).WithMany(x => x.Rating).HasForeignKey(x => x.CustomerID);
        }
    }
}
