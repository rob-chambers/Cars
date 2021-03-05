using Cars.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cars.Infrastructure.Persistence.Configurations
{
    public class MakeConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> entity)
        {
            entity.HasKey(p => p.Id).IsClustered(false);

            entity.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(p => p.Country)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            // Add indexes
            entity.HasIndex(p => p.Id, "PK_Make_Id")
                .IsUnique()
                .IsClustered();
        }
    }
}
