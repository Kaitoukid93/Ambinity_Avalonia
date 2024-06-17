using System;
using Ambinity.Models;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Ambinity.Views.Dashboard;

public partial class DashboardView : UserControl
{
    public DashboardView()
    {
        InitializeComponent();
    }
    public class DashboardViewPage : ISelectablePage
    {
        private readonly Lazy<DashboardView> lazyContent;

        public DashboardViewPage(Lazy<DashboardView> lazyContent)
        {
            this.lazyContent = lazyContent ?? throw new ArgumentNullException(nameof(lazyContent));
        }

        public int Order => 10;

        public string PageName => "Devices Advance Settings";
        public string Geometry => "";

        public object Content { get => lazyContent.Value; }
    }
}