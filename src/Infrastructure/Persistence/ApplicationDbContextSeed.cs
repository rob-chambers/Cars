using Bogus;
using Cars.Core.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedSampleDataAsync(IApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.Makes.Any())
            {
                await SeedMakesAsync(context);
            }

            if (!context.Categories.Any())
            {
                await SeedCategoriesAsync(context);
            }

            if (!context.Warranties.Any())
            {
                await SeedWarrantiesAsync(context);
            }

            if (!context.Models.Any())
            {
                await SeedModelsAsync(context);
            }
        }

        private static async Task SeedModelsAsync(IApplicationDbContext context)
        {
            var random = new Random();
            var bmw = context.Makes.Single(x => x.Name == "BMW");
            var luxury = context.Categories
                .Where(x => x.Name.Contains("Luxury"))
                .Single();

            var min = context.Warranties.Select(x => x.Id).Min();
            var max = context.Warranties.Select(x => x.Id).Max();
            var warranty = context.Warranties.Find(random.Next(min, max + 1));

            var model = new Model
            {
                Make = bmw,
                Category = luxury,
                Name = "3 Series",
                MinPrice = 32000,
                Warranty = warranty
            };

            context.Models.Add(model);

            await context.SaveChangesAsync();
        }

        private static async Task SeedMakesAsync(IApplicationDbContext context)
        {
            //var makes = new Faker<Make>();
            //var names = new[] { "BMW", "Ford", "Toyota", "Mazda", "Volkswagen", "Citroën", "Volvo", "Kia" };
            //var countries = new[] { "Germany", "Italy", "Japan", "France", "USA", "Czech Republic" };

            //makes.RuleFor(x => x.Name, x => x.PickRandom(names));
            //makes.RuleFor(x => x.Country, x => x.PickRandom(countries));

            //var list = makes.Generate();

            //foreach (var item in list)
            //{
            //    context.Categories.Add(item);
            //}

            context.Makes.Add(new Make
            {
                Country = "Germany",
                Name = "BMW"
            }); context.Makes.Add(new Make
            {
                Country = "Germany",
                Name = "Audi"
            }); context.Makes.Add(new Make
            {
                Country = "Germany",
                Name = "Mercedes"
            }); context.Makes.Add(new Make
            {
                Country = "Germany",
                Name = "Volkswagen"
            }); context.Makes.Add(new Make
            {
                Country = "Japan",
                Name = "Mazda"
            }); context.Makes.Add(new Make
            {
                Country = "Japan",
                Name = "Honda"
            });
            context.Makes.Add(new Make
            {
                Country = "Japan",
                Name = "Toyota"
            }); context.Makes.Add(new Make
            {
                Country = "South Korea",
                Name = "Kia"
            });
            context.Makes.Add(new Make
            {
                Country = "USA",
                Name = "Ford"
            });
            context.Makes.Add(new Make
            {
                Country = "Sweden",
                Name = "Volvo"
            });

            await context.SaveChangesAsync();
        }

        private static async Task SeedCategoriesAsync(IApplicationDbContext context)
        {
            var categories = new Faker<Category>();

            var names = new[] { "Luxury Cars", "Small Cars", "Family Cars", "Large SUVs", "Compact SUVs", "Coupés", "Sports Cars", "Executive Cars" };
            categories.RuleFor(x => x.Name, x => names[x.IndexFaker]);
            categories.RuleFor(x => x.Description, x => x.Lorem.Paragraph());

            var list = categories.Generate(names.Length);
            foreach (var item in list)
            {
                context.Categories.Add(item);
            }

            await context.SaveChangesAsync();
        }

        private static async Task SeedWarrantiesAsync(IApplicationDbContext context)
        {
            var warranties = new Faker<Warranty>();

            var mileage = new int?[] { 50000, 60000, 100000, 250000, null };

            warranties.RuleFor(x => x.Mileage, x => x.PickRandom(mileage));
            warranties.RuleFor(x => x.Years, x => x.Random.Int(3, 5));

            var list = warranties.Generate(8);
            foreach (var item in list)
            {
                context.Warranties.Add(item);
            }

            await context.SaveChangesAsync();
        }
    }
}
