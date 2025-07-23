using AutoUpdate.ViewModels;
using Avalonia.Controls;
using Avalonia.Interactivity;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;
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

    private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
        // _updateManager = new UpdateManager("D:\\Dev\\SquirrelWindow\\Deployment\\Releases");
        _updateManager = await UpdateManager
            .GitHubUpdateManager(@"https://github.com/manhtran98bg/AutoUpdate");
    }
    private async void ButtonUpdate_OnClick(object? sender, RoutedEventArgs e)
    {
        await _updateManager.UpdateApp();
        var messageBox = MessageBoxManager
            .GetMessageBoxStandard("Info", "Update successssssssss", ButtonEnum.Ok, MsBox.Avalonia.Enums.Icon.Info);
        await messageBox.ShowWindowDialogAsync(this);
        
    }

    private async void ButtonCheckUpdate_OnClick(object? sender, RoutedEventArgs e)
    {
        var vm = DataContext as MainWindowViewModel;
        if (vm == null)
            return;
        var updateInfo = await _updateManager!.CheckForUpdate();
        if (updateInfo.ReleasesToApply.Count > 0)
        {
            vm.ReadyToUpdate = true;
            vm.NewVersion = updateInfo.ReleasesToApply[0].Version.ToString();
        }
        else
        {
            vm.ReadyToUpdate = false;
        }
    }
}