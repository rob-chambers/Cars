using Cars.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cars.Infrastructure.Persistence.Configurations
{
    public class ModelConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> entity)
        {
            entity.HasKey(p => p.Id)
                .IsClustered(false);
            
            entity.Property(p => p.Id)
                .ValueGeneratedOnAdd();
            
            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(p => p.MinPrice)
                .HasColumnType("smallmoney");

            // Add indexes
            entity.HasIndex(p => p.Id, "PK_Model_Id")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(p => p.MakeId, "IX_Model_Make_Id");
            entity.HasIndex(p => p.CategoryId, "IX_Model_Category_Id");
            entity.HasIndex(p => p.WarrantyId, "IX_Model_Warranty_Id");
        }
    }
}
