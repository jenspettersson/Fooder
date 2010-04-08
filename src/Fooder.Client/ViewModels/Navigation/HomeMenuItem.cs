using System;
using Fooder.Client.Infrastructure;
using Fooder.Client.ViewModels.Interfaces;

namespace Fooder.Client.ViewModels.Navigation
{
    public class HomeMenuItem : IMenuItem
    {
        public string ItemName
        {
            get { return "Home"; }
        }

        public bool Activated
        {
            get { return true; }
        }

        private readonly IShellViewModel _shellViewModel;

        public HomeMenuItem(IShellViewModel shellViewModel)
        {
            _shellViewModel = shellViewModel;
        }

        public void Open()
        {
            _shellViewModel.Open<IHomeViewModel>();
        }
    }
}