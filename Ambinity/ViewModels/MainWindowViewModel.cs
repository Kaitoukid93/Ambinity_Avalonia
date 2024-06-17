using System.Collections.ObjectModel;
using System.Windows.Input;
using AmbinityCore.Models;
using CommunityToolkit.Mvvm.Input;

namespace Ambinity.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            GetAvailableComPorts();
            CommandSetup();
            CreateDummyDevice();
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

        private void CommandSetup()
        {
            ButtonClickCommand = new RelayCommand(IncreaseCounter);
        }

        private void CreateDummyDevice()
        {
            DummyDevice = new Device();
            DummyDevice.Name = "Ambino Basic";
            DummyDevice.Description = "USB Lighting Device";
            DummyDevice.Address = "COM4";
            DummyDevice.IsTransferActive = false;
            
        }
        private int _counter = 0;

        private void IncreaseCounter()
        {
            Counter++;
        }

        public int Counter
        {
            get { return _counter; }
            set
            {
                _counter = value;
                OnPropertyChanged();
            }
        }

        public ICommand ButtonClickCommand { get; set; }
        public Device DummyDevice { get; set; }
    }
}