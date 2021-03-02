using Cars.Services.Interfaces;
using Prism.Mvvm;
using Prism.Regions;

namespace Cars.Modules.Search.ViewModels
{
    public class MainSearchViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly ISearchService _searchService;

        public MainSearchViewModel(
            IRegionManager regionManager,
            ISearchService searchService)
        {
            _regionManager = regionManager;
            _searchService = searchService;
        }
    }
}
