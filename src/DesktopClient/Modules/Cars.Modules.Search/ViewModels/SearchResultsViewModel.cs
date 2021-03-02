using Cars.Models;
using Prism.Mvvm;
using Prism.Regions;

namespace Cars.Modules.Search.ViewModels
{
    public class SearchResultsViewModel : BindableBase, INavigationAware
    {
        private readonly IRegionManager _regionManager;

        public SearchResultsViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            throw new System.NotImplementedException();
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            var category = (Category)navigationContext.Parameters["category"];

            Name = category.Name;
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
    }
}
