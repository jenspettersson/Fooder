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

        public void Open()
        {
            ServiceLocator.Current.GetInstance<IShellViewModel>().Open<BarViewModel>();
        }
    }
}