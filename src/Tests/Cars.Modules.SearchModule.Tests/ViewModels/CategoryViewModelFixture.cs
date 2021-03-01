using Cars.Models;
using Cars.Modules.Search.ViewModels;
using Cars.Services.Interfaces;
using Moq;
using Prism.Regions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Cars.Modules.Search.Tests.ViewModels
{
    public class CategoryViewModelFixture
    {
        private const string SmallCars = "Small Cars";
        private const string FamilyCars = "Family Cars";

        private Mock<ISearchService> _searchServiceMock;
        private Mock<IRegionManager> _regionManagerMock;

        public CategoryViewModelFixture()
        {
            var searchService = new Mock<ISearchService>();

            ICollection<Category> categories = new List<Category>
            {
                new Category
                {
                    Name = SmallCars
                },
                new Category
                {
                    Name = FamilyCars
                }
            };

            searchService.Setup(x => x.GetCategoriesAsync())
                .Returns(Task.FromResult(categories));
            _searchServiceMock = searchService;

            _regionManagerMock = new Mock<IRegionManager>();
        }

        [Fact]
        public void MessagePropertyValueUpdated()
        {
            var vm = new CategoriesViewModel(_regionManagerMock.Object, _searchServiceMock.Object);

            _searchServiceMock.Verify(x => x.GetCategoriesAsync(), Times.Once);

            Assert.True(vm.Categories.Single(x => x.Name == SmallCars) != null);
            Assert.True(vm.Categories.Single(x => x.Name == FamilyCars) != null);
        }
    }
}
