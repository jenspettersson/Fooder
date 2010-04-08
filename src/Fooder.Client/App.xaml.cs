using System;
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
            Registry registry = new UserInterfaceRegistry();

            IContainer container = new Container(registry);

            var commandLine = Environment.CommandLine.Split(' ');

            if (commandLine.Length > 1)
                container.SetDefaultsToProfile(commandLine[1]);

            return new StructureMapAdapter(container);
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