using Cars.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cars.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        [Route("getcategories")]
        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Family Cars",
                    Description = "Some spiel about family cars"
                },
                new Category
                {
                    Id = 2,
                    Name = "Luxury Cars",
                    Description = "The most desirable car"
                }
            };
        }

        [Route("getpopularcars")]
        public async Task<IEnumerable<Vehicle>> GetPopularCarsAsync()
        {
            return new Vehicle[]
            {
                new Vehicle
                {
                    Name = "CR-V Sport",
                    Doors = 4,
                    EngineSize = 2.5f,
                    FuelTankCapacity = 50,
                    HorsePower = 120,
                    Model = new Model
                    {
                        Name = "CR-V",
                        Category = new Category
                        {
                            Id = 2,
                            Name = "SUV",
                        },
                        Id = 98,
                        Make = new Make
                        {
                            Id = 2,
                            Name = "Honda",
                            Country = "Japan"
                        },
                        Warranty = new Warranty
                        {
                            Mileage = 100000,
                             Id = 2,
                             Years = 3
                        }
                    },
                    MPG = 28,
                    Price = 27700,
                    Year = 2019
                },
                new Vehicle
                {
                    Name = "325i 2dr Covertible",
                    Doors = 2,
                    EngineSize = 3.0f,
                    FuelTankCapacity = 60,
                    HorsePower = 180,
                    Model = new Model
                    {
                        Name = "3 Series",
                        Category = new Category
                        {
                            Id = 6,
                            Name = "Luxury Sedans",
                        },
                        Id = 103,
                        Make = new Make
                        {
                            Id = 1,
                            Name = "BMW",
                            Country = "Germany"
                        },
                        Warranty = new Warranty
                        {
                            Mileage = 60000,
                             Id = 3,
                             Years = 3
                        }
                    },
                    MPG = 31,
                    Price = 35700,
                    Year = 2018
                }
            };
        }
    }
}
