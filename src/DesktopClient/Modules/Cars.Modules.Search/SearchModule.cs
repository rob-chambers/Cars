using Cars.Core;
using Cars.Modules.Search.Views;
using Cars.Services;
using Cars.Services.Interfaces;
using DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Net.Http;

namespace Cars.Modules.Search
{
    public class SearchModule : IModule
    {
        private readonly IRegionManager _regionManager;
        private HttpClient _httpClient;

        public SearchModule(IRegionManager regionManager, HttpClient httpClient)
        {
            _regionManager = regionManager;
            _httpClient = httpClient;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, "CategoriesView");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<CategoriesView>();
            containerRegistry.RegisterInstance<ISearchService>(new SearchService("https://localhost:44326", _httpClient));
        }
     }
}