using System.Collections.ObjectModel;
using Ambinity.ViewModels;
using AmbinityCore.Models;

namespace Ambinity.Views.Dashboard;

public class DashboardViewModel
{
    public DashboardViewModel()
    {
        Devices = new ObservableCollection<DashboardDeviceViewModel>();
        for (int i = 0; i < 5; i++)
        {
            Devices.Add(CreateDummyDevice());
        }
    }

    public ObservableCollection<DashboardDeviceViewModel> Devices { get; set; }

    private DashboardDeviceViewModel CreateDummyDevice()
    {
        var device = new Device();
        device.Name = "Ambino Basic";
        device.Description = "USB Lighting Device";
        device.Address = "COM4";
        device.IsTransferActive = false;
        var deviceVm = new DashboardDeviceViewModel();
        deviceVm.Init(device);
        return deviceVm;
    }
}