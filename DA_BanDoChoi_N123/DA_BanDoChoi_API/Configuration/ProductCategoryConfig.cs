using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Description).HasColumnType("nvarchar(1000)");
            builder.Property(x => x.Status).HasColumnType("int");
            builder.HasOne(x => x.ProductCategoryParent).WithMany(x => x.ProductCategories).HasForeignKey(x => x.ParentID);
        } 
    }
}
