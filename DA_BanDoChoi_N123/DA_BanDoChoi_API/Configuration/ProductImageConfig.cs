using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class ProductImageConfig : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).HasColumnType("nvarchar(100)");
            builder.Property(x => x.ImagePath).HasColumnType("nvarchar(150)");
            builder.HasOne(x => x.ProductDetail).WithMany(x => x.ProductImages).HasForeignKey(x => x.ProductDetailID);
        }
    }
}
