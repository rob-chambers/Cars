using Cars.Modules.Search;
using Cars.Services;
using Cars.Services.Interfaces;
using Cars.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace Cars
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<System.Net.Http.HttpClient>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<SearchModule>();
        }
    }
}
