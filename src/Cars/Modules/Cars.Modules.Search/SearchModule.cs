using Cars.Core;
using Cars.Modules.Search.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Cars.Modules.Search
{
    public class SearchModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public SearchModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, "ViewA");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
        }
    }
}