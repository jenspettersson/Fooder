using System;
using Fooder.Client.Features.Foo.ViewModels;
using Fooder.Client.Infrastructure;
using Fooder.Client.ViewModels.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace Fooder.Client.Features.Foo
{
    public class FooMenuItem : IMenuItem
    {
        public string ItemName
        {
            get { return "Foo"; }
        }

        public bool Activated
        {
            get { return false; }
        }

        private readonly IShellViewModel _shellViewModel;

        public FooMenuItem(IShellViewModel shellViewModel)
        {
            _shellViewModel = shellViewModel;
        }

        public void Open()
        {
            _shellViewModel.Open<FooViewModel>();
        }
    }
}