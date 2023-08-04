using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.NameCustomer).HasColumnType("nvarchar(100)");
            builder.Property(x => x.PhoneNumber).HasColumnType("nvarchar(10)");
            builder.Property(x => x.AddressDetail).HasColumnType("nvarchar(250)");
            builder.Property(x => x.Status).HasColumnType("int");
            builder.HasOne(x => x.Customer).WithMany(x => x.Addresses).HasForeignKey(x => x.CustomerID);

        }
    }
}
