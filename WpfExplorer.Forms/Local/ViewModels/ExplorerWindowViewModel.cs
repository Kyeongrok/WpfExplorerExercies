using Jamesnet.Wpf.Mvvm;
using WpfExplorer.Support.Local.Helpers;

namespace WpfExplorer.Forms.Local.ViewModels;

public class ExplorerWindowViewModel : ObservableBase
{
    public string DownloadDirectory { get; init; }
    public string DocumentsDirectory { get; init; }
    public string PicturesDirectory { get; init; }

    public ExplorerWindowViewModel(DirectoryManager directoryManager)
    {
        DownloadDirectory = directoryManager.DownloadDirectory;
        DocumentsDirectory = directoryManager.DocumentsDirectory;
        PicturesDirectory = directoryManager.PicturesDirectory;
    }
}