using Cars.Models;
using Cars.Services.Interfaces;
using Prism.Mvvm;
using Prism.Regions;
using System.Collections.ObjectModel;

namespace Cars.Modules.Search.ViewModels
{
    public class PopularCarsViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly ISearchService _searchService;

        public PopularCarsViewModel(
            IRegionManager regionManager,
            ISearchService searchService)
        {
            _regionManager = regionManager;
            _searchService = searchService;
            LoadPopularCars();
        }

        private void LoadPopularCars()
        {
            var cars = _searchService.GetPopularCarsAsync().Result;
            Cars = new ObservableCollection<Vehicle>(cars);
        }

        public ObservableCollection<Vehicle> Cars { get; private set; }
    }
}
