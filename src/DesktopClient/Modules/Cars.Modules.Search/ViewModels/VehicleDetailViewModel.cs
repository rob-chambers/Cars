using Cars.Models;
using Prism.Mvvm;

namespace Cars.Modules.Search.ViewModels
{
    public class VehicleDetailViewModel : BindableBase
    {
        private Vehicle _selectedVehicle;

        public Vehicle SelectedVehicle
        {
            get { return _selectedVehicle; }
            set { SetProperty(ref _selectedVehicle, value); }
        }    
    }
}
