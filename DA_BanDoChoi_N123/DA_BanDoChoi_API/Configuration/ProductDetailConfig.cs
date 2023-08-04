using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class ProductDetailConfig : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.CodeProduct).HasColumnType("nvarchar(100)");
            builder.Property(x => x.ImportPrice).HasColumnType("int");
            builder.Property(x => x.Price).HasColumnType("int");
            builder.Property(x => x.StockQuantity).HasColumnType("int");
            builder.Property(x => x.Status).HasColumnType("int");
            builder.HasOne(x => x.Product).WithMany(x => x.ProductDetails).HasForeignKey(x => x.ProductID);
            builder.HasOne(x => x.Color).WithMany(x => x.ProductDetail).HasForeignKey(x => x.ColorID);
            builder.HasOne(x => x.Age).WithMany(x => x.ProductDetail).HasForeignKey(x => x.AgeID);
            builder.HasOne(x => x.Material).WithMany(x => x.ProductDetails).HasForeignKey(x => x.MaterialID);
            builder.HasOne(x => x.ProductCategory).WithMany(x => x.ProductDetails).HasForeignKey(x => x.CategoryID);
            builder.HasOne(x => x.Sound).WithMany(x => x.ProductDetails).HasForeignKey(x => x.SoundID);
            builder.HasOne(x => x.Producer).WithMany(x => x.ProductDetails).HasForeignKey(x => x.ProducerID);
        }
    }
}
