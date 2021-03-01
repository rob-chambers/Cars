using Cars.Models;
using Cars.Services.Interfaces;
using Prism.Mvvm;
using Prism.Regions;
using System.Collections.ObjectModel;

namespace Cars.Modules.Search.ViewModels
{
    public class CategoriesViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly ISearchService _searchService;

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
    }
}
