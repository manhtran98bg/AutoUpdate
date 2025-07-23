using System.Reflection;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AutoUpdate.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";
    public string Version { get; } = Assembly.GetExecutingAssembly().GetName().Version.ToString();
    [ObservableProperty]
    private string _newVersion  = string.Empty;
    [ObservableProperty]
    private bool _readyToUpdate = false;
}