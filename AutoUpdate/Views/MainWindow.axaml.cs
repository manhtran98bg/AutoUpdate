using Avalonia.Controls;
using Avalonia.Interactivity;
using Squirrel;

namespace AutoUpdate.Views;

public partial class MainWindow : Window
{
    private UpdateManager? _updateManager;
    public MainWindow()
    {
        InitializeComponent();
        Loaded += MainWindow_Loaded;
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
        _updateManager = new UpdateManager("D:\\Dev\\SquirrelWindow\\Deployment\\Releases");
    }
    private void ButtonUpdate_OnClick(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void ButtonCheckUpdate_OnClick(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }
}