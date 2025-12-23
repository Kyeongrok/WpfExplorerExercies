using WpfExplorer3.Properties;

namespace WpfExplorer3;

internal class Starter
{
    [STAThread]
    private static void Main(string[] args)
    {
        _ = new App()
            .AddInversionModule<HelperModules>()
            .AddWireDataContext<WireDataContext>()
            .Run();
    }
}