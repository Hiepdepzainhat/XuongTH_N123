using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class PaymentConfig : IEntityTypeConfiguration<Payments>
    {
        public void Configure(EntityTypeBuilder<Payments> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Status).HasColumnType("int");


        }
    }
}
