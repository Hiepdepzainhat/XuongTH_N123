using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class VouCherDetailConfig : IEntityTypeConfiguration<VoucherDetail>
    {
        public void Configure(EntityTypeBuilder<VoucherDetail> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Quantity).HasColumnType("int");
            builder.Property(x => x.Price).HasColumnType("int");
            builder.Property(x => x.Percent).HasColumnType("int");
            builder.HasOne(x => x.Voucher).WithMany(x => x.VoucherDetails).HasForeignKey(x => x.CouponID);
        }
    }
}
