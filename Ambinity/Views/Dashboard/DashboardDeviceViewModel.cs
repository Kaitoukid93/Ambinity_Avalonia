using System;
using Ambinity.ViewModels;
using AmbinityCore.Models;

namespace Ambinity.Views.Dashboard;

public class DashboardDeviceViewModel : ActivatableViewModelBase
{
    public event Action DeviceClicked;

    public DashboardDeviceViewModel()
    {
        CommandSetup();
    }

    public IDevice Device { get; set; }

    public void Init(IDevice device)
    {
        Device = device;
    }

    private void CommandSetup()
    {
    }

    public void SelectDevice()
    {
        DeviceClicked?.Invoke();
    }
}