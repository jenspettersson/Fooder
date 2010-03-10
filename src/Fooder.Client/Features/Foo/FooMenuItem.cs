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

        public void Open()
        {
            ServiceLocator.Current.GetInstance<IShellViewModel>().Open<FooViewModel>();
        }
    }
}