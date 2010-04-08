using Caliburn.PresentationFramework;
using Caliburn.PresentationFramework.ApplicationModel;
using Fooder.Client.Model;
using Fooder.Client.ViewModels.Interfaces;

namespace Fooder.Client.ViewModels
{
    public class HomeViewModel : Presenter, IHomeViewModel
    {
        private readonly IRecipeModel recipeModel;

        public IObservableCollection<Recipe> Recipes { get; private set; }

        public HomeViewModel(IRecipeModel recipeModel)
        {
            this.recipeModel = recipeModel;

            Recipes = new BindableCollection<Recipe>(recipeModel.GetAllRecipes());
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            DisplayName = "Latest recipes";
        }
    }
}