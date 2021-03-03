using Cars.Core;
using Cars.Models;
using Cars.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Collections.ObjectModel;

namespace Cars.Modules.Search.ViewModels
{
    public class CategoriesViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly ISearchService _searchService;
        private DelegateCommand<Category> _searchByCategoryCommand;

        public CategoriesViewModel(
            IRegionManager regionManager,
            ISearchService searchService)
        {
            _regionManager = regionManager;
            _searchService = searchService;
            LoadCategories();
        }

        private void LoadCategories()
        {
            var categories = _searchService.GetCategoriesAsync().Result;
            Categories = new ObservableCollection<Category>(categories);
        }

        public ObservableCollection<Category> Categories { get; private set; }
       
        public DelegateCommand<Category> SearchByCategoryCommand =>
            _searchByCategoryCommand ?? (_searchByCategoryCommand = new DelegateCommand<Category>(ExecuteSearchByCategoryCommand));

        private void ExecuteSearchByCategoryCommand(Category category)
        {
            var navigationParameters = new NavigationParameters
            {
                { "category", category }
            };

            _regionManager.RequestNavigate(RegionNames.SearchRegion, "SearchResultsView", navigationParameters);
        }
    }
}
