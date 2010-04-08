using Fooder.Client.Infrastructure;
using Fooder.Client.Model;
using Fooder.Client.ViewModels;
using Fooder.Client.ViewModels.Interfaces;
using StructureMap.Configuration.DSL;

namespace Fooder.Client
{
    public class UserInterfaceRegistry : Registry
    {
        public UserInterfaceRegistry()
        {
            ForRequestedType<IShellViewModel>()
                .AsSingletons()
                .TheDefaultIsConcreteType<ShellViewModel>();

            ForRequestedType<IMenuViewModel>()
                .TheDefaultIsConcreteType<MenuViewModel>();

            ForRequestedType<IHomeViewModel>()
                .AsSingletons()
                .TheDefaultIsConcreteType<HomeViewModel>();

            ForRequestedType<IRecipeViewModel>()
                .AsSingletons()
                .TheDefaultIsConcreteType<RecipeViewModel>();

            ForRequestedType<IShoppingListViewModel>()
                .AsSingletons()
                .TheDefaultIsConcreteType<ShoppingListViewModel>();

            ForRequestedType<IRecipeModel>()
                .AsSingletons()
                .TheDefaultIsConcreteType<RecipeModel>();

            //Note: Adding every class that inherits IMenuItem to the container to be used by the MainMenuViewModel. 
            //Might change this later
            Scan(x =>
            {
                x.TheCallingAssembly();
                x.AddAllTypesOf<IMenuItem>();
            });

            CreateProfile("demo", x => x.For<IRecipeModel>().UseConcreteType<FakeRecipeModel>());
        }
    }
}