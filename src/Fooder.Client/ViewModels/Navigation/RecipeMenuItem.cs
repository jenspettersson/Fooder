using System;
using Fooder.Client.Infrastructure;
using Fooder.Client.ViewModels.Interfaces;

namespace Fooder.Client.ViewModels.Navigation
{
    public class RecipeMenuItem : IMenuItem
    {
        public string ItemName
        {
            get { return "Recipes"; }
        }

        public bool Activated
        {
            get { return true; }
        }

        private readonly IShellViewModel _shellViewModel;

        public RecipeMenuItem(IShellViewModel shellViewModel)
        {
            _shellViewModel = shellViewModel;
        }

        public void Open()
        {
            _shellViewModel.Open<IRecipeViewModel>();
        }
    }
}