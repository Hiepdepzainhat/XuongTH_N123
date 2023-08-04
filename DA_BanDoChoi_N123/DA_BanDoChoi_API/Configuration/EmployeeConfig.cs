using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.FullName).HasColumnType("nvarchar(100)");
            builder.Property(x => x.DateOfBirth).HasColumnType("Date");
            builder.Property(x => x.Gender).HasColumnType("int");
            builder.Property(x => x.Email).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Address).HasColumnType("nvarchar(100)");
            builder.Property(x => x.PhoneNumber).HasColumnType("nvarchar(10)");
            builder.Property(x => x.Image).HasColumnType("nvarchar(150)");
            builder.Property(x => x.Status).HasColumnType("int");
            builder.Property(x => x.PassWord).HasColumnType("nvarchar(100)");
            builder.HasOne(x => x.Role).WithMany(x => x.Employees).HasForeignKey(x => x.ROleID);
        }
    }
}
