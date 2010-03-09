using Caliburn.PresentationFramework.ApplicationModel;
using Fooder.Client.ViewModels.Interfaces;

namespace Fooder.Client.ViewModels
{
    public class MenuViewModel : Presenter, IMenuViewModel
    {
        private readonly IShellViewModel _shellViewModel;

        public MenuViewModel(IShellViewModel shellViewModel)
        {
            _shellViewModel = shellViewModel;
        }

        public void GoToHome()
        {
            _shellViewModel.Open<IHomeViewModel>();
        }

        public void GoToRecipes()
        {
            _shellViewModel.Open<IRecipeViewModel>();
        }

        public void GoToShoppingList()
        {
            _shellViewModel.Open<IShoppingListViewModel>();
        }
    }
}