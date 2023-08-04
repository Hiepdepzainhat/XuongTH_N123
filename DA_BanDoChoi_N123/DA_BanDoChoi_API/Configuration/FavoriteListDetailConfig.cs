using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class FavoriteListDetailConfig : IEntityTypeConfiguration<FavoritesListDetail>
    {
        public void Configure(EntityTypeBuilder<FavoritesListDetail> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).HasColumnType("nvarchar(100)");
            builder.HasOne(x => x.Customer).WithMany(x => x.FavoritesListDetail).HasForeignKey(x => x.CustomerID);
            builder.HasOne(x => x.ProductDetail).WithMany(x => x.FavoritesListDetails).HasForeignKey(x => x.ProductID);

        }
    }
}
