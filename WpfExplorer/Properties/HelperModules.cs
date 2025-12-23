using Prism.Ioc;
using Prism.Modularity;
using WpfExplorer.Support.Local.Helpers;

namespace WpfExplorer3.Properties;

public class HelperModules : IModule
{
    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterSingleton<DirectoryManager>();
    }

    public void OnInitialized(IContainerProvider containerProvider)
    {
    }
}