using Prism.Mvvm;

namespace Cars.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Cars Application";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
