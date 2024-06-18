using Ambinity.Services;
using Ambinity.Stores;
using Ambinity.ViewModels;
using Ambinity.Views.Dashboard;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace Ambinity.Commands;

public class NavigateCommand<TViewModel> : CommandBase
where TViewModel : ViewModelBase 
{
    public NavigateCommand(NavigationService<TViewModel> navigationService)
    {
        _navigationService = navigationService;
    }

    private readonly NavigationService<TViewModel> _navigationService;
    public override void Execute(object parameter)
    {
        _navigationService.Navigate();
    }
}