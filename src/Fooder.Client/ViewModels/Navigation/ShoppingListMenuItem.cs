using Fooder.Client.Infrastructure;
using Fooder.Client.ViewModels.Interfaces;

namespace Fooder.Client.ViewModels.Navigation
{
    public class ShoppingListMenuItem : IMenuItem
    {
        public string ItemName
        {
            get { return "Shopping list"; }
        }

        private readonly IShellViewModel _shellViewModel;

        public ShoppingListMenuItem(IShellViewModel shellViewModel)
        {
            _shellViewModel = shellViewModel;
        }

        public void Open()
        {
            _shellViewModel.Open<IShoppingListViewModel>();
        }
    }
}