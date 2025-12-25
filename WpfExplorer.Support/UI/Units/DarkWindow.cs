using System.Windows;
using System.Windows.Controls;
using Jamesnet.Wpf.Controls;

namespace WpfExplorer.Support.UI.Units;

public class DarkWindow : JamesWindow
{
    static DarkWindow()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkWindow),
            new FrameworkPropertyMetadata(typeof(DarkWindow)));
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();

        if (GetTemplateChild("PART_CloseButton") is Button closeButton)
        {
            closeButton.Click += (s, e) => Close();
        }
    }
}