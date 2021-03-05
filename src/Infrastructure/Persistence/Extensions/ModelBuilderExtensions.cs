using Microsoft.EntityFrameworkCore;
using System;

namespace Cars.Infrastructure.Persistence.Extensions
{
    internal static class ModelBuilderExtensions
    {
        public static void RemovePluralizingTableNameConvention(this ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.DisplayName());
            }
        }
    }
}
