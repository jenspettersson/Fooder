using System;
using Fooder.Client.Infrastructure;
using Fooder.Client.ViewModels.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace Fooder.Client.ViewModels.Navigation
{
    public class ShoppingListMenuItem : IMenuItem
    {
        public string ItemName
        {
            get { return "Shopping list"; }
        }

        public void Open()
        {
            ServiceLocator.Current.GetInstance<IShellViewModel>().Open<IShoppingListViewModel>();
        }
    }
}