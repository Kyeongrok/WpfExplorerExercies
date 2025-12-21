using Jamesnet.Wpf.Mvvm;

namespace WpfExplorer.Forms.Local.ViewModels;

public class ExplorerWindowViewModel : ObservableBase
{
    public string TestTitle { get; init; }

    public ExplorerWindowViewModel()
    {
        TestTitle = "WPF INSIDE OUT";
    }
}