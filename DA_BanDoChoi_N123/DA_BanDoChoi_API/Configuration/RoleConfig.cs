using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DA_BanDoChoi_API.Configuration
{
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.RoleName).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Status).HasColumnType("int");
            builder.Property(x => x.Description).HasColumnType("nvarchar(1000)");
        }
    }
}
