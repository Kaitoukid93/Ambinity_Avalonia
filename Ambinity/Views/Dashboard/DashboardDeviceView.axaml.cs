using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;

namespace Ambinity.Views.Dashboard;

public partial class DashboardDeviceView : UserControl
{
    public DashboardDeviceView()
    {
        InitializeComponent();
    }
    private void InputElement_OnPointerReleased(object? sender, PointerReleasedEventArgs e)
    {
        var vm = this.DataContext as DashboardDeviceViewModel;
        if (vm == null || e.InitialPressMouseButton != MouseButton.Left)
            return;

        vm.SelectDevice();
        e.Handled = true;
    }
}