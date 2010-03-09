using Caliburn.PresentationFramework.ApplicationModel;
using Fooder.Client.ViewModels.Interfaces;

namespace Fooder.Client.ViewModels
{
    public class ShoppingListViewModel : Presenter, IShoppingListViewModel
    {
        public ShoppingListViewModel()
        {
            DisplayName = "Shopping List";
        }
    }
}