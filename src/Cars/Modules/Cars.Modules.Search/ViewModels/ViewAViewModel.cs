using Cars.Services.Interfaces;
using Prism.Mvvm;
using Prism.Regions;

namespace Cars.Modules.Search.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IMessageService _messageService;
        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel(IRegionManager regionManager, IMessageService messageService)
        {
            _regionManager = regionManager;
            _messageService = messageService;

            Message = messageService.GetMessage();
        }
    }
}
