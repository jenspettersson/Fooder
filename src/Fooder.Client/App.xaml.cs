using Caliburn.PresentationFramework.ApplicationModel;
using Caliburn.StructureMap;
using Fooder.Client.Infrastructure;
using Fooder.Client.ViewModels;
using Fooder.Client.ViewModels.Interfaces;
using Microsoft.Practices.ServiceLocation;
using StructureMap;
using StructureMap.Attributes;
using StructureMap.Configuration.DSL;

namespace Fooder.Client
{
    public partial class App
    {
        protected override IServiceLocator CreateContainer()
        {
            Registry registry = GetRegistry();

            IContainer container = new Container(registry);

            return new StructureMapAdapter(container);
        }

        private Registry GetRegistry()
        {
            var registry = new Registry();

            registry.ForRequestedType<IShellViewModel>()
                .AsSingletons()
                .TheDefaultIsConcreteType<ShellViewModel>();

            registry.ForRequestedType<IMenuViewModel>()
                .TheDefaultIsConcreteType<MenuViewModel>();

            registry.ForRequestedType<IHomeViewModel>()
                .AsSingletons()
                .TheDefaultIsConcreteType<HomeViewModel>();

            registry.ForRequestedType<IRecipeViewModel>()
                .AsSingletons()
                .TheDefaultIsConcreteType<RecipeViewModel>();

            registry.ForRequestedType<IShoppingListViewModel>()
                .AsSingletons()
                .TheDefaultIsConcreteType<ShoppingListViewModel>();

            registry.Scan(x =>
                              {
                                  x.TheCallingAssembly();
                                  x.AddAllTypesOf<IMenuItem>();
                              });

            //registry.ForRequestedType<IMenuItem>()
            //    .TheDefaultIsConcreteType<FooMenuItem>();



            return registry;
        }

        protected override object CreateRootModel()
        {
            var binder = (DefaultBinder)Container.GetInstance<IBinder>();

            binder.EnableMessageConventions();
            binder.EnableBindingConventions();

            return Container.GetInstance<IShellViewModel>();
        }
    }
}