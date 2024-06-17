using System.Collections.ObjectModel;
namespace Ambinity.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
                GetAvailableComPorts();
        }
        public string Greeting => "Welcome to Avalonia!";
        public ObservableCollection<string> AvailableComPorts { get; set; }
        private void GetAvailableComPorts()
        {
            AvailableComPorts = new ObservableCollection<string>();

            foreach (var port in System.IO.Ports.SerialPort.GetPortNames())
            {
                AvailableComPorts.Add(port);
            }
           
            
        }
       
    }
}
