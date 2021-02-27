using Cars.Services.Interfaces;
using Prism.Mvvm;
using Prism.Regions;
using System.Linq;

namespace Cars.Modules.Search.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly ISearchService _searchService;
        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel(
            IRegionManager regionManager, 
            ISearchService searchService)
        {
            _regionManager = regionManager;
            _searchService = searchService;
            var categories = _searchService.GetCategoriesAsync().Result;
            Message = string.Join(',', categories.Select(x => x.Name));
        }
    }
}
