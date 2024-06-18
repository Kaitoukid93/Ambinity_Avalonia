using System.Windows.Input;
using Ambinity.Commands;
using Ambinity.Services;
using Ambinity.Stores;
using Ambinity.ViewModels;
using Ambinity.Views.Dashboard;
using AmbinityCore.Models;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace Ambinity.Views.DeviceControl;

public class DeviceControlViewModel : ViewModelBase
{
    #region Construct

    public DeviceControlViewModel(NavigationStores navigationStores)
    {
        _navigationStores = navigationStores;
    }

    #endregion

    #region Events

    #endregion

    #region Properties

    private IDevice _device;
    private NavigationStores _navigationStores;
    public IDevice Device
    {
        get { return _device; }
        set
        {
            _device = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region Methods

    private void CommandSetup()
    {
        var vm = Ioc.Default.GetRequiredService<DashboardViewModel>();
        BackToDashBoardCommand = new NavigateCommand<DashboardViewModel>(
            new NavigationService<DashboardViewModel>(_navigationStores,vm));
    }
    public void Init(IDevice device)
    {
        CommandSetup();
        Device = device;
    }

    #endregion

    #region Commands

    public ICommand BackToDashBoardCommand { get; set; }

    #endregion
}