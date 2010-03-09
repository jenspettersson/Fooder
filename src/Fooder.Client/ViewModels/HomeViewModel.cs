using Caliburn.PresentationFramework.ApplicationModel;
using Fooder.Client.ViewModels.Interfaces;

namespace Fooder.Client.ViewModels
{
    public class HomeViewModel : Presenter, IHomeViewModel
    {
        private readonly IShellViewModel _shellViewModel;

        public HomeViewModel(IShellViewModel shellViewModel)
        {
            _shellViewModel = shellViewModel;
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            DisplayName = "Home";
        }

        public void GoToTest()
        {
            
        }
    }
}