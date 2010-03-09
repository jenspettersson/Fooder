using Caliburn.PresentationFramework.ApplicationModel;
using Fooder.Client.ViewModels.Interfaces;

namespace Fooder.Client.ViewModels
{
    public class RecipeViewModel : Presenter, IRecipeViewModel
    {
        public RecipeViewModel()
        {
            DisplayName = "Recipes";
        }
    }
}