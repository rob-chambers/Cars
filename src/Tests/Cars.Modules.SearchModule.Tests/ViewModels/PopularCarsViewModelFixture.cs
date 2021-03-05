using Cars.Models;
using Cars.Services.Interfaces;
using Moq;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Modules.Search.Tests.ViewModels
{
    public class PopularCarsViewModelFixture
    {
        private Mock<ISearchService> _searchServiceMock;
        private Mock<IRegionManager> _regionManagerMock;

        public PopularCarsViewModelFixture()
        {
            var searchService = new Mock<ISearchService>();

            ICollection<Model> models = new List<Model>
            {
                new Model
                {
                    Name = "3 Series"
                },
                new Model
                {
                    Name = "Golf"
                }
            };

            searchService.Setup(x => x.GetPopularCarsAsync())
                .Returns(Task.FromResult(models));
            _searchServiceMock = searchService;

            _regionManagerMock = new Mock<IRegionManager>();
        }


    }
}
