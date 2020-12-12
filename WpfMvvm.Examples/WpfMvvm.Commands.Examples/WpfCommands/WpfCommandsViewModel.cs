using System;
using System.Windows;
using WpfMvvm.WpfCommands;

namespace Examples.WpfCommands
{
    public class WpfCommandsViewModel
    {
        /// <summary>Для привязки CheckBox.</summary>
        public bool IsHello { get; set; }

        private RelayCommand _helloCommand;
        private RelayCommand _helloArgCommand;
        private RelayCommand _helloBoolCommand;

        /// <summary>Команда без параметров.</summary>
        public RelayCommand HelloCommand => _helloCommand
             ?? (_helloCommand = new RelayCommand(HelloMethod, HelloCanMethod));

        private void HelloMethod()
            => MessageBox.Show($"Привет!\r\nIsHello={IsHello}");

        private bool HelloCanMethod() => IsHello;

        /// <summary>Команда с object параметром.</summary>
        public RelayCommand HelloArgCommand => _helloArgCommand
         ?? (_helloArgCommand = new RelayCommand(HelloArgMethod, HelloArgCanMethod));

        private void HelloArgMethod(object parameter) => HelloMethod();

        private bool HelloArgCanMethod(object parameter)
            => parameter is bool bl && bl;

        /// <summary>Команда с bool параметром.</summary>
        public RelayCommand HelloBoolCommand => _helloBoolCommand
         ?? (_helloBoolCommand = new RelayCommand<bool>(HelloBoolMethod, HelloBoolCanMethod));

        private void HelloBoolMethod(bool parameter) => HelloMethod();

        private bool HelloBoolCanMethod(bool parameter)
            => parameter;

    }
}
