using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class AgeConfig : IEntityTypeConfiguration<Age>
    {
        public void Configure(EntityTypeBuilder<Age> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Status).HasColumnType("int");

        }
    }
}
