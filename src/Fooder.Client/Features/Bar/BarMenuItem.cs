using System;
using Fooder.Client.Features.Bar.ViewModels;
using Fooder.Client.Infrastructure;
using Fooder.Client.ViewModels.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace Fooder.Client.Features.Bar
{
    public class BarMenuItem : IMenuItem
    {
        public string ItemName
        {
            get { return "Bar"; }
        }

        public bool Activated
        {
            get { return false; }
        }

        private readonly IShellViewModel _shellViewModel;

        public BarMenuItem(IShellViewModel shellViewModel)
        {
            _shellViewModel = shellViewModel;
        }

        public void Open()
        {
            _shellViewModel.Open<BarViewModel>();
        }
    }
}