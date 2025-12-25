using System.Windows;
using System.Windows.Controls;
using Prism.Regions;

namespace WpfExplorer.Support.UI.Units;

public class MatthewRegion : ContentControl
{
    public static readonly DependencyProperty RegionNameProperty = 
        DependencyProperty.Register(
            "RegionName", 
            typeof(string), 
            typeof(MatthewRegion), 
            new PropertyMetadata(ContentNamePropertyChanged));
    public string RegionName
    {
        get => (string)GetValue(RegionNameProperty);
        set => SetValue(RegionNameProperty, value);
    }
    private static void ContentNamePropertyChanged(
        DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (e.NewValue is string str && str != "")
        {
            IRegionManager rm = RegionManager
                .GetRegionManager(Application.Current.MainWindow);
            RegionManager.SetRegionName((MatthewRegion)d, str);
            RegionManager.SetRegionManager(d, rm);
        }
    } 
    static MatthewRegion()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MatthewRegion),
            new FrameworkPropertyMetadata(typeof(MatthewRegion)));
    }
}