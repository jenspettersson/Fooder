using System.Linq;
using Caliburn.PresentationFramework;
using Caliburn.PresentationFramework.ApplicationModel;
using Fooder.Client.Infrastructure;
using Fooder.Client.ViewModels.Interfaces;

namespace Fooder.Client.ViewModels
{
    public class MenuViewModel : Presenter, IMenuViewModel
    {
        private IObservableCollection<IMenuItem> _menuItems;

        public IObservableCollection<IMenuItem> MenuItems
        {
            get { return _menuItems; }
        }

        public MenuViewModel(IMenuItem[] menuItems)
        {
            _menuItems = new BindableCollection<IMenuItem>(menuItems.Where(x => x.Activated == true));
        }
    }
}