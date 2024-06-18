using Ambinity.Stores;
using Ambinity.Views.Dashboard;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace Ambinity.Commands;

public class NavigateHomeCommand : CommandBase
{
    public NavigateHomeCommand(NavigationStores navigationStores)
    {
        _navigationStores = navigationStores;
    }
    private readonly NavigationStores _navigationStores;
    public override void Execute(object parameter)
    {
        _navigationStores.CurrentViewModel = Ioc.Default.GetRequiredService<DashboardViewModel>();
    }
}