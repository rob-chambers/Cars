using Cars.Models;
using Prism.Mvvm;

namespace Cars.Modules.Search.ViewModels
{
    public class ModelDetailViewModel : BindableBase
    {
        private Model _selectedModel;
        
        public Model SelectedModel
        {
            get { return _selectedModel; }
            set { SetProperty(ref _selectedModel, value); }
        }
    }
}
