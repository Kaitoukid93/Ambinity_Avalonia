using Ambinity.Stores;
using Ambinity.Views;
using Ambinity.Views.Dashboard;
using Ambinity.Views.DeviceControl;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.DependencyInjection;
using FluentAvalonia.UI.Controls;
using Microsoft.Extensions.DependencyInjection;

namespace Ambinity
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            BindingPlugins.DataValidators.RemoveAt(0);
            var rootFrame = new Frame();


            Ioc.Default.ConfigureServices(
                new ServiceCollection()
                    .AddSingleton<MainWindowViewModel>()
                    .AddSingleton<DeviceControlViewModel>()
                    .AddSingleton<DashboardViewModel>()
                    .AddSingleton<NavigationStores>()
                    .BuildServiceProvider());
            var navigationStore = Ioc.Default.GetRequiredService<NavigationStores>();
            navigationStore.CurrentViewModel = Ioc.Default.GetRequiredService<DashboardViewModel>();
            var vm = Ioc.Default.GetRequiredService<MainWindowViewModel>();
            vm.CurrentViewModel.Init();
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = vm,
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}