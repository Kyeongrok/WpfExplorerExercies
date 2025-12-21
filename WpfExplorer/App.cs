using System.Windows;
using Jamesnet.Wpf.Controls;

namespace WpfExplorer3;

internal class App : JamesApplication
{
    protected override Window CreateShell()
    {
        return new Window();
    }
}