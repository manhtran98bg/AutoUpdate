using System.Reflection;
namespace AutoUpdate.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";
    public string Version { get; } = Assembly.GetExecutingAssembly().GetName().Version.ToString();
}