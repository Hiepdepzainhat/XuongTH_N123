using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class VoucherConfig : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.CreateDate).HasColumnType("Date");
            builder.Property(x => x.EndDate).HasColumnType("Date");
            builder.Property(x => x.Code).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Status).HasColumnType("int");
        }
    }
}
