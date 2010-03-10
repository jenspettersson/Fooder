using System;
using StructureMap.Attributes;
using StructureMap.Graph;

namespace Fooder.Client
{
    public class DefaultConventionScannerWithScope : TypeRules, ITypeScanner
    {
        private readonly InstanceScope _instanceScope;

        public DefaultConventionScannerWithScope(InstanceScope instanceScope)
        {
            _instanceScope = instanceScope;
        }

        public void Process(Type type, PluginGraph graph)
        {
            if(!IsConcrete(type))
                return;

            Type pluginType = FindPluginType(type);

            if(pluginType != null && Constructor.HasConstructors(type))
            {
                graph.AddType(pluginType, type);

                //var family = graph.FindFamily(type);
                //family.AddType(pluginType, pluginType.AssemblyQualifiedName);
                //family.SetScopeTo(_instanceScope);
            }
        }

        public Type FindPluginType(Type concreteType)
        {
            string interfaceName = "I" + concreteType.Name;
            Type[] interfaces = concreteType.GetInterfaces();

            return Array.Find(interfaces, t => t.Name == interfaceName);
        }
    }
}