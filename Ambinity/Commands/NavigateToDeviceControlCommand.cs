using Ambinity.Stores;
using Ambinity.Views.DeviceControl;
using AmbinityCore.Models;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace Ambinity.Commands;

public class NavigateToDeviceControlCommand : CommandBase
{
    public NavigateToDeviceControlCommand(NavigationStores navigationStores)
    {
        _navigationStores = navigationStores;
    }
    private readonly NavigationStores _navigationStores;
    public override void Execute(object parameter)
    {
        _navigationStores.CurrentViewModel = Ioc.Default.GetRequiredService<DeviceControlViewModel>();
        (_navigationStores.CurrentViewModel as DeviceControlViewModel).Init(parameter as Device);
    }
}