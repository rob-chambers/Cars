using Cars.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cars.Infrastructure.Persistence.Configurations
{
    public class WarrantyConfiguration : IEntityTypeConfiguration<Warranty>
    {
        public void Configure(EntityTypeBuilder<Warranty> entity)
        {
            entity.HasKey(p => p.Id).IsClustered(false);
            
            entity.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            entity.Property(p => p.Mileage);

            entity.Property(p => p.Years)
                .HasConversion<byte>();

            // Add indexes
            entity.HasIndex(p => p.Id, "PK_Warranty_Id")
                .IsUnique()
                .IsClustered();
        }
    }
}
