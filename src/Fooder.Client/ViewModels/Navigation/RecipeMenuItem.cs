using System;
using Fooder.Client.Infrastructure;
using Fooder.Client.ViewModels.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace Fooder.Client.ViewModels.Navigation
{
    public class RecipeMenuItem : IMenuItem
    {
        public string ItemName
        {
            get { return "Recipes"; }
        }

        public void Open()
        {
            ServiceLocator.Current.GetInstance<IShellViewModel>().Open<IRecipeViewModel>();
        }
    }
}