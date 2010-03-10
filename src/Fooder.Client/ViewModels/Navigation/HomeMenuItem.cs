using Fooder.Client.Infrastructure;
using Fooder.Client.ViewModels.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace Fooder.Client.ViewModels.Navigation
{
    public class HomeMenuItem : IMenuItem
    {
        public string ItemName
        {
            get { return "Home"; }
        }

        public void Open()
        {
            ServiceLocator.Current.GetInstance<IShellViewModel>().Open<IHomeViewModel>();
        }
    }
}