using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.FullName).HasColumnType("nvarchar(100)");
            builder.Property(x => x.DateOfBirth).HasColumnType("Date");
            builder.Property(x => x.Gender).HasColumnType("int");
            builder.Property(x => x.UserName).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Password).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Email).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Point).HasColumnType("int");
            builder.Property(x => x.PhoneNumber).HasColumnType("nvarchar(10)");
            builder.Property(x => x.Image).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Status).HasColumnType("int");
            builder.HasOne(x => x.MemberType).WithMany(x => x.Customer).HasForeignKey(X => X.MemberID);
          

        }
    }
}
