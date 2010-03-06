using Caliburn.PresentationFramework.ApplicationModel;
using Caliburn.StructureMap;
using Fooder.ViewModels;
using Microsoft.Practices.ServiceLocation;
using StructureMap;
using StructureMap.Configuration.DSL;


namespace Fooder
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

            registry.ForConcreteType<ApplicationModel>();

            return registry;
        }

        protected override object CreateRootModel()
        {
            //var binder = (DefaultBinder) Container.GetInstance<IBinder>();
            
            //binder.EnableMessageConventions();
            //binder.EnableBindingConventions();

            return Container.GetInstance<ApplicationModel>();
        }
    }
}
