using Cars.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cars.Infrastructure.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity.HasKey(p => p.Id)
                .IsClustered(false);

            entity.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            
            entity.Property(p => p.Description)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(p => p.ImageUrl)
                .HasMaxLength(200)
                .IsUnicode(false);

            // Add indexes
            entity.HasIndex(p => p.Id, "PK_Category_Id")
                .IsUnique()
                .IsClustered();
        }
    }
}
